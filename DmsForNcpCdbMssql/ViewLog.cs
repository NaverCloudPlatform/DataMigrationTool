using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NLog;
using System.Threading;

namespace DMS
{
    public partial class ViewLog : UserControl
    {
        private static readonly Lazy<ViewLog> lazy =
            new Lazy<ViewLog>(() => new ViewLog(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static ViewLog Instance { get { return lazy.Value; } }

        Config config;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        public event EventHandler<StatusEventArgs> StatusChangeEvent;
        private bool workViewLog = false; 
        private ViewLog()
        {
            InitializeComponent();
            config = Config.Instance;
            WriteConfig2TextBox();
        }
        
        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (workViewLog) return; 
            ReadLog();
        }

        public void WriteConfig2TextBox()
        {
            textBoxLogFileName.Text = System.DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            textBoxTailRowCounts.Text = "30";
        }


        void Keyword_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (workViewLog)
                    return; 
                ReadLog();
            }
        }

        public async void ReadLog()
        {
            workViewLog = true; 
            StatusUpdate(Status.Working);
            try
            {
                int tailLogCount = 0;
                if (!this.IsHandleCreated) CreateHandle();
                await Task.Run(() =>
                {
                    string logFileFullName = Path.Combine(Application.StartupPath, "log", textBoxLogFileName.Text);

                    tailLogCount = int.Parse(textBoxTailRowCounts.Text.Trim());
                    listBoxLog.InvokeIfRequired(s => {
                        s.Items.Clear();
                        s.HorizontalScrollbar = true;
                    });
                    
                    if (File.Exists(logFileFullName))
                    {
                        try
                        {
                            using (ReverseTextReader reverseTextReader = new ReverseTextReader(logFileFullName))
                            {
                                string line;
                                for (int i = 0; i < tailLogCount; i++)
                                {
                                    line = reverseTextReader.ReadLine();
                                    if (line != null)
                                        listBoxLog.InvokeIfRequired(s => {
                                            listBoxLog.Items.Add(line);
                                        });
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        nlog.Error(string.Format("log file not found ! : {0}", logFileFullName));
                    }
                });
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("{0},{1}", ex.Message, ex.StackTrace));
                workViewLog = false;
            }

            StatusUpdate(Status.Completed);
            workViewLog = false;
        }

        private void StatusUpdate(Status status)
        {
            StatusChangeEvent?.Invoke(this, new StatusEventArgs(status));
        }
    }
}
