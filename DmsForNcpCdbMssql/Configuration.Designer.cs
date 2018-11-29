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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textObjectEndPoint = new System.Windows.Forms.TextBox();
            this.buttonConnectionTest = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.labelBucket = new System.Windows.Forms.Label();
            this.textDefaultBucket = new System.Windows.Forms.TextBox();
            this.textObjectSecretKey = new System.Windows.Forms.TextBox();
            this.labelObjectSecretkey = new System.Windows.Forms.Label();
            this.textObjectAccessKey = new System.Windows.Forms.TextBox();
            this.labelObjectAccesskey = new System.Windows.Forms.Label();
            this.labelObjectEndPoint = new System.Windows.Forms.Label();
            this.checkSSLObjectStorage = new System.Windows.Forms.CheckBox();
            this.textBoxEndPointLable = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAPIEndPointLable = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.textApiGatewayKey = new System.Windows.Forms.TextBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupDatabaseServer = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDbServerInstanceNo = new System.Windows.Forms.Label();
            this.textCloudDbInstanceNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSaveDmsInfo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupDatabaseServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 224);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textObjectEndPoint);
            this.groupBox1.Controls.Add(this.buttonConnectionTest);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.labelBucket);
            this.groupBox1.Controls.Add(this.textDefaultBucket);
            this.groupBox1.Controls.Add(this.textObjectSecretKey);
            this.groupBox1.Controls.Add(this.labelObjectSecretkey);
            this.groupBox1.Controls.Add(this.textObjectAccessKey);
            this.groupBox1.Controls.Add(this.labelObjectAccesskey);
            this.groupBox1.Controls.Add(this.labelObjectEndPoint);
            this.groupBox1.Controls.Add(this.checkSSLObjectStorage);
            this.groupBox1.Controls.Add(this.textBoxEndPointLable);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Target Object Storage Info]";
            // 
            // textObjectEndPoint
            // 
            this.textObjectEndPoint.Location = new System.Drawing.Point(255, 20);
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
            this.buttonConnectionTest.Location = new System.Drawing.Point(671, 170);
            this.buttonConnectionTest.Name = "buttonConnectionTest";
            this.buttonConnectionTest.Size = new System.Drawing.Size(137, 23);
            this.buttonConnectionTest.TabIndex = 2;
            this.buttonConnectionTest.Text = "Connection Test";
            this.buttonConnectionTest.UseVisualStyleBackColor = false;
            this.buttonConnectionTest.Click += new System.EventHandler(this.buttonConnectionTest_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 8F);
            this.label17.Location = new System.Drawing.Point(465, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(337, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Potal > MyPage > Manage Authentication Key OR Amazon S3";
            // 
            // labelBucket
            // 
            this.labelBucket.AutoSize = true;
            this.labelBucket.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBucket.Location = new System.Drawing.Point(200, 126);
            this.labelBucket.Name = "labelBucket";
            this.labelBucket.Size = new System.Drawing.Size(49, 14);
            this.labelBucket.TabIndex = 23;
            this.labelBucket.Text = "Bucket";
            // 
            // textDefaultBucket
            // 
            this.textDefaultBucket.Location = new System.Drawing.Point(255, 123);
            this.textDefaultBucket.Name = "textDefaultBucket";
            this.textDefaultBucket.Size = new System.Drawing.Size(553, 22);
            this.textDefaultBucket.TabIndex = 22;
            // 
            // textObjectSecretKey
            // 
            this.textObjectSecretKey.Location = new System.Drawing.Point(255, 94);
            this.textObjectSecretKey.Name = "textObjectSecretKey";
            this.textObjectSecretKey.Size = new System.Drawing.Size(553, 22);
            this.textObjectSecretKey.TabIndex = 21;
            // 
            // labelObjectSecretkey
            // 
            this.labelObjectSecretkey.AutoSize = true;
            this.labelObjectSecretkey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectSecretkey.Location = new System.Drawing.Point(172, 97);
            this.labelObjectSecretkey.Name = "labelObjectSecretkey";
            this.labelObjectSecretkey.Size = new System.Drawing.Size(77, 14);
            this.labelObjectSecretkey.TabIndex = 20;
            this.labelObjectSecretkey.Text = "Secret Key";
            // 
            // textObjectAccessKey
            // 
            this.textObjectAccessKey.Location = new System.Drawing.Point(255, 65);
            this.textObjectAccessKey.Name = "textObjectAccessKey";
            this.textObjectAccessKey.Size = new System.Drawing.Size(553, 22);
            this.textObjectAccessKey.TabIndex = 19;
            // 
            // labelObjectAccesskey
            // 
            this.labelObjectAccesskey.AutoSize = true;
            this.labelObjectAccesskey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectAccesskey.Location = new System.Drawing.Point(172, 68);
            this.labelObjectAccesskey.Name = "labelObjectAccesskey";
            this.labelObjectAccesskey.Size = new System.Drawing.Size(77, 14);
            this.labelObjectAccesskey.TabIndex = 18;
            this.labelObjectAccesskey.Text = "Access Key";
            // 
            // labelObjectEndPoint
            // 
            this.labelObjectEndPoint.AutoSize = true;
            this.labelObjectEndPoint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectEndPoint.Location = new System.Drawing.Point(67, 25);
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
            this.checkSSLObjectStorage.Location = new System.Drawing.Point(579, 22);
            this.checkSSLObjectStorage.Name = "checkSSLObjectStorage";
            this.checkSSLObjectStorage.Size = new System.Drawing.Size(229, 18);
            this.checkSSLObjectStorage.TabIndex = 14;
            this.checkSSLObjectStorage.Text = "Use Secure transfer (SSL/TLS)";
            this.checkSSLObjectStorage.UseVisualStyleBackColor = true;
            // 
            // textBoxEndPointLable
            // 
            this.textBoxEndPointLable.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.textBoxEndPointLable.Location = new System.Drawing.Point(255, 44);
            this.textBoxEndPointLable.Name = "textBoxEndPointLable";
            this.textBoxEndPointLable.Size = new System.Drawing.Size(311, 20);
            this.textBoxEndPointLable.TabIndex = 26;
            this.textBoxEndPointLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 254);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.textBoxAPIEndPointLable);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.labelApiKey);
            this.groupBox2.Controls.Add(this.textApiGatewayKey);
            this.groupBox2.Controls.Add(this.textApiUrl);
            this.groupBox2.Controls.Add(this.buttonApiGatewayTest);
            this.groupBox2.Controls.Add(this.labelDefaultApi);
            this.groupBox2.Controls.Add(this.textDefaultTestApi);
            this.groupBox2.Controls.Add(this.textApiGatewaySecretKey);
            this.groupBox2.Controls.Add(this.labelSecretKey);
            this.groupBox2.Controls.Add(this.textApiGatewayAccessKey);
            this.groupBox2.Controls.Add(this.labelAccessKey);
            this.groupBox2.Controls.Add(this.labelEndPoint);
            this.groupBox2.Controls.Add(this.checkSSLApiGateway);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ApiGateway Info]";
            // 
            // textBoxAPIEndPointLable
            // 
            this.textBoxAPIEndPointLable.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.textBoxAPIEndPointLable.Location = new System.Drawing.Point(255, 47);
            this.textBoxAPIEndPointLable.Name = "textBoxAPIEndPointLable";
            this.textBoxAPIEndPointLable.Size = new System.Drawing.Size(311, 20);
            this.textBoxAPIEndPointLable.TabIndex = 27;
            this.textBoxAPIEndPointLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 8F);
            this.label16.Location = new System.Drawing.Point(549, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(259, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Potal > MyPage > Manage Authentication Key";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8F);
            this.label13.Location = new System.Drawing.Point(520, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "MC > API Gateway > Create API Key > Primary key";
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiKey.Location = new System.Drawing.Point(193, 145);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(56, 14);
            this.labelApiKey.TabIndex = 27;
            this.labelApiKey.Text = "Api Key";
            // 
            // textApiGatewayKey
            // 
            this.textApiGatewayKey.Location = new System.Drawing.Point(255, 142);
            this.textApiGatewayKey.Name = "textApiGatewayKey";
            this.textApiGatewayKey.Size = new System.Drawing.Size(553, 22);
            this.textApiGatewayKey.TabIndex = 26;
            // 
            // textApiUrl
            // 
            this.textApiUrl.Location = new System.Drawing.Point(255, 22);
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
            this.buttonApiGatewayTest.Location = new System.Drawing.Point(671, 218);
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
            this.labelDefaultApi.Location = new System.Drawing.Point(165, 189);
            this.labelDefaultApi.Name = "labelDefaultApi";
            this.labelDefaultApi.Size = new System.Drawing.Size(84, 14);
            this.labelDefaultApi.TabIndex = 23;
            this.labelDefaultApi.Text = "Default API";
            // 
            // textDefaultTestApi
            // 
            this.textDefaultTestApi.Location = new System.Drawing.Point(255, 185);
            this.textDefaultTestApi.Name = "textDefaultTestApi";
            this.textDefaultTestApi.ReadOnly = true;
            this.textDefaultTestApi.Size = new System.Drawing.Size(553, 22);
            this.textDefaultTestApi.TabIndex = 22;
            // 
            // textApiGatewaySecretKey
            // 
            this.textApiGatewaySecretKey.Location = new System.Drawing.Point(255, 98);
            this.textApiGatewaySecretKey.Name = "textApiGatewaySecretKey";
            this.textApiGatewaySecretKey.Size = new System.Drawing.Size(553, 22);
            this.textApiGatewaySecretKey.TabIndex = 21;
            // 
            // labelSecretKey
            // 
            this.labelSecretKey.AutoSize = true;
            this.labelSecretKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecretKey.Location = new System.Drawing.Point(172, 101);
            this.labelSecretKey.Name = "labelSecretKey";
            this.labelSecretKey.Size = new System.Drawing.Size(77, 14);
            this.labelSecretKey.TabIndex = 20;
            this.labelSecretKey.Text = "Secret Key";
            // 
            // textApiGatewayAccessKey
            // 
            this.textApiGatewayAccessKey.Location = new System.Drawing.Point(255, 69);
            this.textApiGatewayAccessKey.Name = "textApiGatewayAccessKey";
            this.textApiGatewayAccessKey.Size = new System.Drawing.Size(553, 22);
            this.textApiGatewayAccessKey.TabIndex = 19;
            // 
            // labelAccessKey
            // 
            this.labelAccessKey.AutoSize = true;
            this.labelAccessKey.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessKey.Location = new System.Drawing.Point(172, 72);
            this.labelAccessKey.Name = "labelAccessKey";
            this.labelAccessKey.Size = new System.Drawing.Size(77, 14);
            this.labelAccessKey.TabIndex = 18;
            this.labelAccessKey.Text = "Access Key";
            // 
            // labelEndPoint
            // 
            this.labelEndPoint.AutoSize = true;
            this.labelEndPoint.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndPoint.Location = new System.Drawing.Point(67, 27);
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
            this.checkSSLApiGateway.Location = new System.Drawing.Point(580, 23);
            this.checkSSLApiGateway.Name = "checkSSLApiGateway";
            this.checkSSLApiGateway.Size = new System.Drawing.Size(229, 18);
            this.checkSSLApiGateway.TabIndex = 14;
            this.checkSSLApiGateway.Text = "Use Secure transfer (SSL/TLS)";
            this.checkSSLApiGateway.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupDatabaseServer);
            this.panel3.Controls.Add(this.buttonSaveDmsInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 150);
            this.panel3.TabIndex = 2;
            // 
            // groupDatabaseServer
            // 
            this.groupDatabaseServer.BackColor = System.Drawing.SystemColors.Control;
            this.groupDatabaseServer.Controls.Add(this.button2);
            this.groupDatabaseServer.Controls.Add(this.label11);
            this.groupDatabaseServer.Controls.Add(this.labelDbServerInstanceNo);
            this.groupDatabaseServer.Controls.Add(this.textCloudDbInstanceNo);
            this.groupDatabaseServer.Controls.Add(this.button1);
            this.groupDatabaseServer.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupDatabaseServer.Location = new System.Drawing.Point(3, 6);
            this.groupDatabaseServer.Name = "groupDatabaseServer";
            this.groupDatabaseServer.Size = new System.Drawing.Size(816, 105);
            this.groupDatabaseServer.TabIndex = 32;
            this.groupDatabaseServer.TabStop = false;
            this.groupDatabaseServer.Text = "[Database Info]";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(671, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Connection Test";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonDbServerExistsCheck_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(493, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "If m-986706-001 is the DB Server name, enter 986706";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(671, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connection Test";
            this.button1.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Configuration";
            this.Size = new System.Drawing.Size(822, 628);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupDatabaseServer.ResumeLayout(false);
            this.groupDatabaseServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelObjectEndPoint;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelBucket;
        private System.Windows.Forms.TextBox textDefaultBucket;
        private System.Windows.Forms.TextBox textObjectSecretKey;
        private System.Windows.Forms.Label labelObjectSecretkey;
        private System.Windows.Forms.Label labelObjectAccesskey;
        private System.Windows.Forms.Button buttonConnectionTest;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelApiKey;
        private System.Windows.Forms.TextBox textApiGatewayKey;
        private System.Windows.Forms.Button buttonSaveDmsInfo;
        public System.Windows.Forms.CheckBox checkSSLObjectStorage;
        public System.Windows.Forms.TextBox textObjectAccessKey;
        public System.Windows.Forms.TextBox textObjectEndPoint;
        private System.Windows.Forms.GroupBox groupDatabaseServer;
        private System.Windows.Forms.TextBox textCloudDbInstanceNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDbServerInstanceNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxEndPointLable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBoxAPIEndPointLable;
    }
}
