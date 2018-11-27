namespace DMS
{
    partial class UploadLocal2Object
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
            this.buttonLocalDirSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textLocalFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textFilterString = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonObjectReload = new System.Windows.Forms.Button();
            this.buttonObjectDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvLocalDrive = new System.Windows.Forms.DataGridView();
            this.localSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.localFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvObjectStorage = new System.Windows.Forms.DataGridView();
            this.objectSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.objectFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectLastWriteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLocalReload = new System.Windows.Forms.Button();
            this.buttonLocalDelete = new System.Windows.Forms.Button();
            this.buttonLocalUpload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectStorage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 151);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.buttonLocalDirSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textLocalFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textFilterString);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Upload Local 2 Object]";
            // 
            // buttonLocalDirSearch
            // 
            this.buttonLocalDirSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonLocalDirSearch.FlatAppearance.BorderSize = 0;
            this.buttonLocalDirSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLocalDirSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocalDirSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocalDirSearch.ForeColor = System.Drawing.Color.White;
            this.buttonLocalDirSearch.Location = new System.Drawing.Point(671, 61);
            this.buttonLocalDirSearch.Name = "buttonLocalDirSearch";
            this.buttonLocalDirSearch.Size = new System.Drawing.Size(137, 23);
            this.buttonLocalDirSearch.TabIndex = 29;
            this.buttonLocalDirSearch.Text = "Search";
            this.buttonLocalDirSearch.UseVisualStyleBackColor = false;
            this.buttonLocalDirSearch.Click += new System.EventHandler(this.buttonLocalDirSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Local Folder";
            // 
            // textLocalFolder
            // 
            this.textLocalFolder.Location = new System.Drawing.Point(255, 61);
            this.textLocalFolder.Name = "textLocalFolder";
            this.textLocalFolder.Size = new System.Drawing.Size(410, 22);
            this.textLocalFolder.TabIndex = 27;
            this.textLocalFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyword_EnterKeyDown);
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
            this.buttonSave.Location = new System.Drawing.Point(671, 94);
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
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 477);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvLocalDrive, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvObjectStorage, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(822, 477);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonObjectReload);
            this.panel4.Controls.Add(this.buttonObjectDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(423, 444);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 30);
            this.panel4.TabIndex = 19;
            // 
            // buttonObjectReload
            // 
            this.buttonObjectReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonObjectReload.FlatAppearance.BorderSize = 0;
            this.buttonObjectReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonObjectReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObjectReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObjectReload.ForeColor = System.Drawing.Color.White;
            this.buttonObjectReload.Location = new System.Drawing.Point(138, 3);
            this.buttonObjectReload.Name = "buttonObjectReload";
            this.buttonObjectReload.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectReload.TabIndex = 33;
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
            this.buttonObjectDelete.Location = new System.Drawing.Point(0, 3);
            this.buttonObjectDelete.Name = "buttonObjectDelete";
            this.buttonObjectDelete.Size = new System.Drawing.Size(137, 23);
            this.buttonObjectDelete.TabIndex = 32;
            this.buttonObjectDelete.Text = "Delete";
            this.buttonObjectDelete.UseVisualStyleBackColor = false;
            this.buttonObjectDelete.Click += new System.EventHandler(this.buttonObjectDelete_Click);
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
            this.label10.Location = new System.Drawing.Point(129, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "[Local Drive Filelist]";
            // 
            // dgvLocalDrive
            // 
            this.dgvLocalDrive.AllowUserToAddRows = false;
            this.dgvLocalDrive.AllowUserToOrderColumns = true;
            this.dgvLocalDrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localSelect,
            this.localFilename,
            this.localFileSize,
            this.localDateTime});
            this.dgvLocalDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalDrive.Location = new System.Drawing.Point(3, 25);
            this.dgvLocalDrive.Name = "dgvLocalDrive";
            this.dgvLocalDrive.Size = new System.Drawing.Size(414, 413);
            this.dgvLocalDrive.TabIndex = 15;
            // 
            // localSelect
            // 
            this.localSelect.FillWeight = 50F;
            this.localSelect.HeaderText = "Select";
            this.localSelect.Name = "localSelect";
            this.localSelect.Width = 50;
            // 
            // localFilename
            // 
            this.localFilename.FillWeight = 170F;
            this.localFilename.HeaderText = "Filename";
            this.localFilename.Name = "localFilename";
            this.localFilename.Width = 170;
            // 
            // localFileSize
            // 
            this.localFileSize.HeaderText = "FileSize";
            this.localFileSize.Name = "localFileSize";
            // 
            // localDateTime
            // 
            this.localDateTime.HeaderText = "LastWriteTime";
            this.localDateTime.Name = "localDateTime";
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
            this.objectLastWriteTime});
            this.dgvObjectStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjectStorage.Location = new System.Drawing.Point(423, 25);
            this.dgvObjectStorage.Name = "dgvObjectStorage";
            this.dgvObjectStorage.Size = new System.Drawing.Size(396, 413);
            this.dgvObjectStorage.TabIndex = 17;
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
            // objectLastWriteTime
            // 
            this.objectLastWriteTime.HeaderText = "LastWriteTime";
            this.objectLastWriteTime.Name = "objectLastWriteTime";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonLocalReload);
            this.panel3.Controls.Add(this.buttonLocalDelete);
            this.panel3.Controls.Add(this.buttonLocalUpload);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 30);
            this.panel3.TabIndex = 18;
            // 
            // buttonLocalReload
            // 
            this.buttonLocalReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonLocalReload.FlatAppearance.BorderSize = 0;
            this.buttonLocalReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLocalReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocalReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocalReload.ForeColor = System.Drawing.Color.White;
            this.buttonLocalReload.Location = new System.Drawing.Point(277, 3);
            this.buttonLocalReload.Name = "buttonLocalReload";
            this.buttonLocalReload.Size = new System.Drawing.Size(137, 23);
            this.buttonLocalReload.TabIndex = 32;
            this.buttonLocalReload.Text = "Reload";
            this.buttonLocalReload.UseVisualStyleBackColor = false;
            this.buttonLocalReload.Click += new System.EventHandler(this.buttonLocalReload_Click);
            // 
            // buttonLocalDelete
            // 
            this.buttonLocalDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonLocalDelete.FlatAppearance.BorderSize = 0;
            this.buttonLocalDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLocalDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocalDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocalDelete.ForeColor = System.Drawing.Color.White;
            this.buttonLocalDelete.Location = new System.Drawing.Point(139, 3);
            this.buttonLocalDelete.Name = "buttonLocalDelete";
            this.buttonLocalDelete.Size = new System.Drawing.Size(137, 23);
            this.buttonLocalDelete.TabIndex = 31;
            this.buttonLocalDelete.Text = "Delete";
            this.buttonLocalDelete.UseVisualStyleBackColor = false;
            this.buttonLocalDelete.Click += new System.EventHandler(this.buttonLocalDelete_Click);
            // 
            // buttonLocalUpload
            // 
            this.buttonLocalUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonLocalUpload.FlatAppearance.BorderSize = 0;
            this.buttonLocalUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLocalUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocalUpload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocalUpload.ForeColor = System.Drawing.Color.White;
            this.buttonLocalUpload.Location = new System.Drawing.Point(1, 3);
            this.buttonLocalUpload.Name = "buttonLocalUpload";
            this.buttonLocalUpload.Size = new System.Drawing.Size(137, 23);
            this.buttonLocalUpload.TabIndex = 30;
            this.buttonLocalUpload.Text = "Upload";
            this.buttonLocalUpload.UseVisualStyleBackColor = false;
            this.buttonLocalUpload.Click += new System.EventHandler(this.buttonLocalUpload_Click);
            // 
            // UploadLocal2Object
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UploadLocal2Object";
            this.Size = new System.Drawing.Size(822, 628);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectStorage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textFilterString;
        private System.Windows.Forms.Button buttonLocalDirSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textLocalFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonObjectReload;
        private System.Windows.Forms.Button buttonObjectDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvLocalDrive;
        private System.Windows.Forms.DataGridView dgvObjectStorage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLocalReload;
        private System.Windows.Forms.Button buttonLocalDelete;
        private System.Windows.Forms.Button buttonLocalUpload;
        private System.Windows.Forms.DataGridViewCheckBoxColumn localSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn localFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn localFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDateTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn objectSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectLastWriteTime;
    }
}
