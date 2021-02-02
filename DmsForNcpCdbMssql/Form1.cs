using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using System.Diagnostics; 

namespace DMS
{
    public partial class Form1 : Form
    {
        
        Config config;
        private static Logger nlog = LogManager.GetCurrentClassLogger();
        Dictionary<Tuple<string, string, string>, PerformanceCounter> counters =
            new Dictionary<Tuple<string, string, string>, PerformanceCounter>();

        
        public Form1()
        {
            InitializeComponent();
            nlog.Warn("DMS App Started");
            panelLeft.Height = buttonConfiguration.Height;
            panelLeft.Top = buttonConfiguration.Top;
            clearSubjectRegular();
            buttonConfiguration.ForeColor = Color.FromArgb(90, 188, 211);
            buttonConfiguration.BackColor = Color.FromArgb(64, 64, 64);

            config = Config.Instance;
            
            GenerateCounter();
            labelVersion.Text = string.Format("DMS Version : {0}", Application.ProductVersion);
            timer.Start();
        }

        private void clearSubjectRegular()
        {
            buttonConfiguration.ForeColor = Color.FromArgb(255, 255, 255);
            buttonObjectStorageUpload.ForeColor = Color.FromArgb(255, 255, 255);
            buttonBackupStorageUpload.ForeColor = Color.FromArgb(255, 255, 255);
            buttonRestoreDatabase.ForeColor = Color.FromArgb(255, 255, 255);
            buttonDbBackupDownload.ForeColor = Color.FromArgb(255, 255, 255);
            buttonDownloadObject2Local.ForeColor = Color.FromArgb(255, 255, 255);
            buttonViewLog.ForeColor = Color.FromArgb(255, 255, 255);

            buttonConfiguration.BackColor = Color.FromArgb(37, 37, 38);
            buttonObjectStorageUpload.BackColor = Color.FromArgb(37, 37, 38);
            buttonBackupStorageUpload.BackColor = Color.FromArgb(37, 37, 38);
            buttonRestoreDatabase.BackColor = Color.FromArgb(37, 37, 38);
            buttonDbBackupDownload.BackColor = Color.FromArgb(37, 37, 38);
            buttonDownloadObject2Local.BackColor = Color.FromArgb(37, 37, 38);
            buttonViewLog.BackColor = Color.FromArgb(37, 37, 38);
        }


        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationLoad();
        }

        private void ConfigurationLoad()
        {
            RemoveAllUc();

            if (!panelMain.Controls.Contains(Configuration.Instance))
            {
                panelMain.Controls.Add(Configuration.Instance);
                Configuration.Instance.Dock = DockStyle.Fill;
            }

            Configuration.Instance.BringToFront();
            Configuration.Instance.StatusChangeEvent += UpdateBottomStatusText;

            panelLeft.Height = buttonConfiguration.Height;
            panelLeft.Top = buttonConfiguration.Top;
            Configuration.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonConfiguration.ForeColor = Color.FromArgb(90, 188, 211);
            buttonConfiguration.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void RemoveAllUc()
        {
            if (panelMain.Controls.Contains(Configuration.Instance))
                panelMain.Controls.Remove(Configuration.Instance);
            if (panelMain.Controls.Contains(UploadLocal2Object.Instance))
                panelMain.Controls.Remove(UploadLocal2Object.Instance);
            if (panelMain.Controls.Contains(UploadObject2Internal.Instance))
                panelMain.Controls.Remove(UploadObject2Internal.Instance);
            if (panelMain.Controls.Contains(RestoreDatabase.Instance))
                panelMain.Controls.Remove(RestoreDatabase.Instance);
            if (panelMain.Controls.Contains(DownloadInternal2Object.Instance))
                panelMain.Controls.Remove(DownloadInternal2Object.Instance);
            if (panelMain.Controls.Contains(DownloadObject2Local.Instance))
                panelMain.Controls.Remove(DownloadObject2Local.Instance);
            if (panelMain.Controls.Contains(ViewLog.Instance))
                panelMain.Controls.Remove(ViewLog.Instance);
        }


        private void buttonUploadLocal2Object_Click(object sender, EventArgs e)
        {

            RemoveAllUc();

            if (!panelMain.Controls.Contains(UploadLocal2Object.Instance))
            {
                panelMain.Controls.Add(UploadLocal2Object.Instance);
                UploadLocal2Object.Instance.Dock = DockStyle.Fill;
            }

            UploadLocal2Object.Instance.BringToFront();
            UploadLocal2Object.Instance.StatusChangeEvent += UpdateBottomStatusText;

            panelLeft.Height = buttonObjectStorageUpload.Height;
            panelLeft.Top = buttonObjectStorageUpload.Top;
            UploadLocal2Object.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonObjectStorageUpload.ForeColor = Color.FromArgb(90, 188, 211);
            buttonObjectStorageUpload.BackColor = Color.FromArgb(64, 64, 64);
            UploadLocal2Object.Instance.loadLocalDriveFileList();
            UploadLocal2Object.Instance.ObjectStorageFileList();
        }

        private void buttonUploadObject2Internal_Click(object sender, EventArgs e)
        {

            RemoveAllUc();

            if (!panelMain.Controls.Contains(UploadObject2Internal.Instance))
            {
                panelMain.Controls.Add(UploadObject2Internal.Instance);
                UploadObject2Internal.Instance.Dock = DockStyle.Fill;
            }

            UploadObject2Internal.Instance.BringToFront();
            UploadObject2Internal.Instance.StatusChangeEvent += UpdateBottomStatusText;

            panelLeft.Height = buttonBackupStorageUpload.Height;
            panelLeft.Top = buttonBackupStorageUpload.Top;
            UploadObject2Internal.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonBackupStorageUpload.ForeColor = Color.FromArgb(90, 188, 211);
            buttonBackupStorageUpload.BackColor = Color.FromArgb(64, 64, 64);
            UploadObject2Internal.Instance.InternalStorageFileList();
            UploadObject2Internal.Instance.ObjectStorageFileList();
        }

        private void buttonRestoreDatabase_Click(object sender, EventArgs e)
        {
            RemoveAllUc();

            if (!panelMain.Controls.Contains(RestoreDatabase.Instance))
            {
                panelMain.Controls.Add(RestoreDatabase.Instance);
                RestoreDatabase.Instance.Dock = DockStyle.Fill;
            }

            RestoreDatabase.Instance.BringToFront();
            RestoreDatabase.Instance.StatusChangeEvent += UpdateBottomStatusText;

            panelLeft.Height = buttonRestoreDatabase.Height;
            panelLeft.Top = buttonRestoreDatabase.Top;
            RestoreDatabase.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonRestoreDatabase.ForeColor = Color.FromArgb(90, 188, 211);
            buttonRestoreDatabase.BackColor = Color.FromArgb(64, 64, 64);
            RestoreDatabase.Instance.BackupStorageFileList();
        }

        private void buttonDownloadInternal2Object_Click(object sender, EventArgs e)
        {
            RemoveAllUc();

            if (!panelMain.Controls.Contains(DownloadInternal2Object.Instance))
            {
                panelMain.Controls.Add(DownloadInternal2Object.Instance);
                DownloadInternal2Object.Instance.Dock = DockStyle.Fill;
            }

            DownloadInternal2Object.Instance.BringToFront();
            DownloadInternal2Object.Instance.StatusChangeEvent += UpdateBottomStatusText;
            
            panelLeft.Height = buttonDbBackupDownload.Height;
            panelLeft.Top = buttonDbBackupDownload.Top;
            DownloadInternal2Object.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonDbBackupDownload.ForeColor = Color.FromArgb(90, 188, 211);
            buttonDbBackupDownload.BackColor = Color.FromArgb(64, 64, 64);
            DownloadInternal2Object.Instance.InternalStorageFileList();
            DownloadInternal2Object.Instance.ObjectStorageFileList();
        }

        private void buttonDownloadObject2Local_Click(object sender, EventArgs e)
        {
            RemoveAllUc();

            if (!panelMain.Controls.Contains(DownloadObject2Local.Instance))
            {
                panelMain.Controls.Add(DownloadObject2Local.Instance);
                DownloadObject2Local.Instance.Dock = DockStyle.Fill;
            }

            DownloadObject2Local.Instance.BringToFront();
            DownloadObject2Local.Instance.StatusChangeEvent += UpdateBottomStatusText;

            panelLeft.Height = buttonDownloadObject2Local.Height;
            panelLeft.Top = buttonDownloadObject2Local.Top;
            DownloadObject2Local.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonDownloadObject2Local.ForeColor = Color.FromArgb(90, 188, 211);
            buttonDownloadObject2Local.BackColor = Color.FromArgb(64, 64, 64);
            DownloadObject2Local.Instance.loadLocalDriveFileList();
            DownloadObject2Local.Instance.ObjectStorageFileList();
        }

        private void buttonViewLog_Click(object sender, EventArgs e)
        {
            RemoveAllUc();

            if (!panelMain.Controls.Contains(ViewLog.Instance))
            {
                panelMain.Controls.Add(ViewLog.Instance);
                ViewLog.Instance.Dock = DockStyle.Fill;
            }

            ViewLog.Instance.BringToFront();
            ViewLog.Instance.StatusChangeEvent += UpdateBottomStatusText;

            panelLeft.Height = buttonViewLog.Height;
            panelLeft.Top = buttonViewLog.Top;
            ViewLog.Instance.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonViewLog.Font = new Font(buttonViewLog.Font, FontStyle.Bold);
            buttonViewLog.ForeColor = Color.FromArgb(90, 188, 211);
            buttonViewLog.BackColor = Color.FromArgb(64, 64, 64);
            ViewLog.Instance.ReadLog();
        }

        private void UpdateBottomStatusText(object sender, StatusEventArgs e)
        {
            StatusUpdate(e.status);
        }

        private void StatusUpdate(Status value)
        {
            labelStatusText.InvokeIfRequired(s => {
                s.Text = value.ToString();
                s.Invalidate();
                s.Update();
                s.Refresh();
                Application.DoEvents();
            });
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                labelCpu.Text = string.Format(@"{0} %", GetSumCounter("Processor").ToString());
                labelMemory.Text = string.Format(@"{0} % InUse", GetSumCounter("Memory").ToString());
                labelNetworks.Text = string.Format("{0} MBytes", (GetSumCounter("Network Interface") / 1000 / 1000).ToString());
            }
            catch (Exception)
            { }
        }

        private void GenerateCounter()
        {   
            counters.Add(new Tuple<string, string, string>("Processor", "% Processor Time", "_Total")
                    , new PerformanceCounter("Processor", "% Processor Time", "_Total"));

            counters.Add(new Tuple<string, string, string>("Memory", "% Committed Bytes In Use", "")
                    , new PerformanceCounter("Memory", "% Committed Bytes In Use"));

            PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            foreach (var instanceName in performanceCounterCategory.GetInstanceNames())
            {
                // category counter instance 
                counters.Add(new Tuple<string, string, string>("Network Interface", "Bytes Total/sec", instanceName)
                    , new PerformanceCounter("Network Interface", "Bytes Total/sec", instanceName));
            }
        }

        private int GetSumCounter (string Category)
        {
            float instanceValue = 0;
            try
            {
                foreach (var a in counters)
                {
                    if (a.Key.Item1 == Category)
                        instanceValue = instanceValue + a.Value.NextValue();
                }
            }
            catch (Exception) { }
            return (int)instanceValue;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //configuration.WriteConfig2TextBox();
            ConfigurationLoad();
        }
    }
}
