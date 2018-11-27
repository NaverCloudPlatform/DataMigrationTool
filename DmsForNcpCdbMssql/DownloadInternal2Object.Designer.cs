namespace DMS
{
    partial class DownloadInternal2Object
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackupStorageReload = new System.Windows.Forms.Button();
            this.buttonBackupDownload = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backupLastWriteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupFilesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvObjectStorage = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonObjectStorageReload = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonObjectDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInternalStorage = new System.Windows.Forms.DataGridView();
            this.objectSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textFilterString = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxDbBackupDownload = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectStorage)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalStorage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxDbBackupDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackupStorageReload
            // 
            this.buttonBackupStorageReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonBackupStorageReload.FlatAppearance.BorderSize = 0;
            this.buttonBackupStorageReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackupStorageReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupStorageReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupStorageReload.ForeColor = System.Drawing.Color.White;
            this.buttonBackupStorageReload.Location = new System.Drawing.Point(139, 3);
            this.buttonBackupStorageReload.Name = "buttonBackupStorageReload";
            this.buttonBackupStorageReload.Size = new System.Drawing.Size(137, 23);
            this.buttonBackupStorageReload.TabIndex = 32;
            this.buttonBackupStorageReload.Text = "Reload";
            this.buttonBackupStorageReload.UseVisualStyleBackColor = false;
            this.buttonBackupStorageReload.Click += new System.EventHandler(this.buttonBackupStorageReload_Click);
            // 
            // buttonBackupDownload
            // 
            this.buttonBackupDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonBackupDownload.FlatAppearance.BorderSize = 0;
            this.buttonBackupDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackupDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupDownload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupDownload.ForeColor = System.Drawing.Color.White;
            this.buttonBackupDownload.Location = new System.Drawing.Point(1, 3);
            this.buttonBackupDownload.Name = "buttonBackupDownload";
            this.buttonBackupDownload.Size = new System.Drawing.Size(137, 23);
            this.buttonBackupDownload.TabIndex = 30;
            this.buttonBackupDownload.Text = "Download";
            this.buttonBackupDownload.UseVisualStyleBackColor = false;
            this.buttonBackupDownload.Click += new System.EventHandler(this.buttonBackupDownload_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonBackupStorageReload);
            this.panel3.Controls.Add(this.buttonBackupDownload);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 30);
            this.panel3.TabIndex = 18;
            // 
            // backupLastWriteTime
            // 
            this.backupLastWriteTime.HeaderText = "LastWriteTime";
            this.backupLastWriteTime.Name = "backupLastWriteTime";
            // 
            // backupFilesize
            // 
            this.backupFilesize.HeaderText = "FileSize";
            this.backupFilesize.Name = "backupFilesize";
            // 
            // backupFilename
            // 
            this.backupFilename.FillWeight = 170F;
            this.backupFilename.HeaderText = "Filename";
            this.backupFilename.Name = "backupFilename";
            this.backupFilename.Width = 170;
            // 
            // backupSelect
            // 
            this.backupSelect.FillWeight = 50F;
            this.backupSelect.HeaderText = "Select";
            this.backupSelect.Name = "backupSelect";
            this.backupSelect.Width = 50;
            // 
            // dgvObjectStorage
            // 
            this.dgvObjectStorage.AllowUserToAddRows = false;
            this.dgvObjectStorage.AllowUserToOrderColumns = true;
            this.dgvObjectStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.backupSelect,
            this.backupFilename,
            this.backupFilesize,
            this.backupLastWriteTime});
            this.dgvObjectStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectStorage.Location = new System.Drawing.Point(423, 25);
            this.dgvObjectStorage.Name = "dgvObjectStorage";
            this.dgvObjectStorage.Size = new System.Drawing.Size(396, 444);
            this.dgvObjectStorage.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F);
            this.label8.Location = new System.Drawing.Point(530, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "[Object Storage Filelist]";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F);
            this.label10.Location = new System.Drawing.Point(112, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "[Internal Storage Filelist]";
            // 
            // buttonObjectStorageReload
            // 
            this.buttonObjectStorageReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonObjectStorageReload.FlatAppearance.BorderSize = 0;
            this.buttonObjectStorageReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonObjectStorageReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectStorageReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectStorageReload.ForeColor = System.Drawing.Color.White;
            this.buttonObjectStorageReload.Location = new System.Drawing.Point(140, 3);
            this.buttonObjectStorageReload.Name = "buttonObjectStorageReload";
            this.buttonObjectStorageReload.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectStorageReload.TabIndex = 33;
            this.buttonObjectStorageReload.Text = "Reload";
            this.buttonObjectStorageReload.UseVisualStyleBackColor = false;
            this.buttonObjectStorageReload.Click += new System.EventHandler(this.buttonObjectStorageReload_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonObjectDelete);
            this.panel4.Controls.Add(this.buttonObjectStorageReload);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(423, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 30);
            this.panel4.TabIndex = 19;
            // 
            // buttonObjectDelete
            // 
            this.buttonObjectDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonObjectDelete.FlatAppearance.BorderSize = 0;
            this.buttonObjectDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonObjectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectDelete.ForeColor = System.Drawing.Color.White;
            this.buttonObjectDelete.Location = new System.Drawing.Point(2, 3);
            this.buttonObjectDelete.Name = "buttonObjectDelete";
            this.buttonObjectDelete.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectDelete.TabIndex = 34;
            this.buttonObjectDelete.Text = "Delete";
            this.buttonObjectDelete.UseVisualStyleBackColor = false;
            this.buttonObjectDelete.Click += new System.EventHandler(this.buttonObjectDelete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvInternalStorage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvObjectStorage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(822, 508);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvInternalStorage
            // 
            this.dgvInternalStorage.AllowUserToAddRows = false;
            this.dgvInternalStorage.AllowUserToOrderColumns = true;
            this.dgvInternalStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternalStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectSelect,
            this.fileName,
            this.fileType,
            this.backupEndTime});
            this.dgvInternalStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternalStorage.Location = new System.Drawing.Point(3, 25);
            this.dgvInternalStorage.Name = "dgvInternalStorage";
            this.dgvInternalStorage.Size = new System.Drawing.Size(414, 444);
            this.dgvInternalStorage.TabIndex = 15;
            // 
            // objectSelect
            // 
            this.objectSelect.FillWeight = 50F;
            this.objectSelect.HeaderText = "Select";
            this.objectSelect.Name = "objectSelect";
            this.objectSelect.Width = 50;
            // 
            // fileName
            // 
            this.fileName.FillWeight = 170F;
            this.fileName.HeaderText = "Filename";
            this.fileName.Name = "fileName";
            this.fileName.Width = 170;
            // 
            // fileType
            // 
            this.fileType.HeaderText = "FileType";
            this.fileType.Name = "fileType";
            // 
            // backupEndTime
            // 
            this.backupEndTime.HeaderText = "backupEndTime";
            this.backupEndTime.Name = "backupEndTime";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 508);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "Filter Keyword";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(60)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(671, 63);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textFilterString
            // 
            this.textFilterString.Location = new System.Drawing.Point(255, 30);
            this.textFilterString.Name = "textFilterString";
            this.textFilterString.Size = new System.Drawing.Size(553, 22);
            this.textFilterString.TabIndex = 22;
            this.textFilterString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyword_EnterKeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxDbBackupDownload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 120);
            this.panel1.TabIndex = 4;
            // 
            // groupBoxDbBackupDownload
            // 
            this.groupBoxDbBackupDownload.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDbBackupDownload.Controls.Add(this.label4);
            this.groupBoxDbBackupDownload.Controls.Add(this.buttonSave);
            this.groupBoxDbBackupDownload.Controls.Add(this.textFilterString);
            this.groupBoxDbBackupDownload.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxDbBackupDownload.Location = new System.Drawing.Point(3, 15);
            this.groupBoxDbBackupDownload.Name = "groupBoxDbBackupDownload";
            this.groupBoxDbBackupDownload.Size = new System.Drawing.Size(816, 99);
            this.groupBoxDbBackupDownload.TabIndex = 0;
            this.groupBoxDbBackupDownload.TabStop = false;
            this.groupBoxDbBackupDownload.Text = "[Download Internal 2 Object]";
            // 
            // DownloadInternal2Object
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "DownloadInternal2Object";
            this.Size = new System.Drawing.Size(822, 628);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectStorage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalStorage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxDbBackupDownload.ResumeLayout(false);
            this.groupBoxDbBackupDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackupStorageReload;
        private System.Windows.Forms.Button buttonBackupDownload;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupLastWriteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupFilesize;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupFilename;
        private System.Windows.Forms.DataGridViewCheckBoxColumn backupSelect;
        private System.Windows.Forms.DataGridView dgvObjectStorage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonObjectStorageReload;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvInternalStorage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textFilterString;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxDbBackupDownload;
        private System.Windows.Forms.Button buttonObjectDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn objectSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupEndTime;
    }
}
