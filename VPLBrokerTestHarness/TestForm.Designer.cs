namespace VPLBrokerTestHarness
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.tabActions = new System.Windows.Forms.TabControl();
            this.tabBasicBrokerCallsPage = new System.Windows.Forms.TabPage();
            this.pnlReadTransactions = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFindHoldReason = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContactBroker = new System.Windows.Forms.Button();
            this.rdoGetQueue = new System.Windows.Forms.RadioButton();
            this.lblFrom = new System.Windows.Forms.Label();
            this.numPageNumber = new System.Windows.Forms.NumericUpDown();
            this.numRecordsPerPage = new System.Windows.Forms.NumericUpDown();
            this.rdoGetStats = new System.Windows.Forms.RadioButton();
            this.pnlQueueTypes = new System.Windows.Forms.Panel();
            this.rdoAccepted = new System.Windows.Forms.RadioButton();
            this.rdoRejected = new System.Windows.Forms.RadioButton();
            this.rdoCompleted = new System.Windows.Forms.RadioButton();
            this.rdoReceived = new System.Windows.Forms.RadioButton();
            this.lblMax = new System.Windows.Forms.Label();
            this.rdoGetReg = new System.Windows.Forms.RadioButton();
            this.pnlRegKey = new System.Windows.Forms.Panel();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.lblRegID = new System.Windows.Forms.Label();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.tvResults = new EPocalipse.Json.Viewer.JsonViewer();
            this.pnlRetrieveActions = new System.Windows.Forms.Panel();
            this.pnlMakeDecision = new System.Windows.Forms.Panel();
            this.txtReceiveVoterRegAppID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAltID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBlockResubmission = new System.Windows.Forms.CheckBox();
            this.btnHold = new System.Windows.Forms.Button();
            this.cboHoldReason = new System.Windows.Forms.ComboBox();
            this.cboRejectReason = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.tabQRCodeTestPage = new System.Windows.Forms.TabPage();
            this.pnlScanResults = new System.Windows.Forms.Panel();
            this.lvScanResults = new System.Windows.Forms.ListView();
            this.colDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVoterRegistrationApplicationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResults = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnScanAffidavits = new System.Windows.Forms.Button();
            this.lblScanInstructions = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlKeys = new System.Windows.Forms.Panel();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.rdoProduction = new System.Windows.Forms.RadioButton();
            this.rdoTest = new System.Windows.Forms.RadioButton();
            this.rdoLocalHost = new System.Windows.Forms.RadioButton();
            this.cboControllingDomain = new System.Windows.Forms.ComboBox();
            this.lblControllingDomain = new System.Windows.Forms.Label();
            this.stausStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lnkHub = new System.Windows.Forms.LinkLabel();
            this.tabActions.SuspendLayout();
            this.tabBasicBrokerCallsPage.SuspendLayout();
            this.pnlReadTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecordsPerPage)).BeginInit();
            this.pnlQueueTypes.SuspendLayout();
            this.pnlRegKey.SuspendLayout();
            this.pnlReturn.SuspendLayout();
            this.pnlRetrieveActions.SuspendLayout();
            this.pnlMakeDecision.SuspendLayout();
            this.tabQRCodeTestPage.SuspendLayout();
            this.pnlScanResults.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlKeys.SuspendLayout();
            this.stausStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabActions
            // 
            this.tabActions.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabActions.Controls.Add(this.tabBasicBrokerCallsPage);
            this.tabActions.Controls.Add(this.tabQRCodeTestPage);
            this.tabActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabActions.Location = new System.Drawing.Point(0, 0);
            this.tabActions.Margin = new System.Windows.Forms.Padding(2);
            this.tabActions.Multiline = true;
            this.tabActions.Name = "tabActions";
            this.tabActions.SelectedIndex = 0;
            this.tabActions.Size = new System.Drawing.Size(1482, 591);
            this.tabActions.TabIndex = 4;
            // 
            // tabBasicBrokerCallsPage
            // 
            this.tabBasicBrokerCallsPage.Controls.Add(this.pnlReadTransactions);
            this.tabBasicBrokerCallsPage.Controls.Add(this.pnlReturn);
            this.tabBasicBrokerCallsPage.Controls.Add(this.pnlRetrieveActions);
            this.tabBasicBrokerCallsPage.Location = new System.Drawing.Point(4, 4);
            this.tabBasicBrokerCallsPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabBasicBrokerCallsPage.Name = "tabBasicBrokerCallsPage";
            this.tabBasicBrokerCallsPage.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.tabBasicBrokerCallsPage.Size = new System.Drawing.Size(1474, 565);
            this.tabBasicBrokerCallsPage.TabIndex = 0;
            this.tabBasicBrokerCallsPage.Text = "Basic Broker Call Tests";
            this.tabBasicBrokerCallsPage.UseVisualStyleBackColor = true;
            // 
            // pnlReadTransactions
            // 
            this.pnlReadTransactions.BackColor = System.Drawing.Color.LightGray;
            this.pnlReadTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReadTransactions.Controls.Add(this.label6);
            this.pnlReadTransactions.Controls.Add(this.cboFindHoldReason);
            this.pnlReadTransactions.Controls.Add(this.label4);
            this.pnlReadTransactions.Controls.Add(this.btnContactBroker);
            this.pnlReadTransactions.Controls.Add(this.rdoGetQueue);
            this.pnlReadTransactions.Controls.Add(this.lblFrom);
            this.pnlReadTransactions.Controls.Add(this.numPageNumber);
            this.pnlReadTransactions.Controls.Add(this.numRecordsPerPage);
            this.pnlReadTransactions.Controls.Add(this.rdoGetStats);
            this.pnlReadTransactions.Controls.Add(this.pnlQueueTypes);
            this.pnlReadTransactions.Controls.Add(this.lblMax);
            this.pnlReadTransactions.Controls.Add(this.rdoGetReg);
            this.pnlReadTransactions.Controls.Add(this.pnlRegKey);
            this.pnlReadTransactions.Enabled = false;
            this.pnlReadTransactions.Location = new System.Drawing.Point(6, 32);
            this.pnlReadTransactions.Name = "pnlReadTransactions";
            this.pnlReadTransactions.Size = new System.Drawing.Size(730, 108);
            this.pnlReadTransactions.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(728, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Retrieval";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboFindHoldReason
            // 
            this.cboFindHoldReason.DisplayMember = "name";
            this.cboFindHoldReason.Enabled = false;
            this.cboFindHoldReason.FormattingEnabled = true;
            this.cboFindHoldReason.Location = new System.Drawing.Point(103, 80);
            this.cboFindHoldReason.Name = "cboFindHoldReason";
            this.cboFindHoldReason.Size = new System.Drawing.Size(274, 21);
            this.cboFindHoldReason.TabIndex = 29;
            this.cboFindHoldReason.ValueMember = "holdReasonId";
            this.cboFindHoldReason.DropDown += new System.EventHandler(this.cboFindHoldReason_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hold Reason:";
            // 
            // btnContactBroker
            // 
            this.btnContactBroker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContactBroker.Enabled = false;
            this.btnContactBroker.Location = new System.Drawing.Point(622, 72);
            this.btnContactBroker.Margin = new System.Windows.Forms.Padding(2);
            this.btnContactBroker.Name = "btnContactBroker";
            this.btnContactBroker.Size = new System.Drawing.Size(98, 29);
            this.btnContactBroker.TabIndex = 3;
            this.btnContactBroker.Text = "Contact Broker";
            this.btnContactBroker.UseVisualStyleBackColor = true;
            this.btnContactBroker.Click += new System.EventHandler(this.btnContactBroker_Click);
            // 
            // rdoGetQueue
            // 
            this.rdoGetQueue.AutoSize = true;
            this.rdoGetQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGetQueue.Location = new System.Drawing.Point(7, 28);
            this.rdoGetQueue.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGetQueue.Name = "rdoGetQueue";
            this.rdoGetQueue.Size = new System.Drawing.Size(86, 17);
            this.rdoGetQueue.TabIndex = 9;
            this.rdoGetQueue.TabStop = true;
            this.rdoGetQueue.Text = "Get Queue";
            this.rdoGetQueue.UseVisualStyleBackColor = true;
            this.rdoGetQueue.CheckedChanged += new System.EventHandler(this.rdoGetQueue_CheckedChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(130, 28);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(34, 13);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "page:";
            // 
            // numPageNumber
            // 
            this.numPageNumber.Enabled = false;
            this.numPageNumber.Location = new System.Drawing.Point(164, 25);
            this.numPageNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPageNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPageNumber.Name = "numPageNumber";
            this.numPageNumber.Size = new System.Drawing.Size(65, 20);
            this.numPageNumber.TabIndex = 15;
            this.numPageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRecordsPerPage
            // 
            this.numRecordsPerPage.Enabled = false;
            this.numRecordsPerPage.Location = new System.Drawing.Point(312, 25);
            this.numRecordsPerPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRecordsPerPage.Name = "numRecordsPerPage";
            this.numRecordsPerPage.Size = new System.Drawing.Size(65, 20);
            this.numRecordsPerPage.TabIndex = 17;
            this.numRecordsPerPage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rdoGetStats
            // 
            this.rdoGetStats.AutoSize = true;
            this.rdoGetStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGetStats.Location = new System.Drawing.Point(588, 28);
            this.rdoGetStats.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGetStats.Name = "rdoGetStats";
            this.rdoGetStats.Size = new System.Drawing.Size(78, 17);
            this.rdoGetStats.TabIndex = 11;
            this.rdoGetStats.TabStop = true;
            this.rdoGetStats.Text = "Get Stats";
            this.rdoGetStats.UseVisualStyleBackColor = true;
            this.rdoGetStats.CheckedChanged += new System.EventHandler(this.rdoGetStats_CheckedChanged);
            // 
            // pnlQueueTypes
            // 
            this.pnlQueueTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlQueueTypes.Controls.Add(this.rdoAccepted);
            this.pnlQueueTypes.Controls.Add(this.rdoRejected);
            this.pnlQueueTypes.Controls.Add(this.rdoCompleted);
            this.pnlQueueTypes.Controls.Add(this.rdoReceived);
            this.pnlQueueTypes.Enabled = false;
            this.pnlQueueTypes.Location = new System.Drawing.Point(24, 47);
            this.pnlQueueTypes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQueueTypes.Name = "pnlQueueTypes";
            this.pnlQueueTypes.Size = new System.Drawing.Size(353, 31);
            this.pnlQueueTypes.TabIndex = 12;
            // 
            // rdoAccepted
            // 
            this.rdoAccepted.AutoSize = true;
            this.rdoAccepted.Location = new System.Drawing.Point(186, 6);
            this.rdoAccepted.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAccepted.Name = "rdoAccepted";
            this.rdoAccepted.Size = new System.Drawing.Size(71, 17);
            this.rdoAccepted.TabIndex = 6;
            this.rdoAccepted.TabStop = true;
            this.rdoAccepted.Text = "Accepted";
            this.rdoAccepted.UseVisualStyleBackColor = true;
            this.rdoAccepted.CheckedChanged += new System.EventHandler(this.rdoAccepted_CheckedChanged);
            // 
            // rdoRejected
            // 
            this.rdoRejected.AutoSize = true;
            this.rdoRejected.Location = new System.Drawing.Point(276, 6);
            this.rdoRejected.Margin = new System.Windows.Forms.Padding(2);
            this.rdoRejected.Name = "rdoRejected";
            this.rdoRejected.Size = new System.Drawing.Size(68, 17);
            this.rdoRejected.TabIndex = 5;
            this.rdoRejected.TabStop = true;
            this.rdoRejected.Text = "Rejected";
            this.rdoRejected.UseVisualStyleBackColor = true;
            this.rdoRejected.CheckedChanged += new System.EventHandler(this.rdoRejected_CheckedChanged);
            // 
            // rdoCompleted
            // 
            this.rdoCompleted.AutoSize = true;
            this.rdoCompleted.Location = new System.Drawing.Point(2, 6);
            this.rdoCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCompleted.Name = "rdoCompleted";
            this.rdoCompleted.Size = new System.Drawing.Size(75, 17);
            this.rdoCompleted.TabIndex = 4;
            this.rdoCompleted.TabStop = true;
            this.rdoCompleted.Text = "Completed";
            this.rdoCompleted.UseVisualStyleBackColor = true;
            this.rdoCompleted.CheckedChanged += new System.EventHandler(this.rdoCompleted_CheckedChanged);
            // 
            // rdoReceived
            // 
            this.rdoReceived.AutoSize = true;
            this.rdoReceived.Location = new System.Drawing.Point(96, 6);
            this.rdoReceived.Margin = new System.Windows.Forms.Padding(2);
            this.rdoReceived.Name = "rdoReceived";
            this.rdoReceived.Size = new System.Drawing.Size(71, 17);
            this.rdoReceived.TabIndex = 3;
            this.rdoReceived.TabStop = true;
            this.rdoReceived.Text = "Received";
            this.rdoReceived.UseVisualStyleBackColor = true;
            this.rdoReceived.CheckedChanged += new System.EventHandler(this.rdoReceived_CheckedChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(245, 28);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(59, 13);
            this.lblMax.TabIndex = 16;
            this.lblMax.Text = "recs/page:";
            // 
            // rdoGetReg
            // 
            this.rdoGetReg.AutoSize = true;
            this.rdoGetReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGetReg.Location = new System.Drawing.Point(399, 26);
            this.rdoGetReg.Margin = new System.Windows.Forms.Padding(2);
            this.rdoGetReg.Name = "rdoGetReg";
            this.rdoGetReg.Size = new System.Drawing.Size(117, 17);
            this.rdoGetReg.TabIndex = 10;
            this.rdoGetReg.TabStop = true;
            this.rdoGetReg.Text = "Get Registration";
            this.rdoGetReg.UseVisualStyleBackColor = true;
            this.rdoGetReg.CheckedChanged += new System.EventHandler(this.rdoGetReg_CheckedChanged);
            // 
            // pnlRegKey
            // 
            this.pnlRegKey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRegKey.Controls.Add(this.txtRegID);
            this.pnlRegKey.Controls.Add(this.lblRegID);
            this.pnlRegKey.Enabled = false;
            this.pnlRegKey.Location = new System.Drawing.Point(419, 47);
            this.pnlRegKey.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegKey.Name = "pnlRegKey";
            this.pnlRegKey.Size = new System.Drawing.Size(152, 54);
            this.pnlRegKey.TabIndex = 13;
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(24, 21);
            this.txtRegID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(105, 20);
            this.txtRegID.TabIndex = 1;
            // 
            // lblRegID
            // 
            this.lblRegID.AutoSize = true;
            this.lblRegID.Location = new System.Drawing.Point(21, 5);
            this.lblRegID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegID.Name = "lblRegID";
            this.lblRegID.Size = new System.Drawing.Size(94, 13);
            this.lblRegID.TabIndex = 0;
            this.lblRegID.Text = "Voter Reg App ID:";
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.tvResults);
            this.pnlReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReturn.Location = new System.Drawing.Point(2, 146);
            this.pnlReturn.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReturn.Name = "pnlReturn";
            this.pnlReturn.Size = new System.Drawing.Size(1470, 417);
            this.pnlReturn.TabIndex = 11;
            // 
            // tvResults
            // 
            this.tvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResults.Json = "";
            this.tvResults.Location = new System.Drawing.Point(0, 0);
            this.tvResults.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(1470, 417);
            this.tvResults.TabIndex = 4;
            // 
            // pnlRetrieveActions
            // 
            this.pnlRetrieveActions.BackColor = System.Drawing.Color.LightGray;
            this.pnlRetrieveActions.Controls.Add(this.pnlMakeDecision);
            this.pnlRetrieveActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRetrieveActions.Location = new System.Drawing.Point(2, 30);
            this.pnlRetrieveActions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRetrieveActions.Name = "pnlRetrieveActions";
            this.pnlRetrieveActions.Size = new System.Drawing.Size(1470, 116);
            this.pnlRetrieveActions.TabIndex = 10;
            // 
            // pnlMakeDecision
            // 
            this.pnlMakeDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMakeDecision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMakeDecision.Controls.Add(this.txtReceiveVoterRegAppID);
            this.pnlMakeDecision.Controls.Add(this.label8);
            this.pnlMakeDecision.Controls.Add(this.txtAltID);
            this.pnlMakeDecision.Controls.Add(this.label7);
            this.pnlMakeDecision.Controls.Add(this.label5);
            this.pnlMakeDecision.Controls.Add(this.chkBlockResubmission);
            this.pnlMakeDecision.Controls.Add(this.btnHold);
            this.pnlMakeDecision.Controls.Add(this.cboHoldReason);
            this.pnlMakeDecision.Controls.Add(this.cboRejectReason);
            this.pnlMakeDecision.Controls.Add(this.label3);
            this.pnlMakeDecision.Controls.Add(this.btnReceive);
            this.pnlMakeDecision.Controls.Add(this.label2);
            this.pnlMakeDecision.Controls.Add(this.btnAccept);
            this.pnlMakeDecision.Controls.Add(this.btnReject);
            this.pnlMakeDecision.Enabled = false;
            this.pnlMakeDecision.Location = new System.Drawing.Point(740, 2);
            this.pnlMakeDecision.Name = "pnlMakeDecision";
            this.pnlMakeDecision.Size = new System.Drawing.Size(724, 106);
            this.pnlMakeDecision.TabIndex = 23;
            // 
            // txtReceiveVoterRegAppID
            // 
            this.txtReceiveVoterRegAppID.Location = new System.Drawing.Point(6, 44);
            this.txtReceiveVoterRegAppID.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiveVoterRegAppID.Name = "txtReceiveVoterRegAppID";
            this.txtReceiveVoterRegAppID.ReadOnly = true;
            this.txtReceiveVoterRegAppID.Size = new System.Drawing.Size(105, 20);
            this.txtReceiveVoterRegAppID.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Voter Reg App ID:";
            // 
            // txtAltID
            // 
            this.txtAltID.Enabled = false;
            this.txtAltID.Location = new System.Drawing.Point(132, 43);
            this.txtAltID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAltID.Name = "txtAltID";
            this.txtAltID.Size = new System.Drawing.Size(122, 20);
            this.txtAltID.TabIndex = 1;
            this.txtAltID.TextChanged += new System.EventHandler(this.txtAltID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "VSN:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(724, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Status Updates";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBlockResubmission
            // 
            this.chkBlockResubmission.AutoSize = true;
            this.chkBlockResubmission.Enabled = false;
            this.chkBlockResubmission.Location = new System.Drawing.Point(272, 74);
            this.chkBlockResubmission.Name = "chkBlockResubmission";
            this.chkBlockResubmission.Size = new System.Drawing.Size(115, 17);
            this.chkBlockResubmission.TabIndex = 29;
            this.chkBlockResubmission.Text = "block resubmission";
            this.chkBlockResubmission.UseVisualStyleBackColor = true;
            // 
            // btnHold
            // 
            this.btnHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHold.Enabled = false;
            this.btnHold.Location = new System.Drawing.Point(621, 72);
            this.btnHold.Margin = new System.Windows.Forms.Padding(2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(92, 29);
            this.btnHold.TabIndex = 28;
            this.btnHold.Text = "Put On Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // cboHoldReason
            // 
            this.cboHoldReason.DisplayMember = "name";
            this.cboHoldReason.Enabled = false;
            this.cboHoldReason.FormattingEnabled = true;
            this.cboHoldReason.Location = new System.Drawing.Point(499, 43);
            this.cboHoldReason.Name = "cboHoldReason";
            this.cboHoldReason.Size = new System.Drawing.Size(214, 21);
            this.cboHoldReason.TabIndex = 27;
            this.cboHoldReason.ValueMember = "holdReasonId";
            this.cboHoldReason.DropDown += new System.EventHandler(this.cboHoldReason_DropDown);
            this.cboHoldReason.SelectedIndexChanged += new System.EventHandler(this.cboHoldReason_SelectedIndexChanged);
            // 
            // cboRejectReason
            // 
            this.cboRejectReason.DisplayMember = "name";
            this.cboRejectReason.FormattingEnabled = true;
            this.cboRejectReason.Location = new System.Drawing.Point(272, 43);
            this.cboRejectReason.Name = "cboRejectReason";
            this.cboRejectReason.Size = new System.Drawing.Size(214, 21);
            this.cboRejectReason.TabIndex = 26;
            this.cboRejectReason.ValueMember = "rejectReasonId";
            this.cboRejectReason.DropDown += new System.EventHandler(this.cboRejectReason_DropDown);
            this.cboRejectReason.SelectedIndexChanged += new System.EventHandler(this.cboRejectReason_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hold Reason:";
            // 
            // btnReceive
            // 
            this.btnReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceive.Enabled = false;
            this.btnReceive.Location = new System.Drawing.Point(37, 71);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(74, 29);
            this.btnReceive.TabIndex = 18;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Reject Reason:";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(180, 72);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(74, 29);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReject.Enabled = false;
            this.btnReject.Location = new System.Drawing.Point(412, 72);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(74, 29);
            this.btnReject.TabIndex = 20;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // tabQRCodeTestPage
            // 
            this.tabQRCodeTestPage.Controls.Add(this.pnlScanResults);
            this.tabQRCodeTestPage.Controls.Add(this.btnScanAffidavits);
            this.tabQRCodeTestPage.Controls.Add(this.lblScanInstructions);
            this.tabQRCodeTestPage.Location = new System.Drawing.Point(4, 4);
            this.tabQRCodeTestPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabQRCodeTestPage.Name = "tabQRCodeTestPage";
            this.tabQRCodeTestPage.Padding = new System.Windows.Forms.Padding(2, 49, 2, 2);
            this.tabQRCodeTestPage.Size = new System.Drawing.Size(1474, 565);
            this.tabQRCodeTestPage.TabIndex = 1;
            this.tabQRCodeTestPage.Text = "QR Code Test";
            this.tabQRCodeTestPage.UseVisualStyleBackColor = true;
            // 
            // pnlScanResults
            // 
            this.pnlScanResults.Controls.Add(this.lvScanResults);
            this.pnlScanResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScanResults.Location = new System.Drawing.Point(2, 196);
            this.pnlScanResults.Name = "pnlScanResults";
            this.pnlScanResults.Size = new System.Drawing.Size(1470, 367);
            this.pnlScanResults.TabIndex = 3;
            // 
            // lvScanResults
            // 
            this.lvScanResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDateTime,
            this.colVoterRegistrationApplicationID,
            this.colResults});
            this.lvScanResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScanResults.Location = new System.Drawing.Point(0, 0);
            this.lvScanResults.Name = "lvScanResults";
            this.lvScanResults.Size = new System.Drawing.Size(1470, 367);
            this.lvScanResults.TabIndex = 3;
            this.lvScanResults.UseCompatibleStateImageBehavior = false;
            this.lvScanResults.View = System.Windows.Forms.View.Details;
            // 
            // colDateTime
            // 
            this.colDateTime.Text = "Date/Time";
            this.colDateTime.Width = 175;
            // 
            // colVoterRegistrationApplicationID
            // 
            this.colVoterRegistrationApplicationID.Text = "Voter Reg App ID";
            this.colVoterRegistrationApplicationID.Width = 120;
            // 
            // colResults
            // 
            this.colResults.Text = "Results";
            this.colResults.Width = 600;
            // 
            // btnScanAffidavits
            // 
            this.btnScanAffidavits.Location = new System.Drawing.Point(781, 107);
            this.btnScanAffidavits.Name = "btnScanAffidavits";
            this.btnScanAffidavits.Size = new System.Drawing.Size(153, 38);
            this.btnScanAffidavits.TabIndex = 1;
            this.btnScanAffidavits.Text = "Scan Affidavits";
            this.btnScanAffidavits.UseVisualStyleBackColor = true;
            this.btnScanAffidavits.Click += new System.EventHandler(this.btnScanAffidavits_Click);
            // 
            // lblScanInstructions
            // 
            this.lblScanInstructions.BackColor = System.Drawing.Color.LightGray;
            this.lblScanInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScanInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScanInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanInstructions.Location = new System.Drawing.Point(2, 49);
            this.lblScanInstructions.Name = "lblScanInstructions";
            this.lblScanInstructions.Size = new System.Drawing.Size(1470, 147);
            this.lblScanInstructions.TabIndex = 0;
            this.lblScanInstructions.Text = "Instructions:\r\n------------------------------------------------\r\n1. Place one or " +
    "more Affidavits in the scanner.\r\n2. Press [Scan Affidavits]\r\n3. View Results";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.Controls.Add(this.pnlKeys);
            this.pnlHeader.Controls.Add(this.rdoProduction);
            this.pnlHeader.Controls.Add(this.rdoTest);
            this.pnlHeader.Controls.Add(this.rdoLocalHost);
            this.pnlHeader.Controls.Add(this.cboControllingDomain);
            this.pnlHeader.Controls.Add(this.lblControllingDomain);
            this.pnlHeader.Location = new System.Drawing.Point(2, 1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1478, 34);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlKeys
            // 
            this.pnlKeys.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlKeys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKeys.Controls.Add(this.lnkHub);
            this.pnlKeys.Controls.Add(this.txtPrivateKey);
            this.pnlKeys.Controls.Add(this.label1);
            this.pnlKeys.Controls.Add(this.txtAPIKey);
            this.pnlKeys.Controls.Add(this.lblPrivateKey);
            this.pnlKeys.Location = new System.Drawing.Point(222, -1);
            this.pnlKeys.Name = "pnlKeys";
            this.pnlKeys.Size = new System.Drawing.Size(778, 35);
            this.pnlKeys.TabIndex = 18;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(556, 9);
            this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrivateKey.MaxLength = 36;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(212, 20);
            this.txtPrivateKey.TabIndex = 2;
            this.txtPrivateKey.TextChanged += new System.EventHandler(this.txtPrivateKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your API Key: ";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(213, 9);
            this.txtAPIKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPIKey.MaxLength = 36;
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(212, 20);
            this.txtAPIKey.TabIndex = 1;
            this.txtAPIKey.TextChanged += new System.EventHandler(this.txtAPIKey_TextChanged);
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(442, 12);
            this.lblPrivateKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(110, 13);
            this.lblPrivateKey.TabIndex = 16;
            this.lblPrivateKey.Text = "Account Private Key: ";
            // 
            // rdoProduction
            // 
            this.rdoProduction.AutoSize = true;
            this.rdoProduction.Location = new System.Drawing.Point(135, 10);
            this.rdoProduction.Margin = new System.Windows.Forms.Padding(2);
            this.rdoProduction.Name = "rdoProduction";
            this.rdoProduction.Size = new System.Drawing.Size(76, 17);
            this.rdoProduction.TabIndex = 13;
            this.rdoProduction.Text = "Production";
            this.rdoProduction.UseVisualStyleBackColor = true;
            // 
            // rdoTest
            // 
            this.rdoTest.AutoSize = true;
            this.rdoTest.Checked = true;
            this.rdoTest.Location = new System.Drawing.Point(85, 10);
            this.rdoTest.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTest.Name = "rdoTest";
            this.rdoTest.Size = new System.Drawing.Size(46, 17);
            this.rdoTest.TabIndex = 12;
            this.rdoTest.TabStop = true;
            this.rdoTest.Text = "Test";
            this.rdoTest.UseVisualStyleBackColor = true;
            // 
            // rdoLocalHost
            // 
            this.rdoLocalHost.AutoSize = true;
            this.rdoLocalHost.Location = new System.Drawing.Point(8, 10);
            this.rdoLocalHost.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLocalHost.Name = "rdoLocalHost";
            this.rdoLocalHost.Size = new System.Drawing.Size(73, 17);
            this.rdoLocalHost.TabIndex = 11;
            this.rdoLocalHost.Text = "LocalHost";
            this.rdoLocalHost.UseVisualStyleBackColor = true;
            // 
            // cboControllingDomain
            // 
            this.cboControllingDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboControllingDomain.DisplayMember = "Name";
            this.cboControllingDomain.Enabled = false;
            this.cboControllingDomain.FormattingEnabled = true;
            this.cboControllingDomain.Location = new System.Drawing.Point(1119, 8);
            this.cboControllingDomain.Margin = new System.Windows.Forms.Padding(2);
            this.cboControllingDomain.Name = "cboControllingDomain";
            this.cboControllingDomain.Size = new System.Drawing.Size(353, 21);
            this.cboControllingDomain.TabIndex = 3;
            this.cboControllingDomain.ValueMember = "DomainId";
            this.cboControllingDomain.DropDown += new System.EventHandler(this.cboControllingDomain_DropDown);
            this.cboControllingDomain.SelectedIndexChanged += new System.EventHandler(this.cboControllingDomain_SelectedIndexChanged);
            // 
            // lblControllingDomain
            // 
            this.lblControllingDomain.AutoSize = true;
            this.lblControllingDomain.Location = new System.Drawing.Point(1014, 12);
            this.lblControllingDomain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControllingDomain.Name = "lblControllingDomain";
            this.lblControllingDomain.Size = new System.Drawing.Size(101, 13);
            this.lblControllingDomain.TabIndex = 3;
            this.lblControllingDomain.Text = "Controlling Domain: ";
            // 
            // stausStrip
            // 
            this.stausStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.stausStrip.Location = new System.Drawing.Point(0, 569);
            this.stausStrip.Name = "stausStrip";
            this.stausStrip.Size = new System.Drawing.Size(1482, 22);
            this.stausStrip.TabIndex = 5;
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lnkHub
            // 
            this.lnkHub.AutoSize = true;
            this.lnkHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHub.Location = new System.Drawing.Point(3, 10);
            this.lnkHub.Name = "lnkHub";
            this.lnkHub.Size = new System.Drawing.Size(120, 16);
            this.lnkHub.TabIndex = 19;
            this.lnkHub.TabStop = true;
            this.lnkHub.Text = "Election Hub Keys:";
            this.lnkHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHub_LinkClicked);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 591);
            this.Controls.Add(this.stausStrip);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tabActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPL Broker Test Harness";
            this.tabActions.ResumeLayout(false);
            this.tabBasicBrokerCallsPage.ResumeLayout(false);
            this.pnlReadTransactions.ResumeLayout(false);
            this.pnlReadTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRecordsPerPage)).EndInit();
            this.pnlQueueTypes.ResumeLayout(false);
            this.pnlQueueTypes.PerformLayout();
            this.pnlRegKey.ResumeLayout(false);
            this.pnlRegKey.PerformLayout();
            this.pnlReturn.ResumeLayout(false);
            this.pnlRetrieveActions.ResumeLayout(false);
            this.pnlMakeDecision.ResumeLayout(false);
            this.pnlMakeDecision.PerformLayout();
            this.tabQRCodeTestPage.ResumeLayout(false);
            this.pnlScanResults.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKeys.ResumeLayout(false);
            this.pnlKeys.PerformLayout();
            this.stausStrip.ResumeLayout(false);
            this.stausStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TabControl tabActions;
        private System.Windows.Forms.TabPage tabBasicBrokerCallsPage;
        private System.Windows.Forms.TabPage tabQRCodeTestPage;
        private System.Windows.Forms.Button btnContactBroker;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cboControllingDomain;
        private System.Windows.Forms.Label lblControllingDomain;
        private System.Windows.Forms.Panel pnlRetrieveActions;
        private System.Windows.Forms.RadioButton rdoGetStats;
        private System.Windows.Forms.RadioButton rdoGetReg;
        private System.Windows.Forms.RadioButton rdoGetQueue;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.RadioButton rdoProduction;
        private System.Windows.Forms.RadioButton rdoTest;
        private System.Windows.Forms.RadioButton rdoLocalHost;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Panel pnlQueueTypes;
        private System.Windows.Forms.RadioButton rdoRejected;
        private System.Windows.Forms.RadioButton rdoCompleted;
        private System.Windows.Forms.RadioButton rdoReceived;
        private System.Windows.Forms.Panel pnlRegKey;
        private System.Windows.Forms.Label lblRegID;
        private System.Windows.Forms.TextBox txtRegID;
        private EPocalipse.Json.Viewer.JsonViewer tvResults;
        private System.Windows.Forms.RadioButton rdoAccepted;
        private System.Windows.Forms.NumericUpDown numRecordsPerPage;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numPageNumber;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMakeDecision;
        private System.Windows.Forms.Panel pnlReadTransactions;
        private System.Windows.Forms.Panel pnlScanResults;
        private System.Windows.Forms.ListView lvScanResults;
        private System.Windows.Forms.Button btnScanAffidavits;
        private System.Windows.Forms.Label lblScanInstructions;
        private System.Windows.Forms.ColumnHeader colVoterRegistrationApplicationID;
        private System.Windows.Forms.ColumnHeader colResults;
        private System.Windows.Forms.ColumnHeader colDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboHoldReason;
        private System.Windows.Forms.ComboBox cboRejectReason;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.StatusStrip stausStrip;
        private System.Windows.Forms.CheckBox chkBlockResubmission;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.ComboBox cboFindHoldReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAltID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReceiveVoterRegAppID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlKeys;
        private System.Windows.Forms.LinkLabel lnkHub;

    }
}

