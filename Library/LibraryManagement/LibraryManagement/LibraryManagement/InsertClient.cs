using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibraryManagement
{
    public partial class InsertClient : Form
    {
        string mainID = null;

        public InsertClient()
        {
            InitializeComponent();
        }

        public InsertClient(string _id)
        {
            InitializeComponent();
            this.mainID = _id;
            Client client = new Client();
            client.get(_id);
            tbxName.Text = client.name;
            tbxAddress.Text = client.address;
            tbxPostalCode.Text = client.postal_code;
            tbxCity.Text = client.city;
            dateTimePicker1.Value = new DateTime(Convert.ToInt32(client.birthdate.Substring(6, 4)), Convert.ToInt32(client.birthdate.Substring(3, 2)), Convert.ToInt32(client.birthdate.Substring(0, 2)));
        }

        private void InsertClient_Load(object sender, EventArgs e)
        {

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
            if (tbxName.Text == "")
            {
                MessageBox.Show("The name field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.validateAlpha(tbxName.Text))
            {
                MessageBox.Show("The name field is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxAddress.Text == "")
            {
                MessageBox.Show("The address field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxPostalCode.Text.Length != 8)
            {
                MessageBox.Show("The postal code field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbxCity.Text == "")
            {
                MessageBox.Show("The city field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.validateAlpha(tbxCity.Text))
            {
                MessageBox.Show("The city field is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client client = new Client();
            client.id = this.mainID;
            client.name = tbxName.Text.Trim();
            client.address = tbxAddress.Text.Trim();
            client.postal_code = tbxPostalCode.Text.Trim();
            client.city = tbxCity.Text.Trim();
            client.birthdate = dateTimePicker1.Value.ToString().Split(' ')[0].Trim();
            client.save();
            MessageBox.Show("Client inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
