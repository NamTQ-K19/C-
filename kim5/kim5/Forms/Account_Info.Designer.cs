namespace kim5.Forms
{
    partial class frmAccount_Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkAutoProcessPurchasePro = new System.Windows.Forms.CheckBox();
            this.chkIncomeProApp = new System.Windows.Forms.CheckBox();
            this.chkSecondaryFlag = new System.Windows.Forms.CheckBox();
            this.chkAutoOptionPurchasePro = new System.Windows.Forms.CheckBox();
            this.chkAutoOptionCallCouponProcessing = new System.Windows.Forms.CheckBox();
            this.chkRTArchiveMethod = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtAccountLongName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpTerminationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCreationDateUtc = new System.Windows.Forms.DateTimePicker();
            this.nudCashBalance = new System.Windows.Forms.NumericUpDown();
            this.nudTransactions = new System.Windows.Forms.NumericUpDown();
            this.nudSpaceDailyAcc = new System.Windows.Forms.NumericUpDown();
            this.txtBalanceAccountNo = new System.Windows.Forms.TextBox();
            this.dtpInspectionDate = new System.Windows.Forms.DateTimePicker();
            this.txtBalanceAccountLongName = new System.Windows.Forms.TextBox();
            this.dtpLAffectDateUtc = new System.Windows.Forms.DateTimePicker();
            this.cboAIOperatingMethod = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cboAccountAssignment = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpaceDailyAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCOUNT INFO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSpaceDailyAcc);
            this.groupBox1.Controls.Add(this.nudTransactions);
            this.groupBox1.Controls.Add(this.nudCashBalance);
            this.groupBox1.Controls.Add(this.dtpCreationDateUtc);
            this.groupBox1.Controls.Add(this.dtpTerminationDate);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.txtAccountLongName);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Summary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboAccountAssignment);
            this.groupBox2.Controls.Add(this.cboPaymentMethod);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cboAIOperatingMethod);
            this.groupBox2.Controls.Add(this.chkRTArchiveMethod);
            this.groupBox2.Controls.Add(this.chkAutoOptionCallCouponProcessing);
            this.groupBox2.Controls.Add(this.chkAutoOptionPurchasePro);
            this.groupBox2.Controls.Add(this.chkSecondaryFlag);
            this.groupBox2.Controls.Add(this.chkIncomeProApp);
            this.groupBox2.Controls.Add(this.chkAutoProcessPurchasePro);
            this.groupBox2.Location = new System.Drawing.Point(941, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Flags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Long Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account #:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Group #:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teminattion Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Creation Date/ Time UTC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cash Balance: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Transactions:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Space Daily Acc:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpLAffectDateUtc);
            this.groupBox3.Controls.Add(this.txtBalanceAccountLongName);
            this.groupBox3.Controls.Add(this.dtpInspectionDate);
            this.groupBox3.Controls.Add(this.txtBalanceAccountNo);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(26, 514);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(884, 211);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Account #:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Account Long Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Inspection Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Laffect Date/ Time UTC:";
            // 
            // chkAutoProcessPurchasePro
            // 
            this.chkAutoProcessPurchasePro.AutoSize = true;
            this.chkAutoProcessPurchasePro.Location = new System.Drawing.Point(31, 56);
            this.chkAutoProcessPurchasePro.Name = "chkAutoProcessPurchasePro";
            this.chkAutoProcessPurchasePro.Size = new System.Drawing.Size(229, 24);
            this.chkAutoProcessPurchasePro.TabIndex = 0;
            this.chkAutoProcessPurchasePro.Text = "Auto Process Purchase Pro";
            this.chkAutoProcessPurchasePro.UseVisualStyleBackColor = true;
            // 
            // chkIncomeProApp
            // 
            this.chkIncomeProApp.AutoSize = true;
            this.chkIncomeProApp.Location = new System.Drawing.Point(31, 108);
            this.chkIncomeProApp.Name = "chkIncomeProApp";
            this.chkIncomeProApp.Size = new System.Drawing.Size(160, 24);
            this.chkIncomeProApp.TabIndex = 1;
            this.chkIncomeProApp.Text = "AIncome Pro App";
            this.chkIncomeProApp.UseVisualStyleBackColor = true;
            // 
            // chkSecondaryFlag
            // 
            this.chkSecondaryFlag.AutoSize = true;
            this.chkSecondaryFlag.Location = new System.Drawing.Point(31, 166);
            this.chkSecondaryFlag.Name = "chkSecondaryFlag";
            this.chkSecondaryFlag.Size = new System.Drawing.Size(146, 24);
            this.chkSecondaryFlag.TabIndex = 2;
            this.chkSecondaryFlag.Text = "Secondary Flag";
            this.chkSecondaryFlag.UseVisualStyleBackColor = true;
            // 
            // chkAutoOptionPurchasePro
            // 
            this.chkAutoOptionPurchasePro.AutoSize = true;
            this.chkAutoOptionPurchasePro.Location = new System.Drawing.Point(31, 224);
            this.chkAutoOptionPurchasePro.Name = "chkAutoOptionPurchasePro";
            this.chkAutoOptionPurchasePro.Size = new System.Drawing.Size(219, 24);
            this.chkAutoOptionPurchasePro.TabIndex = 3;
            this.chkAutoOptionPurchasePro.Text = "Auto Option Purchase Pro";
            this.chkAutoOptionPurchasePro.UseVisualStyleBackColor = true;
            // 
            // chkAutoOptionCallCouponProcessing
            // 
            this.chkAutoOptionCallCouponProcessing.AutoSize = true;
            this.chkAutoOptionCallCouponProcessing.Location = new System.Drawing.Point(31, 285);
            this.chkAutoOptionCallCouponProcessing.Name = "chkAutoOptionCallCouponProcessing";
            this.chkAutoOptionCallCouponProcessing.Size = new System.Drawing.Size(292, 24);
            this.chkAutoOptionCallCouponProcessing.TabIndex = 4;
            this.chkAutoOptionCallCouponProcessing.Text = "Auto Option Call Coupon Processing";
            this.chkAutoOptionCallCouponProcessing.UseVisualStyleBackColor = true;
            // 
            // chkRTArchiveMethod
            // 
            this.chkRTArchiveMethod.AutoSize = true;
            this.chkRTArchiveMethod.Location = new System.Drawing.Point(31, 341);
            this.chkRTArchiveMethod.Name = "chkRTArchiveMethod";
            this.chkRTArchiveMethod.Size = new System.Drawing.Size(170, 24);
            this.chkRTArchiveMethod.TabIndex = 5;
            this.chkRTArchiveMethod.Text = "RT Archive Method";
            this.chkRTArchiveMethod.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(952, 636);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 62);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(110, 58);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(226, 26);
            this.txtAccountNo.TabIndex = 9;
            // 
            // txtAccountLongName
            // 
            this.txtAccountLongName.Location = new System.Drawing.Point(542, 61);
            this.txtAccountLongName.Name = "txtAccountLongName";
            this.txtAccountLongName.Size = new System.Drawing.Size(296, 26);
            this.txtAccountLongName.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(110, 192);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(226, 26);
            this.dtpStartDate.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 12;
            // 
            // dtpTerminationDate
            // 
            this.dtpTerminationDate.Location = new System.Drawing.Point(535, 124);
            this.dtpTerminationDate.Name = "dtpTerminationDate";
            this.dtpTerminationDate.Size = new System.Drawing.Size(303, 26);
            this.dtpTerminationDate.TabIndex = 13;
            // 
            // dtpCreationDateUtc
            // 
            this.dtpCreationDateUtc.Location = new System.Drawing.Point(594, 193);
            this.dtpCreationDateUtc.Name = "dtpCreationDateUtc";
            this.dtpCreationDateUtc.Size = new System.Drawing.Size(256, 26);
            this.dtpCreationDateUtc.TabIndex = 14;
            // 
            // nudCashBalance
            // 
            this.nudCashBalance.Location = new System.Drawing.Point(129, 268);
            this.nudCashBalance.Name = "nudCashBalance";
            this.nudCashBalance.Size = new System.Drawing.Size(100, 26);
            this.nudCashBalance.TabIndex = 15;
            // 
            // nudTransactions
            // 
            this.nudTransactions.Location = new System.Drawing.Point(382, 262);
            this.nudTransactions.Name = "nudTransactions";
            this.nudTransactions.Size = new System.Drawing.Size(100, 26);
            this.nudTransactions.TabIndex = 16;
            // 
            // nudSpaceDailyAcc
            // 
            this.nudSpaceDailyAcc.Location = new System.Drawing.Point(717, 262);
            this.nudSpaceDailyAcc.Name = "nudSpaceDailyAcc";
            this.nudSpaceDailyAcc.Size = new System.Drawing.Size(100, 26);
            this.nudSpaceDailyAcc.TabIndex = 17;
            // 
            // txtBalanceAccountNo
            // 
            this.txtBalanceAccountNo.Location = new System.Drawing.Point(129, 47);
            this.txtBalanceAccountNo.Name = "txtBalanceAccountNo";
            this.txtBalanceAccountNo.Size = new System.Drawing.Size(226, 26);
            this.txtBalanceAccountNo.TabIndex = 18;
            // 
            // dtpInspectionDate
            // 
            this.dtpInspectionDate.Location = new System.Drawing.Point(591, 47);
            this.dtpInspectionDate.Name = "dtpInspectionDate";
            this.dtpInspectionDate.Size = new System.Drawing.Size(226, 26);
            this.dtpInspectionDate.TabIndex = 18;
            // 
            // txtBalanceAccountLongName
            // 
            this.txtBalanceAccountLongName.Location = new System.Drawing.Point(170, 104);
            this.txtBalanceAccountLongName.Name = "txtBalanceAccountLongName";
            this.txtBalanceAccountLongName.Size = new System.Drawing.Size(226, 26);
            this.txtBalanceAccountLongName.TabIndex = 19;
            // 
            // dtpLAffectDateUtc
            // 
            this.dtpLAffectDateUtc.Location = new System.Drawing.Point(641, 105);
            this.dtpLAffectDateUtc.Name = "dtpLAffectDateUtc";
            this.dtpLAffectDateUtc.Size = new System.Drawing.Size(226, 26);
            this.dtpLAffectDateUtc.TabIndex = 20;
            // 
            // cboAIOperatingMethod
            // 
            this.cboAIOperatingMethod.FormattingEnabled = true;
            this.cboAIOperatingMethod.Location = new System.Drawing.Point(504, 56);
            this.cboAIOperatingMethod.Name = "cboAIOperatingMethod";
            this.cboAIOperatingMethod.Size = new System.Drawing.Size(200, 28);
            this.cboAIOperatingMethod.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "AI Operating Method: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(340, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Payment Method: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Payment Method: ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(504, 106);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(200, 28);
            this.cboPaymentMethod.TabIndex = 21;
            // 
            // cboAccountAssignment
            // 
            this.cboAccountAssignment.FormattingEnabled = true;
            this.cboAccountAssignment.Location = new System.Drawing.Point(504, 170);
            this.cboAccountAssignment.Name = "cboAccountAssignment";
            this.cboAccountAssignment.Size = new System.Drawing.Size(200, 28);
            this.cboAccountAssignment.TabIndex = 22;
            // 
            // frmAccount_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 840);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmAccount_Info";
            this.Text = "Account_Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpaceDailyAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkAutoProcessPurchasePro;
        private System.Windows.Forms.CheckBox chkRTArchiveMethod;
        private System.Windows.Forms.CheckBox chkAutoOptionCallCouponProcessing;
        private System.Windows.Forms.CheckBox chkAutoOptionPurchasePro;
        private System.Windows.Forms.CheckBox chkSecondaryFlag;
        private System.Windows.Forms.CheckBox chkIncomeProApp;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtAccountLongName;
        private System.Windows.Forms.DateTimePicker dtpTerminationDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown nudSpaceDailyAcc;
        private System.Windows.Forms.NumericUpDown nudTransactions;
        private System.Windows.Forms.NumericUpDown nudCashBalance;
        private System.Windows.Forms.DateTimePicker dtpCreationDateUtc;
        private System.Windows.Forms.TextBox txtBalanceAccountNo;
        private System.Windows.Forms.DateTimePicker dtpInspectionDate;
        private System.Windows.Forms.DateTimePicker dtpLAffectDateUtc;
        private System.Windows.Forms.TextBox txtBalanceAccountLongName;
        private System.Windows.Forms.ComboBox cboAIOperatingMethod;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.ComboBox cboAccountAssignment;
    }
}