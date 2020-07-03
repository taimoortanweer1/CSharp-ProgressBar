using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LibraryManagement
{
    public partial class InsertArticle : Form
    {
        string mainID = null;
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public InsertArticle()
        {
            InitializeComponent();
        }

        public InsertArticle(string _id)
        {
            InitializeComponent();
            this.mainID = _id;
            Article art = new Article();
            art.get(_id);
            tbxArticle.Text = art.article;
            TypeArticle type = new TypeArticle();
            type.get(art.typeArticle);
            cbxTypeArticle.SelectedItem = type.typeArticle;

        }

        private void InsertArticle_Load(object sender, EventArgs e)
        {
            List<TypeArticle> types = new TypeArticle().getAll();

            foreach (TypeArticle type in types)
            {
                this.cbxTypeArticle.Items.Add(type.typeArticle);
            }

        }

        private bool validateAlpha(string value)
        {
            Regex regex = new Regex("[a-zA-Z-'áàâãÁÀÂÃéèêÉÈÊíìîÍÌÎóòôõÓÒÔÕúùûüÚÙÛñÑçÇ]+( [a-zA-Z-'áàâãÁÀÂÃéèêÉÈÊíìîÍÌÎóòôõÓÒÔÕúùûüÚÙÛñÑçÇ]+)*$");

            if (regex.IsMatch(value))
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxArticle.Text == "")
            {
                MessageBox.Show("The Article is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.validateAlpha(tbxArticle.Text))
            {
                MessageBox.Show("The Article field is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbxTypeArticle.SelectedItem == null)
            {
                MessageBox.Show("The Article type is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TypeArticle t = new TypeArticle();
            t.loadByUnique(cbxTypeArticle.SelectedItem.ToString());

            Article type = new Article();
            type.id = this.mainID;
            type.typeArticle = t.id;
            type.article = tbxArticle.Text.Trim();
            type.save();
            if (this.mainID == null)
                MessageBox.Show("Type Article successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Type Article successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
