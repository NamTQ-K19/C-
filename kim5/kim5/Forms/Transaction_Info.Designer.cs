namespace kim5.Forms
{
    partial class frmTransaction_Info
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
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.grpDateRange = new System.Windows.Forms.GroupBox();
            this.dtpProcessingDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDateType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.cboTransactionSource = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCaExternalRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTransactionId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGpiTransactionType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTransactionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSecurity = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSecurityIdType = new System.Windows.Forms.ComboBox();
            this.btnClearSecurity = new System.Windows.Forms.Button();
            this.btnSearchSecurity = new System.Windows.Forms.Button();
            this.txtSecurityId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.btnClearAccount = new System.Windows.Forms.Button();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.btnCustomFilter = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboCurrentView = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalPages = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalRecords = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGoToPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.grpCriteria.SuspendLayout();
            this.grpDateRange.SuspendLayout();
            this.grpTransaction.SuspendLayout();
            this.grpSecurity.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.grpNavigation.SuspendLayout();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.grpDateRange);
            this.grpCriteria.Controls.Add(this.grpTransaction);
            this.grpCriteria.Controls.Add(this.grpSecurity);
            this.grpCriteria.Controls.Add(this.grpAccount);
            this.grpCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCriteria.Location = new System.Drawing.Point(34, 39);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Size = new System.Drawing.Size(1955, 829);
            this.grpCriteria.TabIndex = 5;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Criteria";
            // 
            // grpDateRange
            // 
            this.grpDateRange.Controls.Add(this.dtpProcessingDate);
            this.grpDateRange.Controls.Add(this.label12);
            this.grpDateRange.Controls.Add(this.dtpEndDate);
            this.grpDateRange.Controls.Add(this.label11);
            this.grpDateRange.Controls.Add(this.dtpBeginDate);
            this.grpDateRange.Controls.Add(this.label9);
            this.grpDateRange.Controls.Add(this.cboDateType);
            this.grpDateRange.Controls.Add(this.label10);
            this.grpDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDateRange.Location = new System.Drawing.Point(39, 597);
            this.grpDateRange.Name = "grpDateRange";
            this.grpDateRange.Size = new System.Drawing.Size(1862, 206);
            this.grpDateRange.TabIndex = 27;
            this.grpDateRange.TabStop = false;
            this.grpDateRange.Text = "Date Range";
            this.grpDateRange.Enter += new System.EventHandler(this.grpDateRange_Enter);
            // 
            // dtpProcessingDate
            // 
            this.dtpProcessingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProcessingDate.Location = new System.Drawing.Point(387, 148);
            this.dtpProcessingDate.Name = "dtpProcessingDate";
            this.dtpProcessingDate.Size = new System.Drawing.Size(355, 31);
            this.dtpProcessingDate.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(128, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Current Processing Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(1322, 69);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(355, 31);
            this.dtpEndDate.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1209, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "End Date:";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBeginDate.Location = new System.Drawing.Point(763, 69);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(355, 31);
            this.dtpBeginDate.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(635, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Begin Date:";
            // 
            // cboDateType
            // 
            this.cboDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDateType.FormattingEnabled = true;
            this.cboDateType.Location = new System.Drawing.Point(264, 69);
            this.cboDateType.Name = "cboDateType";
            this.cboDateType.Size = new System.Drawing.Size(280, 33);
            this.cboDateType.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Date Type:";
            // 
            // grpTransaction
            // 
            this.grpTransaction.Controls.Add(this.cboTransactionSource);
            this.grpTransaction.Controls.Add(this.label8);
            this.grpTransaction.Controls.Add(this.txtCaExternalRef);
            this.grpTransaction.Controls.Add(this.label7);
            this.grpTransaction.Controls.Add(this.cboTransactionId);
            this.grpTransaction.Controls.Add(this.label6);
            this.grpTransaction.Controls.Add(this.cboGpiTransactionType);
            this.grpTransaction.Controls.Add(this.label4);
            this.grpTransaction.Controls.Add(this.cboTransactionType);
            this.grpTransaction.Controls.Add(this.label5);
            this.grpTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransaction.Location = new System.Drawing.Point(39, 372);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Size = new System.Drawing.Size(1862, 204);
            this.grpTransaction.TabIndex = 27;
            this.grpTransaction.TabStop = false;
            this.grpTransaction.Text = "Transaction";
            // 
            // cboTransactionSource
            // 
            this.cboTransactionSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionSource.FormattingEnabled = true;
            this.cboTransactionSource.Location = new System.Drawing.Point(902, 140);
            this.cboTransactionSource.Name = "cboTransactionSource";
            this.cboTransactionSource.Size = new System.Drawing.Size(280, 33);
            this.cboTransactionSource.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(682, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Transaction Source:";
            // 
            // txtCaExternalRef
            // 
            this.txtCaExternalRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaExternalRef.Location = new System.Drawing.Point(264, 140);
            this.txtCaExternalRef.Name = "txtCaExternalRef";
            this.txtCaExternalRef.Size = new System.Drawing.Size(280, 31);
            this.txtCaExternalRef.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "CA External Reference:";
            // 
            // cboTransactionId
            // 
            this.cboTransactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionId.FormattingEnabled = true;
            this.cboTransactionId.Location = new System.Drawing.Point(1430, 69);
            this.cboTransactionId.Name = "cboTransactionId";
            this.cboTransactionId.Size = new System.Drawing.Size(280, 33);
            this.cboTransactionId.TabIndex = 29;
            this.cboTransactionId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1267, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Transaction ID:";
            // 
            // cboGpiTransactionType
            // 
            this.cboGpiTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGpiTransactionType.FormattingEnabled = true;
            this.cboGpiTransactionType.Location = new System.Drawing.Point(902, 69);
            this.cboGpiTransactionType.Name = "cboGpiTransactionType";
            this.cboGpiTransactionType.Size = new System.Drawing.Size(280, 33);
            this.cboGpiTransactionType.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "GPI Transaction Type ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboTransactionType
            // 
            this.cboTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionType.FormattingEnabled = true;
            this.cboTransactionType.Location = new System.Drawing.Point(264, 69);
            this.cboTransactionType.Name = "cboTransactionType";
            this.cboTransactionType.Size = new System.Drawing.Size(280, 33);
            this.cboTransactionType.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Transaction Type:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grpSecurity
            // 
            this.grpSecurity.Controls.Add(this.label3);
            this.grpSecurity.Controls.Add(this.cboSecurityIdType);
            this.grpSecurity.Controls.Add(this.btnClearSecurity);
            this.grpSecurity.Controls.Add(this.btnSearchSecurity);
            this.grpSecurity.Controls.Add(this.txtSecurityId);
            this.grpSecurity.Controls.Add(this.label2);
            this.grpSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecurity.Location = new System.Drawing.Point(39, 228);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Size = new System.Drawing.Size(1862, 119);
            this.grpSecurity.TabIndex = 24;
            this.grpSecurity.TabStop = false;
            this.grpSecurity.Text = "Security";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Security ID:";
            // 
            // cboSecurityIdType
            // 
            this.cboSecurityIdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSecurityIdType.FormattingEnabled = true;
            this.cboSecurityIdType.Location = new System.Drawing.Point(264, 69);
            this.cboSecurityIdType.Name = "cboSecurityIdType";
            this.cboSecurityIdType.Size = new System.Drawing.Size(280, 33);
            this.cboSecurityIdType.TabIndex = 25;
            // 
            // btnClearSecurity
            // 
            this.btnClearSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSecurity.Location = new System.Drawing.Point(1244, 69);
            this.btnClearSecurity.Name = "btnClearSecurity";
            this.btnClearSecurity.Size = new System.Drawing.Size(99, 34);
            this.btnClearSecurity.TabIndex = 23;
            this.btnClearSecurity.Text = "Clear";
            this.btnClearSecurity.UseVisualStyleBackColor = true;
            // 
            // btnSearchSecurity
            // 
            this.btnSearchSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSecurity.Location = new System.Drawing.Point(1124, 69);
            this.btnSearchSecurity.Name = "btnSearchSecurity";
            this.btnSearchSecurity.Size = new System.Drawing.Size(114, 34);
            this.btnSearchSecurity.TabIndex = 17;
            this.btnSearchSecurity.Text = "Search";
            this.btnSearchSecurity.UseVisualStyleBackColor = true;
            // 
            // txtSecurityId
            // 
            this.txtSecurityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityId.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSecurityId.Location = new System.Drawing.Point(763, 68);
            this.txtSecurityId.Name = "txtSecurityId";
            this.txtSecurityId.Size = new System.Drawing.Size(355, 31);
            this.txtSecurityId.TabIndex = 8;
            this.txtSecurityId.Text = "Enter key to search";
            this.txtSecurityId.TextChanged += new System.EventHandler(this.txtSecurityId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Security ID Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.btnClearAccount);
            this.grpAccount.Controls.Add(this.btnSearchAccount);
            this.grpAccount.Controls.Add(this.txtAccountNumber);
            this.grpAccount.Controls.Add(this.label1);
            this.grpAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(39, 82);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(1862, 119);
            this.grpAccount.TabIndex = 5;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Account";
            this.grpAccount.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnClearAccount
            // 
            this.btnClearAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAccount.Location = new System.Drawing.Point(682, 70);
            this.btnClearAccount.Name = "btnClearAccount";
            this.btnClearAccount.Size = new System.Drawing.Size(92, 36);
            this.btnClearAccount.TabIndex = 23;
            this.btnClearAccount.Text = "Clear";
            this.btnClearAccount.UseVisualStyleBackColor = true;
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccount.Location = new System.Drawing.Point(559, 69);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(108, 37);
            this.btnSearchAccount.TabIndex = 17;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = true;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAccountNumber.Location = new System.Drawing.Point(264, 69);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(280, 31);
            this.txtAccountNumber.TabIndex = 8;
            this.txtAccountNumber.Text = "Enter key to search";
            this.txtAccountNumber.TextChanged += new System.EventHandler(this.txtAccountNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpNavigation
            // 
            this.grpNavigation.Controls.Add(this.btnCustomFilter);
            this.grpNavigation.Controls.Add(this.btnFind);
            this.grpNavigation.Controls.Add(this.comboBox1);
            this.grpNavigation.Controls.Add(this.cboCurrentView);
            this.grpNavigation.Controls.Add(this.label16);
            this.grpNavigation.Controls.Add(this.txtTotalPages);
            this.grpNavigation.Controls.Add(this.label15);
            this.grpNavigation.Controls.Add(this.txtTotalRecords);
            this.grpNavigation.Controls.Add(this.label14);
            this.grpNavigation.Controls.Add(this.txtCurrentPage);
            this.grpNavigation.Controls.Add(this.label13);
            this.grpNavigation.Controls.Add(this.btnGoToPage);
            this.grpNavigation.Controls.Add(this.btnNextPage);
            this.grpNavigation.Controls.Add(this.btnPrevPage);
            this.grpNavigation.Controls.Add(this.btnLastPage);
            this.grpNavigation.Controls.Add(this.btnFirstPage);
            this.grpNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNavigation.Location = new System.Drawing.Point(34, 923);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(1901, 244);
            this.grpNavigation.TabIndex = 32;
            this.grpNavigation.TabStop = false;
            this.grpNavigation.Text = "Navigation";
            // 
            // btnCustomFilter
            // 
            this.btnCustomFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomFilter.Location = new System.Drawing.Point(1005, 176);
            this.btnCustomFilter.Name = "btnCustomFilter";
            this.btnCustomFilter.Size = new System.Drawing.Size(170, 34);
            this.btnCustomFilter.TabIndex = 43;
            this.btnCustomFilter.Text = "Custom Filter";
            this.btnCustomFilter.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(896, 176);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 34);
            this.btnFind.TabIndex = 42;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 33);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "View Actions";
            // 
            // cboCurrentView
            // 
            this.cboCurrentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurrentView.FormattingEnabled = true;
            this.cboCurrentView.Location = new System.Drawing.Point(202, 176);
            this.cboCurrentView.Name = "cboCurrentView";
            this.cboCurrentView.Size = new System.Drawing.Size(280, 33);
            this.cboCurrentView.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(55, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 25);
            this.label16.TabIndex = 39;
            this.label16.Text = "Current View:";
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPages.Location = new System.Drawing.Point(1474, 89);
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.Size = new System.Drawing.Size(128, 31);
            this.txtTotalPages.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1337, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 25);
            this.label15.TabIndex = 37;
            this.label15.Text = "Total pages:";
            // 
            // txtTotalRecords
            // 
            this.txtTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRecords.Location = new System.Drawing.Point(1163, 89);
            this.txtTotalRecords.Name = "txtTotalRecords";
            this.txtTotalRecords.Size = new System.Drawing.Size(128, 31);
            this.txtTotalRecords.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1000, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Total of record:";
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPage.Location = new System.Drawing.Point(806, 90);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(128, 31);
            this.txtCurrentPage.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(732, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Pape:";
            // 
            // btnGoToPage
            // 
            this.btnGoToPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToPage.Location = new System.Drawing.Point(612, 89);
            this.btnGoToPage.Name = "btnGoToPage";
            this.btnGoToPage.Size = new System.Drawing.Size(84, 34);
            this.btnGoToPage.TabIndex = 22;
            this.btnGoToPage.Text = "Go to";
            this.btnGoToPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(303, 89);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(84, 34);
            this.btnNextPage.TabIndex = 21;
            this.btnNextPage.Text = "> >";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.Location = new System.Drawing.Point(187, 89);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(84, 34);
            this.btnPrevPage.TabIndex = 20;
            this.btnPrevPage.Text = "< <";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.Location = new System.Drawing.Point(435, 89);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(84, 34);
            this.btnLastPage.TabIndex = 19;
            this.btnLastPage.Text = "> > |";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.Location = new System.Drawing.Point(60, 89);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(84, 34);
            this.btnFirstPage.TabIndex = 18;
            this.btnFirstPage.Text = "| < <";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.dgvTransactions);
            this.grpResult.Controls.Add(this.label17);
            this.grpResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResult.Location = new System.Drawing.Point(34, 1230);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(1901, 435);
            this.grpResult.TabIndex = 33;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(504, 25);
            this.label17.TabIndex = 45;
            this.label17.Text = "Drag a column header here to group by that column";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(39, 121);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 82;
            this.dgvTransactions.RowTemplate.Height = 33;
            this.dgvTransactions.Size = new System.Drawing.Size(1820, 280);
            this.dgvTransactions.TabIndex = 46;
            // 
            // frmTransaction_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2136, 1755);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.grpCriteria);
            this.Name = "frmTransaction_Info";
            this.Text = "Transaction_Info";
            this.Load += new System.EventHandler(this.frmTransaction_Info_Load);
            this.grpCriteria.ResumeLayout(false);
            this.grpDateRange.ResumeLayout(false);
            this.grpDateRange.PerformLayout();
            this.grpTransaction.ResumeLayout(false);
            this.grpTransaction.PerformLayout();
            this.grpSecurity.ResumeLayout(false);
            this.grpSecurity.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpNavigation.ResumeLayout(false);
            this.grpNavigation.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCriteria;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.Button btnSearchAccount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearAccount;
        private System.Windows.Forms.GroupBox grpSecurity;
        private System.Windows.Forms.Button btnClearSecurity;
        private System.Windows.Forms.TextBox txtSecurityId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSecurityIdType;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTransactionType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGpiTransactionType;
        private System.Windows.Forms.ComboBox cboTransactionId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCaExternalRef;
        private System.Windows.Forms.GroupBox grpDateRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDateType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTransactionSource;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpProcessingDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnGoToPage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTotalPages;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalRecords;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCurrentPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboCurrentView;
        private System.Windows.Forms.Button btnSearchSecurity;
        private System.Windows.Forms.Button btnCustomFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label17;
    }
}