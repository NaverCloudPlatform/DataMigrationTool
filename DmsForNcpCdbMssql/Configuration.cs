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

namespace DMS
{
    public partial class Configuration : UserControl
    {

        Config config;
        ObjectStorage objectStorage;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;

        public Configuration()
        {
            InitializeComponent();
            textBoxEndPointLable.Text = @"http://docs.ncloud.com/en/storage/storage-7-1.html";
            textBoxEndPointLable.ReadOnly = true;
            textBoxEndPointLable.BorderStyle = 0;
            textBoxEndPointLable.BackColor = this.BackColor;
            textBoxEndPointLable.TabStop = false;

            textBoxAPIEndPointLable.Text = @"http://docs.ncloud.com/ko/api_new/api_new-9-1.html";
            textBoxAPIEndPointLable.ReadOnly = true;
            textBoxAPIEndPointLable.BorderStyle = 0;
            textBoxAPIEndPointLable.BackColor = this.BackColor;
            textBoxAPIEndPointLable.TabStop = false;
            
            config = Config.Instance;
            objectStorage = ObjectStorage.Instance;
            WriteConfig2TextBox();
        }

        public void WriteConfig2TextBox()
        {
            textObjectEndPoint.Text = config.AppConfigurations[new Tuple<Category, Key>(Category.Config, Key.ObjectEndPoint)];
            if (config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1")
                checkSSLObjectStorage.CheckState = CheckState.Checked;
            else
                checkSSLObjectStorage.CheckState = CheckState.Unchecked;

            textObjectAccessKey.Text = config.GetEnumValue(Category.Config, Key.ObjectAccessKey);
            textObjectSecretKey.Text = config.GetEnumValue(Category.Config, Key.ObjectSecretKey);
            textDefaultBucket.Text = config.GetEnumValue(Category.Config, Key.ObjectBucket);

            textNcpApiUrl.Text = config.AppConfigurations[new Tuple<Category, Key>(Category.Config, Key.NcpApiUrl)];
            textApiGatewayAccessKey.Text = config.GetEnumValue(Category.Config, Key.ApiGatewayAccessKey);
            textApiGatewaySecretKey.Text = config.GetEnumValue(Category.Config, Key.ApiGatewaySecretKey);
            textApiGatewayKey.Text = config.GetEnumValue(Category.Config, Key.ApiGatewayKey);
            textDefaultTestApi.Text = config.GetEnumValue(Category.Config, Key.DefaultTestApi);
            textCloudDbInstanceNo.Text = config.GetEnumValue(Category.Config, Key.CloudDbInstanceNo);

            if (config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1")
                checkSSLApiGateway.CheckState = CheckState.Checked;
            else
                checkSSLApiGateway.CheckState = CheckState.Unchecked;
            
        }

        private async void buttonConnectionTest_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonConnectionTest_Click Started");
            StatusUpdate(Status.Working);
            try
            {
                if (textObjectEndPoint.Text.ToUpper().StartsWith(@"HTTP://"))
                    textObjectEndPoint.Text = textObjectEndPoint.Text.Substring(7, textObjectEndPoint.Text.Length - 7);
                if (textObjectEndPoint.Text.ToUpper().StartsWith(@"HTTPS://"))
                    textObjectEndPoint.Text = textObjectEndPoint.Text.Substring(8, textObjectEndPoint.Text.Length - 8);
            }
            catch (Exception) { }
            bool isNCloud = false;
            try
            {
                ConfigSaveAllItem();
                string Message = await objectStorage.CheckBucket(config.GetEnumValue(Category.Config, Key.ObjectBucket));
                MessageBox.Show(Message); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
            }

            if (
                    isNCloud
                    && System.Text.RegularExpressions.Regex.IsMatch
                    (
                        textObjectEndPoint.Text
                        , "ncloud"
                        , System.Text.RegularExpressions.RegexOptions.IgnoreCase
                    )
                )
            {
                textNcpApiUrl.Text = @"ncloud.apigw.ntruss.com";
                textApiGatewayAccessKey.Text = textObjectAccessKey.Text;
                textApiGatewaySecretKey.Text = textObjectSecretKey.Text;
            }

            StatusUpdate(Status.Completed);
            nlog.Warn("buttonConnectionTest_Click Completed");
        }
        
        private void StatusUpdate(Status status)
        {
            StatusChangeEvent?.Invoke(this, new StatusEventArgs(status));
        }
        
        private void ConfigSaveAllItem()
        {
            nlog.Warn("ConfigSaveAllItem Started");
            
            config.SetEnumValue(Category.Config, Key.ObjectEndPoint, textObjectEndPoint.Text);
            config.SetEnumValue(Category.Config, Key.UseSSLObjectStorage, checkSSLObjectStorage.CheckState == CheckState.Checked ? "1" : "0");
            config.SetEnumValue(Category.Config, Key.ObjectAccessKey, textObjectAccessKey.Text);
            config.SetEnumValue(Category.Config, Key.ObjectSecretKey, textObjectSecretKey.Text);
            config.SetEnumValue(Category.Config, Key.ObjectBucket, textDefaultBucket.Text);
            config.SetEnumValue(Category.Config, Key.NcpApiUrl, textNcpApiUrl.Text);
            config.SetEnumValue(Category.Config, Key.ApiGatewayAccessKey, textApiGatewayAccessKey.Text);
            config.SetEnumValue(Category.Config, Key.ApiGatewaySecretKey, textApiGatewaySecretKey.Text);
            config.SetEnumValue(Category.Config, Key.ApiGatewayKey, textApiGatewayKey.Text);
            config.SetEnumValue(Category.Config, Key.UseSSLApiGateway, checkSSLApiGateway.CheckState == CheckState.Checked ? "1" : "0");
            config.SetEnumValue(Category.Config, Key.DefaultTestApi, textDefaultTestApi.Text);
            config.SetEnumValue(Category.Config, Key.CloudDbInstanceNo, textCloudDbInstanceNo.Text);
            lock(config.lockObject)
                config.WriteConfigToFile();

            nlog.Warn("ConfigSaveAllItem Completed");
        }

        private async void buttonApiGatewayTest_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonApiGatewayTest_Click Started");
            StatusUpdate(Status.Working);
            try
            {
                if (textNcpApiUrl.Text.ToUpper().StartsWith(@"HTTP://"))
                    textNcpApiUrl.Text = textNcpApiUrl.Text.Substring(7, textNcpApiUrl.Text.Length - 7);
                
                if (textNcpApiUrl.Text.ToUpper().StartsWith(@"HTTPS://"))
                    textNcpApiUrl.Text = textNcpApiUrl.Text.Substring(8, textNcpApiUrl.Text.Length - 8);
            }
            catch (Exception) { }

            ConfigSaveAllItem();
            var postParams = new List<KeyValuePair<string, string>>();
            AsyncCall asyncCall = new AsyncCall();
            string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
            endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.NcpApiUrl);

            Task<string> result = asyncCall.WebApiCall(
                endpointUrl
                , GetPostType.GET
                , @"/clouddb/v1/" + config.GetEnumValue(Category.Config, Key.DefaultTestApi) + "?dbKindCode=MSSQL&responseFormatType=json"
                , postParams);

            string json = await result;
            nlog.Warn(json);
            MessageBox.Show(json);
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonApiGatewayTest_Click Completed");
        }

        private async void buttonSaveDmsInfo_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonSaveDmsInfo_Click Started");
            StatusUpdate(Status.Working);
            ConfigSaveAllItem();
            var postParams = new List<KeyValuePair<string, string>>();
            AsyncCall asyncCall = new AsyncCall();
            string objectEndpoint = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
            objectEndpoint = objectEndpoint + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);

            postParams.Add(new KeyValuePair<string, string>("objectStorageAccessKey", config.GetEnumValue(Category.Config, Key.ObjectAccessKey)));
            postParams.Add(new KeyValuePair<string, string>("objectStorageSecretKey", config.GetEnumValue(Category.Config, Key.ObjectSecretKey)));
            postParams.Add(new KeyValuePair<string, string>("endpoint", objectEndpoint));
            postParams.Add(new KeyValuePair<string, string>("bucketName", config.GetEnumValue(Category.Config, Key.ObjectBucket)));
            postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));

            string apiEndpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
            apiEndpointUrl = apiEndpointUrl + config.GetEnumValue(Category.Config, Key.NcpApiUrl);

            Task<string> result = asyncCall.WebApiCall(
                apiEndpointUrl
                , GetPostType.POST
                , @"/clouddb/v1/setObjectStorageInfo"
                , postParams);

            string json = await result;
            nlog.Warn(json);
            MessageBox.Show(json);
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonSaveDmsInfo_Click Completed");
        }
        

        private async void buttonDbServerExistsCheck_Click(object sender, EventArgs e)
        {
            nlog.Warn("BackupStorageFileList Started");
            StatusUpdate(Status.Working);
            string returnMessage = string.Empty;
            bool serverExists = false;
            Dictionary<string, string> cloudDBInstanceLists = new Dictionary<string, string>();
            try
            {
                ConfigSaveAllItem();

                string json = string.Empty;
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                json = await GetZoneListAsync();
                getZoneList getZoneList = JsonConvert.DeserializeObject<getZoneList>(json, settings);
                List<zone> zones = getZoneList.getZoneListResponse.zoneList;

                foreach (var a in zones)
                {
                    string InstancesOfZoneJson = string.Empty;
                    nlog.Warn(string.Format("{0},{1},{2},{3},{4}", a.zoneNo, a.zoneName, a.zoneCode, a.zoneDescription, a.regionNo));
                    InstancesOfZoneJson = await GetCloudDBInstanceListAsync(a.zoneNo.ToString());
                    cloudDBInstanceLists.Add(a.zoneNo.ToString(), InstancesOfZoneJson);
                    nlog.Warn(InstancesOfZoneJson);
                }

                foreach (var a in cloudDBInstanceLists)
                {
                    getCloudDBInstanceList getCloudDBInstanceList = JsonConvert.DeserializeObject<getCloudDBInstanceList>(a.Value, settings);
                    List<cloudDBInstanceList> cloudDBInstanceList = getCloudDBInstanceList.getCloudDBInstanceListResponse.cloudDBInstanceList;
                    foreach (var b in cloudDBInstanceList)
                    {
                        nlog.Warn(b.cloudDBInstanceNo);
                        if (b.cloudDBInstanceNo == textCloudDbInstanceNo.Text)
                        {
                            serverExists = true; 
                            MessageBox.Show("Success");
                            break; 
                        }
                    }
                }
                if (!serverExists)
                    MessageBox.Show("Fail : Server dose not exists");
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                MessageBox.Show("Fail");
            }
            
            StatusUpdate(Status.Completed);
            nlog.Warn("BackupStorageFileList Completed");
        }

        private async Task<string> GetCloudDBInstanceListAsync(string zoneNo)
        {
            nlog.Warn("GetCloudDBInstanceListAsync Started");
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();
                postParams.Add(new KeyValuePair<string, string>("dbKindCode", "MSSQL"));
                postParams.Add(new KeyValuePair<string, string>("zoneNo", zoneNo));
                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));

                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.NcpApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , @"/clouddb/v1/getCloudDBInstanceList"
                    , postParams);

                json = await result;
                nlog.Warn(json);
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("{0}, {1}", e.Message, e.StackTrace));
            }

            return json;
        }


        private async Task<string> GetZoneListAsync()
        {
            nlog.Warn("GetZoneListAsync Started");
            
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();

                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));
                postParams.Add(new KeyValuePair<string, string>("regionNo", "1"));
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.NcpApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , "/server/v1/getZoneList"
                    , postParams);

                json = await result;
                nlog.Warn(json);
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("{0}, {1}", e.Message, e.StackTrace));
            }
            return json;
        }
        
        private async Task<string> BackupStorageFileListAync()
        {
            nlog.Warn("BackupStorageFileListAync Started");

            ConfigSaveAllItem();
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();
                postParams.Add(new KeyValuePair<string, string>("cloudDBInstanceNo", config.GetEnumValue(Category.Upload, Key.CloudDbInstanceNo)));
                postParams.Add(new KeyValuePair<string, string>("folderName", ""));
                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.NcpApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , "getObjectStorageBackupList"
                    , postParams);

                json = await result;
                nlog.Warn(json);
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("{0}, {1}", e.Message, e.StackTrace));
            }
            StatusUpdate(Status.Completed);
            nlog.Warn("BackupStorageFileListAync Completed");
            return json;
        }
    }
}
