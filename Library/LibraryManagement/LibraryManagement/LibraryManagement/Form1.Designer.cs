namespace LibraryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInsertArtycleTypes = new System.Windows.Forms.Button();
            this.dgvArticleType = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInsertArticle = new System.Windows.Forms.Button();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnInsertLoans = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnInsertClients = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.datePickerAmountStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePickerAmountEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAmountCharged = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTypeArticle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoanReturnOverdue = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxNrLoansDone = new System.Windows.Forms.TextBox();
            this.dateTimePickerNrLoansEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNrLoansStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticleType)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 120);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 511);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInsertArtycleTypes);
            this.tabPage1.Controls.Add(this.dgvArticleType);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(815, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Article Types";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInsertArtycleTypes
            // 
            this.btnInsertArtycleTypes.Location = new System.Drawing.Point(6, 8);
            this.btnInsertArtycleTypes.Name = "btnInsertArtycleTypes";
            this.btnInsertArtycleTypes.Size = new System.Drawing.Size(75, 23);
            this.btnInsertArtycleTypes.TabIndex = 1;
            this.btnInsertArtycleTypes.Text = "Insert";
            this.btnInsertArtycleTypes.UseVisualStyleBackColor = true;
            this.btnInsertArtycleTypes.Click += new System.EventHandler(this.btnInsertArtycleTypes_Click);
            // 
            // dgvArticleType
            // 
            this.dgvArticleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticleType.Location = new System.Drawing.Point(3, 41);
            this.dgvArticleType.MultiSelect = false;
            this.dgvArticleType.Name = "dgvArticleType";
            this.dgvArticleType.ReadOnly = true;
            this.dgvArticleType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticleType.Size = new System.Drawing.Size(809, 462);
            this.dgvArticleType.TabIndex = 0;
            this.dgvArticleType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviews_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInsertArticle);
            this.tabPage2.Controls.Add(this.dgvArticle);
            this.tabPage2.Location = new System.Drawing.Point(124, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Articles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInsertArticle
            // 
            this.btnInsertArticle.Location = new System.Drawing.Point(6, 8);
            this.btnInsertArticle.Name = "btnInsertArticle";
            this.btnInsertArticle.Size = new System.Drawing.Size(75, 23);
            this.btnInsertArticle.TabIndex = 3;
            this.btnInsertArticle.Text = "Insert";
            this.btnInsertArticle.UseVisualStyleBackColor = true;
            this.btnInsertArticle.Click += new System.EventHandler(this.btnInsertArticle_Click);
            // 
            // dgvArticle
            // 
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(3, 38);
            this.dgvArticle.MultiSelect = false;
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.ReadOnly = true;
            this.dgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticle.Size = new System.Drawing.Size(809, 462);
            this.dgvArticle.TabIndex = 2;
            this.dgvArticle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviews_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInsertLoans);
            this.tabPage3.Controls.Add(this.dgvLoans);
            this.tabPage3.Location = new System.Drawing.Point(124, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(815, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Loans";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInsertLoans
            // 
            this.btnInsertLoans.Location = new System.Drawing.Point(6, 8);
            this.btnInsertLoans.Name = "btnInsertLoans";
            this.btnInsertLoans.Size = new System.Drawing.Size(75, 23);
            this.btnInsertLoans.TabIndex = 3;
            this.btnInsertLoans.Text = "Insert";
            this.btnInsertLoans.UseVisualStyleBackColor = true;
            this.btnInsertLoans.Click += new System.EventHandler(this.btnInsertLoans_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(3, 38);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(809, 462);
            this.dgvLoans.TabIndex = 2;
            this.dgvLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviews_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvClients);
            this.tabPage4.Controls.Add(this.btnInsertClients);
            this.tabPage4.Location = new System.Drawing.Point(124, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(815, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage Clients";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClients.Location = new System.Drawing.Point(3, 37);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(809, 463);
            this.dgvClients.TabIndex = 3;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviews_CellContentClick);
            // 
            // btnInsertClients
            // 
            this.btnInsertClients.Location = new System.Drawing.Point(6, 8);
            this.btnInsertClients.Name = "btnInsertClients";
            this.btnInsertClients.Size = new System.Drawing.Size(75, 23);
            this.btnInsertClients.TabIndex = 4;
            this.btnInsertClients.Text = "Insert";
            this.btnInsertClients.UseVisualStyleBackColor = true;
            this.btnInsertClients.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.dgvReports);
            this.tabPage5.Location = new System.Drawing.Point(124, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(815, 503);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reports";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(6, 130);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(803, 367);
            this.dgvReports.TabIndex = 0;
            // 
            // datePickerAmountStart
            // 
            this.datePickerAmountStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerAmountStart.Location = new System.Drawing.Point(100, 28);
            this.datePickerAmountStart.Name = "datePickerAmountStart";
            this.datePickerAmountStart.Size = new System.Drawing.Size(103, 20);
            this.datePickerAmountStart.TabIndex = 1;
            this.datePickerAmountStart.ValueChanged += new System.EventHandler(this.datePickerAmountStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxAmountCharged);
            this.groupBox1.Controls.Add(this.datePickerAmountEnd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datePickerAmountStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amount charged for a period of time";
            // 
            // datePickerAmountEnd
            // 
            this.datePickerAmountEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerAmountEnd.Location = new System.Drawing.Point(100, 54);
            this.datePickerAmountEnd.Name = "datePickerAmountEnd";
            this.datePickerAmountEnd.Size = new System.Drawing.Size(103, 20);
            this.datePickerAmountEnd.TabIndex = 3;
            this.datePickerAmountEnd.ValueChanged += new System.EventHandler(this.datePickerAmountEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End date:";
            // 
            // tbxAmountCharged
            // 
            this.tbxAmountCharged.Location = new System.Drawing.Point(41, 80);
            this.tbxAmountCharged.Name = "tbxAmountCharged";
            this.tbxAmountCharged.ReadOnly = true;
            this.tbxAmountCharged.Size = new System.Drawing.Size(162, 20);
            this.tbxAmountCharged.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxTypeArticle);
            this.groupBox2.Location = new System.Drawing.Point(252, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loans by type of article";
            // 
            // cbxTypeArticle
            // 
            this.cbxTypeArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeArticle.FormattingEnabled = true;
            this.cbxTypeArticle.Location = new System.Drawing.Point(86, 27);
            this.cbxTypeArticle.Name = "cbxTypeArticle";
            this.cbxTypeArticle.Size = new System.Drawing.Size(136, 21);
            this.cbxTypeArticle.TabIndex = 0;
            this.cbxTypeArticle.SelectedIndexChanged += new System.EventHandler(this.cbxTypeArticle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type Article:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoanReturnOverdue);
            this.groupBox3.Location = new System.Drawing.Point(252, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Articles loaned whose return date is overdue";
            // 
            // btnLoanReturnOverdue
            // 
            this.btnLoanReturnOverdue.Location = new System.Drawing.Point(132, 21);
            this.btnLoanReturnOverdue.Name = "btnLoanReturnOverdue";
            this.btnLoanReturnOverdue.Size = new System.Drawing.Size(90, 23);
            this.btnLoanReturnOverdue.TabIndex = 0;
            this.btnLoanReturnOverdue.Text = "OK";
            this.btnLoanReturnOverdue.UseVisualStyleBackColor = true;
            this.btnLoanReturnOverdue.Click += new System.EventHandler(this.btnLoanReturnOverdue_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbxNrLoansDone);
            this.groupBox4.Controls.Add(this.dateTimePickerNrLoansEnd);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dateTimePickerNrLoansStart);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(523, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 116);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number of loans done and returned for a period of time";
            // 
            // tbxNrLoansDone
            // 
            this.tbxNrLoansDone.Location = new System.Drawing.Point(62, 80);
            this.tbxNrLoansDone.Name = "tbxNrLoansDone";
            this.tbxNrLoansDone.ReadOnly = true;
            this.tbxNrLoansDone.Size = new System.Drawing.Size(162, 20);
            this.tbxNrLoansDone.TabIndex = 10;
            // 
            // dateTimePickerNrLoansEnd
            // 
            this.dateTimePickerNrLoansEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNrLoansEnd.Location = new System.Drawing.Point(121, 54);
            this.dateTimePickerNrLoansEnd.Name = "dateTimePickerNrLoansEnd";
            this.dateTimePickerNrLoansEnd.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerNrLoansEnd.TabIndex = 8;
            this.dateTimePickerNrLoansEnd.ValueChanged += new System.EventHandler(this.dateTimePickerNrLoansEnd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "End date:";
            // 
            // dateTimePickerNrLoansStart
            // 
            this.dateTimePickerNrLoansStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNrLoansStart.Location = new System.Drawing.Point(121, 28);
            this.dateTimePickerNrLoansStart.Name = "dateTimePickerNrLoansStart";
            this.dateTimePickerNrLoansStart.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerNrLoansStart.TabIndex = 6;
            this.dateTimePickerNrLoansStart.ValueChanged += new System.EventHandler(this.dateTimePickerNrLoansStart_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 511);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticleType)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvArticleType;
        private System.Windows.Forms.Button btnInsertArtycleTypes;
        private System.Windows.Forms.Button btnInsertClients;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnInsertArticle;
        private System.Windows.Forms.DataGridView dgvArticle;
        private System.Windows.Forms.Button btnInsertLoans;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxNrLoansDone;
        private System.Windows.Forms.DateTimePicker dateTimePickerNrLoansEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNrLoansStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoanReturnOverdue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTypeArticle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxAmountCharged;
        private System.Windows.Forms.DateTimePicker datePickerAmountEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerAmountStart;
        private System.Windows.Forms.Label label1;
    }
}

