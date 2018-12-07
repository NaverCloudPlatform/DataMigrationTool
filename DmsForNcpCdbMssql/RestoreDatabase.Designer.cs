namespace DMS
{
    partial class RestoreDatabase
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
            this.label5 = new System.Windows.Forms.Label();
            this.textInternalFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textFilterString = new System.Windows.Forms.TextBox();
            this.textNewDatabaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStopAtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBackupStorage = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestReturnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkRecovery = new System.Windows.Forms.CheckBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonRestoreLog = new System.Windows.Forms.Button();
            this.buttonRestoreDatabase = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackupStorage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 235);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textInternalFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textFilterString);
            this.groupBox1.Controls.Add(this.textNewDatabaseName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textStopAtTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Restore Database]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Change Internal Storage Folder";
            // 
            // textInternalFolder
            // 
            this.textInternalFolder.Location = new System.Drawing.Point(254, 123);
            this.textInternalFolder.Name = "textInternalFolder";
            this.textInternalFolder.Size = new System.Drawing.Size(554, 22);
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
            this.buttonSave.Location = new System.Drawing.Point(671, 178);
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
            // textNewDatabaseName
            // 
            this.textNewDatabaseName.Location = new System.Drawing.Point(255, 93);
            this.textNewDatabaseName.Name = "textNewDatabaseName";
            this.textNewDatabaseName.Size = new System.Drawing.Size(553, 22);
            this.textNewDatabaseName.TabIndex = 21;
            this.textNewDatabaseName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyword_EnterKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Database Name";
            // 
            // textStopAtTime
            // 
            this.textStopAtTime.Location = new System.Drawing.Point(255, 61);
            this.textStopAtTime.Name = "textStopAtTime";
            this.textStopAtTime.Size = new System.Drawing.Size(553, 22);
            this.textStopAtTime.TabIndex = 19;
            this.textStopAtTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyword_EnterKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stop At Time";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 393);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 816F));
            this.tableLayoutPanel2.Controls.Add(this.dgvBackupStorage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 9);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 382);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvBackupStorage
            // 
            this.dgvBackupStorage.AllowUserToAddRows = false;
            this.dgvBackupStorage.AllowUserToOrderColumns = true;
            this.dgvBackupStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackupStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.RequestNo,
            this.RequestReturnCode,
            this.ReturnCode,
            this.ReturnCodeName});
            this.dgvBackupStorage.Location = new System.Drawing.Point(3, 25);
            this.dgvBackupStorage.Name = "dgvBackupStorage";
            this.dgvBackupStorage.Size = new System.Drawing.Size(810, 320);
            this.dgvBackupStorage.TabIndex = 20;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.FillWeight = 50F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Filename";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "FileSize";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "LastWriteTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // RequestNo
            // 
            this.RequestNo.HeaderText = "RequestNo";
            this.RequestNo.Name = "RequestNo";
            // 
            // RequestReturnCode
            // 
            this.RequestReturnCode.HeaderText = "RequestReturnCode";
            this.RequestReturnCode.Name = "RequestReturnCode";
            // 
            // ReturnCode
            // 
            this.ReturnCode.HeaderText = "ReturnCode";
            this.ReturnCode.Name = "ReturnCode";
            // 
            // ReturnCodeName
            // 
            this.ReturnCodeName.HeaderText = "ReturnCodeName";
            this.ReturnCodeName.Name = "ReturnCodeName";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F);
            this.label10.Location = new System.Drawing.Point(310, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "[Internal Storage Filelist]";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkRecovery);
            this.panel3.Controls.Add(this.buttonReload);
            this.panel3.Controls.Add(this.buttonRestoreLog);
            this.panel3.Controls.Add(this.buttonRestoreDatabase);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 28);
            this.panel3.TabIndex = 18;
            // 
            // checkRecovery
            // 
            this.checkRecovery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkRecovery.AutoSize = true;
            this.checkRecovery.Checked = true;
            this.checkRecovery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRecovery.Font = new System.Drawing.Font("Consolas", 9F);
            this.checkRecovery.Location = new System.Drawing.Point(287, 6);
            this.checkRecovery.Name = "checkRecovery";
            this.checkRecovery.Size = new System.Drawing.Size(117, 18);
            this.checkRecovery.TabIndex = 33;
            this.checkRecovery.Text = "with Recovery";
            this.checkRecovery.UseVisualStyleBackColor = true;
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.White;
            this.buttonReload.Location = new System.Drawing.Point(668, 4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(137, 23);
            this.buttonReload.TabIndex = 32;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonRestoreLog
            // 
            this.buttonRestoreLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonRestoreLog.FlatAppearance.BorderSize = 0;
            this.buttonRestoreLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRestoreLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreLog.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreLog.ForeColor = System.Drawing.Color.White;
            this.buttonRestoreLog.Location = new System.Drawing.Point(139, 3);
            this.buttonRestoreLog.Name = "buttonRestoreLog";
            this.buttonRestoreLog.Size = new System.Drawing.Size(137, 23);
            this.buttonRestoreLog.TabIndex = 31;
            this.buttonRestoreLog.Text = "Restore Log";
            this.buttonRestoreLog.UseVisualStyleBackColor = false;
            this.buttonRestoreLog.Click += new System.EventHandler(this.buttonRestoreLog_Click);
            // 
            // buttonRestoreDatabase
            // 
            this.buttonRestoreDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonRestoreDatabase.FlatAppearance.BorderSize = 0;
            this.buttonRestoreDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRestoreDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreDatabase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreDatabase.ForeColor = System.Drawing.Color.White;
            this.buttonRestoreDatabase.Location = new System.Drawing.Point(1, 3);
            this.buttonRestoreDatabase.Name = "buttonRestoreDatabase";
            this.buttonRestoreDatabase.Size = new System.Drawing.Size(137, 23);
            this.buttonRestoreDatabase.TabIndex = 30;
            this.buttonRestoreDatabase.Text = "Restore Database";
            this.buttonRestoreDatabase.UseVisualStyleBackColor = false;
            this.buttonRestoreDatabase.Click += new System.EventHandler(this.buttonRestoreDatabase_Click);
            // 
            // RestoreDatabase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "RestoreDatabase";
            this.Size = new System.Drawing.Size(822, 628);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackupStorage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textFilterString;
        private System.Windows.Forms.TextBox textNewDatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStopAtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvBackupStorage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonRestoreLog;
        private System.Windows.Forms.Button buttonRestoreDatabase;
        private System.Windows.Forms.CheckBox checkRecovery;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestReturnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnCodeName;
        private System.Windows.Forms.TextBox textInternalFolder;
        private System.Windows.Forms.Label label5;
    }
}
