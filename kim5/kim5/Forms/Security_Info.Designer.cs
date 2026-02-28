namespace kim5.Forms
{
    partial class frmSecurity_Info
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
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSecurityInfo = new System.Windows.Forms.GroupBox();
            this.cboSecurityExchange = new System.Windows.Forms.ComboBox();
            this.dtpDurableDate = new System.Windows.Forms.DateTimePicker();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPreportingId = new System.Windows.Forms.TextBox();
            this.txtAdpSecureId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustodyId = new System.Windows.Forms.TextBox();
            this.txtAdpSecurityId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.chkInDefault = new System.Windows.Forms.CheckBox();
            this.nudPriceFactor = new System.Windows.Forms.NumericUpDown();
            this.dtpDefaultSince = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCommenceDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpClassification = new System.Windows.Forms.GroupBox();
            this.cboUnderlyingCall = new System.Windows.Forms.ComboBox();
            this.cboIssueType = new System.Windows.Forms.ComboBox();
            this.cboInstrumentClass = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSecurityTypeCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grpIncomeInfo = new System.Windows.Forms.GroupBox();
            this.chkCouponFlag = new System.Windows.Forms.CheckBox();
            this.dtpNotifiedCallDate = new System.Windows.Forms.DateTimePicker();
            this.nudInterestDaily = new System.Windows.Forms.NumericUpDown();
            this.dtpPartDeslockDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIncomeIssueDate = new System.Windows.Forms.DateTimePicker();
            this.cboPayType = new System.Windows.Forms.ComboBox();
            this.cboPaceType = new System.Windows.Forms.ComboBox();
            this.dtpFirstCouponDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMaturityDate = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpSecurityInfo.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFactor)).BeginInit();
            this.grpClassification.SuspendLayout();
            this.grpIncomeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(35, 43);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(322, 61);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Security Info";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // grpSecurityInfo
            // 
            this.grpSecurityInfo.Controls.Add(this.cboSecurityExchange);
            this.grpSecurityInfo.Controls.Add(this.dtpDurableDate);
            this.grpSecurityInfo.Controls.Add(this.btnDiscard);
            this.grpSecurityInfo.Controls.Add(this.btnSave);
            this.grpSecurityInfo.Controls.Add(this.btnEdit);
            this.grpSecurityInfo.Controls.Add(this.txtPreportingId);
            this.grpSecurityInfo.Controls.Add(this.txtAdpSecureId);
            this.grpSecurityInfo.Controls.Add(this.label7);
            this.grpSecurityInfo.Controls.Add(this.label6);
            this.grpSecurityInfo.Controls.Add(this.label5);
            this.grpSecurityInfo.Controls.Add(this.txtCustodyId);
            this.grpSecurityInfo.Controls.Add(this.txtAdpSecurityId);
            this.grpSecurityInfo.Controls.Add(this.label4);
            this.grpSecurityInfo.Controls.Add(this.label3);
            this.grpSecurityInfo.Controls.Add(this.label1);
            this.grpSecurityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecurityInfo.Location = new System.Drawing.Point(28, 145);
            this.grpSecurityInfo.Name = "grpSecurityInfo";
            this.grpSecurityInfo.Size = new System.Drawing.Size(1371, 378);
            this.grpSecurityInfo.TabIndex = 4;
            this.grpSecurityInfo.TabStop = false;
            this.grpSecurityInfo.Text = "Security Information";
            this.grpSecurityInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboSecurityExchange
            // 
            this.cboSecurityExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSecurityExchange.FormattingEnabled = true;
            this.cboSecurityExchange.Location = new System.Drawing.Point(968, 219);
            this.cboSecurityExchange.Name = "cboSecurityExchange";
            this.cboSecurityExchange.Size = new System.Drawing.Size(355, 33);
            this.cboSecurityExchange.TabIndex = 22;
            // 
            // dtpDurableDate
            // 
            this.dtpDurableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDurableDate.Location = new System.Drawing.Point(264, 219);
            this.dtpDurableDate.Name = "dtpDurableDate";
            this.dtpDurableDate.Size = new System.Drawing.Size(355, 31);
            this.dtpDurableDate.TabIndex = 21;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Location = new System.Drawing.Point(352, 285);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(122, 50);
            this.btnDiscard.TabIndex = 19;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(209, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(71, 285);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 50);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtPreportingId
            // 
            this.txtPreportingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreportingId.Location = new System.Drawing.Point(968, 145);
            this.txtPreportingId.Name = "txtPreportingId";
            this.txtPreportingId.Size = new System.Drawing.Size(355, 31);
            this.txtPreportingId.TabIndex = 15;
            // 
            // txtAdpSecureId
            // 
            this.txtAdpSecureId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdpSecureId.Location = new System.Drawing.Point(968, 69);
            this.txtAdpSecureId.Name = "txtAdpSecureId";
            this.txtAdpSecureId.Size = new System.Drawing.Size(355, 31);
            this.txtAdpSecureId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Security Exchanges:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(800, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preporting ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "ADP Securl\'s ID:";
            // 
            // txtCustodyId
            // 
            this.txtCustodyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustodyId.Location = new System.Drawing.Point(264, 145);
            this.txtCustodyId.Name = "txtCustodyId";
            this.txtCustodyId.Size = new System.Drawing.Size(355, 31);
            this.txtCustodyId.TabIndex = 9;
            this.txtCustodyId.TextChanged += new System.EventHandler(this.txtCustodyID_TextChanged);
            // 
            // txtAdpSecurityId
            // 
            this.txtAdpSecurityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdpSecurityId.Location = new System.Drawing.Point(264, 69);
            this.txtAdpSecurityId.Name = "txtAdpSecurityId";
            this.txtAdpSecurityId.Size = new System.Drawing.Size(355, 31);
            this.txtAdpSecurityId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durable Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Custody ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = " ADP Security ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.Controls.Add(this.chkInDefault);
            this.grpBasicInfo.Controls.Add(this.nudPriceFactor);
            this.grpBasicInfo.Controls.Add(this.dtpDefaultSince);
            this.grpBasicInfo.Controls.Add(this.dtpIssueDate);
            this.grpBasicInfo.Controls.Add(this.dtpCommenceDate);
            this.grpBasicInfo.Controls.Add(this.label8);
            this.grpBasicInfo.Controls.Add(this.label9);
            this.grpBasicInfo.Controls.Add(this.label10);
            this.grpBasicInfo.Controls.Add(this.txtStateCode);
            this.grpBasicInfo.Controls.Add(this.label11);
            this.grpBasicInfo.Controls.Add(this.label12);
            this.grpBasicInfo.Controls.Add(this.label13);
            this.grpBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBasicInfo.Location = new System.Drawing.Point(28, 590);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(1371, 300);
            this.grpBasicInfo.TabIndex = 5;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Security Basic Information";
            this.grpBasicInfo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkInDefault
            // 
            this.chkInDefault.AutoSize = true;
            this.chkInDefault.Font = new System.Drawing.Font("Microsoft Tai Le", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInDefault.Location = new System.Drawing.Point(264, 129);
            this.chkInDefault.Name = "chkInDefault";
            this.chkInDefault.Size = new System.Drawing.Size(28, 27);
            this.chkInDefault.TabIndex = 28;
            this.chkInDefault.UseVisualStyleBackColor = true;
            // 
            // nudPriceFactor
            // 
            this.nudPriceFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPriceFactor.Location = new System.Drawing.Point(968, 205);
            this.nudPriceFactor.Name = "nudPriceFactor";
            this.nudPriceFactor.Size = new System.Drawing.Size(355, 31);
            this.nudPriceFactor.TabIndex = 27;
            // 
            // dtpDefaultSince
            // 
            this.dtpDefaultSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDefaultSince.Location = new System.Drawing.Point(968, 125);
            this.dtpDefaultSince.Name = "dtpDefaultSince";
            this.dtpDefaultSince.Size = new System.Drawing.Size(355, 31);
            this.dtpDefaultSince.TabIndex = 25;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Location = new System.Drawing.Point(968, 54);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(355, 31);
            this.dtpIssueDate.TabIndex = 24;
            // 
            // dtpCommenceDate
            // 
            this.dtpCommenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCommenceDate.Location = new System.Drawing.Point(264, 58);
            this.dtpCommenceDate.Name = "dtpCommenceDate";
            this.dtpCommenceDate.Size = new System.Drawing.Size(355, 31);
            this.dtpCommenceDate.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(828, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price Factor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "In Default Since:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(842, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Issue Date:";
            // 
            // txtStateCode
            // 
            this.txtStateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateCode.Location = new System.Drawing.Point(264, 204);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(355, 31);
            this.txtStateCode.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(133, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "State Code:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "In Default:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "Commence Date:";
            // 
            // grpClassification
            // 
            this.grpClassification.Controls.Add(this.cboUnderlyingCall);
            this.grpClassification.Controls.Add(this.cboIssueType);
            this.grpClassification.Controls.Add(this.cboInstrumentClass);
            this.grpClassification.Controls.Add(this.label15);
            this.grpClassification.Controls.Add(this.label16);
            this.grpClassification.Controls.Add(this.txtSecurityTypeCode);
            this.grpClassification.Controls.Add(this.label17);
            this.grpClassification.Controls.Add(this.label18);
            this.grpClassification.Controls.Add(this.label19);
            this.grpClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClassification.Location = new System.Drawing.Point(1480, 145);
            this.grpClassification.Name = "grpClassification";
            this.grpClassification.Size = new System.Drawing.Size(1371, 196);
            this.grpClassification.TabIndex = 6;
            this.grpClassification.TabStop = false;
            this.grpClassification.Text = "Security Classification";
            this.grpClassification.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cboUnderlyingCall
            // 
            this.cboUnderlyingCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnderlyingCall.FormattingEnabled = true;
            this.cboUnderlyingCall.Location = new System.Drawing.Point(968, 127);
            this.cboUnderlyingCall.Name = "cboUnderlyingCall";
            this.cboUnderlyingCall.Size = new System.Drawing.Size(355, 33);
            this.cboUnderlyingCall.TabIndex = 18;
            // 
            // cboIssueType
            // 
            this.cboIssueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIssueType.FormattingEnabled = true;
            this.cboIssueType.Location = new System.Drawing.Point(264, 128);
            this.cboIssueType.Name = "cboIssueType";
            this.cboIssueType.Size = new System.Drawing.Size(355, 33);
            this.cboIssueType.TabIndex = 17;
            // 
            // cboInstrumentClass
            // 
            this.cboInstrumentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInstrumentClass.FormattingEnabled = true;
            this.cboInstrumentClass.Location = new System.Drawing.Point(968, 64);
            this.cboInstrumentClass.Name = "cboInstrumentClass";
            this.cboInstrumentClass.Size = new System.Drawing.Size(355, 33);
            this.cboInstrumentClass.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(798, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Underlying Call:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(784, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "Instrument Class:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtSecurityTypeCode
            // 
            this.txtSecurityTypeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityTypeCode.Location = new System.Drawing.Point(264, 66);
            this.txtSecurityTypeCode.Name = "txtSecurityTypeCode";
            this.txtSecurityTypeCode.Size = new System.Drawing.Size(355, 31);
            this.txtSecurityTypeCode.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(119, 206);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 25);
            this.label17.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(135, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 25);
            this.label18.TabIndex = 6;
            this.label18.Text = "Issue Type:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(40, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(218, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "Security Types Code:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // grpIncomeInfo
            // 
            this.grpIncomeInfo.Controls.Add(this.chkCouponFlag);
            this.grpIncomeInfo.Controls.Add(this.dtpNotifiedCallDate);
            this.grpIncomeInfo.Controls.Add(this.nudInterestDaily);
            this.grpIncomeInfo.Controls.Add(this.dtpPartDeslockDate);
            this.grpIncomeInfo.Controls.Add(this.dtpIncomeIssueDate);
            this.grpIncomeInfo.Controls.Add(this.cboPayType);
            this.grpIncomeInfo.Controls.Add(this.cboPaceType);
            this.grpIncomeInfo.Controls.Add(this.dtpFirstCouponDate);
            this.grpIncomeInfo.Controls.Add(this.dtpMaturityDate);
            this.grpIncomeInfo.Controls.Add(this.label27);
            this.grpIncomeInfo.Controls.Add(this.label26);
            this.grpIncomeInfo.Controls.Add(this.label25);
            this.grpIncomeInfo.Controls.Add(this.label14);
            this.grpIncomeInfo.Controls.Add(this.label20);
            this.grpIncomeInfo.Controls.Add(this.label21);
            this.grpIncomeInfo.Controls.Add(this.label22);
            this.grpIncomeInfo.Controls.Add(this.label23);
            this.grpIncomeInfo.Controls.Add(this.label24);
            this.grpIncomeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIncomeInfo.Location = new System.Drawing.Point(1480, 402);
            this.grpIncomeInfo.Name = "grpIncomeInfo";
            this.grpIncomeInfo.Size = new System.Drawing.Size(1371, 488);
            this.grpIncomeInfo.TabIndex = 17;
            this.grpIncomeInfo.TabStop = false;
            this.grpIncomeInfo.Text = "Income Information";
            // 
            // chkCouponFlag
            // 
            this.chkCouponFlag.AutoSize = true;
            this.chkCouponFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCouponFlag.Location = new System.Drawing.Point(264, 408);
            this.chkCouponFlag.Name = "chkCouponFlag";
            this.chkCouponFlag.Size = new System.Drawing.Size(28, 27);
            this.chkCouponFlag.TabIndex = 36;
            this.chkCouponFlag.UseVisualStyleBackColor = true;
            // 
            // dtpNotifiedCallDate
            // 
            this.dtpNotifiedCallDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotifiedCallDate.Location = new System.Drawing.Point(957, 315);
            this.dtpNotifiedCallDate.Name = "dtpNotifiedCallDate";
            this.dtpNotifiedCallDate.Size = new System.Drawing.Size(355, 31);
            this.dtpNotifiedCallDate.TabIndex = 35;
            // 
            // nudInterestDaily
            // 
            this.nudInterestDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInterestDaily.Location = new System.Drawing.Point(264, 315);
            this.nudInterestDaily.Name = "nudInterestDaily";
            this.nudInterestDaily.Size = new System.Drawing.Size(355, 31);
            this.nudInterestDaily.TabIndex = 34;
            // 
            // dtpPartDeslockDate
            // 
            this.dtpPartDeslockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPartDeslockDate.Location = new System.Drawing.Point(957, 225);
            this.dtpPartDeslockDate.Name = "dtpPartDeslockDate";
            this.dtpPartDeslockDate.Size = new System.Drawing.Size(355, 31);
            this.dtpPartDeslockDate.TabIndex = 33;
            // 
            // dtpIncomeIssueDate
            // 
            this.dtpIncomeIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIncomeIssueDate.Location = new System.Drawing.Point(264, 225);
            this.dtpIncomeIssueDate.Name = "dtpIncomeIssueDate";
            this.dtpIncomeIssueDate.Size = new System.Drawing.Size(355, 31);
            this.dtpIncomeIssueDate.TabIndex = 32;
            // 
            // cboPayType
            // 
            this.cboPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayType.FormattingEnabled = true;
            this.cboPayType.Location = new System.Drawing.Point(957, 140);
            this.cboPayType.Name = "cboPayType";
            this.cboPayType.Size = new System.Drawing.Size(355, 33);
            this.cboPayType.TabIndex = 31;
            // 
            // cboPaceType
            // 
            this.cboPaceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaceType.FormattingEnabled = true;
            this.cboPaceType.Location = new System.Drawing.Point(264, 140);
            this.cboPaceType.Name = "cboPaceType";
            this.cboPaceType.Size = new System.Drawing.Size(355, 33);
            this.cboPaceType.TabIndex = 30;
            // 
            // dtpFirstCouponDate
            // 
            this.dtpFirstCouponDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstCouponDate.Location = new System.Drawing.Point(957, 62);
            this.dtpFirstCouponDate.Name = "dtpFirstCouponDate";
            this.dtpFirstCouponDate.Size = new System.Drawing.Size(355, 31);
            this.dtpFirstCouponDate.TabIndex = 29;
            // 
            // dtpMaturityDate
            // 
            this.dtpMaturityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMaturityDate.Location = new System.Drawing.Point(264, 63);
            this.dtpMaturityDate.Name = "dtpMaturityDate";
            this.dtpMaturityDate.Size = new System.Drawing.Size(355, 31);
            this.dtpMaturityDate.TabIndex = 28;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(117, 410);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(141, 25);
            this.label27.TabIndex = 22;
            this.label27.Text = "Coupon Flag:";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(760, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(191, 25);
            this.label26.TabIndex = 21;
            this.label26.Text = "Nonified Call Date:";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(115, 315);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(143, 25);
            this.label25.TabIndex = 20;
            this.label25.Text = "Interest Daily:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(746, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Part (Deslock) Date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(896, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 25);
            this.label20.TabIndex = 12;
            this.label20.Text = "Pay:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(810, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 25);
            this.label21.TabIndex = 11;
            this.label21.Text = "First Coupon:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(138, 231);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 25);
            this.label22.TabIndex = 7;
            this.label22.Text = "Issue Date:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(137, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 25);
            this.label23.TabIndex = 6;
            this.label23.Text = "Pace Type:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(112, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(146, 25);
            this.label24.TabIndex = 5;
            this.label24.Text = "Maturity Date:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(1337, 945);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 85);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmSecurity_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1042);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpIncomeInfo);
            this.Controls.Add(this.grpClassification);
            this.Controls.Add(this.grpBasicInfo);
            this.Controls.Add(this.grpSecurityInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Name = "frmSecurity_Info";
            this.Text = "Security_Info";
            this.grpSecurityInfo.ResumeLayout(false);
            this.grpSecurityInfo.PerformLayout();
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFactor)).EndInit();
            this.grpClassification.ResumeLayout(false);
            this.grpClassification.PerformLayout();
            this.grpIncomeInfo.ResumeLayout(false);
            this.grpIncomeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterestDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSecurityInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdpSecurityId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreportingId;
        private System.Windows.Forms.TextBox txtAdpSecureId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustodyId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpClassification;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSecurityTypeCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grpIncomeInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpDurableDate;
        private System.Windows.Forms.ComboBox cboSecurityExchange;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DateTimePicker dtpCommenceDate;
        private System.Windows.Forms.DateTimePicker dtpDefaultSince;
        private System.Windows.Forms.NumericUpDown nudPriceFactor;
        private System.Windows.Forms.ComboBox cboUnderlyingCall;
        private System.Windows.Forms.ComboBox cboIssueType;
        private System.Windows.Forms.ComboBox cboInstrumentClass;
        private System.Windows.Forms.DateTimePicker dtpNotifiedCallDate;
        private System.Windows.Forms.NumericUpDown nudInterestDaily;
        private System.Windows.Forms.DateTimePicker dtpPartDeslockDate;
        private System.Windows.Forms.DateTimePicker dtpIncomeIssueDate;
        private System.Windows.Forms.ComboBox cboPayType;
        private System.Windows.Forms.ComboBox cboPaceType;
        private System.Windows.Forms.DateTimePicker dtpFirstCouponDate;
        private System.Windows.Forms.DateTimePicker dtpMaturityDate;
        private System.Windows.Forms.CheckBox chkInDefault;
        private System.Windows.Forms.CheckBox chkCouponFlag;
    }
}