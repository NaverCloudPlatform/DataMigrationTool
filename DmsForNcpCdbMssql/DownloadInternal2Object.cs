using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using Newtonsoft.Json;
using System.Threading;
using DMS.General;

namespace DMS
{
    public partial class DownloadInternal2Object : UserControl
    {
        private static readonly Lazy<DownloadInternal2Object> lazy =
            new Lazy<DownloadInternal2Object>(() => new DownloadInternal2Object(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static DownloadInternal2Object Instance { get { return lazy.Value; } }
        
        Config config;
        ObjectStorage objectStorage;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;
        private bool workInternalStorage = false;
        private bool workObjectStorage = false; 
       
        private DownloadInternal2Object()
        {
            InitializeComponent();
            GFunctions.ColumSizeFix(dgvInternalStorage);
            GFunctions.ColumSizeFix(dgvObjectStorage);
            config = Config.Instance;
            objectStorage = ObjectStorage.Instance;
            WriteConfig2TextBox();
        }

        void Keyword_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (workInternalStorage || workObjectStorage)
                    return; 
                ConfigSaveAllItem();
                ObjectStorageFileList();
                InternalStorageFileList();
            }
        }

        public void WriteConfig2TextBox()
        {
            textFilterString.Text = config.GetEnumValue(Category.Upload, Key.FilterString);
        }

        private async void buttonBackupDownload_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonBackupDownload Clicked");
            ConfigSaveAllItem();
            string json = string.Empty;
            foreach (DataGridViewRow item in dgvInternalStorage.Rows)
            {
                
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    var postParams = new List<KeyValuePair<string, string>>();
                    AsyncCall asyncCall = new AsyncCall();
                    postParams.Add(new KeyValuePair<string, string>("cloudDBInstanceNo", config.GetEnumValue(Category.Config, Key.CloudDbInstanceNo)));
                    postParams.Add(new KeyValuePair<string, string>("fileName", item.Cells[1].EditedFormattedValue.ToString()));
                    postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));
                    string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                    endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

                    Task<string> result = asyncCall.WebApiCall(
                        endpointUrl, GetPostType.POST, @"/clouddb/v2/uploadDmsFile", postParams);
                    json = await result;
                    nlog.Warn(json);
                }
            };

            ObjectStorageFileList();
            InternalStorageFileList();
            nlog.Warn("buttonBackupDownload Completed");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (workInternalStorage || workObjectStorage)
                return;
            ConfigSaveAllItem();
            ObjectStorageFileList();
            InternalStorageFileList();
        }

        private void StatusUpdate(Status status)
        {
            StatusChangeEvent?.Invoke(this, new StatusEventArgs(status));
        }
        
        private void ConfigSaveAllItem()
        {
            nlog.Warn("ConfigSaveAllItem Started");
            config.SetEnumValue(Category.Upload, Key.FilterString, textFilterString.Text);
            lock (config.lockObject)
                config.WriteConfigToFile();
            nlog.Warn("ConfigSaveAllItem Completed");
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
                dgvObjectStorage.InvokeIfRequired(s =>
                {
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
                        dgvObjectStorage.InvokeIfRequired(s =>
                        {

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

        private void buttonObjectStorageReload_Click(object sender, EventArgs e)
        {
            if (workObjectStorage)
                return;
            ObjectStorageFileList();
        }
        
        private void buttonBackupStorageReload_Click(object sender, EventArgs e)
        {
            if (workInternalStorage)
                return;
            InternalStorageFileList();
        }
        
        public async void InternalStorageFileList()
        {
            nlog.Warn("InternalStorageFileList Started");
            workInternalStorage = true; 
            StatusUpdate(Status.Working);

            try
            {
                ConfigSaveAllItem();
                dgvInternalStorage.InvokeIfRequired(s => {
                    s.Rows.Clear();
                    s.RowHeadersVisible = false;
                    s.BackgroundColor = Color.White;
                });
                
                Task<string> result = getBackupListAsync();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                string getBackupListResult = await result;

                if (getBackupListResult.Contains("server does not exists"))
                    throw new Exception("There is no corresponding server. Perform the Configuration steps again.");

                getBackupList getBackupList = JsonConvert.DeserializeObject<getBackupList>(getBackupListResult, settings);
                List<backupFileList> files = getBackupList.getBackupListResponse.backupFileList;
                long uiRefresh = 0;
                foreach (var file in files)
                {
                    if (
                            (System.Text.RegularExpressions.Regex.IsMatch
                                (
                                file.fileName
                                , textFilterString.Text
                                , System.Text.RegularExpressions.RegexOptions.IgnoreCase
                                )
                            )
                            || textFilterString.Text.Length == 0
                        )
                    {
                        string RequestNo = string.Empty;
                        string RequestReturnCode = string.Empty;
                        string ReturnCode = string.Empty;
                        string ReturnCodeName = string.Empty;

                        dgvInternalStorage.InvokeIfRequired(s => {
                            int n = s.Rows.Add();
                            s.Rows[n].Cells[0].Value = "false";
                            s.Rows[n].Cells[1].Value = file.fileName;
                            s.Rows[n].Cells[2].Value = file.backupType.code;
                            s.Rows[n].Cells[3].Value = String.Format("{0:yyyy-MM-dd HH:mm:ss}", System.DateTime.Parse(file.backupEndTime));
                        });
                        if (uiRefresh % 100 == 0) StatusUpdate(Status.Working);
                        uiRefresh++;
                    }
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0},{1}", ex.Message, ex.StackTrace));
                workInternalStorage = false;
                MessageBox.Show(ex.Message);
            }

            StatusUpdate(Status.Completed);
            workInternalStorage = false;
            nlog.Warn("InternalStorageFileList Completed");
        }

        private async Task<string> getBackupListAsync()
        {
            nlog.Warn("getBackupListAsync Started");

            ConfigSaveAllItem();
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();
                postParams.Add(new KeyValuePair<string, string>("cloudDBInstanceNo", config.GetEnumValue(Category.Config, Key.CloudDbInstanceNo)));
                postParams.Add(new KeyValuePair<string, string>("databaseName", ""));
                postParams.Add(new KeyValuePair<string, string>("type", ""));
                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , @"/clouddb/v2/getBackupList"
                    , postParams);

                json = await result;
                nlog.Warn(json);
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("{0}, {1}", e.Message, e.StackTrace));
            }
            StatusUpdate(Status.Completed);
            nlog.Warn("getBackupListAsync Completed");
            return json;
        }
    }
}
