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
    public partial class InsertArticleType : Form
    {
        string mainID = null;
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public InsertArticleType()
        {
            InitializeComponent();
        }

        public InsertArticleType(string _id)
        {
            InitializeComponent();
            this.mainID = _id;
            TypeArticle type = new TypeArticle();
            type.get(_id);
            tbxArticleType.Text = type.typeArticle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxArticleType.Text == "")
            {
                MessageBox.Show("The Type Article is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TypeArticle type = new TypeArticle();
            type.id = this.mainID;
            type.typeArticle = tbxArticleType.Text.Trim();
            type.save();
            if(this.mainID == null)
                MessageBox.Show("Type Article successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Type Article successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InsertArticleType_Load(object sender, EventArgs e)
        {
            
        }
    }
}
