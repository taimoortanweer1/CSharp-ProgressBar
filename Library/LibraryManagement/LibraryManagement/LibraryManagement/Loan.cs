using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class Loan
    {
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public string id { get; set; }
        public string article_id { get; set; }
        public string client_id { get; set; }
        public string date_loan { get; set; }
        public string date_return { get; set; }
        public string amount { get; set; }
        public string returned { get; set; }

        public bool save()
        {
            if (this.id == null)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tblLoans(ArticleID, ClientID, DateLoan, DateReturn, Amount, Returned) VALUES(@article_id, @client_id, @date_loan, @date_return, @amount, @returned);", this.con);
                cmd.Parameters.Add("@article_id", this.article_id);
                cmd.Parameters.Add("@client_id", this.client_id);
                cmd.Parameters.Add("@date_loan", this.date_loan);
                cmd.Parameters.Add("@date_return", this.date_return);
                cmd.Parameters.Add("@amount", this.amount);
                cmd.Parameters.Add("@returned", this.returned);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.tblLoans SET ArticleID=@article_id, ClientID=@client_id, DateLoan=@date_loan, DateReturn=@date_return, Amount=@amount, Returned=@returned WHERE LoanID=@id;", this.con);
                cmd.Parameters.Add("@id", this.id);
                cmd.Parameters.Add("@article_id", this.article_id);
                cmd.Parameters.Add("@client_id", this.client_id);
                cmd.Parameters.Add("@date_loan", this.date_loan);
                cmd.Parameters.Add("@date_return", this.date_return);
                cmd.Parameters.Add("@amount", this.amount);
                cmd.Parameters.Add("@returned", this.returned);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }

        public void delete()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tblLoans WHERE LoanID='" + this.id + "';", con);
            
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void get(string _id)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblLoans WHERE LoanID='" + _id + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.article_id = Reader.GetValue(1).ToString();
                    this.client_id = Reader.GetValue(2).ToString();
                    this.date_loan = Reader.GetValue(3).ToString();
                    this.date_return = Reader.GetValue(4).ToString();
                    this.amount = Reader.GetValue(5).ToString();
                    this.returned = Reader.GetValue(6).ToString();
                }
                con.Close();
            }
        }

        public List<Loan> getAll()
        {
            List<Loan> data = new List<Loan>();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblLoans;", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Loan ta = new Loan();
                    ta.id = Reader.GetValue(0).ToString();
                    ta.article_id = Reader.GetValue(1).ToString();
                    ta.client_id = Reader.GetValue(2).ToString();
                    ta.date_loan = Reader.GetValue(3).ToString();
                    ta.date_return = Reader.GetValue(4).ToString();
                    ta.amount = Reader.GetValue(5).ToString();
                    ta.returned = Reader.GetValue(6).ToString();
                    data.Add(ta);
                }
                con.Close();
            }
            return data;
        }

        

    }
}
