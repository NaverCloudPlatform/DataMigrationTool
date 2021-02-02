namespace DMS
{
    partial class Configuration
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
            this.components = new System.ComponentModel.Container();
            this.panelObjectStorageInfo = new System.Windows.Forms.Panel();
            this.groupBoxObjectStorageInfo = new System.Windows.Forms.GroupBox();
            this.textObjectEndPoint = new System.Windows.Forms.TextBox();
            this.buttonConnectionTest = new System.Windows.Forms.Button();
            this.labelObjectStorageDesc = new System.Windows.Forms.Label();
            this.labelBucket = new System.Windows.Forms.Label();
            this.textDefaultBucket = new System.Windows.Forms.TextBox();
            this.textObjectSecretKey = new System.Windows.Forms.TextBox();
            this.labelObjectSecretkey = new System.Windows.Forms.Label();
            this.textObjectAccessKey = new System.Windows.Forms.TextBox();
            this.labelObjectAccesskey = new System.Windows.Forms.Label();
            this.labelObjectEndPoint = new System.Windows.Forms.Label();
            this.checkSSLObjectStorage = new System.Windows.Forms.CheckBox();
            this.textBoxEndPointLable = new System.Windows.Forms.TextBox();
            this.panelApiGatewayInfo = new System.Windows.Forms.Panel();
            this.groupBoxApiGatewayInfo = new System.Windows.Forms.GroupBox();
            this.textBoxAPIEndPointLable = new System.Windows.Forms.TextBox();
            this.labelApiGateWayDesc = new System.Windows.Forms.Label();
            this.textApiUrl = new System.Windows.Forms.TextBox();
            this.buttonApiGatewayTest = new System.Windows.Forms.Button();
            this.labelDefaultApi = new System.Windows.Forms.Label();
            this.textDefaultTestApi = new System.Windows.Forms.TextBox();
            this.textApiGatewaySecretKey = new System.Windows.Forms.TextBox();
            this.labelSecretKey = new System.Windows.Forms.Label();
            this.textApiGatewayAccessKey = new System.Windows.Forms.TextBox();
            this.labelAccessKey = new System.Windows.Forms.Label();
            this.labelEndPoint = new System.Windows.Forms.Label();
            this.checkSSLApiGateway = new System.Windows.Forms.CheckBox();
            this.PanelDatabaseInfo = new System.Windows.Forms.Panel();
            this.groupDatabaseServerInfo = new System.Windows.Forms.GroupBox();
            this.buttonDatabaseConnectionTest = new System.Windows.Forms.Button();
            this.labelDatabaseInstanceNoDesciption = new System.Windows.Forms.Label();
            this.labelDbServerInstanceNo = new System.Windows.Forms.Label();
            this.textCloudDbInstanceNo = new System.Windows.Forms.TextBox();
            this.buttonApiGatewayConnectionTest = new System.Windows.Forms.Button();
            this.buttonSaveDmsInfo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelObjectStorageInfo.SuspendLayout();
            this.groupBoxObjectStorageInfo.SuspendLayout();
            this.panelApiGatewayInfo.SuspendLayout();
            this.groupBoxApiGatewayInfo.SuspendLayout();
            this.PanelDatabaseInfo.SuspendLayout();
            this.groupDatabaseServerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelObjectStorageInfo
            // 
            this.panelObjectStorageInfo.Controls.Add(this.groupBoxObjectStorageInfo);
            this.panelObjectStorageInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelObjectStorageInfo.Location = new System.Drawing.Point(0, 0);
            this.panelObjectStorageInfo.Name = "panelObjectStorageInfo";
            this.panelObjectStorageInfo.Size = new System.Drawing.Size(822, 234);
            this.panelObjectStorageInfo.TabIndex = 0;
            // 
            // groupBoxObjectStorageInfo
            // 
            this.groupBoxObjectStorageInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxObjectStorageInfo.Controls.Add(this.textObjectEndPoint);
            this.groupBoxObjectStorageInfo.Controls.Add(this.buttonConnectionTest);
            this.groupBoxObjectStorageInfo.Controls.Add(this.labelObjectStorageDesc);
            this.groupBoxObjectStorageInfo.Controls.Add(this.labelBucket);
            this.groupBoxObjectStorageInfo.Controls.Add(this.textDefaultBucket);
            this.groupBoxObjectStorageInfo.Controls.Add(this.textObjectSecretKey);
            this.groupBoxObjectStorageInfo.Controls.Add(this.labelObjectSecretkey);
            this.groupBoxObjectStorageInfo.Controls.Add(this.textObjectAccessKey);
            this.groupBoxObjectStorageInfo.Controls.Add(this.labelObjectAccesskey);
            this.groupBoxObjectStorageInfo.Controls.Add(this.labelObjectEndPoint);
            this.groupBoxObjectStorageInfo.Controls.Add(this.checkSSLObjectStorage);
            this.groupBoxObjectStorageInfo.Controls.Add(this.textBoxEndPointLable);
            this.groupBoxObjectStorageInfo.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxObjectStorageInfo.Location = new System.Drawing.Point(3, 16);
            this.groupBoxObjectStorageInfo.Name = "groupBoxObjectStorageInfo";
            this.groupBoxObjectStorageInfo.Size = new System.Drawing.Size(816, 212);
            this.groupBoxObjectStorageInfo.TabIndex = 0;
            this.groupBoxObjectStorageInfo.TabStop = false;
            this.groupBoxObjectStorageInfo.Text = "[Target Object Storage Info]";
            // 
            // textObjectEndPoint
            // 
            this.textObjectEndPoint.Location = new System.Drawing.Point(255, 27);
            this.textObjectEndPoint.Name = "textObjectEndPoint";
            this.textObjectEndPoint.Size = new System.Drawing.Size(318, 22);
            this.textObjectEndPoint.TabIndex = 25;
            // 
            // buttonConnectionTest
            // 
            this.buttonConnectionTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonConnectionTest.FlatAppearance.BorderSize = 0;
            this.buttonConnectionTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConnectionTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectionTest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectionTest.ForeColor = System.Drawing.Color.White;
            this.buttonConnectionTest.Location = new System.Drawing.Point(671, 177);
            this.buttonConnectionTest.Name = "buttonConnectionTest";
            this.buttonConnectionTest.Size = new System.Drawing.Size(137, 23);
            this.buttonConnectionTest.TabIndex = 2;
            this.buttonConnectionTest.Text = "Connection Test";
            this.buttonConnectionTest.UseVisualStyleBackColor = false;
            this.buttonConnectionTest.Click += new System.EventHandler(this.buttonConnectionTest_Click);
            // 
            // labelObjectStorageDesc
            // 
            this.labelObjectStorageDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelObjectStorageDesc.AutoSize = true;
            this.labelObjectStorageDesc.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelObjectStorageDesc.Location = new System.Drawing.Point(465, 155);
            this.labelObjectStorageDesc.Name = "labelObjectStorageDesc";
            this.labelObjectStorageDesc.Size = new System.Drawing.Size(337, 13);
            this.labelObjectStorageDesc.TabIndex = 24;
            this.labelObjectStorageDesc.Text = "Potal > MyPage > Manage Authentication Key OR Amazon S3";
            // 
            // labelBucket
            // 
            this.labelBucket.AutoSize = true;
            this.labelBucket.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBucket.Location = new System.Drawing.Point(200, 133);
            this.labelBucket.Name = "labelBucket";
            this.labelBucket.Size = new System.Drawing.Size(49, 14);
            this.labelBucket.TabIndex = 23;
            this.labelBucket.Text = "Bucket";
            // 
            // textDefaultBucket
            // 
            this.textDefaultBucket.Location = new System.Drawing.Point(255, 130);
            this.textDefaultBucket.Name = "textDefaultBucket";
            this.textDefaultBucket.Size = new System.Drawing.Size(553, 22);
            this.textDefaultBucket.TabIndex = 22;
            // 
            // textObjectSecretKey
            // 
            this.textObjectSecretKey.Location = new System.Drawing.Point(255, 101);
            this.textObjectSecretKey.Name = "textObjectSecretKey";
            this.textObjectSecretKey.Size = new System.Drawing.Size(553, 22);
            this.textObjectSecretKey.TabIndex = 21;
            // 
            // labelObjectSecretkey
            // 
            this.labelObjectSecretkey.AutoSize = true;
            this.labelObjectSecretkey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectSecretkey.Location = new System.Drawing.Point(172, 104);
            this.labelObjectSecretkey.Name = "labelObjectSecretkey";
            this.labelObjectSecretkey.Size = new System.Drawing.Size(77, 14);
            this.labelObjectSecretkey.TabIndex = 20;
            this.labelObjectSecretkey.Text = "Secret Key";
            // 
            // textObjectAccessKey
            // 
            this.textObjectAccessKey.Location = new System.Drawing.Point(255, 72);
            this.textObjectAccessKey.Name = "textObjectAccessKey";
            this.textObjectAccessKey.Size = new System.Drawing.Size(553, 22);
            this.textObjectAccessKey.TabIndex = 19;
            // 
            // labelObjectAccesskey
            // 
            this.labelObjectAccesskey.AutoSize = true;
            this.labelObjectAccesskey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectAccesskey.Location = new System.Drawing.Point(172, 75);
            this.labelObjectAccesskey.Name = "labelObjectAccesskey";
            this.labelObjectAccesskey.Size = new System.Drawing.Size(77, 14);
            this.labelObjectAccesskey.TabIndex = 18;
            this.labelObjectAccesskey.Text = "Access Key";
            // 
            // labelObjectEndPoint
            // 
            this.labelObjectEndPoint.AutoSize = true;
            this.labelObjectEndPoint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectEndPoint.Location = new System.Drawing.Point(67, 32);
            this.labelObjectEndPoint.Name = "labelObjectEndPoint";
            this.labelObjectEndPoint.Size = new System.Drawing.Size(182, 14);
            this.labelObjectEndPoint.TabIndex = 16;
            this.labelObjectEndPoint.Text = "EndPoint (Request domain)";
            // 
            // checkSSLObjectStorage
            // 
            this.checkSSLObjectStorage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkSSLObjectStorage.AutoSize = true;
            this.checkSSLObjectStorage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSSLObjectStorage.Location = new System.Drawing.Point(579, 31);
            this.checkSSLObjectStorage.Name = "checkSSLObjectStorage";
            this.checkSSLObjectStorage.Size = new System.Drawing.Size(229, 18);
            this.checkSSLObjectStorage.TabIndex = 14;
            this.checkSSLObjectStorage.Text = "Use Secure transfer (SSL/TLS)";
            this.checkSSLObjectStorage.UseVisualStyleBackColor = true;
            // 
            // textBoxEndPointLable
            // 
            this.textBoxEndPointLable.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.textBoxEndPointLable.Location = new System.Drawing.Point(255, 51);
            this.textBoxEndPointLable.Name = "textBoxEndPointLable";
            this.textBoxEndPointLable.Size = new System.Drawing.Size(311, 20);
            this.textBoxEndPointLable.TabIndex = 26;
            this.textBoxEndPointLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelApiGatewayInfo
            // 
            this.panelApiGatewayInfo.Controls.Add(this.groupBoxApiGatewayInfo);
            this.panelApiGatewayInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApiGatewayInfo.Location = new System.Drawing.Point(0, 234);
            this.panelApiGatewayInfo.Name = "panelApiGatewayInfo";
            this.panelApiGatewayInfo.Size = new System.Drawing.Size(822, 248);
            this.panelApiGatewayInfo.TabIndex = 1;
            // 
            // groupBoxApiGatewayInfo
            // 
            this.groupBoxApiGatewayInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxApiGatewayInfo.Controls.Add(this.textBoxAPIEndPointLable);
            this.groupBoxApiGatewayInfo.Controls.Add(this.labelApiGateWayDesc);
            this.groupBoxApiGatewayInfo.Controls.Add(this.textApiUrl);
            this.groupBoxApiGatewayInfo.Controls.Add(this.buttonApiGatewayTest);
            this.groupBoxApiGatewayInfo.Controls.Add(this.labelDefaultApi);
            this.groupBoxApiGatewayInfo.Controls.Add(this.textDefaultTestApi);
            this.groupBoxApiGatewayInfo.Controls.Add(this.textApiGatewaySecretKey);
            this.groupBoxApiGatewayInfo.Controls.Add(this.labelSecretKey);
            this.groupBoxApiGatewayInfo.Controls.Add(this.textApiGatewayAccessKey);
            this.groupBoxApiGatewayInfo.Controls.Add(this.labelAccessKey);
            this.groupBoxApiGatewayInfo.Controls.Add(this.labelEndPoint);
            this.groupBoxApiGatewayInfo.Controls.Add(this.checkSSLApiGateway);
            this.groupBoxApiGatewayInfo.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxApiGatewayInfo.Location = new System.Drawing.Point(3, 6);
            this.groupBoxApiGatewayInfo.Name = "groupBoxApiGatewayInfo";
            this.groupBoxApiGatewayInfo.Size = new System.Drawing.Size(816, 233);
            this.groupBoxApiGatewayInfo.TabIndex = 1;
            this.groupBoxApiGatewayInfo.TabStop = false;
            this.groupBoxApiGatewayInfo.Text = "[ApiGateway Info]";
            // 
            // textBoxAPIEndPointLable
            // 
            this.textBoxAPIEndPointLable.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.textBoxAPIEndPointLable.Location = new System.Drawing.Point(255, 54);
            this.textBoxAPIEndPointLable.Name = "textBoxAPIEndPointLable";
            this.textBoxAPIEndPointLable.Size = new System.Drawing.Size(311, 20);
            this.textBoxAPIEndPointLable.TabIndex = 27;
            this.textBoxAPIEndPointLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelApiGateWayDesc
            // 
            this.labelApiGateWayDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelApiGateWayDesc.AutoSize = true;
            this.labelApiGateWayDesc.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelApiGateWayDesc.Location = new System.Drawing.Point(549, 132);
            this.labelApiGateWayDesc.Name = "labelApiGateWayDesc";
            this.labelApiGateWayDesc.Size = new System.Drawing.Size(259, 13);
            this.labelApiGateWayDesc.TabIndex = 30;
            this.labelApiGateWayDesc.Text = "Potal > MyPage > Manage Authentication Key";
            // 
            // textApiUrl
            // 
            this.textApiUrl.Location = new System.Drawing.Point(255, 29);
            this.textApiUrl.Name = "textApiUrl";
            this.textApiUrl.Size = new System.Drawing.Size(318, 22);
            this.textApiUrl.TabIndex = 25;
            // 
            // buttonApiGatewayTest
            // 
            this.buttonApiGatewayTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonApiGatewayTest.FlatAppearance.BorderSize = 0;
            this.buttonApiGatewayTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApiGatewayTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApiGatewayTest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApiGatewayTest.ForeColor = System.Drawing.Color.White;
            this.buttonApiGatewayTest.Location = new System.Drawing.Point(671, 207);
            this.buttonApiGatewayTest.Name = "buttonApiGatewayTest";
            this.buttonApiGatewayTest.Size = new System.Drawing.Size(137, 23);
            this.buttonApiGatewayTest.TabIndex = 2;
            this.buttonApiGatewayTest.Text = "Connection Test";
            this.buttonApiGatewayTest.UseVisualStyleBackColor = false;
            this.buttonApiGatewayTest.Click += new System.EventHandler(this.buttonApiGatewayTest_Click);
            // 
            // labelDefaultApi
            // 
            this.labelDefaultApi.AutoSize = true;
            this.labelDefaultApi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultApi.Location = new System.Drawing.Point(165, 178);
            this.labelDefaultApi.Name = "labelDefaultApi";
            this.labelDefaultApi.Size = new System.Drawing.Size(84, 14);
            this.labelDefaultApi.TabIndex = 23;
            this.labelDefaultApi.Text = "Default API";
            // 
            // textDefaultTestApi
            // 
            this.textDefaultTestApi.Location = new System.Drawing.Point(255, 174);
            this.textDefaultTestApi.Name = "textDefaultTestApi";
            this.textDefaultTestApi.ReadOnly = true;
            this.textDefaultTestApi.Size = new System.Drawing.Size(553, 22);
            this.textDefaultTestApi.TabIndex = 22;
            // 
            // textApiGatewaySecretKey
            // 
            this.textApiGatewaySecretKey.Location = new System.Drawing.Point(255, 107);
            this.textApiGatewaySecretKey.Name = "textApiGatewaySecretKey";
            this.textApiGatewaySecretKey.Size = new System.Drawing.Size(553, 22);
            this.textApiGatewaySecretKey.TabIndex = 21;
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.AutoSize = true;
            this.labelSecretKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecretKey.Location = new System.Drawing.Point(172, 110);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(77, 14);
            this.labelSecretKey.TabIndex = 20;
            this.labelSecretKey.Text = "Secret Key";
            // 
            // textApiGatewayAccessKey
            // 
            this.textApiGatewayAccessKey.Location = new System.Drawing.Point(255, 78);
            this.textApiGatewayAccessKey.Name = "textApiGatewayAccessKey";
            this.textApiGatewayAccessKey.Size = new System.Drawing.Size(553, 22);
            this.textApiGatewayAccessKey.TabIndex = 19;
            // 
            // labelAccessKey
            // 
            this.labelAccessKey.AutoSize = true;
            this.labelAccessKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessKey.Location = new System.Drawing.Point(172, 81);
            this.labelAccessKey.Name = "labelAccessKey";
            this.labelAccessKey.Size = new System.Drawing.Size(77, 14);
            this.labelAccessKey.TabIndex = 18;
            this.labelAccessKey.Text = "Access Key";
            // 
            // labelEndPoint
            // 
            this.labelEndPoint.AutoSize = true;
            this.labelEndPoint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndPoint.Location = new System.Drawing.Point(67, 34);
            this.labelEndPoint.Name = "labelEndPoint";
            this.labelEndPoint.Size = new System.Drawing.Size(182, 14);
            this.labelEndPoint.TabIndex = 16;
            this.labelEndPoint.Text = "EndPoint (Request domain)";
            // 
            // checkSSLApiGateway
            // 
            this.checkSSLApiGateway.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkSSLApiGateway.AutoSize = true;
            this.checkSSLApiGateway.Checked = true;
            this.checkSSLApiGateway.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSSLApiGateway.Enabled = false;
            this.checkSSLApiGateway.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSSLApiGateway.Location = new System.Drawing.Point(579, 31);
            this.checkSSLApiGateway.Name = "checkSSLApiGateway";
            this.checkSSLApiGateway.Size = new System.Drawing.Size(229, 18);
            this.checkSSLApiGateway.TabIndex = 14;
            this.checkSSLApiGateway.Text = "Use Secure transfer (SSL/TLS)";
            this.checkSSLApiGateway.UseVisualStyleBackColor = true;
            // 
            // PanelDatabaseInfo
            // 
            this.PanelDatabaseInfo.Controls.Add(this.groupDatabaseServerInfo);
            this.PanelDatabaseInfo.Controls.Add(this.buttonSaveDmsInfo);
            this.PanelDatabaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDatabaseInfo.Location = new System.Drawing.Point(0, 482);
            this.PanelDatabaseInfo.Name = "PanelDatabaseInfo";
            this.PanelDatabaseInfo.Size = new System.Drawing.Size(822, 146);
            this.PanelDatabaseInfo.TabIndex = 2;
            // 
            // groupDatabaseServerInfo
            // 
            this.groupDatabaseServerInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupDatabaseServerInfo.Controls.Add(this.buttonDatabaseConnectionTest);
            this.groupDatabaseServerInfo.Controls.Add(this.labelDatabaseInstanceNoDesciption);
            this.groupDatabaseServerInfo.Controls.Add(this.labelDbServerInstanceNo);
            this.groupDatabaseServerInfo.Controls.Add(this.textCloudDbInstanceNo);
            this.groupDatabaseServerInfo.Controls.Add(this.buttonApiGatewayConnectionTest);
            this.groupDatabaseServerInfo.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupDatabaseServerInfo.Location = new System.Drawing.Point(3, 3);
            this.groupDatabaseServerInfo.Name = "groupDatabaseServerInfo";
            this.groupDatabaseServerInfo.Size = new System.Drawing.Size(816, 109);
            this.groupDatabaseServerInfo.TabIndex = 32;
            this.groupDatabaseServerInfo.TabStop = false;
            this.groupDatabaseServerInfo.Text = "[Database Info]";
            // 
            // buttonDatabaseConnectionTest
            // 
            this.buttonDatabaseConnectionTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.buttonDatabaseConnectionTest.FlatAppearance.BorderSize = 0;
            this.buttonDatabaseConnectionTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDatabaseConnectionTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatabaseConnectionTest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatabaseConnectionTest.ForeColor = System.Drawing.Color.White;
            this.buttonDatabaseConnectionTest.Location = new System.Drawing.Point(671, 75);
            this.buttonDatabaseConnectionTest.Name = "buttonDatabaseConnectionTest";
            this.buttonDatabaseConnectionTest.Size = new System.Drawing.Size(137, 23);
            this.buttonDatabaseConnectionTest.TabIndex = 31;
            this.buttonDatabaseConnectionTest.Text = "Connection Test";
            this.buttonDatabaseConnectionTest.UseVisualStyleBackColor = false;
            this.buttonDatabaseConnectionTest.Click += new System.EventHandler(this.buttonDbServerExistsCheck_Click);
            // 
            // labelDatabaseInstanceNoDesciption
            // 
            this.labelDatabaseInstanceNoDesciption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseInstanceNoDesciption.AutoSize = true;
            this.labelDatabaseInstanceNoDesciption.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseInstanceNoDesciption.Location = new System.Drawing.Point(493, 50);
            this.labelDatabaseInstanceNoDesciption.Name = "labelDatabaseInstanceNoDesciption";
            this.labelDatabaseInstanceNoDesciption.Size = new System.Drawing.Size(313, 13);
            this.labelDatabaseInstanceNoDesciption.TabIndex = 27;
            this.labelDatabaseInstanceNoDesciption.Text = "If m-986706-001 is the DB Server name, enter 986706";
            // 
            // labelDbServerInstanceNo
            // 
            this.labelDbServerInstanceNo.AutoSize = true;
            this.labelDbServerInstanceNo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDbServerInstanceNo.Location = new System.Drawing.Point(46, 28);
            this.labelDbServerInstanceNo.Name = "labelDbServerInstanceNo";
            this.labelDbServerInstanceNo.Size = new System.Drawing.Size(203, 14);
            this.labelDbServerInstanceNo.TabIndex = 26;
            this.labelDbServerInstanceNo.Text = "Target DB Server Instance No";
            // 
            // textCloudDbInstanceNo
            // 
            this.textCloudDbInstanceNo.Location = new System.Drawing.Point(255, 25);
            this.textCloudDbInstanceNo.Name = "textCloudDbInstanceNo";
            this.textCloudDbInstanceNo.Size = new System.Drawing.Size(553, 22);
            this.textCloudDbInstanceNo.TabIndex = 25;
            // 
            // buttonApiGatewayConnectionTest
            // 
            this.buttonApiGatewayConnectionTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.buttonApiGatewayConnectionTest.FlatAppearance.BorderSize = 0;
            this.buttonApiGatewayConnectionTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApiGatewayConnectionTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApiGatewayConnectionTest.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApiGatewayConnectionTest.ForeColor = System.Drawing.Color.LightGray;
            this.buttonApiGatewayConnectionTest.Location = new System.Drawing.Point(671, 241);
            this.buttonApiGatewayConnectionTest.Name = "buttonApiGatewayConnectionTest";
            this.buttonApiGatewayConnectionTest.Size = new System.Drawing.Size(137, 23);
            this.buttonApiGatewayConnectionTest.TabIndex = 2;
            this.buttonApiGatewayConnectionTest.Text = "Connection Test";
            this.buttonApiGatewayConnectionTest.UseVisualStyleBackColor = false;
            // 
            // buttonSaveDmsInfo
            // 
            this.buttonSaveDmsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(60)))));
            this.buttonSaveDmsInfo.FlatAppearance.BorderSize = 0;
            this.buttonSaveDmsInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveDmsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDmsInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDmsInfo.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDmsInfo.Location = new System.Drawing.Point(674, 118);
            this.buttonSaveDmsInfo.Name = "buttonSaveDmsInfo";
            this.buttonSaveDmsInfo.Size = new System.Drawing.Size(137, 23);
            this.buttonSaveDmsInfo.TabIndex = 31;
            this.buttonSaveDmsInfo.Text = "Save";
            this.buttonSaveDmsInfo.UseVisualStyleBackColor = false;
            this.buttonSaveDmsInfo.Click += new System.EventHandler(this.buttonSaveDmsInfo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Configuration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PanelDatabaseInfo);
            this.Controls.Add(this.panelApiGatewayInfo);
            this.Controls.Add(this.panelObjectStorageInfo);
            this.DoubleBuffered = true;
            this.Name = "Configuration";
            this.Size = new System.Drawing.Size(822, 628);
            this.panelObjectStorageInfo.ResumeLayout(false);
            this.groupBoxObjectStorageInfo.ResumeLayout(false);
            this.groupBoxObjectStorageInfo.PerformLayout();
            this.panelApiGatewayInfo.ResumeLayout(false);
            this.groupBoxApiGatewayInfo.ResumeLayout(false);
            this.groupBoxApiGatewayInfo.PerformLayout();
            this.PanelDatabaseInfo.ResumeLayout(false);
            this.groupDatabaseServerInfo.ResumeLayout(false);
            this.groupDatabaseServerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelObjectStorageInfo;
        private System.Windows.Forms.Panel panelApiGatewayInfo;
        private System.Windows.Forms.Panel PanelDatabaseInfo;
        private System.Windows.Forms.GroupBox groupBoxObjectStorageInfo;
        private System.Windows.Forms.Label labelObjectEndPoint;
        private System.Windows.Forms.Label labelObjectStorageDesc;
        private System.Windows.Forms.Label labelBucket;
        private System.Windows.Forms.TextBox textDefaultBucket;
        private System.Windows.Forms.TextBox textObjectSecretKey;
        private System.Windows.Forms.Label labelObjectSecretkey;
        private System.Windows.Forms.Label labelObjectAccesskey;
        private System.Windows.Forms.Button buttonConnectionTest;
        private System.Windows.Forms.GroupBox groupBoxApiGatewayInfo;
        private System.Windows.Forms.TextBox textApiUrl;
        private System.Windows.Forms.Button buttonApiGatewayTest;
        private System.Windows.Forms.Label labelDefaultApi;
        private System.Windows.Forms.TextBox textDefaultTestApi;
        private System.Windows.Forms.TextBox textApiGatewaySecretKey;
        private System.Windows.Forms.Label labelSecretKey;
        private System.Windows.Forms.TextBox textApiGatewayAccessKey;
        private System.Windows.Forms.Label labelAccessKey;
        private System.Windows.Forms.Label labelEndPoint;
        private System.Windows.Forms.CheckBox checkSSLApiGateway;
        private System.Windows.Forms.Label labelApiGateWayDesc;
        private System.Windows.Forms.Button buttonSaveDmsInfo;
        public System.Windows.Forms.CheckBox checkSSLObjectStorage;
        public System.Windows.Forms.TextBox textObjectAccessKey;
        public System.Windows.Forms.TextBox textObjectEndPoint;
        private System.Windows.Forms.GroupBox groupDatabaseServerInfo;
        private System.Windows.Forms.TextBox textCloudDbInstanceNo;
        private System.Windows.Forms.Button buttonApiGatewayConnectionTest;
        private System.Windows.Forms.Label labelDbServerInstanceNo;
        private System.Windows.Forms.Label labelDatabaseInstanceNoDesciption;
        private System.Windows.Forms.Button buttonDatabaseConnectionTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxEndPointLable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBoxAPIEndPointLable;
    }
}
