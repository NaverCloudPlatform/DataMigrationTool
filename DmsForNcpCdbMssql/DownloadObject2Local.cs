using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using NLog;
using DMS.General;

namespace DMS
{

    public partial class DownloadObject2Local : UserControl
    {
        private static readonly Lazy<DownloadObject2Local> lazy =
            new Lazy<DownloadObject2Local>(() => new DownloadObject2Local(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static DownloadObject2Local Instance { get { return lazy.Value; } }

        Config config;
        ObjectStorage objectStorage;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;
        private bool workObjectStorage = false;
        private bool workLocalStorage = false;
        
        private DownloadObject2Local()
        {
            InitializeComponent();
            GFunctions.ColumSizeFix(dgvObjectStorage);
            GFunctions.ColumSizeFix(dgvLocalDrive);
            config = Config.Instance;
            objectStorage = ObjectStorage.Instance;
            WriteConfig2TextBox();
        }

        void Keyword_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (workObjectStorage || workLocalStorage)
                    return; 
                ConfigSaveAllItem();
                ObjectStorageFileList();
                loadLocalDriveFileList();
            }
        }

        private void ConfigSaveAllItem()
        {
            nlog.Warn("ConfigSaveAllItem Started");
            config.SetEnumValue(Category.Upload, Key.FilterString, textFilterString.Text);
            config.SetEnumValue(Category.Upload, Key.LocalDir, textLocalFolder.Text);
            lock (config.lockObject)
                config.WriteConfigToFile();
            nlog.Warn("ConfigSaveAllItem Completed");
        }

        private void StatusUpdate(Status status)
        {
            StatusChangeEvent?.Invoke(this, new StatusEventArgs(status));
        }
        
        public void WriteConfig2TextBox()
        {
            textFilterString.Text = config.GetEnumValue(Category.Upload, Key.FilterString);
            textLocalFolder.Text = config.GetEnumValue(Category.Upload, Key.LocalDir);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (workObjectStorage || workLocalStorage)
                return;
            ConfigSaveAllItem();
            loadLocalDriveFileList();
            ObjectStorageFileList();
        }

        public void loadLocalDriveFileList()
        {
            nlog.Warn("LoadLocalDriveFileList Started");
            workLocalStorage = true;
            StatusUpdate(Status.Working);
            try
            {
                DirectoryInfo d = new DirectoryInfo(textLocalFolder.Text);
                FileInfo[] files = d.GetFiles("*" + textFilterString.Text + "*");
                long uiRefresh = 0;
                dgvLocalDrive.InvokeIfRequired(s => {
                    s.Rows.Clear();
                    s.RowHeadersVisible = false;
                    s.BackgroundColor = Color.White;

                    foreach (FileInfo file in files)
                    {
                        int n = s.Rows.Add();
                        s.Rows[n].Cells[0].Value = "false";
                        s.Rows[n].Cells[1].Value = file.Name;
                        s.Rows[n].Cells[2].Value = file.Length;
                        s.Rows[n].Cells[3].Value = String.Format("{0:yyyy-MM-dd HH:mm:ss}", file.LastWriteTime);
                        if (uiRefresh % 100 == 0) StatusUpdate(Status.Working);
                        uiRefresh++;
                    }
                });
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0},{1}", ex.Message, ex.StackTrace));
                workLocalStorage = false; 
            }
            StatusUpdate(Status.Completed);
            workLocalStorage = false;
            nlog.Warn("LoadLocalDriveFileList Completed");
        }

        private void buttonLocalDelete_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonLocalDelete_Click Started");
            StatusUpdate(Status.Working);
            ConfigSaveAllItem();
            foreach (DataGridViewRow item in dgvLocalDrive.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    File.Delete(Path.Combine(textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString()));
                }
            }
            loadLocalDriveFileList();
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonLocalDelete_Click Completed");
        }

        private void buttonLocalDirSearch_Click(object sender, EventArgs e)
        {
            nlog.Warn("SearchLocalDir Started");
            StatusUpdate(Status.Working);
            ConfigSaveAllItem();
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textLocalFolder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            loadLocalDriveFileList();
            StatusUpdate(Status.Completed);
            nlog.Warn("SearchLocalDir Completed");
        }
        
        private async void buttonObjectDownload_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonObjectDownload_Click Started");
            StatusUpdate(Status.Working);
            try
            {
                ConfigSaveAllItem();
                foreach (DataGridViewRow item in dgvObjectStorage.Rows)
                {
                    if (bool.Parse(item.Cells[0].Value.ToString()))
                    {
                        nlog.Warn(string.Format("{0} {1} download Started", textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString()));
                        string[] fullpath = item.Cells[1].EditedFormattedValue.ToString().Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                        string file = fullpath.Last();
                        Task task = objectStorage.download(
                            item.Cells[1].EditedFormattedValue.ToString()
                            , config.GetEnumValue(Category.Config, Key.ObjectBucket)
                            //, Path.Combine(textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString())
                            , Path.Combine(textLocalFolder.Text, file)
                            );
                        StatusUpdate(Status.Working);
                        await task;
                        nlog.Warn(string.Format("{0} {1} download Completed", textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0},{1}", ex.Message, ex.StackTrace));
            }
            ObjectStorageFileList();
            nlog.Warn("buttonObjectDownload_Click Completed");
        }

        private void buttonObjectReload_Click(object sender, EventArgs e)
        {
            if (workObjectStorage) return; 
            ObjectStorageFileList();
        }
        
        public async void ObjectStorageFileList()
        {
            nlog.Warn("ObjectStorageFileList Started");
            workObjectStorage = true; 
            StatusUpdate(Status.Working);
            try
            {
                ConfigSaveAllItem();

                Task<List<ObjectStorageFile>> result = objectStorage.list(config.GetEnumValue(Category.Config, Key.ObjectBucket));
                dgvObjectStorage.InvokeIfRequired(s => {
                    s.Rows.Clear();
                    s.RowHeadersVisible = false;
                    s.BackgroundColor = Color.White;
                });
                List<ObjectStorageFile> files = await result;
                long uiRefresh = 0;
                foreach (var file in files)
                {
                    if ((System.Text.RegularExpressions.Regex.IsMatch(file.Name
                        , textFilterString.Text
                        , System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        || textFilterString.Text.Length == 0
                        )
                    {
                        dgvObjectStorage.InvokeIfRequired(s => {
                            int n = s.Rows.Add();
                            s.Rows[n].Cells[0].Value = "false";
                            s.Rows[n].Cells[1].Value = file.Name;
                            s.Rows[n].Cells[2].Value = file.Length;
                            s.Rows[n].Cells[3].Value = String.Format("{0:yyyy-MM-dd HH:mm:ss}", System.DateTime.Parse(file.LastWriteTime));
                        });
                        if (uiRefresh % 100 == 0) StatusUpdate(Status.Working);
                        uiRefresh++;
                    }
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0},{1}", ex.Message, ex.StackTrace));
            }
            finally
            {
                workObjectStorage = false; 
            }
            StatusUpdate(Status.Completed);
            nlog.Warn("ObjectStorageFileList Completed");
        }

        private void buttonLocalReload_Click(object sender, EventArgs e)
        {
            if (workLocalStorage) return; 
            loadLocalDriveFileList();
        }

        private void buttonObjectDelete_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonObjectDelete_Click Started");
            StatusUpdate(Status.Working);
            ConfigSaveAllItem();
            foreach (DataGridViewRow item in dgvObjectStorage.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    objectStorage.delete(config.GetEnumValue(Category.Config, Key.ObjectBucket), item.Cells[1].EditedFormattedValue.ToString());
                }
            };
            ObjectStorageFileList();
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonObjectDelete_Click Completed");
        }
    }
}
