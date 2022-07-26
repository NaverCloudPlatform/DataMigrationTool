namespace DMS
{
    partial class UploadObject2InternalVP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textInternalFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textFilterString = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBackupReload = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvObjectStorage = new System.Windows.Forms.DataGridView();
            this.objectSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.objectFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInternalStorage = new System.Windows.Forms.DataGridView();
            this.backupSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.backupFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupFilesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupLastWriteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonObjectReload = new System.Windows.Forms.Button();
            this.buttonObjectDelete = new System.Windows.Forms.Button();
            this.buttonObjectUpload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalStorage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 120);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textInternalFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textFilterString);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Upload Object 2 Internal VP]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "Change Internal Storage Folder";
            // 
            // textInternalFolder
            // 
            this.textInternalFolder.Location = new System.Drawing.Point(255, 65);
            this.textInternalFolder.Name = "textInternalFolder";
            this.textInternalFolder.Size = new System.Drawing.Size(363, 22);
            this.textInternalFolder.TabIndex = 27;
            this.textInternalFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyword_EnterKeyDown);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 508);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvObjectStorage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvInternalStorage, 1, 1);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonBackupReload);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(423, 475);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 30);
            this.panel4.TabIndex = 19;
            // 
            // buttonBackupReload
            // 
            this.buttonBackupReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonBackupReload.FlatAppearance.BorderSize = 0;
            this.buttonBackupReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackupReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupReload.ForeColor = System.Drawing.Color.White;
            this.buttonBackupReload.Location = new System.Drawing.Point(1, 3);
            this.buttonBackupReload.Name = "buttonBackupReload";
            this.buttonBackupReload.Size = new System.Drawing.Size(137, 23);
            this.buttonBackupReload.TabIndex = 33;
            this.buttonBackupReload.Text = "Reload";
            this.buttonBackupReload.UseVisualStyleBackColor = false;
            this.buttonBackupReload.Click += new System.EventHandler(this.buttonInternalReload_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F);
            this.label8.Location = new System.Drawing.Point(523, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "[Internal Storage Filelist]";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F);
            this.label10.Location = new System.Drawing.Point(119, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "[Object Storage Filelist]";
            // 
            // dgvObjectStorage
            // 
            this.dgvObjectStorage.AllowUserToAddRows = false;
            this.dgvObjectStorage.AllowUserToOrderColumns = true;
            this.dgvObjectStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectSelect,
            this.objectFilename,
            this.objectFileSize,
            this.objectDateTime});
            this.dgvObjectStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectStorage.Location = new System.Drawing.Point(3, 25);
            this.dgvObjectStorage.Name = "dgvObjectStorage";
            this.dgvObjectStorage.Size = new System.Drawing.Size(414, 444);
            this.dgvObjectStorage.TabIndex = 15;
            // 
            // objectSelect
            // 
            this.objectSelect.FillWeight = 50F;
            this.objectSelect.HeaderText = "Select";
            this.objectSelect.Name = "objectSelect";
            this.objectSelect.Width = 50;
            // 
            // objectFilename
            // 
            this.objectFilename.FillWeight = 170F;
            this.objectFilename.HeaderText = "Filename";
            this.objectFilename.Name = "objectFilename";
            this.objectFilename.Width = 170;
            // 
            // objectFileSize
            // 
            this.objectFileSize.HeaderText = "FileSize";
            this.objectFileSize.Name = "objectFileSize";
            // 
            // objectDateTime
            // 
            this.objectDateTime.HeaderText = "LastWriteTime";
            this.objectDateTime.Name = "objectDateTime";
            // 
            // dgvInternalStorage
            // 
            this.dgvInternalStorage.AllowUserToAddRows = false;
            this.dgvInternalStorage.AllowUserToOrderColumns = true;
            this.dgvInternalStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternalStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.backupSelect,
            this.backupFilename,
            this.backupFilesize,
            this.backupLastWriteTime});
            this.dgvInternalStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternalStorage.Location = new System.Drawing.Point(423, 25);
            this.dgvInternalStorage.Name = "dgvInternalStorage";
            this.dgvInternalStorage.Size = new System.Drawing.Size(396, 444);
            this.dgvInternalStorage.TabIndex = 17;
            // 
            // backupSelect
            // 
            this.backupSelect.FillWeight = 50F;
            this.backupSelect.HeaderText = "Select";
            this.backupSelect.Name = "backupSelect";
            this.backupSelect.Width = 50;
            // 
            // backupFilename
            // 
            this.backupFilename.FillWeight = 170F;
            this.backupFilename.HeaderText = "Filename";
            this.backupFilename.Name = "backupFilename";
            this.backupFilename.Width = 170;
            // 
            // backupFilesize
            // 
            this.backupFilesize.HeaderText = "FileSize";
            this.backupFilesize.Name = "backupFilesize";
            // 
            // backupLastWriteTime
            // 
            this.backupLastWriteTime.HeaderText = "LastWriteTime";
            this.backupLastWriteTime.Name = "backupLastWriteTime";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonObjectReload);
            this.panel3.Controls.Add(this.buttonObjectDelete);
            this.panel3.Controls.Add(this.buttonObjectUpload);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 30);
            this.panel3.TabIndex = 18;
            // 
            // buttonObjectReload
            // 
            this.buttonObjectReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonObjectReload.FlatAppearance.BorderSize = 0;
            this.buttonObjectReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonObjectReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectReload.ForeColor = System.Drawing.Color.White;
            this.buttonObjectReload.Location = new System.Drawing.Point(277, 3);
            this.buttonObjectReload.Name = "buttonObjectReload";
            this.buttonObjectReload.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectReload.TabIndex = 32;
            this.buttonObjectReload.Text = "Reload";
            this.buttonObjectReload.UseVisualStyleBackColor = false;
            this.buttonObjectReload.Click += new System.EventHandler(this.buttonObjectReload_Click);
            // 
            // buttonObjectDelete
            // 
            this.buttonObjectDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonObjectDelete.FlatAppearance.BorderSize = 0;
            this.buttonObjectDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonObjectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectDelete.ForeColor = System.Drawing.Color.White;
            this.buttonObjectDelete.Location = new System.Drawing.Point(139, 3);
            this.buttonObjectDelete.Name = "buttonObjectDelete";
            this.buttonObjectDelete.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectDelete.TabIndex = 31;
            this.buttonObjectDelete.Text = "Delete";
            this.buttonObjectDelete.UseVisualStyleBackColor = false;
            this.buttonObjectDelete.Click += new System.EventHandler(this.buttonObjectDelete_Click);
            // 
            // buttonObjectUpload
            // 
            this.buttonObjectUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonObjectUpload.FlatAppearance.BorderSize = 0;
            this.buttonObjectUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonObjectUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectUpload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectUpload.ForeColor = System.Drawing.Color.White;
            this.buttonObjectUpload.Location = new System.Drawing.Point(1, 3);
            this.buttonObjectUpload.Name = "buttonObjectUpload";
            this.buttonObjectUpload.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectUpload.TabIndex = 30;
            this.buttonObjectUpload.Text = "Upload";
            this.buttonObjectUpload.UseVisualStyleBackColor = false;
            this.buttonObjectUpload.Click += new System.EventHandler(this.buttonObjectUpload_Click);
            // 
            // UploadObject2InternalVP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UploadObject2InternalVP";
            this.Size = new System.Drawing.Size(822, 628);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalStorage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textFilterString;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBackupReload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvObjectStorage;
        private System.Windows.Forms.DataGridView dgvInternalStorage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonObjectReload;
        private System.Windows.Forms.Button buttonObjectDelete;
        private System.Windows.Forms.Button buttonObjectUpload;
        private System.Windows.Forms.DataGridViewCheckBoxColumn objectSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDateTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn backupSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupFilesize;
        private System.Windows.Forms.DataGridViewTextBoxColumn backupLastWriteTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInternalFolder;
    }
}
