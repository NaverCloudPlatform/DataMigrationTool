﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using System.IO;
using System.Threading;
using DMS.General;
using Newtonsoft.Json;

namespace DMS
{
    public partial class UploadObject2InternalVP : UserControl
    {
        private static readonly Lazy<UploadObject2InternalVP> lazy =
            new Lazy<UploadObject2InternalVP>(() => new UploadObject2InternalVP(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static UploadObject2InternalVP Instance { get { return lazy.Value; } }

        Config config;
        ObjectStorage objectStorage;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;
        private bool workObjectStorage = false;
        private bool workInternalStorage = false;
        
        private UploadObject2InternalVP()
        {
            InitializeComponent();
            GFunctions.ColumSizeFix(dgvObjectStorage);
            GFunctions.ColumSizeFix(dgvInternalStorage);       
            config = Config.Instance;
            objectStorage = ObjectStorage.Instance;
            WriteConfig2TextBox();
        }
        
        public void WriteConfig2TextBox()
        {
            textFilterString.Text = config.GetEnumValue(Category.Upload, Key.FilterString);
            textInternalFolder.Text = config.GetEnumValue(Category.Upload, Key.InternalFolder);
        }
        void Keyword_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (workObjectStorage || workInternalStorage)
                    return; 
                ObjectStorageFileList();
                InternalStorageFileList();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (workObjectStorage || workInternalStorage)
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
            config.SetEnumValue(Category.Upload, Key.InternalFolder, textInternalFolder.Text);
            config.SetEnumValue(Category.Upload, Key.FilterString, textFilterString.Text);
            lock (config.lockObject)
                config.WriteConfigToFile();
            nlog.Warn("ConfigSaveAllItem Completed");
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
                    }
                    if (uiRefresh % 100 == 0) StatusUpdate(Status.Working);
                    uiRefresh++;
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
                    objectStorage.delete(
                        config.GetEnumValue(Category.Config, Key.ObjectBucket)
                        , item.Cells[1].EditedFormattedValue.ToString());
                }
            };
            ObjectStorageFileList();
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonObjectDelete_Click Completed");
        }

        private async void buttonObjectUpload_Click(object sender, EventArgs e)
        {
            nlog.Warn("BackupStorageUpload Clicked");
            ConfigSaveAllItem();
            string json = string.Empty;
            foreach (DataGridViewRow item in dgvObjectStorage.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    bool exists = IsFileExistsInLocal(item.Cells[1].Value.ToString());
                    bool matchSize = IsMatchFileSizeInLocal(item.Cells[1].Value.ToString(), Convert.ToInt64(item.Cells[2].Value.ToString().ToString()));
                    if ((exists && matchSize) || !exists)
                    {
                        var postParams = new List<KeyValuePair<string, string>>();
                        AsyncCall asyncCall = new AsyncCall();
                        postParams.Add(new KeyValuePair<string, string>("cloudMssqlInstanceNo", config.GetEnumValue(Category.Config, Key.CloudDbInstanceNo)));
                        postParams.Add(new KeyValuePair<string, string>("fileName", item.Cells[1].EditedFormattedValue.ToString()));
                        postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));
                        string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                        endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);
                        Task<string> result = asyncCall.WebApiCall(
                            endpointUrl, GetPostType.POST, @"/vmssql/v2/downloadDmsFile", postParams);
                        json = await result;
                        nlog.Warn(json);
                    }
                }
            };

            ObjectStorageFileList();
            InternalStorageFileList();
            nlog.Warn("BackupStorageUpload Completed");
        }

        private bool IsFileExistsInLocal(string filename)
        {
            bool exists = false;
            try
            {
                string fullFilename = $@"{config.GetEnumValue(Category.Upload, Key.LocalDir)}\{filename}";
                if (File.Exists(fullFilename))
                {
                    exists = true;
                    nlog.Warn($@"IsFileExistsInLocal exists : {exists}, filename : {fullFilename}");
                }
                else
                {
                    exists = false;
                    nlog.Warn($@"IsFileExistsInLocal exists : {exists}, filename : {fullFilename}");
                    nlog.Warn("It's probably a file that only exists in objectstorage.");
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", ex.Message, ex.StackTrace));
            }
            return exists;
        }

        private bool IsMatchFileSizeInLocal (string filename, long filesize)
        {
            bool isMatch = true;
            StatusUpdate(Status.Working);

            try
            {
                DirectoryInfo d = new DirectoryInfo(config.GetEnumValue(Category.Upload, Key.LocalDir));
                FileInfo[] files = d.GetFiles(filename);
                long uiRefresh = 0;
                
                foreach (var file in files)
                {
                    if (file.Name == filename)
                    {
                        if (file.Length != filesize)
                        {
                            MessageBox.Show(string.Format("file size does not match! LocalFileSize : {0}, objectStorageFileSize : {1}", file.Length, filesize));
                            nlog.Warn(string.Format("file size does not match! LocalFileSize : {0}, objectStorageFileSize : {1}", file.Length, filesize));
                            isMatch = false;
                        }
                    }
                    if (uiRefresh % 100 == 0) StatusUpdate(Status.Working);
                    uiRefresh++;
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", ex.Message, ex.StackTrace));
            }
            StatusUpdate(Status.Completed);
            return isMatch;
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
                
                string getDmsObjectStorageBackupListResponse = await getDmsObjectStorageBackupListAsync();
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                if (getDmsObjectStorageBackupListResponse.Contains("server does not exists"))
                    throw new Exception("There is no corresponding server. Perform the Configuration steps again.");

                if (getDmsObjectStorageBackupListResponse.Contains("totalRows"))
                {
                    var getDmsObjectStorageBackupList = JsonConvert.DeserializeObject<getDmsObjectStorageBackupList>(getDmsObjectStorageBackupListResponse, settings);
                    List<DmsFileList> files = getDmsObjectStorageBackupList.getDmsObjectStorageBackupListResponse.dmsFileList;

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

                            dgvInternalStorage.InvokeIfRequired(s =>
                            {
                                int n = s.Rows.Add();
                                s.Rows[n].Cells[0].Value = "false";
                                s.Rows[n].Cells[1].Value = file.fileName;
                                s.Rows[n].Cells[2].Value = file.fileLength;
                                s.Rows[n].Cells[3].Value = String.Format("{0:yyyy-MM-dd HH:mm:ss}", System.DateTime.Parse(file.lastWriteTime));
                            });

                        }
                    }
                }
                else if (getDmsObjectStorageBackupListResponse.Contains("errorCode"))
                {
                    var responseError = JsonConvert.DeserializeObject<Error>(getDmsObjectStorageBackupListResponse, settings);
                    string errorMessage = $@"errorMessage : {responseError.responseError.message}, errorCode : {responseError.responseError.errorCode}, details : {responseError.responseError.details} {Environment.NewLine}Check the internal storage folder name.";
                    throw new Exception(errorMessage);
                }
                else 
                {
                    var responseError = JsonConvert.DeserializeObject<ResponseError>(getDmsObjectStorageBackupListResponse, settings);
                    string errorMessage = $@"returnMessage : {responseError.responseError.returnMessage}, returnCode : {responseError.responseError.returnCode} {Environment.NewLine}Check the internal storage folder name.";
                    throw new Exception(errorMessage);
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
        
        private async Task<string> getDmsObjectStorageBackupListAsync()
        {
            nlog.Warn("getDmsObjectStorageBackupListAsync Started");

            ConfigSaveAllItem();
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();
                postParams.Add(new KeyValuePair<string, string>("cloudMssqlInstanceNo", config.GetEnumValue(Category.Config, Key.CloudDbInstanceNo)));
                postParams.Add(new KeyValuePair<string, string>("folderName", textInternalFolder.Text));
                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , @"/vmssql/v2/getDmsObjectStorageBackupList"
                    , postParams);

                json = await result;
                nlog.Warn(json);
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0},{1}", ex.Message, ex.StackTrace));
            }
            StatusUpdate(Status.Completed);
            nlog.Warn("getDmsObjectStorageBackupListAsync Completed");
            return json;
        }

        private void buttonInternalReload_Click(object sender, EventArgs e)
        {
            if (workInternalStorage) return;
            InternalStorageFileList();
        }
    }
}
