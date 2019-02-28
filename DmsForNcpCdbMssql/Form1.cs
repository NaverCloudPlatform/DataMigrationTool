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
            configuration.BringToFront();
            panelLeft.Height = buttonConfiguration.Height;
            panelLeft.Top = buttonConfiguration.Top;
            clearSubjectRegular();
            buttonConfiguration.ForeColor = Color.FromArgb(90, 188, 211);
            buttonConfiguration.BackColor = Color.FromArgb(64, 64, 64);

            config = Config.Instance;
            configuration.StatusChangeEvent += UpdateBottomStatusText;
            uploadLocal2Object.StatusChangeEvent += UpdateBottomStatusText;
            uploadObject2Internal.StatusChangeEvent += UpdateBottomStatusText;
            restoreDatabase.StatusChangeEvent += UpdateBottomStatusText;
            viewLog.StatusChangeEvent += UpdateBottomStatusText;
            downloadInternal2Object.StatusChangeEvent += UpdateBottomStatusText;
            downloadObject2Local.StatusChangeEvent += UpdateBottomStatusText;
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
            configuration.BringToFront();
            panelLeft.Height = buttonConfiguration.Height;
            panelLeft.Top = buttonConfiguration.Top;
            //configuration.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonConfiguration.ForeColor = Color.FromArgb(90, 188, 211);
            buttonConfiguration.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void buttonUploadLocal2Object_Click(object sender, EventArgs e)
        {
            uploadLocal2Object.BringToFront();
            panelLeft.Height = buttonObjectStorageUpload.Height;
            panelLeft.Top = buttonObjectStorageUpload.Top;
            uploadLocal2Object.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonObjectStorageUpload.ForeColor = Color.FromArgb(90, 188, 211);
            buttonObjectStorageUpload.BackColor = Color.FromArgb(64, 64, 64);
            uploadLocal2Object.loadLocalDriveFileList();
            uploadLocal2Object.ObjectStorageFileList();
        }

        private void buttonUploadObject2Internal_Click(object sender, EventArgs e)
        {
            uploadObject2Internal.BringToFront();
            panelLeft.Height = buttonBackupStorageUpload.Height;
            panelLeft.Top = buttonBackupStorageUpload.Top;
            uploadObject2Internal.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonBackupStorageUpload.ForeColor = Color.FromArgb(90, 188, 211);
            buttonBackupStorageUpload.BackColor = Color.FromArgb(64, 64, 64);
            uploadObject2Internal.InternalStorageFileList();
            uploadObject2Internal.ObjectStorageFileList();
        }

        private void buttonRestoreDatabase_Click(object sender, EventArgs e)
        {
            restoreDatabase.BringToFront();
            panelLeft.Height = buttonRestoreDatabase.Height;
            panelLeft.Top = buttonRestoreDatabase.Top;
            restoreDatabase.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonRestoreDatabase.ForeColor = Color.FromArgb(90, 188, 211);
            buttonRestoreDatabase.BackColor = Color.FromArgb(64, 64, 64);
            restoreDatabase.BackupStorageFileList();
        }
        
        private void buttonDownloadInternal2Object_Click(object sender, EventArgs e)
        {
            downloadInternal2Object.BringToFront();
            panelLeft.Height = buttonDbBackupDownload.Height;
            panelLeft.Top = buttonDbBackupDownload.Top;
            downloadInternal2Object.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonDbBackupDownload.ForeColor = Color.FromArgb(90, 188, 211);
            buttonDbBackupDownload.BackColor = Color.FromArgb(64, 64, 64);
            downloadInternal2Object.InternalStorageFileList();
            downloadInternal2Object.ObjectStorageFileList();
        }

        private void buttonDownloadObject2Local_Click(object sender, EventArgs e)
        {
            downloadObject2Local.BringToFront();
            panelLeft.Height = buttonDownloadObject2Local.Height;
            panelLeft.Top = buttonDownloadObject2Local.Top;
            downloadObject2Local.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonDownloadObject2Local.ForeColor = Color.FromArgb(90, 188, 211);
            buttonDownloadObject2Local.BackColor = Color.FromArgb(64, 64, 64);
            downloadObject2Local.loadLocalDriveFileList();
            downloadObject2Local.ObjectStorageFileList();
        }

        private void buttonViewLog_Click(object sender, EventArgs e)
        {
            viewLog.BringToFront();
            panelLeft.Height = buttonViewLog.Height;
            panelLeft.Top = buttonViewLog.Top;
            viewLog.WriteConfig2TextBox();
            clearSubjectRegular();
            buttonViewLog.Font = new Font(buttonViewLog.Font, FontStyle.Bold);
            buttonViewLog.ForeColor = Color.FromArgb(90, 188, 211);
            buttonViewLog.BackColor = Color.FromArgb(64, 64, 64);
            viewLog.ReadLog();
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
            configuration.WriteConfig2TextBox();

        }
    }
}
