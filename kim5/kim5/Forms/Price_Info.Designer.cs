namespace kim5.Forms
{
    partial class frmPrice_Info
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSecurities = new System.Windows.Forms.DataGridView();
            this.cboSecurityIdType = new System.Windows.Forms.ComboBox();
            this.txtSecurityId = new System.Windows.Forms.TextBox();
            this.btnSearchSecurityId = new System.Windows.Forms.Button();
            this.btnClearSecurityId = new System.Windows.Forms.Button();
            this.dtpEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.txtSecurityName = new System.Windows.Forms.TextBox();
            this.cboCurrentView = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCustomFilter = new System.Windows.Forms.Button();
            this.cboViewActions = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRICE_INFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSecurityName);
            this.groupBox1.Controls.Add(this.dtpEffectiveDate);
            this.groupBox1.Controls.Add(this.btnClearSecurityId);
            this.groupBox1.Controls.Add(this.btnSearchSecurityId);
            this.groupBox1.Controls.Add(this.txtSecurityId);
            this.groupBox1.Controls.Add(this.cboSecurityIdType);
            this.groupBox1.Controls.Add(this.dgvSecurities);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1271, 637);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Security ID Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Effective Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Security ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Security Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.btnCustomFilter);
            this.groupBox2.Controls.Add(this.cboViewActions);
            this.groupBox2.Controls.Add(this.cboCurrentView);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(27, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1158, 102);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Current View:";
            // 
            // dgvSecurities
            // 
            this.dgvSecurities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurities.Location = new System.Drawing.Point(27, 378);
            this.dgvSecurities.Name = "dgvSecurities";
            this.dgvSecurities.RowHeadersWidth = 62;
            this.dgvSecurities.RowTemplate.Height = 28;
            this.dgvSecurities.Size = new System.Drawing.Size(1158, 233);
            this.dgvSecurities.TabIndex = 8;
            // 
            // cboSecurityIdType
            // 
            this.cboSecurityIdType.FormattingEnabled = true;
            this.cboSecurityIdType.Location = new System.Drawing.Point(183, 60);
            this.cboSecurityIdType.Name = "cboSecurityIdType";
            this.cboSecurityIdType.Size = new System.Drawing.Size(316, 28);
            this.cboSecurityIdType.TabIndex = 9;
            // 
            // txtSecurityId
            // 
            this.txtSecurityId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSecurityId.Location = new System.Drawing.Point(747, 62);
            this.txtSecurityId.Name = "txtSecurityId";
            this.txtSecurityId.Size = new System.Drawing.Size(327, 26);
            this.txtSecurityId.TabIndex = 10;
            this.txtSecurityId.Text = "Enter key to search";
            // 
            // btnSearchSecurityId
            // 
            this.btnSearchSecurityId.Location = new System.Drawing.Point(1070, 60);
            this.btnSearchSecurityId.Name = "btnSearchSecurityId";
            this.btnSearchSecurityId.Size = new System.Drawing.Size(88, 31);
            this.btnSearchSecurityId.TabIndex = 11;
            this.btnSearchSecurityId.Text = "Search";
            this.btnSearchSecurityId.UseVisualStyleBackColor = true;
            // 
            // btnClearSecurityId
            // 
            this.btnClearSecurityId.Location = new System.Drawing.Point(1151, 60);
            this.btnClearSecurityId.Name = "btnClearSecurityId";
            this.btnClearSecurityId.Size = new System.Drawing.Size(89, 31);
            this.btnClearSecurityId.TabIndex = 12;
            this.btnClearSecurityId.Text = "Clear";
            this.btnClearSecurityId.UseVisualStyleBackColor = true;
            // 
            // dtpEffectiveDate
            // 
            this.dtpEffectiveDate.Location = new System.Drawing.Point(183, 123);
            this.dtpEffectiveDate.Name = "dtpEffectiveDate";
            this.dtpEffectiveDate.Size = new System.Drawing.Size(316, 26);
            this.dtpEffectiveDate.TabIndex = 13;
            // 
            // txtSecurityName
            // 
            this.txtSecurityName.Location = new System.Drawing.Point(747, 127);
            this.txtSecurityName.Name = "txtSecurityName";
            this.txtSecurityName.Size = new System.Drawing.Size(438, 26);
            this.txtSecurityName.TabIndex = 14;
            // 
            // cboCurrentView
            // 
            this.cboCurrentView.FormattingEnabled = true;
            this.cboCurrentView.Location = new System.Drawing.Point(156, 40);
            this.cboCurrentView.Name = "cboCurrentView";
            this.cboCurrentView.Size = new System.Drawing.Size(316, 28);
            this.cboCurrentView.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(756, 33);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 40);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnCustomFilter
            // 
            this.btnCustomFilter.Location = new System.Drawing.Point(883, 33);
            this.btnCustomFilter.Name = "btnCustomFilter";
            this.btnCustomFilter.Size = new System.Drawing.Size(139, 40);
            this.btnCustomFilter.TabIndex = 2;
            this.btnCustomFilter.Text = "Custom Filter";
            this.btnCustomFilter.UseVisualStyleBackColor = true;
            // 
            // cboViewActions
            // 
            this.cboViewActions.FormattingEnabled = true;
            this.cboViewActions.Location = new System.Drawing.Point(493, 40);
            this.cboViewActions.Name = "cboViewActions";
            this.cboViewActions.Size = new System.Drawing.Size(240, 28);
            this.cboViewActions.TabIndex = 15;
            this.cboViewActions.Text = "View Actions";
            // 
            // frmPrice_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 814);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrice_Info";
            this.Text = "Price_Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSecurities;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSecurityId;
        private System.Windows.Forms.ComboBox cboSecurityIdType;
        private System.Windows.Forms.TextBox txtSecurityName;
        private System.Windows.Forms.DateTimePicker dtpEffectiveDate;
        private System.Windows.Forms.Button btnClearSecurityId;
        private System.Windows.Forms.Button btnSearchSecurityId;
        private System.Windows.Forms.ComboBox cboCurrentView;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCustomFilter;
        private System.Windows.Forms.ComboBox cboViewActions;
    }
}