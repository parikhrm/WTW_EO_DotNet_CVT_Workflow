namespace CVT_Workflow
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.volumes = new System.Windows.Forms.NumericUpDown();
            this.label_volumes = new System.Windows.Forms.Label();
            this.requestorsegmentname = new System.Windows.Forms.ComboBox();
            this.label_requestorsegmentname = new System.Windows.Forms.Label();
            this.requestid = new System.Windows.Forms.TextBox();
            this.label_requestid = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.comments = new System.Windows.Forms.TextBox();
            this.label_comments = new System.Windows.Forms.Label();
            this.requestorlocation = new System.Windows.Forms.ComboBox();
            this.label_requestorlocation = new System.Windows.Forms.Label();
            this.requestoremailaddress = new System.Windows.Forms.TextBox();
            this.label_requestoremailaddress = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.approvedby = new System.Windows.Forms.ComboBox();
            this.label_approvedby = new System.Windows.Forms.Label();
            this.approvedtime = new System.Windows.Forms.DateTimePicker();
            this.approveddate = new System.Windows.Forms.DateTimePicker();
            this.label_approveddate = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.queryraisedby = new System.Windows.Forms.ComboBox();
            this.label_queryraisedby = new System.Windows.Forms.Label();
            this.queryresolvedtime = new System.Windows.Forms.DateTimePicker();
            this.queryresolveddate = new System.Windows.Forms.DateTimePicker();
            this.label_queryresolveddate = new System.Windows.Forms.Label();
            this.queriedfor = new System.Windows.Forms.ComboBox();
            this.label_queriedfor = new System.Windows.Forms.Label();
            this.label_querycategory = new System.Windows.Forms.Label();
            this.querycategory = new System.Windows.Forms.ComboBox();
            this.querytime = new System.Windows.Forms.DateTimePicker();
            this.querydate = new System.Windows.Forms.DateTimePicker();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label_querydate = new System.Windows.Forms.Label();
            this.orgstatus = new System.Windows.Forms.ComboBox();
            this.label_orgstatus = new System.Windows.Forms.Label();
            this.orgid = new System.Windows.Forms.TextBox();
            this.label_orgid = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.label_role = new System.Windows.Forms.Label();
            this.bu = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchbypartyname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbyrequeststatus = new System.Windows.Forms.ComboBox();
            this.searchbyactivitytype = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTATMissCases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReceivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestorEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestorLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRequestorSegmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLegalEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClientOnboardingFormRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVolumes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClientInformationFormSMSOExceptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClientOnboardingVerificationCompleteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRICOpted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInflowProcessedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInflowProcessedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInflowProcessedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueryCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueriedFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueryResolvedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueryResolvedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQueryRaisedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReQueryBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReQueryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReQueryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApprovedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApprovedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPLCRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUBO_ValidationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubCategories_QC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategories_QC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQCDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQCDoneBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.searchbyorgid = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label_bu = new System.Windows.Forms.Label();
            this.receivedtime = new System.Windows.Forms.DateTimePicker();
            this.receiveddate = new System.Windows.Forms.DateTimePicker();
            this.partyname = new System.Windows.Forms.TextBox();
            this.activitytype = new System.Windows.Forms.ComboBox();
            this.label_receiveddate = new System.Windows.Forms.Label();
            this.label_partyname = new System.Windows.Forms.Label();
            this.label_activitytype = new System.Windows.Forms.Label();
            this.label_legalentityname = new System.Windows.Forms.Label();
            this.legalentity = new System.Windows.Forms.ComboBox();
            this.label_plcrequestid = new System.Windows.Forms.Label();
            this.plcrequestid = new System.Windows.Forms.TextBox();
            this.label_categoriesqc = new System.Windows.Forms.Label();
            this.label_qcdoneby = new System.Windows.Forms.Label();
            this.label_subcategoriesqc = new System.Windows.Forms.Label();
            this.label_qcdate = new System.Windows.Forms.Label();
            this.categories_qc = new System.Windows.Forms.ComboBox();
            this.subcategories_qc = new System.Windows.Forms.ComboBox();
            this.qcdoneby = new System.Windows.Forms.ComboBox();
            this.qcdate = new System.Windows.Forms.DateTimePicker();
            this.label_cofverificationcompletedate = new System.Windows.Forms.Label();
            this.label_cofsmsoreceiveddate = new System.Windows.Forms.Label();
            this.clientinformationformsmsoexceptiondate = new System.Windows.Forms.DateTimePicker();
            this.clientonboardingverificationcompletedate = new System.Windows.Forms.DateTimePicker();
            this.label_clientonboardingformrequired = new System.Windows.Forms.Label();
            this.clientonboardingformrequired = new System.Windows.Forms.ComboBox();
            this.label_ricopted = new System.Windows.Forms.Label();
            this.ricopted = new System.Windows.Forms.ComboBox();
            this.label_inflowprocessedby = new System.Windows.Forms.Label();
            this.inflowprocessedby = new System.Windows.Forms.ComboBox();
            this.label_inflowprocesseddate = new System.Windows.Forms.Label();
            this.inflowprocesseddate = new System.Windows.Forms.DateTimePicker();
            this.inflowprocessedtime = new System.Windows.Forms.DateTimePicker();
            this.todaydate = new System.Windows.Forms.DateTimePicker();
            this.datagridview_click = new System.Windows.Forms.Button();
            this.label_requerydate = new System.Windows.Forms.Label();
            this.requerytime = new System.Windows.Forms.DateTimePicker();
            this.requerydate = new System.Windows.Forms.DateTimePicker();
            this.label_requeryby = new System.Windows.Forms.Label();
            this.requeryby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ubovalidationdate = new System.Windows.Forms.DateTimePicker();
            this.mainpage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumes)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(613, 525);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(91, 20);
            this.linkLabel2.TabIndex = 81;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "TAT Report";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(492, 525);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 20);
            this.linkLabel1.TabIndex = 80;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Export to Excel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // volumes
            // 
            this.volumes.Location = new System.Drawing.Point(1761, 296);
            this.volumes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.volumes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.volumes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumes.Name = "volumes";
            this.volumes.Size = new System.Drawing.Size(90, 26);
            this.volumes.TabIndex = 57;
            this.volumes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumes.ValueChanged += new System.EventHandler(this.volumes_ValueChanged);
            // 
            // label_volumes
            // 
            this.label_volumes.AutoSize = true;
            this.label_volumes.Location = new System.Drawing.Point(1674, 296);
            this.label_volumes.Name = "label_volumes";
            this.label_volumes.Size = new System.Drawing.Size(71, 20);
            this.label_volumes.TabIndex = 56;
            this.label_volumes.Text = "Volumes";
            this.label_volumes.Click += new System.EventHandler(this.label28_Click);
            // 
            // requestorsegmentname
            // 
            this.requestorsegmentname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestorsegmentname.FormattingEnabled = true;
            this.requestorsegmentname.Location = new System.Drawing.Point(562, 86);
            this.requestorsegmentname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.requestorsegmentname.Name = "requestorsegmentname";
            this.requestorsegmentname.Size = new System.Drawing.Size(306, 28);
            this.requestorsegmentname.TabIndex = 14;
            this.requestorsegmentname.SelectedIndexChanged += new System.EventHandler(this.requestorsegmentname_SelectedIndexChanged);
            // 
            // label_requestorsegmentname
            // 
            this.label_requestorsegmentname.AutoSize = true;
            this.label_requestorsegmentname.Location = new System.Drawing.Point(416, 86);
            this.label_requestorsegmentname.Name = "label_requestorsegmentname";
            this.label_requestorsegmentname.Size = new System.Drawing.Size(120, 40);
            this.label_requestorsegmentname.TabIndex = 13;
            this.label_requestorsegmentname.Text = "Requestor \r\nSegment Name";
            this.label_requestorsegmentname.Click += new System.EventHandler(this.label27_Click);
            // 
            // requestid
            // 
            this.requestid.Location = new System.Drawing.Point(112, 47);
            this.requestid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestid.Name = "requestid";
            this.requestid.Size = new System.Drawing.Size(122, 26);
            this.requestid.TabIndex = 1;
            // 
            // label_requestid
            // 
            this.label_requestid.AutoSize = true;
            this.label_requestid.Location = new System.Drawing.Point(9, 47);
            this.label_requestid.Name = "label_requestid";
            this.label_requestid.Size = new System.Drawing.Size(87, 20);
            this.label_requestid.TabIndex = 0;
            this.label_requestid.Text = "RequestID";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(323, 517);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(127, 42);
            this.reset.TabIndex = 81;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(182, 517);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(135, 42);
            this.update.TabIndex = 80;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(45, 517);
            this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(131, 42);
            this.insert.TabIndex = 79;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            this.insert.MouseLeave += new System.EventHandler(this.insert_MouseLeave);
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(1641, 387);
            this.comments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(229, 52);
            this.comments.TabIndex = 70;
            this.comments.TextChanged += new System.EventHandler(this.comments_TextChanged);
            // 
            // label_comments
            // 
            this.label_comments.AutoSize = true;
            this.label_comments.Location = new System.Drawing.Point(1543, 389);
            this.label_comments.Name = "label_comments";
            this.label_comments.Size = new System.Drawing.Size(86, 20);
            this.label_comments.TabIndex = 69;
            this.label_comments.Text = "Comments";
            this.label_comments.Click += new System.EventHandler(this.label24_Click);
            // 
            // requestorlocation
            // 
            this.requestorlocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestorlocation.FormattingEnabled = true;
            this.requestorlocation.Location = new System.Drawing.Point(112, 83);
            this.requestorlocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestorlocation.Name = "requestorlocation";
            this.requestorlocation.Size = new System.Drawing.Size(280, 28);
            this.requestorlocation.TabIndex = 12;
            this.requestorlocation.SelectedIndexChanged += new System.EventHandler(this.requestorlocation_SelectedIndexChanged);
            // 
            // label_requestorlocation
            // 
            this.label_requestorlocation.AutoSize = true;
            this.label_requestorlocation.Location = new System.Drawing.Point(9, 83);
            this.label_requestorlocation.Name = "label_requestorlocation";
            this.label_requestorlocation.Size = new System.Drawing.Size(88, 40);
            this.label_requestorlocation.TabIndex = 11;
            this.label_requestorlocation.Text = "Requestor \r\nLocation";
            this.label_requestorlocation.Click += new System.EventHandler(this.label23_Click);
            // 
            // requestoremailaddress
            // 
            this.requestoremailaddress.Location = new System.Drawing.Point(1527, 18);
            this.requestoremailaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestoremailaddress.Multiline = true;
            this.requestoremailaddress.Name = "requestoremailaddress";
            this.requestoremailaddress.Size = new System.Drawing.Size(356, 53);
            this.requestoremailaddress.TabIndex = 10;
            this.requestoremailaddress.TextChanged += new System.EventHandler(this.requestoremailaddress_TextChanged);
            // 
            // label_requestoremailaddress
            // 
            this.label_requestoremailaddress.AutoSize = true;
            this.label_requestoremailaddress.Location = new System.Drawing.Point(1373, 18);
            this.label_requestoremailaddress.Name = "label_requestoremailaddress";
            this.label_requestoremailaddress.Size = new System.Drawing.Size(127, 40);
            this.label_requestoremailaddress.TabIndex = 9;
            this.label_requestoremailaddress.Text = "Requestor Email\r\nAddress";
            this.label_requestoremailaddress.Click += new System.EventHandler(this.label22_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(1506, 394);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(22, 21);
            this.checkBox5.TabIndex = 68;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // approvedby
            // 
            this.approvedby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approvedby.FormattingEnabled = true;
            this.approvedby.Location = new System.Drawing.Point(1219, 389);
            this.approvedby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approvedby.Name = "approvedby";
            this.approvedby.Size = new System.Drawing.Size(271, 28);
            this.approvedby.TabIndex = 67;
            this.approvedby.DropDown += new System.EventHandler(this.approvedby_DropDown);
            this.approvedby.SelectedIndexChanged += new System.EventHandler(this.approvedby_SelectedIndexChanged);
            // 
            // label_approvedby
            // 
            this.label_approvedby.AutoSize = true;
            this.label_approvedby.Location = new System.Drawing.Point(1114, 391);
            this.label_approvedby.Name = "label_approvedby";
            this.label_approvedby.Size = new System.Drawing.Size(99, 20);
            this.label_approvedby.TabIndex = 66;
            this.label_approvedby.Text = "Approved By";
            this.label_approvedby.Click += new System.EventHandler(this.label20_Click);
            // 
            // approvedtime
            // 
            this.approvedtime.CustomFormat = " ";
            this.approvedtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.approvedtime.Location = new System.Drawing.Point(863, 420);
            this.approvedtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approvedtime.Name = "approvedtime";
            this.approvedtime.ShowUpDown = true;
            this.approvedtime.Size = new System.Drawing.Size(128, 26);
            this.approvedtime.TabIndex = 65;
            this.approvedtime.ValueChanged += new System.EventHandler(this.approvedtime_ValueChanged);
            this.approvedtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.approvedtime_KeyDown);
            this.approvedtime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.approvedtime_MouseDown);
            // 
            // approveddate
            // 
            this.approveddate.CustomFormat = " ";
            this.approveddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.approveddate.Location = new System.Drawing.Point(863, 390);
            this.approveddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approveddate.Name = "approveddate";
            this.approveddate.Size = new System.Drawing.Size(232, 26);
            this.approveddate.TabIndex = 64;
            this.approveddate.ValueChanged += new System.EventHandler(this.approveddate_ValueChanged);
            this.approveddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.approveddate_KeyDown);
            // 
            // label_approveddate
            // 
            this.label_approveddate.AutoSize = true;
            this.label_approveddate.Location = new System.Drawing.Point(735, 392);
            this.label_approveddate.Name = "label_approveddate";
            this.label_approveddate.Size = new System.Drawing.Size(116, 20);
            this.label_approveddate.TabIndex = 63;
            this.label_approveddate.Text = "Approved Date";
            this.label_approveddate.Click += new System.EventHandler(this.label19_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1624, 300);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(22, 21);
            this.checkBox4.TabIndex = 55;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // queryraisedby
            // 
            this.queryraisedby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryraisedby.FormattingEnabled = true;
            this.queryraisedby.Location = new System.Drawing.Point(926, 293);
            this.queryraisedby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryraisedby.Name = "queryraisedby";
            this.queryraisedby.Size = new System.Drawing.Size(240, 28);
            this.queryraisedby.TabIndex = 50;
            this.queryraisedby.DropDown += new System.EventHandler(this.queryresolvedby_DropDown);
            this.queryraisedby.SelectedIndexChanged += new System.EventHandler(this.queryresolvedby_SelectedIndexChanged);
            // 
            // label_queryraisedby
            // 
            this.label_queryraisedby.AutoSize = true;
            this.label_queryraisedby.Location = new System.Drawing.Point(789, 293);
            this.label_queryraisedby.Name = "label_queryraisedby";
            this.label_queryraisedby.Size = new System.Drawing.Size(127, 20);
            this.label_queryraisedby.TabIndex = 49;
            this.label_queryraisedby.Text = "Query Raised By";
            this.label_queryraisedby.Click += new System.EventHandler(this.label18_Click);
            // 
            // queryresolvedtime
            // 
            this.queryresolvedtime.CustomFormat = " ";
            this.queryresolvedtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.queryresolvedtime.Location = new System.Drawing.Point(1377, 320);
            this.queryresolvedtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryresolvedtime.Name = "queryresolvedtime";
            this.queryresolvedtime.ShowUpDown = true;
            this.queryresolvedtime.Size = new System.Drawing.Size(126, 26);
            this.queryresolvedtime.TabIndex = 54;
            this.queryresolvedtime.ValueChanged += new System.EventHandler(this.queryresolvedtime_ValueChanged);
            this.queryresolvedtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryresolvedtime_KeyDown);
            this.queryresolvedtime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.queryresolvedtime_MouseDown);
            // 
            // queryresolveddate
            // 
            this.queryresolveddate.CustomFormat = " ";
            this.queryresolveddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.queryresolveddate.Location = new System.Drawing.Point(1377, 292);
            this.queryresolveddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryresolveddate.Name = "queryresolveddate";
            this.queryresolveddate.Size = new System.Drawing.Size(212, 26);
            this.queryresolveddate.TabIndex = 53;
            this.queryresolveddate.ValueChanged += new System.EventHandler(this.queryresolveddate_ValueChanged);
            this.queryresolveddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryresolveddate_KeyDown);
            // 
            // label_queryresolveddate
            // 
            this.label_queryresolveddate.AutoSize = true;
            this.label_queryresolveddate.Location = new System.Drawing.Point(1234, 293);
            this.label_queryresolveddate.Name = "label_queryresolveddate";
            this.label_queryresolveddate.Size = new System.Drawing.Size(125, 40);
            this.label_queryresolveddate.TabIndex = 52;
            this.label_queryresolveddate.Text = "Query Resolved \r\nDate";
            this.label_queryresolveddate.Click += new System.EventHandler(this.label17_Click);
            // 
            // queriedfor
            // 
            this.queriedfor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queriedfor.FormattingEnabled = true;
            this.queriedfor.Location = new System.Drawing.Point(500, 326);
            this.queriedfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queriedfor.Name = "queriedfor";
            this.queriedfor.Size = new System.Drawing.Size(274, 28);
            this.queriedfor.TabIndex = 48;
            this.queriedfor.DropDown += new System.EventHandler(this.queriedfor_DropDown);
            this.queriedfor.SelectedIndexChanged += new System.EventHandler(this.queriedfor_SelectedIndexChanged);
            // 
            // label_queriedfor
            // 
            this.label_queriedfor.AutoSize = true;
            this.label_queriedfor.Location = new System.Drawing.Point(390, 326);
            this.label_queriedfor.Name = "label_queriedfor";
            this.label_queriedfor.Size = new System.Drawing.Size(93, 20);
            this.label_queriedfor.TabIndex = 47;
            this.label_queriedfor.Text = "Queried For";
            this.label_queriedfor.Click += new System.EventHandler(this.label16_Click);
            // 
            // label_querycategory
            // 
            this.label_querycategory.AutoSize = true;
            this.label_querycategory.Location = new System.Drawing.Point(373, 293);
            this.label_querycategory.Name = "label_querycategory";
            this.label_querycategory.Size = new System.Drawing.Size(119, 20);
            this.label_querycategory.TabIndex = 45;
            this.label_querycategory.Text = "Query Category";
            this.label_querycategory.Click += new System.EventHandler(this.label15_Click);
            // 
            // querycategory
            // 
            this.querycategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.querycategory.FormattingEnabled = true;
            this.querycategory.Location = new System.Drawing.Point(500, 293);
            this.querycategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.querycategory.Name = "querycategory";
            this.querycategory.Size = new System.Drawing.Size(274, 28);
            this.querycategory.TabIndex = 46;
            this.querycategory.DropDown += new System.EventHandler(this.querycategory_DropDown);
            this.querycategory.SelectedIndexChanged += new System.EventHandler(this.querycategory_SelectedIndexChanged);
            // 
            // querytime
            // 
            this.querytime.CustomFormat = " ";
            this.querytime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.querytime.Location = new System.Drawing.Point(121, 323);
            this.querytime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.querytime.Name = "querytime";
            this.querytime.ShowUpDown = true;
            this.querytime.Size = new System.Drawing.Size(126, 26);
            this.querytime.TabIndex = 44;
            this.querytime.ValueChanged += new System.EventHandler(this.querytime_ValueChanged);
            this.querytime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.querytime_KeyDown);
            this.querytime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.querytime_MouseDown);
            // 
            // querydate
            // 
            this.querydate.CustomFormat = " ";
            this.querydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.querydate.Location = new System.Drawing.Point(121, 293);
            this.querydate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.querydate.Name = "querydate";
            this.querydate.Size = new System.Drawing.Size(246, 26);
            this.querydate.TabIndex = 43;
            this.querydate.ValueChanged += new System.EventHandler(this.querydate_ValueChanged);
            this.querydate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.querydate_KeyDown);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1191, 297);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 51;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label_querydate
            // 
            this.label_querydate.AutoSize = true;
            this.label_querydate.Location = new System.Drawing.Point(9, 293);
            this.label_querydate.Name = "label_querydate";
            this.label_querydate.Size = new System.Drawing.Size(109, 40);
            this.label_querydate.TabIndex = 42;
            this.label_querydate.Text = "Query Raised \r\nDate";
            this.label_querydate.Click += new System.EventHandler(this.label14_Click);
            // 
            // orgstatus
            // 
            this.orgstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgstatus.FormattingEnabled = true;
            this.orgstatus.Location = new System.Drawing.Point(650, 155);
            this.orgstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orgstatus.Name = "orgstatus";
            this.orgstatus.Size = new System.Drawing.Size(266, 28);
            this.orgstatus.TabIndex = 24;
            this.orgstatus.DropDown += new System.EventHandler(this.orgstatus_DropDown);
            this.orgstatus.SelectedIndexChanged += new System.EventHandler(this.orgstatus_SelectedIndexChanged);
            // 
            // label_orgstatus
            // 
            this.label_orgstatus.AutoSize = true;
            this.label_orgstatus.Location = new System.Drawing.Point(558, 155);
            this.label_orgstatus.Name = "label_orgstatus";
            this.label_orgstatus.Size = new System.Drawing.Size(86, 20);
            this.label_orgstatus.TabIndex = 23;
            this.label_orgstatus.Text = "Org Status";
            this.label_orgstatus.Click += new System.EventHandler(this.label10_Click);
            // 
            // orgid
            // 
            this.orgid.Location = new System.Drawing.Point(327, 154);
            this.orgid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orgid.Name = "orgid";
            this.orgid.Size = new System.Drawing.Size(230, 26);
            this.orgid.TabIndex = 22;
            this.orgid.TextChanged += new System.EventHandler(this.orgid_TextChanged);
            // 
            // label_orgid
            // 
            this.label_orgid.AutoSize = true;
            this.label_orgid.Location = new System.Drawing.Point(267, 152);
            this.label_orgid.Name = "label_orgid";
            this.label_orgid.Size = new System.Drawing.Size(53, 20);
            this.label_orgid.TabIndex = 21;
            this.label_orgid.Text = "Org Id";
            this.label_orgid.Click += new System.EventHandler(this.label9_Click);
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(60, 149);
            this.role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(205, 28);
            this.role.TabIndex = 20;
            this.role.DropDown += new System.EventHandler(this.role_DropDown);
            this.role.SelectedIndexChanged += new System.EventHandler(this.role_SelectedIndexChanged);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Location = new System.Drawing.Point(12, 149);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(42, 20);
            this.label_role.TabIndex = 19;
            this.label_role.Text = "Role";
            this.label_role.Click += new System.EventHandler(this.label8_Click);
            // 
            // bu
            // 
            this.bu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bu.FormattingEnabled = true;
            this.bu.Location = new System.Drawing.Point(918, 89);
            this.bu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bu.Name = "bu";
            this.bu.Size = new System.Drawing.Size(248, 28);
            this.bu.TabIndex = 16;
            this.bu.DropDown += new System.EventHandler(this.bu_DropDown);
            this.bu.SelectedIndexChanged += new System.EventHandler(this.bu_SelectedIndexChanged);
            this.bu.SelectionChangeCommitted += new System.EventHandler(this.bu_SelectionChangeCommitted);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchbypartyname);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.searchbyrequeststatus);
            this.tabPage1.Controls.Add(this.searchbyactivitytype);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.searchbyorgid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1890, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CVT Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // searchbypartyname
            // 
            this.searchbypartyname.Location = new System.Drawing.Point(225, 7);
            this.searchbypartyname.Name = "searchbypartyname";
            this.searchbypartyname.Size = new System.Drawing.Size(245, 26);
            this.searchbypartyname.TabIndex = 16;
            this.searchbypartyname.TextChanged += new System.EventHandler(this.searchbypartyname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search by Request Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search by Activity Type";
            // 
            // searchbyrequeststatus
            // 
            this.searchbyrequeststatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchbyrequeststatus.FormattingEnabled = true;
            this.searchbyrequeststatus.Location = new System.Drawing.Point(760, 7);
            this.searchbyrequeststatus.Name = "searchbyrequeststatus";
            this.searchbyrequeststatus.Size = new System.Drawing.Size(264, 28);
            this.searchbyrequeststatus.TabIndex = 13;
            this.searchbyrequeststatus.SelectedIndexChanged += new System.EventHandler(this.searchbyrequeststatus_SelectedIndexChanged);
            this.searchbyrequeststatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbyrequeststatus_KeyDown);
            // 
            // searchbyactivitytype
            // 
            this.searchbyactivitytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchbyactivitytype.FormattingEnabled = true;
            this.searchbyactivitytype.Location = new System.Drawing.Point(478, 7);
            this.searchbyactivitytype.Name = "searchbyactivitytype";
            this.searchbyactivitytype.Size = new System.Drawing.Size(263, 28);
            this.searchbyactivitytype.TabIndex = 12;
            this.searchbyactivitytype.SelectedIndexChanged += new System.EventHandler(this.searchbyactivitytype_SelectedIndexChanged);
            this.searchbyactivitytype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbyactivitytype_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTATMissCases,
            this.txtRequestId,
            this.txtActivityType,
            this.txtPartyName,
            this.txtReceivedDate,
            this.txtReceivedTime,
            this.txtRequestorEmailAddress,
            this.txtRequestorLocation,
            this.txtRequestorSegmentName,
            this.txtBU,
            this.txtLegalEntityName,
            this.txtRole,
            this.txtOrgID,
            this.txtOrgStatus,
            this.txtClientOnboardingFormRequired,
            this.txtVolumes,
            this.txtClientInformationFormSMSOExceptionDate,
            this.txtClientOnboardingVerificationCompleteDate,
            this.txtRICOpted,
            this.txtInflowProcessedBy,
            this.txtInflowProcessedDate,
            this.txtInflowProcessedTime,
            this.txtQueryDate,
            this.txtQueryTime,
            this.txtQueryCategory,
            this.txtQueriedFor,
            this.txtQueryResolvedDate,
            this.txtQueryResolvedTime,
            this.txtQueryRaisedBy,
            this.txtReQueryBy,
            this.txtReQueryDate,
            this.txtReQueryTime,
            this.txtApprovedDate,
            this.txtApprovedTime,
            this.txtApprovedBy,
            this.txtComments,
            this.txtPLCRequestID,
            this.txtUBO_ValidationDate,
            this.txtSubCategories_QC,
            this.txtCategories_QC,
            this.txtQCDate,
            this.txtQCDoneBy});
            this.dataGridView1.Location = new System.Drawing.Point(27, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1814, 281);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // txtTATMissCases
            // 
            this.txtTATMissCases.DataPropertyName = "TATMissCases";
            this.txtTATMissCases.HeaderText = "TATMissCases";
            this.txtTATMissCases.Name = "txtTATMissCases";
            this.txtTATMissCases.ReadOnly = true;
            this.txtTATMissCases.Visible = false;
            // 
            // txtRequestId
            // 
            this.txtRequestId.DataPropertyName = "RequestId";
            this.txtRequestId.HeaderText = "RequestId";
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.ReadOnly = true;
            // 
            // txtActivityType
            // 
            this.txtActivityType.DataPropertyName = "ActivityType";
            this.txtActivityType.HeaderText = "ActivityType";
            this.txtActivityType.Name = "txtActivityType";
            this.txtActivityType.ReadOnly = true;
            // 
            // txtPartyName
            // 
            this.txtPartyName.DataPropertyName = "PartyName";
            this.txtPartyName.HeaderText = "PartyName";
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.ReadOnly = true;
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.DataPropertyName = "ReceivedDate";
            this.txtReceivedDate.HeaderText = "ReceivedDate";
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.ReadOnly = true;
            // 
            // txtReceivedTime
            // 
            this.txtReceivedTime.DataPropertyName = "ReceivedTime";
            this.txtReceivedTime.HeaderText = "ReceivedTime";
            this.txtReceivedTime.Name = "txtReceivedTime";
            this.txtReceivedTime.ReadOnly = true;
            // 
            // txtRequestorEmailAddress
            // 
            this.txtRequestorEmailAddress.DataPropertyName = "RequestorEmailAddress";
            this.txtRequestorEmailAddress.HeaderText = "RequestorEmailAddress";
            this.txtRequestorEmailAddress.Name = "txtRequestorEmailAddress";
            this.txtRequestorEmailAddress.ReadOnly = true;
            // 
            // txtRequestorLocation
            // 
            this.txtRequestorLocation.DataPropertyName = "RequestorLocation";
            this.txtRequestorLocation.HeaderText = "RequestorLocation";
            this.txtRequestorLocation.Name = "txtRequestorLocation";
            this.txtRequestorLocation.ReadOnly = true;
            // 
            // txtRequestorSegmentName
            // 
            this.txtRequestorSegmentName.DataPropertyName = "RequestorSegmentName";
            this.txtRequestorSegmentName.HeaderText = "RequestorSegmentName";
            this.txtRequestorSegmentName.Name = "txtRequestorSegmentName";
            this.txtRequestorSegmentName.ReadOnly = true;
            // 
            // txtBU
            // 
            this.txtBU.DataPropertyName = "BU";
            this.txtBU.HeaderText = "BU";
            this.txtBU.Name = "txtBU";
            this.txtBU.ReadOnly = true;
            // 
            // txtLegalEntityName
            // 
            this.txtLegalEntityName.DataPropertyName = "LegalEntityName";
            this.txtLegalEntityName.HeaderText = "LegalEntityName";
            this.txtLegalEntityName.Name = "txtLegalEntityName";
            this.txtLegalEntityName.ReadOnly = true;
            // 
            // txtRole
            // 
            this.txtRole.DataPropertyName = "Role";
            this.txtRole.HeaderText = "Role";
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            // 
            // txtOrgID
            // 
            this.txtOrgID.DataPropertyName = "OrgID";
            this.txtOrgID.HeaderText = "OrgID";
            this.txtOrgID.Name = "txtOrgID";
            this.txtOrgID.ReadOnly = true;
            // 
            // txtOrgStatus
            // 
            this.txtOrgStatus.DataPropertyName = "OrgStatus";
            this.txtOrgStatus.HeaderText = "OrgStatus";
            this.txtOrgStatus.Name = "txtOrgStatus";
            this.txtOrgStatus.ReadOnly = true;
            // 
            // txtClientOnboardingFormRequired
            // 
            this.txtClientOnboardingFormRequired.DataPropertyName = "ClientOnboardingFormRequired";
            this.txtClientOnboardingFormRequired.HeaderText = "ClientOnboardingFormRequired";
            this.txtClientOnboardingFormRequired.Name = "txtClientOnboardingFormRequired";
            this.txtClientOnboardingFormRequired.ReadOnly = true;
            // 
            // txtVolumes
            // 
            this.txtVolumes.DataPropertyName = "Volumes";
            this.txtVolumes.HeaderText = "Volumes";
            this.txtVolumes.Name = "txtVolumes";
            this.txtVolumes.ReadOnly = true;
            // 
            // txtClientInformationFormSMSOExceptionDate
            // 
            this.txtClientInformationFormSMSOExceptionDate.DataPropertyName = "COF_SMSO_Received_Date";
            this.txtClientInformationFormSMSOExceptionDate.HeaderText = "ClientInformationFormSMSOExceptionDate";
            this.txtClientInformationFormSMSOExceptionDate.Name = "txtClientInformationFormSMSOExceptionDate";
            this.txtClientInformationFormSMSOExceptionDate.ReadOnly = true;
            // 
            // txtClientOnboardingVerificationCompleteDate
            // 
            this.txtClientOnboardingVerificationCompleteDate.DataPropertyName = "COF_Verification_Complete_Date";
            this.txtClientOnboardingVerificationCompleteDate.HeaderText = "ClientOnboardingVerificationCompleteDate";
            this.txtClientOnboardingVerificationCompleteDate.Name = "txtClientOnboardingVerificationCompleteDate";
            this.txtClientOnboardingVerificationCompleteDate.ReadOnly = true;
            // 
            // txtRICOpted
            // 
            this.txtRICOpted.DataPropertyName = "RICOpted";
            this.txtRICOpted.HeaderText = "RICOpted";
            this.txtRICOpted.Name = "txtRICOpted";
            this.txtRICOpted.ReadOnly = true;
            // 
            // txtInflowProcessedBy
            // 
            this.txtInflowProcessedBy.DataPropertyName = "InflowProcessedBy";
            this.txtInflowProcessedBy.HeaderText = "InflowProcessedBy";
            this.txtInflowProcessedBy.Name = "txtInflowProcessedBy";
            this.txtInflowProcessedBy.ReadOnly = true;
            // 
            // txtInflowProcessedDate
            // 
            this.txtInflowProcessedDate.DataPropertyName = "InflowProcessedDate";
            this.txtInflowProcessedDate.HeaderText = "InflowProcessedDate";
            this.txtInflowProcessedDate.Name = "txtInflowProcessedDate";
            this.txtInflowProcessedDate.ReadOnly = true;
            // 
            // txtInflowProcessedTime
            // 
            this.txtInflowProcessedTime.DataPropertyName = "InflowProcessedTime";
            this.txtInflowProcessedTime.HeaderText = "InflowProcessedTime";
            this.txtInflowProcessedTime.Name = "txtInflowProcessedTime";
            this.txtInflowProcessedTime.ReadOnly = true;
            // 
            // txtQueryDate
            // 
            this.txtQueryDate.DataPropertyName = "QueryDate";
            this.txtQueryDate.HeaderText = "QueryDate";
            this.txtQueryDate.Name = "txtQueryDate";
            this.txtQueryDate.ReadOnly = true;
            // 
            // txtQueryTime
            // 
            this.txtQueryTime.DataPropertyName = "QueryTime";
            this.txtQueryTime.HeaderText = "QueryTime";
            this.txtQueryTime.Name = "txtQueryTime";
            this.txtQueryTime.ReadOnly = true;
            // 
            // txtQueryCategory
            // 
            this.txtQueryCategory.DataPropertyName = "QueryCategory";
            this.txtQueryCategory.HeaderText = "QueryCategory";
            this.txtQueryCategory.Name = "txtQueryCategory";
            this.txtQueryCategory.ReadOnly = true;
            // 
            // txtQueriedFor
            // 
            this.txtQueriedFor.DataPropertyName = "QueriedFor";
            this.txtQueriedFor.HeaderText = "QueriedFor";
            this.txtQueriedFor.Name = "txtQueriedFor";
            this.txtQueriedFor.ReadOnly = true;
            // 
            // txtQueryResolvedDate
            // 
            this.txtQueryResolvedDate.DataPropertyName = "QueryResolvedDate";
            this.txtQueryResolvedDate.HeaderText = "QueryResolvedDate";
            this.txtQueryResolvedDate.Name = "txtQueryResolvedDate";
            this.txtQueryResolvedDate.ReadOnly = true;
            // 
            // txtQueryResolvedTime
            // 
            this.txtQueryResolvedTime.DataPropertyName = "QueryResolvedTime";
            this.txtQueryResolvedTime.HeaderText = "QueryResolvedTime";
            this.txtQueryResolvedTime.Name = "txtQueryResolvedTime";
            this.txtQueryResolvedTime.ReadOnly = true;
            // 
            // txtQueryRaisedBy
            // 
            this.txtQueryRaisedBy.DataPropertyName = "QueryRaisedBy";
            this.txtQueryRaisedBy.HeaderText = "QueryRaisedBy";
            this.txtQueryRaisedBy.Name = "txtQueryRaisedBy";
            this.txtQueryRaisedBy.ReadOnly = true;
            // 
            // txtReQueryBy
            // 
            this.txtReQueryBy.DataPropertyName = "ReQueryBy";
            this.txtReQueryBy.HeaderText = "ReQueryBy";
            this.txtReQueryBy.Name = "txtReQueryBy";
            this.txtReQueryBy.ReadOnly = true;
            // 
            // txtReQueryDate
            // 
            this.txtReQueryDate.DataPropertyName = "ReQueryDate";
            this.txtReQueryDate.HeaderText = "ReQueryDate";
            this.txtReQueryDate.Name = "txtReQueryDate";
            this.txtReQueryDate.ReadOnly = true;
            // 
            // txtReQueryTime
            // 
            this.txtReQueryTime.DataPropertyName = "ReQueryTime";
            this.txtReQueryTime.HeaderText = "ReQueryTime";
            this.txtReQueryTime.Name = "txtReQueryTime";
            this.txtReQueryTime.ReadOnly = true;
            // 
            // txtApprovedDate
            // 
            this.txtApprovedDate.DataPropertyName = "ApprovedDate";
            this.txtApprovedDate.HeaderText = "ApprovedDate";
            this.txtApprovedDate.Name = "txtApprovedDate";
            this.txtApprovedDate.ReadOnly = true;
            // 
            // txtApprovedTime
            // 
            this.txtApprovedTime.DataPropertyName = "ApprovedTime";
            this.txtApprovedTime.HeaderText = "ApprovedTime";
            this.txtApprovedTime.Name = "txtApprovedTime";
            this.txtApprovedTime.ReadOnly = true;
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.DataPropertyName = "ApprovedBy";
            this.txtApprovedBy.HeaderText = "ApprovedBy";
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.ReadOnly = true;
            // 
            // txtComments
            // 
            this.txtComments.DataPropertyName = "Comments";
            this.txtComments.HeaderText = "Comments";
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            // 
            // txtPLCRequestID
            // 
            this.txtPLCRequestID.DataPropertyName = "PLCRequestID";
            this.txtPLCRequestID.HeaderText = "PLCRequestID";
            this.txtPLCRequestID.Name = "txtPLCRequestID";
            this.txtPLCRequestID.ReadOnly = true;
            // 
            // txtUBO_ValidationDate
            // 
            this.txtUBO_ValidationDate.DataPropertyName = "UBO_ValidationDate";
            this.txtUBO_ValidationDate.HeaderText = "UBO_ValidationDate";
            this.txtUBO_ValidationDate.Name = "txtUBO_ValidationDate";
            this.txtUBO_ValidationDate.ReadOnly = true;
            // 
            // txtSubCategories_QC
            // 
            this.txtSubCategories_QC.DataPropertyName = "SubCategories_QC";
            this.txtSubCategories_QC.HeaderText = "SubCategories_QC";
            this.txtSubCategories_QC.Name = "txtSubCategories_QC";
            this.txtSubCategories_QC.ReadOnly = true;
            // 
            // txtCategories_QC
            // 
            this.txtCategories_QC.DataPropertyName = "Categories_QC";
            this.txtCategories_QC.HeaderText = "Categories_QC";
            this.txtCategories_QC.Name = "txtCategories_QC";
            this.txtCategories_QC.ReadOnly = true;
            // 
            // txtQCDate
            // 
            this.txtQCDate.DataPropertyName = "QCDate";
            this.txtQCDate.HeaderText = "QCDate";
            this.txtQCDate.Name = "txtQCDate";
            this.txtQCDate.ReadOnly = true;
            // 
            // txtQCDoneBy
            // 
            this.txtQCDoneBy.DataPropertyName = "QCDoneBy";
            this.txtQCDoneBy.HeaderText = "QCDoneBy";
            this.txtQCDoneBy.Name = "txtQCDoneBy";
            this.txtQCDoneBy.ReadOnly = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(248, 39);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(166, 20);
            this.label32.TabIndex = 9;
            this.label32.Text = "Search by Party Name";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(56, 42);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 20);
            this.label31.TabIndex = 8;
            this.label31.Text = "Search by Org ID";
            // 
            // searchbyorgid
            // 
            this.searchbyorgid.Location = new System.Drawing.Point(41, 7);
            this.searchbyorgid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchbyorgid.Name = "searchbyorgid";
            this.searchbyorgid.Size = new System.Drawing.Size(174, 26);
            this.searchbyorgid.TabIndex = 2;
            this.searchbyorgid.TextChanged += new System.EventHandler(this.searchbyorginflow_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 580);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1898, 414);
            this.tabControl1.TabIndex = 13;
            // 
            // label_bu
            // 
            this.label_bu.AutoSize = true;
            this.label_bu.Location = new System.Drawing.Point(880, 86);
            this.label_bu.Name = "label_bu";
            this.label_bu.Size = new System.Drawing.Size(32, 20);
            this.label_bu.TabIndex = 15;
            this.label_bu.Text = "BU";
            this.label_bu.Click += new System.EventHandler(this.label6_Click);
            // 
            // receivedtime
            // 
            this.receivedtime.CustomFormat = " ";
            this.receivedtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receivedtime.Location = new System.Drawing.Point(1173, 48);
            this.receivedtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receivedtime.Name = "receivedtime";
            this.receivedtime.ShowUpDown = true;
            this.receivedtime.Size = new System.Drawing.Size(128, 26);
            this.receivedtime.TabIndex = 8;
            this.receivedtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receivedtime_KeyDown);
            this.receivedtime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.receivedtime_MouseDown);
            // 
            // receiveddate
            // 
            this.receiveddate.CustomFormat = " ";
            this.receiveddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receiveddate.Location = new System.Drawing.Point(1173, 18);
            this.receiveddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiveddate.Name = "receiveddate";
            this.receiveddate.Size = new System.Drawing.Size(194, 26);
            this.receiveddate.TabIndex = 7;
            this.receiveddate.ValueChanged += new System.EventHandler(this.receiveddate_ValueChanged);
            this.receiveddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.receiveddate_KeyDown);
            // 
            // partyname
            // 
            this.partyname.Location = new System.Drawing.Point(753, 18);
            this.partyname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partyname.Multiline = true;
            this.partyname.Name = "partyname";
            this.partyname.Size = new System.Drawing.Size(281, 49);
            this.partyname.TabIndex = 5;
            // 
            // activitytype
            // 
            this.activitytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activitytype.FormattingEnabled = true;
            this.activitytype.Location = new System.Drawing.Point(340, 15);
            this.activitytype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activitytype.Name = "activitytype";
            this.activitytype.Size = new System.Drawing.Size(291, 28);
            this.activitytype.TabIndex = 3;
            this.activitytype.DropDown += new System.EventHandler(this.activitytype_DropDown);
            this.activitytype.SelectedIndexChanged += new System.EventHandler(this.activitytype_SelectedIndexChanged);
            this.activitytype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activitytype_KeyDown);
            // 
            // label_receiveddate
            // 
            this.label_receiveddate.AutoSize = true;
            this.label_receiveddate.Location = new System.Drawing.Point(1042, 15);
            this.label_receiveddate.Name = "label_receiveddate";
            this.label_receiveddate.Size = new System.Drawing.Size(114, 20);
            this.label_receiveddate.TabIndex = 6;
            this.label_receiveddate.Text = "Received Date";
            // 
            // label_partyname
            // 
            this.label_partyname.AutoSize = true;
            this.label_partyname.Location = new System.Drawing.Point(646, 21);
            this.label_partyname.Name = "label_partyname";
            this.label_partyname.Size = new System.Drawing.Size(91, 20);
            this.label_partyname.TabIndex = 4;
            this.label_partyname.Text = "Party Name";
            // 
            // label_activitytype
            // 
            this.label_activitytype.AutoSize = true;
            this.label_activitytype.Location = new System.Drawing.Point(244, 18);
            this.label_activitytype.Name = "label_activitytype";
            this.label_activitytype.Size = new System.Drawing.Size(96, 20);
            this.label_activitytype.TabIndex = 2;
            this.label_activitytype.Text = "Activity Type";
            // 
            // label_legalentityname
            // 
            this.label_legalentityname.AutoSize = true;
            this.label_legalentityname.Location = new System.Drawing.Point(1172, 92);
            this.label_legalentityname.Name = "label_legalentityname";
            this.label_legalentityname.Size = new System.Drawing.Size(138, 20);
            this.label_legalentityname.TabIndex = 17;
            this.label_legalentityname.Text = "Legal Entity Name";
            // 
            // legalentity
            // 
            this.legalentity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.legalentity.FormattingEnabled = true;
            this.legalentity.Location = new System.Drawing.Point(1316, 89);
            this.legalentity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.legalentity.Name = "legalentity";
            this.legalentity.Size = new System.Drawing.Size(568, 28);
            this.legalentity.TabIndex = 18;
            this.legalentity.DropDown += new System.EventHandler(this.legalentity_DropDown);
            this.legalentity.SelectedIndexChanged += new System.EventHandler(this.legalentity_SelectedIndexChanged);
            this.legalentity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.legalentity_KeyDown);
            // 
            // label_plcrequestid
            // 
            this.label_plcrequestid.AutoSize = true;
            this.label_plcrequestid.Location = new System.Drawing.Point(1120, 250);
            this.label_plcrequestid.Name = "label_plcrequestid";
            this.label_plcrequestid.Size = new System.Drawing.Size(121, 20);
            this.label_plcrequestid.TabIndex = 38;
            this.label_plcrequestid.Text = "PLC RequestID";
            // 
            // plcrequestid
            // 
            this.plcrequestid.Location = new System.Drawing.Point(1247, 252);
            this.plcrequestid.Name = "plcrequestid";
            this.plcrequestid.Size = new System.Drawing.Size(205, 26);
            this.plcrequestid.TabIndex = 39;
            // 
            // label_categoriesqc
            // 
            this.label_categoriesqc.AutoSize = true;
            this.label_categoriesqc.Location = new System.Drawing.Point(554, 468);
            this.label_categoriesqc.Name = "label_categoriesqc";
            this.label_categoriesqc.Size = new System.Drawing.Size(113, 20);
            this.label_categoriesqc.TabIndex = 73;
            this.label_categoriesqc.Text = "Categories QC";
            // 
            // label_qcdoneby
            // 
            this.label_qcdoneby.AutoSize = true;
            this.label_qcdoneby.Location = new System.Drawing.Point(1384, 476);
            this.label_qcdoneby.Name = "label_qcdoneby";
            this.label_qcdoneby.Size = new System.Drawing.Size(97, 20);
            this.label_qcdoneby.TabIndex = 77;
            this.label_qcdoneby.Text = "QC Done By";
            // 
            // label_subcategoriesqc
            // 
            this.label_subcategoriesqc.AutoSize = true;
            this.label_subcategoriesqc.Location = new System.Drawing.Point(14, 465);
            this.label_subcategoriesqc.Name = "label_subcategoriesqc";
            this.label_subcategoriesqc.Size = new System.Drawing.Size(146, 20);
            this.label_subcategoriesqc.TabIndex = 71;
            this.label_subcategoriesqc.Text = "Sub Categories QC";
            // 
            // label_qcdate
            // 
            this.label_qcdate.AutoSize = true;
            this.label_qcdate.Location = new System.Drawing.Point(1021, 473);
            this.label_qcdate.Name = "label_qcdate";
            this.label_qcdate.Size = new System.Drawing.Size(71, 20);
            this.label_qcdate.TabIndex = 75;
            this.label_qcdate.Text = "QC Date";
            // 
            // categories_qc
            // 
            this.categories_qc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_qc.FormattingEnabled = true;
            this.categories_qc.Location = new System.Drawing.Point(673, 468);
            this.categories_qc.Name = "categories_qc";
            this.categories_qc.Size = new System.Drawing.Size(324, 28);
            this.categories_qc.TabIndex = 74;
            this.categories_qc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categories_qc_KeyDown);
            // 
            // subcategories_qc
            // 
            this.subcategories_qc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subcategories_qc.FormattingEnabled = true;
            this.subcategories_qc.Location = new System.Drawing.Point(176, 465);
            this.subcategories_qc.Name = "subcategories_qc";
            this.subcategories_qc.Size = new System.Drawing.Size(356, 28);
            this.subcategories_qc.TabIndex = 72;
            this.subcategories_qc.SelectedIndexChanged += new System.EventHandler(this.subcategories_qc_SelectedIndexChanged);
            this.subcategories_qc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subcategories_qc_KeyDown);
            // 
            // qcdoneby
            // 
            this.qcdoneby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qcdoneby.FormattingEnabled = true;
            this.qcdoneby.Location = new System.Drawing.Point(1505, 476);
            this.qcdoneby.Name = "qcdoneby";
            this.qcdoneby.Size = new System.Drawing.Size(324, 28);
            this.qcdoneby.TabIndex = 78;
            this.qcdoneby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qcdoneby_KeyDown);
            // 
            // qcdate
            // 
            this.qcdate.CustomFormat = " ";
            this.qcdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qcdate.Location = new System.Drawing.Point(1107, 473);
            this.qcdate.Name = "qcdate";
            this.qcdate.Size = new System.Drawing.Size(252, 26);
            this.qcdate.TabIndex = 76;
            this.qcdate.ValueChanged += new System.EventHandler(this.qcdate_ValueChanged);
            this.qcdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qcdate_KeyDown);
            // 
            // label_cofverificationcompletedate
            // 
            this.label_cofverificationcompletedate.AutoSize = true;
            this.label_cofverificationcompletedate.Location = new System.Drawing.Point(693, 219);
            this.label_cofverificationcompletedate.Name = "label_cofverificationcompletedate";
            this.label_cofverificationcompletedate.Size = new System.Drawing.Size(125, 40);
            this.label_cofverificationcompletedate.TabIndex = 34;
            this.label_cofverificationcompletedate.Text = "COF Verification\r\nComplete Date ";
            this.label_cofverificationcompletedate.Click += new System.EventHandler(this.label_cofverificationcompletedate_Click);
            // 
            // label_cofsmsoreceiveddate
            // 
            this.label_cofsmsoreceiveddate.AutoSize = true;
            this.label_cofsmsoreceiveddate.Location = new System.Drawing.Point(294, 220);
            this.label_cofsmsoreceiveddate.Name = "label_cofsmsoreceiveddate";
            this.label_cofsmsoreceiveddate.Size = new System.Drawing.Size(114, 40);
            this.label_cofsmsoreceiveddate.TabIndex = 32;
            this.label_cofsmsoreceiveddate.Text = "COF SMSO \r\nReceived Date";
            // 
            // clientinformationformsmsoexceptiondate
            // 
            this.clientinformationformsmsoexceptiondate.CustomFormat = " ";
            this.clientinformationformsmsoexceptiondate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clientinformationformsmsoexceptiondate.Location = new System.Drawing.Point(416, 217);
            this.clientinformationformsmsoexceptiondate.Name = "clientinformationformsmsoexceptiondate";
            this.clientinformationformsmsoexceptiondate.Size = new System.Drawing.Size(255, 26);
            this.clientinformationformsmsoexceptiondate.TabIndex = 33;
            this.clientinformationformsmsoexceptiondate.ValueChanged += new System.EventHandler(this.clientinformationformsmsoexceptiondate_ValueChanged);
            this.clientinformationformsmsoexceptiondate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientinformationformsmsoexceptiondate_KeyDown);
            // 
            // clientonboardingverificationcompletedate
            // 
            this.clientonboardingverificationcompletedate.CustomFormat = " ";
            this.clientonboardingverificationcompletedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clientonboardingverificationcompletedate.Location = new System.Drawing.Point(839, 219);
            this.clientonboardingverificationcompletedate.Name = "clientonboardingverificationcompletedate";
            this.clientonboardingverificationcompletedate.Size = new System.Drawing.Size(260, 26);
            this.clientonboardingverificationcompletedate.TabIndex = 35;
            this.clientonboardingverificationcompletedate.ValueChanged += new System.EventHandler(this.clientonboardingverificationcompletedate_ValueChanged);
            this.clientonboardingverificationcompletedate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientonboardingverificationcompletedate_KeyDown);
            // 
            // label_clientonboardingformrequired
            // 
            this.label_clientonboardingformrequired.AutoSize = true;
            this.label_clientonboardingformrequired.Location = new System.Drawing.Point(9, 220);
            this.label_clientonboardingformrequired.Name = "label_clientonboardingformrequired";
            this.label_clientonboardingformrequired.Size = new System.Drawing.Size(136, 40);
            this.label_clientonboardingformrequired.TabIndex = 30;
            this.label_clientonboardingformrequired.Text = "Client Onboarding\r\nForm Required";
            // 
            // clientonboardingformrequired
            // 
            this.clientonboardingformrequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientonboardingformrequired.FormattingEnabled = true;
            this.clientonboardingformrequired.Location = new System.Drawing.Point(151, 220);
            this.clientonboardingformrequired.Name = "clientonboardingformrequired";
            this.clientonboardingformrequired.Size = new System.Drawing.Size(121, 28);
            this.clientonboardingformrequired.TabIndex = 31;
            this.clientonboardingformrequired.SelectedIndexChanged += new System.EventHandler(this.clientonboardingformrequired_SelectedIndexChanged);
            this.clientonboardingformrequired.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientonboardingformrequired_KeyDown);
            // 
            // label_ricopted
            // 
            this.label_ricopted.AutoSize = true;
            this.label_ricopted.Location = new System.Drawing.Point(1120, 219);
            this.label_ricopted.Name = "label_ricopted";
            this.label_ricopted.Size = new System.Drawing.Size(85, 20);
            this.label_ricopted.TabIndex = 36;
            this.label_ricopted.Text = "RIC Opted";
            // 
            // ricopted
            // 
            this.ricopted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ricopted.FormattingEnabled = true;
            this.ricopted.Location = new System.Drawing.Point(1247, 218);
            this.ricopted.Name = "ricopted";
            this.ricopted.Size = new System.Drawing.Size(121, 28);
            this.ricopted.TabIndex = 37;
            // 
            // label_inflowprocessedby
            // 
            this.label_inflowprocessedby.AutoSize = true;
            this.label_inflowprocessedby.Location = new System.Drawing.Point(933, 155);
            this.label_inflowprocessedby.Name = "label_inflowprocessedby";
            this.label_inflowprocessedby.Size = new System.Drawing.Size(130, 40);
            this.label_inflowprocessedby.TabIndex = 25;
            this.label_inflowprocessedby.Text = "Inflow Processed\r\nBy";
            // 
            // inflowprocessedby
            // 
            this.inflowprocessedby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inflowprocessedby.FormattingEnabled = true;
            this.inflowprocessedby.Location = new System.Drawing.Point(1087, 155);
            this.inflowprocessedby.Name = "inflowprocessedby";
            this.inflowprocessedby.Size = new System.Drawing.Size(266, 28);
            this.inflowprocessedby.TabIndex = 26;
            this.inflowprocessedby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inflowprocessedby_KeyDown);
            // 
            // label_inflowprocesseddate
            // 
            this.label_inflowprocesseddate.AutoSize = true;
            this.label_inflowprocesseddate.Location = new System.Drawing.Point(1384, 155);
            this.label_inflowprocesseddate.Name = "label_inflowprocesseddate";
            this.label_inflowprocesseddate.Size = new System.Drawing.Size(130, 40);
            this.label_inflowprocesseddate.TabIndex = 27;
            this.label_inflowprocesseddate.Text = "Inflow Processed\r\nDate";
            // 
            // inflowprocesseddate
            // 
            this.inflowprocesseddate.CustomFormat = " ";
            this.inflowprocesseddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inflowprocesseddate.Location = new System.Drawing.Point(1535, 155);
            this.inflowprocesseddate.Name = "inflowprocesseddate";
            this.inflowprocesseddate.Size = new System.Drawing.Size(253, 26);
            this.inflowprocesseddate.TabIndex = 28;
            this.inflowprocesseddate.ValueChanged += new System.EventHandler(this.inflowprocesseddate_ValueChanged);
            this.inflowprocesseddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inflowprocesseddate_KeyDown);
            // 
            // inflowprocessedtime
            // 
            this.inflowprocessedtime.CustomFormat = " ";
            this.inflowprocessedtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inflowprocessedtime.Location = new System.Drawing.Point(1535, 186);
            this.inflowprocessedtime.Name = "inflowprocessedtime";
            this.inflowprocessedtime.ShowUpDown = true;
            this.inflowprocessedtime.Size = new System.Drawing.Size(132, 26);
            this.inflowprocessedtime.TabIndex = 29;
            this.inflowprocessedtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inflowprocessedtime_KeyDown);
            this.inflowprocessedtime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inflowprocessedtime_MouseDown);
            // 
            // todaydate
            // 
            this.todaydate.Location = new System.Drawing.Point(1748, 527);
            this.todaydate.Name = "todaydate";
            this.todaydate.Size = new System.Drawing.Size(150, 26);
            this.todaydate.TabIndex = 95;
            // 
            // datagridview_click
            // 
            this.datagridview_click.Location = new System.Drawing.Point(1566, 525);
            this.datagridview_click.Name = "datagridview_click";
            this.datagridview_click.Size = new System.Drawing.Size(129, 34);
            this.datagridview_click.TabIndex = 96;
            this.datagridview_click.Text = "DataGridView";
            this.datagridview_click.UseVisualStyleBackColor = true;
            // 
            // label_requerydate
            // 
            this.label_requerydate.AutoSize = true;
            this.label_requerydate.Location = new System.Drawing.Point(9, 392);
            this.label_requerydate.Name = "label_requerydate";
            this.label_requerydate.Size = new System.Drawing.Size(108, 20);
            this.label_requerydate.TabIndex = 58;
            this.label_requerydate.Text = "Requery Date";
            // 
            // requerytime
            // 
            this.requerytime.CustomFormat = " ";
            this.requerytime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.requerytime.Location = new System.Drawing.Point(121, 419);
            this.requerytime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requerytime.Name = "requerytime";
            this.requerytime.ShowUpDown = true;
            this.requerytime.Size = new System.Drawing.Size(126, 26);
            this.requerytime.TabIndex = 60;
            this.requerytime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.requerytime_KeyDown);
            this.requerytime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.requerytime_MouseDown);
            // 
            // requerydate
            // 
            this.requerydate.CustomFormat = " ";
            this.requerydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.requerydate.Location = new System.Drawing.Point(121, 389);
            this.requerydate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requerydate.Name = "requerydate";
            this.requerydate.Size = new System.Drawing.Size(246, 26);
            this.requerydate.TabIndex = 59;
            this.requerydate.ValueChanged += new System.EventHandler(this.requerydate_ValueChanged);
            this.requerydate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.requerydate_KeyDown);
            // 
            // label_requeryby
            // 
            this.label_requeryby.AutoSize = true;
            this.label_requeryby.Location = new System.Drawing.Point(378, 390);
            this.label_requeryby.Name = "label_requeryby";
            this.label_requeryby.Size = new System.Drawing.Size(105, 20);
            this.label_requeryby.TabIndex = 61;
            this.label_requeryby.Text = "Requeried By";
            // 
            // requeryby
            // 
            this.requeryby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requeryby.FormattingEnabled = true;
            this.requeryby.Location = new System.Drawing.Point(489, 390);
            this.requeryby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requeryby.Name = "requeryby";
            this.requeryby.Size = new System.Drawing.Size(240, 28);
            this.requeryby.TabIndex = 62;
            this.requeryby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.requeryby_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1489, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "UBO Validation\r\nDate";
            // 
            // ubovalidationdate
            // 
            this.ubovalidationdate.CustomFormat = " ";
            this.ubovalidationdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ubovalidationdate.Location = new System.Drawing.Point(1613, 220);
            this.ubovalidationdate.Name = "ubovalidationdate";
            this.ubovalidationdate.Size = new System.Drawing.Size(238, 26);
            this.ubovalidationdate.TabIndex = 41;
            this.ubovalidationdate.ValueChanged += new System.EventHandler(this.ubovalidationdate_ValueChanged);
            this.ubovalidationdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ubovalidationdate_KeyDown);
            // 
            // mainpage
            // 
            this.mainpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mainpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpage.Location = new System.Drawing.Point(12, 10);
            this.mainpage.Name = "mainpage";
            this.mainpage.Size = new System.Drawing.Size(139, 33);
            this.mainpage.TabIndex = 97;
            this.mainpage.Text = "Main Page";
            this.mainpage.UseVisualStyleBackColor = false;
            this.mainpage.Click += new System.EventHandler(this.mainpage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 1005);
            this.Controls.Add(this.mainpage);
            this.Controls.Add(this.ubovalidationdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requeryby);
            this.Controls.Add(this.label_requeryby);
            this.Controls.Add(this.requerytime);
            this.Controls.Add(this.requerydate);
            this.Controls.Add(this.label_requerydate);
            this.Controls.Add(this.datagridview_click);
            this.Controls.Add(this.todaydate);
            this.Controls.Add(this.inflowprocessedtime);
            this.Controls.Add(this.inflowprocesseddate);
            this.Controls.Add(this.label_inflowprocesseddate);
            this.Controls.Add(this.inflowprocessedby);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label_inflowprocessedby);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ricopted);
            this.Controls.Add(this.label_ricopted);
            this.Controls.Add(this.clientonboardingformrequired);
            this.Controls.Add(this.label_clientonboardingformrequired);
            this.Controls.Add(this.clientonboardingverificationcompletedate);
            this.Controls.Add(this.clientinformationformsmsoexceptiondate);
            this.Controls.Add(this.label_cofsmsoreceiveddate);
            this.Controls.Add(this.label_cofverificationcompletedate);
            this.Controls.Add(this.qcdate);
            this.Controls.Add(this.qcdoneby);
            this.Controls.Add(this.subcategories_qc);
            this.Controls.Add(this.categories_qc);
            this.Controls.Add(this.label_qcdate);
            this.Controls.Add(this.label_subcategoriesqc);
            this.Controls.Add(this.label_qcdoneby);
            this.Controls.Add(this.label_categoriesqc);
            this.Controls.Add(this.plcrequestid);
            this.Controls.Add(this.label_plcrequestid);
            this.Controls.Add(this.legalentity);
            this.Controls.Add(this.label_legalentityname);
            this.Controls.Add(this.volumes);
            this.Controls.Add(this.label_volumes);
            this.Controls.Add(this.requestorsegmentname);
            this.Controls.Add(this.label_requestorsegmentname);
            this.Controls.Add(this.requestid);
            this.Controls.Add(this.label_requestid);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.label_comments);
            this.Controls.Add(this.requestorlocation);
            this.Controls.Add(this.label_requestorlocation);
            this.Controls.Add(this.requestoremailaddress);
            this.Controls.Add(this.label_requestoremailaddress);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.approvedby);
            this.Controls.Add(this.label_approvedby);
            this.Controls.Add(this.approvedtime);
            this.Controls.Add(this.approveddate);
            this.Controls.Add(this.label_approveddate);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.queryraisedby);
            this.Controls.Add(this.label_queryraisedby);
            this.Controls.Add(this.queryresolvedtime);
            this.Controls.Add(this.queryresolveddate);
            this.Controls.Add(this.label_queryresolveddate);
            this.Controls.Add(this.queriedfor);
            this.Controls.Add(this.label_queriedfor);
            this.Controls.Add(this.label_querycategory);
            this.Controls.Add(this.querycategory);
            this.Controls.Add(this.querytime);
            this.Controls.Add(this.querydate);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label_querydate);
            this.Controls.Add(this.orgstatus);
            this.Controls.Add(this.label_orgstatus);
            this.Controls.Add(this.orgid);
            this.Controls.Add(this.label_orgid);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.bu);
            this.Controls.Add(this.label_bu);
            this.Controls.Add(this.receivedtime);
            this.Controls.Add(this.receiveddate);
            this.Controls.Add(this.partyname);
            this.Controls.Add(this.activitytype);
            this.Controls.Add(this.label_receiveddate);
            this.Controls.Add(this.label_partyname);
            this.Controls.Add(this.label_activitytype);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CVT Workflow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown volumes;
        private System.Windows.Forms.Label label_volumes;
        private System.Windows.Forms.ComboBox requestorsegmentname;
        private System.Windows.Forms.Label label_requestorsegmentname;
        private System.Windows.Forms.TextBox requestid;
        private System.Windows.Forms.Label label_requestid;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label_comments;
        private System.Windows.Forms.ComboBox requestorlocation;
        private System.Windows.Forms.Label label_requestorlocation;
        private System.Windows.Forms.TextBox requestoremailaddress;
        private System.Windows.Forms.Label label_requestoremailaddress;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.ComboBox approvedby;
        private System.Windows.Forms.Label label_approvedby;
        private System.Windows.Forms.DateTimePicker approvedtime;
        private System.Windows.Forms.DateTimePicker approveddate;
        private System.Windows.Forms.Label label_approveddate;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox queryraisedby;
        private System.Windows.Forms.Label label_queryraisedby;
        private System.Windows.Forms.DateTimePicker queryresolvedtime;
        private System.Windows.Forms.DateTimePicker queryresolveddate;
        private System.Windows.Forms.Label label_queryresolveddate;
        private System.Windows.Forms.ComboBox queriedfor;
        private System.Windows.Forms.Label label_queriedfor;
        private System.Windows.Forms.Label label_querycategory;
        private System.Windows.Forms.ComboBox querycategory;
        private System.Windows.Forms.DateTimePicker querytime;
        private System.Windows.Forms.DateTimePicker querydate;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label_querydate;
        private System.Windows.Forms.ComboBox orgstatus;
        private System.Windows.Forms.Label label_orgstatus;
        private System.Windows.Forms.TextBox orgid;
        private System.Windows.Forms.Label label_orgid;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.ComboBox bu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox searchbyorgid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label_bu;
        private System.Windows.Forms.DateTimePicker receivedtime;
        private System.Windows.Forms.DateTimePicker receiveddate;
        private System.Windows.Forms.TextBox partyname;
        private System.Windows.Forms.ComboBox activitytype;
        private System.Windows.Forms.Label label_receiveddate;
        private System.Windows.Forms.Label label_partyname;
        private System.Windows.Forms.Label label_activitytype;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_legalentityname;
        private System.Windows.Forms.ComboBox legalentity;
        private System.Windows.Forms.Label label_plcrequestid;
        private System.Windows.Forms.TextBox plcrequestid;
        private System.Windows.Forms.Label label_categoriesqc;
        private System.Windows.Forms.Label label_qcdoneby;
        private System.Windows.Forms.Label label_subcategoriesqc;
        private System.Windows.Forms.Label label_qcdate;
        private System.Windows.Forms.ComboBox categories_qc;
        private System.Windows.Forms.ComboBox subcategories_qc;
        private System.Windows.Forms.ComboBox qcdoneby;
        private System.Windows.Forms.DateTimePicker qcdate;
        private System.Windows.Forms.Label label_cofverificationcompletedate;
        private System.Windows.Forms.Label label_cofsmsoreceiveddate;
        private System.Windows.Forms.DateTimePicker clientinformationformsmsoexceptiondate;
        private System.Windows.Forms.DateTimePicker clientonboardingverificationcompletedate;
        private System.Windows.Forms.Label label_clientonboardingformrequired;
        private System.Windows.Forms.ComboBox clientonboardingformrequired;
        private System.Windows.Forms.Label label_ricopted;
        private System.Windows.Forms.ComboBox ricopted;
        private System.Windows.Forms.Label label_inflowprocessedby;
        private System.Windows.Forms.ComboBox inflowprocessedby;
        private System.Windows.Forms.Label label_inflowprocesseddate;
        private System.Windows.Forms.DateTimePicker inflowprocesseddate;
        private System.Windows.Forms.DateTimePicker inflowprocessedtime;
        private System.Windows.Forms.DateTimePicker todaydate;
        private System.Windows.Forms.Button datagridview_click;
        private System.Windows.Forms.ComboBox searchbyrequeststatus;
        private System.Windows.Forms.ComboBox searchbyactivitytype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchbypartyname;
        private System.Windows.Forms.Label label_requerydate;
        private System.Windows.Forms.DateTimePicker requerytime;
        private System.Windows.Forms.DateTimePicker requerydate;
        private System.Windows.Forms.Label label_requeryby;
        private System.Windows.Forms.ComboBox requeryby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ubovalidationdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTATMissCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReceivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestorEmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestorLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRequestorSegmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLegalEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOrgStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClientOnboardingFormRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVolumes;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClientInformationFormSMSOExceptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClientOnboardingVerificationCompleteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRICOpted;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInflowProcessedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInflowProcessedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInflowProcessedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueryCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueriedFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueryResolvedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueryResolvedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueryRaisedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReQueryBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReQueryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReQueryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApprovedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApprovedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApprovedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPLCRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUBO_ValidationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubCategories_QC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategories_QC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQCDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQCDoneBy;
        private System.Windows.Forms.Button mainpage;

    }
}

