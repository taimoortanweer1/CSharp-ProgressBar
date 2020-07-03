using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class InsertLoan : Form
    {
        string mainID = null;

        public InsertLoan()
        {
            InitializeComponent();
        }

        public InsertLoan(string _id)
        {
            InitializeComponent();
            this.mainID = _id;

        }

        private void InsertLoan_Load(object sender, EventArgs e)
        {
            List<Article> articles = new Article().getAll();

            foreach (Article a in articles)
            {
                cbxArticle.Items.Add(a.article);
            }

            List<Client> clients = new Client().getAll();

            foreach (Client c in clients)
            {
                cbxClient.Items.Add(c.name);
            }

            if (this.mainID != null)
            {
                Loan loan = new Loan();

                Client client = new Client();
                client.get(loan.client_id);
                cbxClient.SelectedItem = client.name;

                Article art = new Article();
                art.get(loan.article_id);
                cbxArticle.SelectedItem = art.article;

                datePickerLoan.Value = new DateTime(Convert.ToInt32(loan.date_loan.Substring(6, 4)), Convert.ToInt32(loan.date_loan.Substring(3, 2)), Convert.ToInt32(loan.date_loan.Substring(0, 2)));
                datePickerReturn.Value = new DateTime(Convert.ToInt32(loan.date_return.Substring(6, 4)), Convert.ToInt32(loan.date_return.Substring(3, 2)), Convert.ToInt32(loan.date_return.Substring(0, 2)));

                maskAmount.Text = loan.amount;

                if (loan.returned == "1")
                    checkReturned.Checked = true;
                else
                    checkReturned.Checked = false;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxArticle.SelectedItem == null)
            {
                MessageBox.Show("The Article field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbxClient.SelectedItem == null)
            {
                MessageBox.Show("The Client field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (maskAmount.Text.Length != 5)
            {
                MessageBox.Show("The Amount field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Article art = new Article();
            art.loadByUnique(cbxArticle.SelectedItem.ToString());

            Client c = new Client();
            c.loadByUnique(cbxClient.SelectedItem.ToString());

            Loan loan = new Loan();
            loan.id = this.mainID;
            loan.article_id = art.id;
            loan.client_id = c.id;
            loan.date_loan = datePickerLoan.Value.ToString().Split(' ')[0].Trim();
            loan.date_return = datePickerReturn.Value.ToString().Split(' ')[0].Trim();
            loan.amount = maskAmount.Text;

            if (checkReturned.Checked)
                loan.returned = "1";
            else
                loan.returned = "0";

            loan.save();
            MessageBox.Show("Loan inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
