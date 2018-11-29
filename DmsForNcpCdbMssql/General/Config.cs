using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using NLog;


namespace DMS
{

    public enum Category { Config, Upload, Download }
    public enum Key
    {
              ObjectEndPoint
            , UseSSLObjectStorage
            , ObjectAccessKey
            , ObjectSecretKey
            , ObjectBucket
            , ApiUrl
            , UseSSLApiGateway
            , DefaultTestApi
            , ApiGatewayAccessKey
            , ApiGatewaySecretKey
            , ApiGatewayKey
            , NewDatabaseName
            , StopAtTime
            , FilterString
            , LocalDir
            , CloudDbInstanceNo
            , InternalFolder
    }

    public enum CallResult { Success, Fail }

    public enum Status { Working, Completed }

    public enum GetPostType { GET, POST };
    class Config
    {
        
        private static Logger nlog = LogManager.GetCurrentClassLogger();

        public static Config Instance { get { return lazy.Value; } }
        private static readonly Lazy<Config> lazy =
            new Lazy<Config>(
                () => new Config()
                , LazyThreadSafetyMode.ExecutionAndPublication
                );


        private string appPath = string.Empty;
        private string configFile = string.Empty;
        string configurationFileFullName = string.Empty;
        public Dictionary<Tuple<Category, Key>, string> AppConfigurations;
        public object lockObject = new object(); 
        public string GetEnumValue(Category category, Key key)
        {
            string sReturn = string.Empty;
            try
            {
                sReturn = AppConfigurations[new Tuple<Category, Key>(category, key)];
            }
            catch
            {
                nlog.Error(string.Format("enum does not exists! {0}, {1}", category, key));
                sReturn = "enum does not exists!";
            }
            return sReturn;
        }

        public void SetEnumValue(Category category, Key key, string value)
        {
            AppConfigurations[new Tuple<Category, Key>(category, key)] = value;
        }
   
        public Config()
        {
            this.appPath = Application.StartupPath;
            this.configFile = "ConfigDms.txt";
            this.configurationFileFullName = Path.Combine(appPath, configFile);
            AppConfigurations = new Dictionary<Tuple<Category, Key>, string>();

            if (!File.Exists(Path.Combine(appPath, configFile + ".backup")))
                File.Copy(Path.Combine(appPath, configFile), Path.Combine(appPath, configFile + ".backup"));
             
            LoadConfigFromFile();
        }

        public void WriteConfigToFile()
        {
            lock (lockObject)
            {
                try
                {
                    File.Delete(configurationFileFullName);
                    using (StreamWriter file = new StreamWriter(configurationFileFullName))
                    {
                        foreach (var a in AppConfigurations)
                        {
                            file.WriteLine("{0}:::{1}:::{2}", a.Key.Item1, a.Key.Item2, a.Value);
                        }
                    }
                }
                catch (Exception e)
                {
                    nlog.Error(string.Format("{0}, {1}", e.Message, e.StackTrace));
                }
            }
        }

        private void LoadConfigFromFile()
        {
            string line = string.Empty;
            using (StreamReader file = new StreamReader(configurationFileFullName))
            {
                AppConfigurations.Clear();
                while ((line = file.ReadLine()) != null)
                {
                    string[] lineValues = line.Split(
                        new string[] { ":::" }
                        , StringSplitOptions.None
                        );

                    AppConfigurations.Add(
                    new Tuple<Category, Key>(
                        (Category)Enum.Parse(typeof(Category), lineValues[0])
                        , (Key)Enum.Parse(typeof(Key), lineValues[1])
                        )
                        , lineValues[2].ToString()
                    );
                }
            }
        }

        
    }
    
    public static class ControlHelpers
    {
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}
