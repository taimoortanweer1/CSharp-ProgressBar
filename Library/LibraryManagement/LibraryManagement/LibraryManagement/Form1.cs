using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        bool edit_cols_type_article = false;
        bool edit_cols_article = false;
        bool edit_cols_client = false;
        bool edit_cols_loan = false;
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public Form1()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshDGV("type_article");
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void btnInsertArtycleTypes_Click(object sender, EventArgs e)
        {
            InsertArticleType form = new InsertArticleType();
            form.ShowDialog();
            form.BringToFront();
            this.refreshDGV("type_article");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Insert clients
            InsertClient form = new InsertClient();
            form.ShowDialog();
            form.BringToFront();
            this.refreshDGV("client");
        }

        private void refreshDGV(string dgv)
        {
            try
            {
                if (dgv == "type_article")
                {
                    dgvArticleType.DataSource = null;

                    SqlCommand cmd = new SqlCommand("select * from tblTypeArticle", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvArticleType.DataSource = ds.Tables[0];
                    dgvArticleType.AutoGenerateColumns = false;
                    dgvArticleType.AllowUserToAddRows = false;
                    

                    if (!edit_cols_type_article)
                    {
                        edit_cols_type_article = true;
                        DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                        Editlink.UseColumnTextForLinkValue = true;
                        Editlink.HeaderText = "EDIT";
                        Editlink.DataPropertyName = "lnkColumn";
                        Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                        Editlink.Text = "Edit";
                        dgvArticleType.Columns.Add(Editlink);
                        DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                        Deletelink.UseColumnTextForLinkValue = true;
                        Deletelink.HeaderText = "DELETE";
                        Deletelink.DataPropertyName = "lnkColumn";
                        Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                        Deletelink.Text = "Delete";
                        dgvArticleType.Columns.Add(Deletelink);
                    }

                }
                else if (dgv == "client")
                {
                    dgvClients.DataSource = null;

                    SqlCommand cmd = new SqlCommand("select * from tblClients", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvClients.DataSource = ds.Tables[0];
                    dgvClients.AutoGenerateColumns = false;
                    dgvClients.AllowUserToAddRows = false;
                    

                    if (!edit_cols_client)
                    {
                        edit_cols_client = true;
                        DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                        Editlink.UseColumnTextForLinkValue = true;
                        Editlink.HeaderText = "EDIT";
                        Editlink.DataPropertyName = "lnkColumn";
                        Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                        Editlink.Text = "Edit";
                        dgvClients.Columns.Add(Editlink);
                        DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                        Deletelink.UseColumnTextForLinkValue = true;
                        Deletelink.HeaderText = "DELETE";
                        Deletelink.DataPropertyName = "lnkColumn";
                        Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                        Deletelink.Text = "Delete";
                        dgvClients.Columns.Add(Deletelink);
                    }
                }
                else if (dgv == "article")
                {
                    dgvArticle.DataSource = null;


                    SqlCommand cmd = new SqlCommand("SELECT A.ArticleID,T.TypeArticle FROM dbo.tblArticle AS A JOIN dbo.tblTypeArticle AS T ON T.TypeArticleID = A.TypeArticleID;", con);                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvArticle.DataSource = ds.Tables[0];
                    dgvArticle.AutoGenerateColumns = false;
                    dgvArticle.AllowUserToAddRows = false;
                    

                    if (!edit_cols_article)
                    {
                        edit_cols_article = true;
                        DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                        Editlink.UseColumnTextForLinkValue = true;
                        Editlink.HeaderText = "EDIT";
                        Editlink.DataPropertyName = "lnkColumn";
                        Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                        Editlink.Text = "Edit";
                        dgvArticle.Columns.Add(Editlink);
                        DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                        Deletelink.UseColumnTextForLinkValue = true;
                        Deletelink.HeaderText = "DELETE";
                        Deletelink.DataPropertyName = "lnkColumn";
                        Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                        Deletelink.Text = "Delete";
                        dgvArticle.Columns.Add(Deletelink);
                    }
                }
                else if (dgv == "loans")
                {
                    dgvLoans.DataSource = null;

                    SqlCommand cmd = new SqlCommand("SELECT LoanID,A.Article,C.Name,DateLoan,DateReturn,Amount,Returned FROM .dbo.tblLoans AS L JOIN dbo.tblArticle AS A ON A.ArticleID = L.ArticleID JOIN dbo.tblClients AS C ON C.ClientID = L.ClientID;", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgvLoans.DataSource = ds.Tables[0];
                    dgvLoans.AutoGenerateColumns = false;
                    dgvLoans.AllowUserToAddRows = false;
                    

                    if (!edit_cols_loan)
                    {
                        edit_cols_loan = true;
                        DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                        Editlink.UseColumnTextForLinkValue = true;
                        Editlink.HeaderText = "EDIT";
                        Editlink.DataPropertyName = "lnkColumn";
                        Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                        Editlink.Text = "Edit";
                        dgvLoans.Columns.Add(Editlink);
                        DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
                        Deletelink.UseColumnTextForLinkValue = true;
                        Deletelink.HeaderText = "DELETE";
                        Deletelink.DataPropertyName = "lnkColumn";
                        Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
                        Deletelink.Text = "Delete";
                        dgvLoans.Columns.Add(Deletelink);
                    }
                }
            }
            catch (Exception ex)
            {
                // Table is empty
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.refreshDGV("type_article");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                this.refreshDGV("article");
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                this.refreshDGV("loans");
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                this.refreshDGV("client");
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                //reports
                List<Article> articles = new Article().getAll();
                this.cbxTypeArticle.Items.Clear();

                foreach (Article art in articles)
                {
                    this.cbxTypeArticle.Items.Add(art.article);
                }

            }
        }


        private void datagridviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            string id = dgv.SelectedRows[0].Cells[0].Value.ToString();

            if (dgv.Name == "dgvArticleType")
            {
                if (e.ColumnIndex == 2)
                {
                    InsertArticleType form = new InsertArticleType(id);
                    form.ShowDialog();
                    form.BringToFront();
                    this.refreshDGV("type_article");
                }
                else if (e.ColumnIndex == 3)
                {
                    TypeArticle type = new TypeArticle();
                    type.get(id);
                    type.delete();
                    this.refreshDGV("type_article");
                }
            }
            else if (dgv.Name == "dgvArticle")
            {
                if (e.ColumnIndex == 3)
                {
                    InsertArticle form = new InsertArticle(id);
                    form.ShowDialog();
                    form.BringToFront();
                    this.refreshDGV("article");
                }
                else if (e.ColumnIndex == 4)
                {
                    Article article = new Article();
                    article.get(id);
                    article.delete();
                    this.refreshDGV("article");
                }
            }
            else if (dgv.Name == "dgvLoans")
            {
                if (e.ColumnIndex == 7)
                {
                    InsertLoan form = new InsertLoan(id);
                    form.ShowDialog();
                    form.BringToFront();
                    this.refreshDGV("loans");
                }
                else if (e.ColumnIndex == 8)
                {
                    Loan loan = new Loan();
                    loan.get(id);
                    loan.delete();
                    this.refreshDGV("loans");
                }
            }
            else if (dgv.Name == "dgvClients")
            {
                if (e.ColumnIndex == 6)
                {
                    InsertClient form = new InsertClient(id);
                    form.ShowDialog();
                    form.BringToFront();
                    this.refreshDGV("client");
                }
                else if (e.ColumnIndex == 7)
                {
                    Client client = new Client();
                    client.get(id);
                    client.delete();
                    this.refreshDGV("client");
                }
            }
        }

        private void btnInsertArticle_Click(object sender, EventArgs e)
        {
            InsertArticle form = new InsertArticle();
            form.ShowDialog();
            form.BringToFront();
            this.refreshDGV("article");
        }

        private void btnInsertLoans_Click(object sender, EventArgs e)
        {
            InsertLoan form = new InsertLoan();
            form.ShowDialog();
            form.BringToFront();
            this.refreshDGV("loans");
        }

        private void btnLoanReturnOverdue_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = null;

            string start = datePickerAmountStart.Value.ToString().Split(' ')[0];
            string end = datePickerAmountStart.Value.ToString().Split(' ')[0];

            string query = "SELECT L.LoanID,A.Article,C.Name,L.DateLoan,L.DateReturn,L.Amount ";
            query += "FROM dbo.tblLoans AS L JOIN dbo.tblArticle AS A ON L.ArticleID=A.ArticleID ";
            query += "JOIN dbo.tblClients AS C ON L.ClientID=C.ClientID ";
            query += "WHERE L.DateReturn <= '" + DateTime.Now.Date + "' AND Returned = 0;";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvReports.DataSource = ds.Tables[0];
            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;

        }

        private void NrLoansDone()
        {
            dgvReports.DataSource = null;

            string start = datePickerAmountStart.Value.ToString().Split(' ')[0];
            string end = datePickerAmountStart.Value.ToString().Split(' ')[0];

            string query = "SELECT L.LoanID,A.Article,C.Name,L.DateLoan,L.DateReturn,L.Amount,L.Returned ";
            query += "FROM dbo.tblLoans AS L JOIN dbo.tblArticle AS A ON L.ArticleID=A.ArticleID ";
            query += "JOIN dbo.tblClients AS C ON L.ClientID=C.ClientID WHERE L.DateLoan >= '" + start + "' AND L.DateLoan <= '" + end + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvReports.DataSource = ds.Tables[0];
            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;
 
        }

        private void datePickerAmountStart_ValueChanged(object sender, EventArgs e)
        {
            this.getAmount();
        }

        private void datePickerAmountEnd_ValueChanged(object sender, EventArgs e)
        {
            this.getAmount();
        }

        private void getAmount()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            con.Open();

            string query = "SELECT SUM(Amount) FROM dbo.tblLoans AS L ";
            query += "JOIN dbo.tblArticle AS A ON L.ArticleID=A.ArticleID ";
            query += "JOIN dbo.tblClients AS C ON L.ClientID=C.ClientID ";
            query += "WHERE L.DateLoan >= '" + this.datePickerAmountStart.Value.ToString() + "' AND L.DateLoan <= '" + this.datePickerAmountEnd.Value.ToString() + "'";

            SqlCommand Command = new SqlCommand(query, con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.tbxAmountCharged.Text = Reader.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void cbxTypeArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Article article = new Article();
            article.loadByUnique(cbxTypeArticle.SelectedItem.ToString());

            dgvReports.DataSource = null;

            string query = "SELECT L.LoanID,A.Article,C.Name,L.DateLoan,L.DateReturn,L.Amount,L.Returned ";
            query += "FROM dbo.tblLoans AS L JOIN dbo.tblArticle AS A ON L.ArticleID=A.ArticleID ";
            query += "JOIN dbo.tblClients AS C ON L.ClientID=C.ClientID WHERE L.ArticleID = '" + article.id + "';";

            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvReports.DataSource = ds.Tables[0];
            dgvReports.AutoGenerateColumns = false;
            dgvReports.AllowUserToAddRows = false;

        }

        private void dateTimePickerNrLoansStart_ValueChanged(object sender, EventArgs e)
        {
            this.getLoansDoneAndReturned();
        }

        private void dateTimePickerNrLoansEnd_ValueChanged(object sender, EventArgs e)
        {
            this.getLoansDoneAndReturned();
        }

        private void getLoansDoneAndReturned()
        {
            dgvReports.DataSource = null;

            string query = "SELECT count(*) ";
            query += "FROM dbo.tblLoans AS L WHERE L.Returned = 1 AND L.DateReturn >= '" + dateTimePickerNrLoansStart.Value.ToString() + "' AND L.DateReturn <= '" + dateTimePickerNrLoansEnd.Value.ToString() + "';";
            
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            con.Open();
            SqlCommand Command = new SqlCommand(query, con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.tbxNrLoansDone.Text = Reader.GetValue(0).ToString();
                }
                con.Close();
            }
        }



    }
}
