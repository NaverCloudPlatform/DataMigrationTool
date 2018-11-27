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


namespace DMS
{
    public partial class UploadLocal2Object : UserControl
    {
        Config config;
        ObjectStorage objectStorage;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;
        private bool workLocalStorage = false;
        private bool workObjectStorage = false;
        public UploadLocal2Object()
        {
            InitializeComponent();
            dgvLocalDrive.RowHeadersVisible = false;
            dgvLocalDrive.BackgroundColor = Color.White;
            dgvObjectStorage.RowHeadersVisible = false;
            dgvObjectStorage.BackgroundColor = Color.White;
            config = Config.Instance;
            objectStorage = ObjectStorage.Instance;
            WriteConfig2TextBox();
        }
        
        public void WriteConfig2TextBox()
        {
            textFilterString.Text = config.GetEnumValue(Category.Upload, Key.FilterString);
            textLocalFolder.Text = config.GetEnumValue(Category.Upload, Key.LocalDir);
        }

        void Keyword_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (workLocalStorage | workObjectStorage)
                    return;
                ObjectStorageFileList();
                loadLocalDriveFileList();
            }
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

        private void StatusUpdate(Status status)
        {
            StatusChangeEvent?.Invoke(this, new StatusEventArgs(status));
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (workLocalStorage | workObjectStorage)
                return;
            ConfigSaveAllItem();
            loadLocalDriveFileList();
            ObjectStorageFileList();
        }

        private void buttonLocalReload_Click(object sender, EventArgs e)
        {
            if (workLocalStorage) return; 
            loadLocalDriveFileList();
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
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
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

        private async void buttonLocalUpload_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonLocalUpload_Click Started");
            StatusUpdate(Status.Working);
            ConfigSaveAllItem();
            foreach (DataGridViewRow item in dgvLocalDrive.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    nlog.Warn(string.Format("{0} {1} upload Started", textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString()));
                    Task task = objectStorage.upload(
                        Path.Combine(textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString())
                        , config.GetEnumValue(Category.Config, Key.ObjectBucket)
                        , item.Cells[1].EditedFormattedValue.ToString()
                        );
                    StatusUpdate(Status.Working);
                    await task; 
                    nlog.Warn(string.Format("{0} {1} upload Completed", textLocalFolder.Text, item.Cells[1].EditedFormattedValue.ToString()));
                }
            }
            ObjectStorageFileList();
            nlog.Warn("buttonLocalUpload_Click Completed");
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
                workObjectStorage = false; 
            }
            StatusUpdate(Status.Completed);
            workObjectStorage = false;
            nlog.Warn("ObjectStorageFileList Completed");
        }
        
        private void buttonObjectReload_Click(object sender, EventArgs e)
        {
            if (workObjectStorage) return; 
            ObjectStorageFileList();
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
                    objectStorage.delete(
                        config.GetEnumValue(Category.Config, Key.ObjectBucket)
                        , item.Cells[1].EditedFormattedValue.ToString());
                }
            };
            ObjectStorageFileList();
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonObjectDelete_Click Completed");
        }
    }
}
