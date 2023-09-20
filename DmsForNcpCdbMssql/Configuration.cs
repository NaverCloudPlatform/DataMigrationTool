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
using System.Text.RegularExpressions;

namespace DMS
{
    public partial class Configuration : UserControl
    {
        private static readonly Lazy<Configuration> lazy =
            new Lazy<Configuration>(() => new Configuration(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static Configuration Instance { get { return lazy.Value; } }
        
        Config config;
        ObjectStorage objectStorage;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;

        bool TargetObjectStorageInfoTested { get; set; } = false;
        bool ApigatewayInfoTested { get; set; } = false;
        bool DatabaseInfoTested { get; set; } = false;

        private Configuration()
        {
            InitializeComponent();
            textBoxEndPointLable.Text = @"https://api.ncloud-docs.com/docs/storage-objectstorage";
            textBoxEndPointLable.ReadOnly = true;
            textBoxEndPointLable.BorderStyle = 0;
            textBoxEndPointLable.BackColor = this.BackColor;
            textBoxEndPointLable.TabStop = false;

            textBoxAPIEndPointLable.Text = @"https://api.ncloud-docs.com/docs/database-clouddb";
            textBoxAPIEndPointLable.ReadOnly = true;
            textBoxAPIEndPointLable.BorderStyle = 0;
            textBoxAPIEndPointLable.BackColor = this.BackColor;
            textBoxAPIEndPointLable.TabStop = false;

            config = Config.Instance;
            Platform = config.GetEnumValue(Category.Config, Key.Platform);
            ZoneVariableChange();

            objectStorage = ObjectStorage.Instance;
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
            textApiUrl.Text = config.GetEnumValue(Category.Config, Key.ApiUrl); 
            textApiGatewayAccessKey.Text = config.GetEnumValue(Category.Config, Key.ApiGatewayAccessKey);
            textApiGatewaySecretKey.Text = config.GetEnumValue(Category.Config, Key.ApiGatewaySecretKey);
            textDefaultTestApi.Text = DefaultTestApi;
            textCloudDbInstanceNo.Text = config.GetEnumValue(Category.Config, Key.CloudDbInstanceNo);

            if (config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1")
                checkSSLApiGateway.CheckState = CheckState.Checked;
            else
                checkSSLApiGateway.CheckState = CheckState.Unchecked;

            config.ConfigurationBackup();
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
            bool ConnectionTestSuccess = false;
            try
            {
                ConfigSaveAllItem();
                if (!BucketNameCheck(textDefaultBucket.Text))
                {
                    MessageBox.Show("Bucket names must start with an English lowercase letter and are limited to 30 characters.");
                    return;
                }

                string Message = await objectStorage.CheckBucket(config.GetEnumValue(Category.Config, Key.ObjectBucket));
                if (Message == CallResult.Success.ToString())
                {
                    ConnectionTestSuccess = true;
                    TargetObjectStorageInfoTested = true;
                    MessageBox.Show("TargetObjectStorageInfo Connection test was successful");
                }
                else
                {
                    MessageBox.Show(Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                ConnectionTestSuccess = false;
                TargetObjectStorageInfoTested = false;
            }

            if (
                    ConnectionTestSuccess
                    && System.Text.RegularExpressions.Regex.IsMatch
                    (
                        textObjectEndPoint.Text
                        , "ncloud"
                        , System.Text.RegularExpressions.RegexOptions.IgnoreCase
                    )
                )
            {
                textApiUrl.Text = @"ncloud.apigw.ntruss.com";
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
            config.SetEnumValue(Category.Config, Key.Platform, Platform);
            config.SetEnumValue(Category.Config, Key.UseSSLObjectStorage, checkSSLObjectStorage.CheckState == CheckState.Checked ? "1" : "0");
            config.SetEnumValue(Category.Config, Key.ObjectAccessKey, textObjectAccessKey.Text);
            config.SetEnumValue(Category.Config, Key.ObjectSecretKey, textObjectSecretKey.Text);
            config.SetEnumValue(Category.Config, Key.ObjectBucket, textDefaultBucket.Text);
            config.SetEnumValue(Category.Config, Key.ApiUrl, textApiUrl.Text);

            switch (Platform)
            {
                case "CP":
                    config.SetEnumValue(Category.Config, Key.CPDefaultTestApi, textDefaultTestApi.Text);
                    break;
                case "VP":

                    config.SetEnumValue(Category.Config, Key.VPDefaultTestApi, textDefaultTestApi.Text);
                    break;
            }

            config.SetEnumValue(Category.Config, Key.ApiGatewayAccessKey, textApiGatewayAccessKey.Text);
            config.SetEnumValue(Category.Config, Key.ApiGatewaySecretKey, textApiGatewaySecretKey.Text);
            config.SetEnumValue(Category.Config, Key.UseSSLApiGateway, checkSSLApiGateway.CheckState == CheckState.Checked ? "1" : "0");
            
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
                if (textApiUrl.Text.ToUpper().StartsWith(@"HTTP://"))
                    textApiUrl.Text = textApiUrl.Text.Substring(7, textApiUrl.Text.Length - 7);
                
                if (textApiUrl.Text.ToUpper().StartsWith(@"HTTPS://"))
                    textApiUrl.Text = textApiUrl.Text.Substring(8, textApiUrl.Text.Length - 8);
            }
            catch (Exception) { }

            ConfigSaveAllItem();
            var postParams = new List<KeyValuePair<string, string>>();
            AsyncCall asyncCall = new AsyncCall();
            string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
            endpointUrl = endpointUrl + textApiUrl.Text;

            Task<string> result; 

            if (Platform.Equals("CP"))
            {
               result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.GET
                    , @"/clouddb/v2/" + DefaultTestApi + "?dbKindCode=MSSQL&responseFormatType=json"
                    , postParams);
            }
            else 
            {
                result = asyncCall.WebApiCall(
                     endpointUrl
                     , GetPostType.GET
                     , @"/vmssql/v2/" + DefaultTestApi + "?responseFormatType=json"
                     , postParams);
            }

            string json = await result;
            nlog.Warn(json);
            
            if(json.Contains("success"))
            {
                ApigatewayInfoTested = true;
                MessageBox.Show("ApiGatewayInfo Connection test was successful");
            }
            else
            {
                ApigatewayInfoTested = false;
                MessageBox.Show(json);
            }
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonApiGatewayTest_Click Completed");
        }

        private async void buttonSaveDmsInfo_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonSaveDmsInfo_Click Started");

            if (!TargetObjectStorageInfoTested)
            {
                MessageBox.Show("Save after performing the Target Object Storage Info Connection test.");
                return;
            }
            if (!ApigatewayInfoTested)
            {
                MessageBox.Show("Save after performing the ApiGateway Info Connection test.");
                return;
            }
            if (!DatabaseInfoTested)
            {
                MessageBox.Show("Save after performing the Database Info Connection test.");
                return;
            }


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
            apiEndpointUrl = apiEndpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

            Task<string> result;

 

            if (Platform.Equals("CP"))
            {
                result = asyncCall.WebApiCall(
                                apiEndpointUrl
                                , GetPostType.POST
                                , @"/clouddb/v2/setObjectStorageInfo"
                                , postParams);
            }
            else
            {
                result = asyncCall.WebApiCall(
                                 apiEndpointUrl
                                 , GetPostType.POST
                                 , @"/vmssql/v2/setDmsObjectStorageInfo"
                                 , postParams);
            }

            string json = await result;
            nlog.Warn(json);
            
            if (json.Contains("success"))
            {
                MessageBox.Show("DMT setting information was saved on the server.");
            }
            
            StatusUpdate(Status.Completed);
            nlog.Warn("buttonSaveDmsInfo_Click Completed");
        }
        

        private async void buttonDbServerExistsCheck_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonDbServerExistsCheck_Click Started");
            if (Platform.Equals("CP"))
                await CPDbServerExistsCheck();
            if (Platform.Equals("VP"))
                await VPDbServerExistsCheck();
            nlog.Warn("buttonDbServerExistsCheck_Click Completed");
        }


        private async Task CPDbServerExistsCheck()
        {
            StatusUpdate(Status.Working);
            string returnMessage = string.Empty;
            bool serverExists = false;
            Dictionary<string, string> dicCloudDBInstance = new Dictionary<string, string>();
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
                    InstancesOfZoneJson = await GetCPCloudDBInstanceListAsync(a.zoneNo.ToString());
                    dicCloudDBInstance.Add(a.zoneNo.ToString(), InstancesOfZoneJson);
                    nlog.Warn(InstancesOfZoneJson);
                }

                foreach (var a in dicCloudDBInstance)
                {
                    getCloudDBInstanceList getCloudDBInstanceList = JsonConvert.DeserializeObject<getCloudDBInstanceList>(a.Value, settings);
                    List<cloudDBInstanceList> cloudDBInstanceList = getCloudDBInstanceList.getCloudDBInstanceListResponse.cloudDBInstanceList;
                    foreach (var b in cloudDBInstanceList)
                    {
                        nlog.Warn(b.cloudDBInstanceNo);
                        if (b.cloudDBInstanceNo.Equals(textCloudDbInstanceNo.Text.Trim()))
                        {
                            serverExists = true;
                            break;
                        }
                    }
                }
                if (serverExists)
                {
                    MessageBox.Show("DatabaseInfo Connection test was successful");
                    DatabaseInfoTested = true;
                }
                if (!serverExists)
                {
                    MessageBox.Show(string.Format("{0} : Server dose not exists", CallResult.Fail.ToString()));
                    DatabaseInfoTested = false;
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                MessageBox.Show(string.Format("{0} : {1}", CallResult.Fail.ToString(), ex.Message));
            }

            StatusUpdate(Status.Completed);
        }

        private async Task VPDbServerExistsCheck()
        {
            StatusUpdate(Status.Working);
            string returnMessage = string.Empty;
            bool serverExists = false;
            Dictionary<string, string> dicCloudDBInstance = new Dictionary<string, string>();
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
                    InstancesOfZoneJson = await GetVPCloudDBInstanceListAsync(a.zoneNo.ToString());
                    dicCloudDBInstance.Add(a.zoneNo.ToString(), InstancesOfZoneJson); // stirng dic
                    nlog.Warn(InstancesOfZoneJson);
                }

                foreach (var a in dicCloudDBInstance)
                {
                    getCloudMssqlInstanceList getCloudMssqlInstanceList = JsonConvert.DeserializeObject<getCloudMssqlInstanceList>(a.Value, settings);
                    List<CloudMssqlInstance> CloudMssqlInstanceList = getCloudMssqlInstanceList.getCloudMssqlInstanceListResponse.cloudMssqlInstanceList;
                    foreach (var b in CloudMssqlInstanceList)
                    {
                        nlog.Warn(b.cloudMssqlInstanceNo);
                        if (b.cloudMssqlInstanceNo.Equals(textCloudDbInstanceNo.Text.Trim()))
                        {
                            serverExists = true;
                            break;
                        }
                    }
                }
                if (serverExists)
                {
                    MessageBox.Show("DatabaseInfo Connection test was successful");
                    DatabaseInfoTested = true;
                }
                if (!serverExists)
                {
                    MessageBox.Show(string.Format("{0} : Server dose not exists", CallResult.Fail.ToString()));
                    DatabaseInfoTested = false;
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                MessageBox.Show(string.Format("{0} : {1}", CallResult.Fail.ToString(), ex.Message));
            }

            StatusUpdate(Status.Completed);
        }

        private async Task<string> GetCPCloudDBInstanceListAsync(string zoneNo)
        {
            nlog.Warn("GetCPCloudDBInstanceListAsync Started");
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();
                postParams.Add(new KeyValuePair<string, string>("dbKindCode", "MSSQL"));
                postParams.Add(new KeyValuePair<string, string>("zoneNo", zoneNo));
                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));

                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , @"/clouddb/v2/getCloudDBInstanceList"
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

        private async Task<string> GetVPCloudDBInstanceListAsync(string zoneNo)
        {
            nlog.Warn("GetVPCloudDBInstanceListAsync Started");
            string json = string.Empty;
            try
            {
                var postParams = new List<KeyValuePair<string, string>>();
                AsyncCall asyncCall = new AsyncCall();
                postParams.Add(new KeyValuePair<string, string>("responseFormatType", "json"));

                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLApiGateway) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , @"/vmssql/v2/getCloudMssqlInstanceList"
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
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

                Task<string> result = asyncCall.WebApiCall(
                    endpointUrl
                    , GetPostType.POST
                    , "/server/v2/getZoneList"
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
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ApiUrl);

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

        private void rbPlatformClicked(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Name == "rbClassicPublic")
            {
                Platform = "CP";
            }
            if (rb.Name == "rbVpcPublic")
            {
                //Platform = "VP";
                MessageBox.Show("From September 21, 2023, only the classic environment is supported.");
            }
            ZoneVariableChange();
        }

        private void ZoneVariableChange()
        {
            config.SetEnumValue(Category.Config, Key.Platform, Platform);
            switch (Platform)
            {
                case "CP":
                    Platform = "CP";
                    DefaultTestApi = config.GetEnumValue(Category.Config, Key.CPDefaultTestApi);
                    rbClassicPublic.Checked = true;
                    break;
                case "VP":
                    Platform = "VP";
                    DefaultTestApi = config.GetEnumValue(Category.Config, Key.VPDefaultTestApi);
                    rbVpcPublic.Checked = true;
                    break;
            }
            WriteConfig2TextBox();
        }

        string Platform = string.Empty;
        string DefaultTestApi = string.Empty;

        private bool BucketNameCheck(string bucketname)
        {
            Regex regex = new Regex(@"^[a-z][a-z0-9\-]{1,30}$");
            bool ismatch = regex.IsMatch(bucketname);
            if (!ismatch)
                return false;
            else
                return true; 
        }


        private async void buttonCreateBucket_Click(object sender, EventArgs e)
        {
            nlog.Warn("buttonCreateBucket_Click Started");

            if (!BucketNameCheck(textDefaultBucket.Text))
            {
                MessageBox.Show("Bucket names must start with an English lowercase letter and are limited to 30 characters.");
                return;
            }

            StatusUpdate(Status.Working);
            try
            {
                if (textObjectEndPoint.Text.ToUpper().StartsWith(@"HTTP://"))
                    textObjectEndPoint.Text = textObjectEndPoint.Text.Substring(7, textObjectEndPoint.Text.Length - 7);
                if (textObjectEndPoint.Text.ToUpper().StartsWith(@"HTTPS://"))
                    textObjectEndPoint.Text = textObjectEndPoint.Text.Substring(8, textObjectEndPoint.Text.Length - 8);
            }
            catch (Exception) { }
            bool ConnectionTestSuccess = false;
            try
            {
                ConfigSaveAllItem();
                string Message = await objectStorage.CreateBucketAsync(textDefaultBucket.Text);
                MessageBox.Show(Message);
                ConnectionTestSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                ConnectionTestSuccess = false;
            }

            if (
                    ConnectionTestSuccess
                    && System.Text.RegularExpressions.Regex.IsMatch
                    (
                        textObjectEndPoint.Text
                        , "ncloud"
                        , System.Text.RegularExpressions.RegexOptions.IgnoreCase
                    )
                )
            {
                textApiUrl.Text = @"ncloud.apigw.ntruss.com";
                textApiGatewayAccessKey.Text = textObjectAccessKey.Text;
                textApiGatewaySecretKey.Text = textObjectSecretKey.Text;
            }

            StatusUpdate(Status.Completed);
            nlog.Warn("buttonCreateBucket_Click Completed");
        }
    }
}
