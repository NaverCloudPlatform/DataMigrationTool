using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography;
using NLog;

namespace DMS
{

    class Auth
    {
        private static readonly Lazy<Auth> lazy =
            new Lazy<Auth>(() => new Auth(), LazyThreadSafetyMode.ExecutionAndPublication);

        Config config;

        public static Auth Instance { get { return lazy.Value; } }

        Auth()
        {
            config = Config.Instance;
        }

        public string makeSignature(GetPostType calltype, string action, ref string stringtimestamp, string accessKey, string secureKey/*, string apiKey*/)
        {
           
            if (string.IsNullOrEmpty(action))
                return "parameter error";

            long timestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            string space = " ";
            string newLine = "\n";
            string method = calltype == GetPostType.POST ? "POST" : "GET";
            stringtimestamp = timestamp.ToString();
            
            string message = new StringBuilder()
                    .Append(method)
                    .Append(space)
                    .Append(action)
                    .Append(newLine)
                    .Append(stringtimestamp)
                    .Append(newLine)
                    //.Append(apiKey)
                    //.Append(newLine)
                    .Append(accessKey)
                    .ToString();

            byte[] secretKey = Encoding.UTF8.GetBytes(secureKey);
            HMACSHA256 hmac = new HMACSHA256(secretKey);
            hmac.Initialize();
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            byte[] rawHmac = hmac.ComputeHash(bytes);

            return Convert.ToBase64String(rawHmac);
        }
    }
}
