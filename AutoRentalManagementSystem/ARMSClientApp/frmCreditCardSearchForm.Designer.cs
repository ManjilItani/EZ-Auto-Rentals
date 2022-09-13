
namespace ARMSClientApp
{
    partial class frmCreditCardSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreditCardOwnerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreditCardCompany = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCreditCardLimit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCreditLimitBalance = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMerchantCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Card Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(368, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNum.Location = new System.Drawing.Point(170, 118);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(186, 26);
            this.txtCardNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Credit Card Number && Click Search:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Credit Card Infromation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Credit Card Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardNumber.Location = new System.Drawing.Point(212, 232);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.ReadOnly = true;
            this.txtCreditCardNumber.Size = new System.Drawing.Size(186, 26);
            this.txtCreditCardNumber.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Credit Card Owner Name";
            // 
            // txtCreditCardOwnerName
            // 
            this.txtCreditCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardOwnerName.Location = new System.Drawing.Point(212, 264);
            this.txtCreditCardOwnerName.Name = "txtCreditCardOwnerName";
            this.txtCreditCardOwnerName.ReadOnly = true;
            this.txtCreditCardOwnerName.Size = new System.Drawing.Size(186, 26);
            this.txtCreditCardOwnerName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Credit Card Company";
            // 
            // txtCreditCardCompany
            // 
            this.txtCreditCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardCompany.Location = new System.Drawing.Point(212, 296);
            this.txtCreditCardCompany.Name = "txtCreditCardCompany";
            this.txtCreditCardCompany.ReadOnly = true;
            this.txtCreditCardCompany.Size = new System.Drawing.Size(186, 26);
            this.txtCreditCardCompany.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Expiration Date";
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpirationDate.Location = new System.Drawing.Point(212, 360);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.ReadOnly = true;
            this.txtExpirationDate.Size = new System.Drawing.Size(227, 26);
            this.txtExpirationDate.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(212, 392);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(227, 26);
            this.txtAddress1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(212, 424);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(227, 26);
            this.txtAddress2.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(212, 456);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(186, 26);
            this.txtCity.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(212, 488);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(60, 26);
            this.txtState.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 524);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Zip Code";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(212, 520);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(186, 26);
            this.txtZip.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 556);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(212, 552);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(186, 26);
            this.txtCountry.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 588);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 18);
            this.label16.TabIndex = 29;
            this.label16.Text = "Credit Card Limit";
            // 
            // txtCreditCardLimit
            // 
            this.txtCreditCardLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardLimit.Location = new System.Drawing.Point(212, 584);
            this.txtCreditCardLimit.Name = "txtCreditCardLimit";
            this.txtCreditCardLimit.ReadOnly = true;
            this.txtCreditCardLimit.Size = new System.Drawing.Size(186, 26);
            this.txtCreditCardLimit.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 620);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 18);
            this.label17.TabIndex = 31;
            this.label17.Text = "Credit Limit Balance";
            // 
            // txtCreditLimitBalance
            // 
            this.txtCreditLimitBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditLimitBalance.Location = new System.Drawing.Point(212, 616);
            this.txtCreditLimitBalance.Name = "txtCreditLimitBalance";
            this.txtCreditLimitBalance.ReadOnly = true;
            this.txtCreditLimitBalance.Size = new System.Drawing.Size(186, 26);
            this.txtCreditLimitBalance.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 652);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 18);
            this.label18.TabIndex = 33;
            this.label18.Text = "Activation Status";
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivationStatus.Location = new System.Drawing.Point(212, 648);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.ReadOnly = true;
            this.txtActivationStatus.Size = new System.Drawing.Size(186, 26);
            this.txtActivationStatus.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(491, 709);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 39);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(440, 196);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(244, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "Print Credit Card Information:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(505, 251);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 39);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 18);
            this.label15.TabIndex = 38;
            this.label15.Text = "Merchant Code";
            // 
            // txtMerchantCode
            // 
            this.txtMerchantCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerchantCode.Location = new System.Drawing.Point(212, 328);
            this.txtMerchantCode.Name = "txtMerchantCode";
            this.txtMerchantCode.ReadOnly = true;
            this.txtMerchantCode.Size = new System.Drawing.Size(186, 26);
            this.txtMerchantCode.TabIndex = 37;
            // 
            // frmCreditCardSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 790);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMerchantCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtActivationStatus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCreditLimitBalance);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCreditCardLimit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCreditCardCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreditCardOwnerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmCreditCardSearch";
            this.Text = "Credit Card Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreditCardOwnerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCreditCardCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpirationDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCreditCardLimit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCreditLimitBalance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMerchantCode;
    }
}