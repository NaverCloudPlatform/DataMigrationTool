using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace DMS
{

    class AsyncCall
    {
        private static Logger nlog = LogManager.GetCurrentClassLogger();

        public async Task<string> WebApiCall(string url, GetPostType calltype, string action)
        {
            return await WebApiCall(url, calltype, action, "");
        }

        public async Task<string> WebApiCall(string Url, GetPostType calltype, string action, List<KeyValuePair<string, string>> parameters)
        {
            Config config = Config.Instance;
            string accessKey = config.GetEnumValue(Category.Config, Key.ApiGatewayAccessKey);
            string secureKey = config.GetEnumValue(Category.Config, Key.ApiGatewaySecretKey);
            string apiKey = config.GetEnumValue(Category.Config, Key.ApiGatewayKey);
            string responseString = string.Empty;
            try
            {
                foreach (var a in parameters)
                {
                    nlog.Warn(string.Format("key : {0}, value :{1}", a.Key, a.Value));
                }

                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMilliseconds(30000);
                    string timestamp = string.Empty;
                    string sig = Auth.Instance.makeSignature(calltype, action, ref timestamp, accessKey, secureKey, apiKey);
                    string url = Url + action;

                    client.DefaultRequestHeaders.Add("x-ncp-apigw-timestamp", timestamp);
                    client.DefaultRequestHeaders.Add("x-ncp-apigw-api-key", apiKey);
                    client.DefaultRequestHeaders.Add("x-ncp-iam-access-key", accessKey);
                    client.DefaultRequestHeaders.Add("x-ncp-apigw-signature-v1", sig);

                    if (calltype == GetPostType.POST)
                    {
                        var content = new FormUrlEncodedContent(parameters);
                        var response = await client.PostAsync(url, content);
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        var response = await client.GetAsync(url);
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                responseString = ex.Message;
                nlog.Error(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
            }
            return responseString;
        }

        public async Task<string> WebApiCall(string Url, GetPostType calltype, string action, string parameters)
        {
            Config config = Config.Instance;
            string accessKey = config.GetEnumValue(Category.Config, Key.ApiGatewayAccessKey);
            string secureKey = config.GetEnumValue(Category.Config, Key.ApiGatewaySecretKey);
            string apiKey = config.GetEnumValue(Category.Config, Key.ApiGatewayKey);
            string responseString = string.Empty;

            nlog.Warn(string.Format("parameters: {0}", parameters));

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMilliseconds(5000);
                    string timestamp = string.Empty;
                    string sig = Auth.Instance.makeSignature(calltype, action, ref timestamp, accessKey, secureKey, apiKey);
                    string url = Url + action;

                    client.DefaultRequestHeaders.Add("x-ncp-apigw-timestamp", timestamp);
                    client.DefaultRequestHeaders.Add("x-ncp-apigw-api-key", apiKey);
                    client.DefaultRequestHeaders.Add("x-ncp-iam-access-key", accessKey);
                    client.DefaultRequestHeaders.Add("x-ncp-apigw-signature-v1", sig);

                    if (calltype == GetPostType.POST)
                    {
                        var content = new StringContent(parameters, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync(url, content);
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        var response = await client.GetAsync(url);
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("{0}, {1}", e.Message, e.StackTrace));
            }
            return responseString;
        }
    }
}
