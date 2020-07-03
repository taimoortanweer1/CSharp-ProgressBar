namespace LibraryManagement
{
    partial class InsertLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertLoan));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxArticle = new System.Windows.Forms.ComboBox();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerLoan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.maskAmount = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkReturned = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article:";
            // 
            // cbxArticle
            // 
            this.cbxArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticle.FormattingEnabled = true;
            this.cbxArticle.Location = new System.Drawing.Point(85, 25);
            this.cbxArticle.Name = "cbxArticle";
            this.cbxArticle.Size = new System.Drawing.Size(192, 21);
            this.cbxArticle.TabIndex = 1;
            // 
            // cbxClient
            // 
            this.cbxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(85, 52);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(192, 21);
            this.cbxClient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client:";
            // 
            // datePickerLoan
            // 
            this.datePickerLoan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerLoan.Location = new System.Drawing.Point(85, 79);
            this.datePickerLoan.Name = "datePickerLoan";
            this.datePickerLoan.Size = new System.Drawing.Size(192, 20);
            this.datePickerLoan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Loan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Return:";
            // 
            // datePickerReturn
            // 
            this.datePickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerReturn.Location = new System.Drawing.Point(85, 105);
            this.datePickerReturn.Name = "datePickerReturn";
            this.datePickerReturn.Size = new System.Drawing.Size(192, 20);
            this.datePickerReturn.TabIndex = 6;
            // 
            // maskAmount
            // 
            this.maskAmount.Location = new System.Drawing.Point(85, 131);
            this.maskAmount.Mask = "00,00";
            this.maskAmount.Name = "maskAmount";
            this.maskAmount.Size = new System.Drawing.Size(43, 20);
            this.maskAmount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount:";
            // 
            // checkReturned
            // 
            this.checkReturned.AutoSize = true;
            this.checkReturned.Location = new System.Drawing.Point(85, 157);
            this.checkReturned.Name = "checkReturned";
            this.checkReturned.Size = new System.Drawing.Size(70, 17);
            this.checkReturned.TabIndex = 10;
            this.checkReturned.Text = "Returned";
            this.checkReturned.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkReturned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePickerReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePickerLoan);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxArticle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Loan";
            this.Load += new System.EventHandler(this.InsertLoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxArticle;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerLoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerReturn;
        private System.Windows.Forms.MaskedTextBox maskAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkReturned;
        private System.Windows.Forms.Button button1;
    }
}