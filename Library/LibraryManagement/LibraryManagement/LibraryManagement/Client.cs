using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class Client
    {
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string postal_code { get; set; }
        public string city { get; set; }
        public string birthdate { get; set; }

        public bool save()
        {
            try
            {
                if (this.id == null)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tblClients(Name,Address,PostalCode,City,DateOfBirth) VALUES(@name, @address, @postal_code, @city, @birthdate);", this.con);
                    cmd.Parameters.Add("@name", this.name);
                    cmd.Parameters.Add("@address", this.address);
                    cmd.Parameters.Add("@postal_code", this.postal_code);
                    cmd.Parameters.Add("@city", this.city);
                    cmd.Parameters.Add("@birthdate", this.birthdate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.tblClients SET Name=@name,Address=@address,PostalCode=@postal_code,City=@city,DateOfBirth=@birthdate WHERE ClientID=@id;", this.con);
                    cmd.Parameters.Add("@id", this.id);
                    cmd.Parameters.Add("@name", this.name);
                    cmd.Parameters.Add("@address", this.address);
                    cmd.Parameters.Add("@postal_code", this.postal_code);
                    cmd.Parameters.Add("@city", this.city);
                    cmd.Parameters.Add("@birthdate", this.birthdate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void delete()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tblLoans WHERE ClientID='" + this.id + "';DELETE FROM dbo.tblClients WHERE ClientID='" + this.id + "';", con);
            
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void get(string _id)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblClients WHERE ClientID='" + _id + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.name = Reader.GetValue(1).ToString();
                    this.address = Reader.GetValue(2).ToString();
                    this.postal_code = Reader.GetValue(3).ToString();
                    this.city = Reader.GetValue(4).ToString();
                    this.birthdate = Reader.GetValue(5).ToString();
                }
                con.Close();
            }
        }

        public void loadByUnique(string _name)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblClients WHERE Name='" + _name + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.name = Reader.GetValue(1).ToString();
                    this.address = Reader.GetValue(2).ToString();
                    this.postal_code = Reader.GetValue(3).ToString();
                    this.city = Reader.GetValue(4).ToString();
                    this.birthdate = Reader.GetValue(5).ToString();
                }
                con.Close();
            }
        }

        public List<Client> getAll()
        {
            List<Client> data = new List<Client>();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblClients;", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Client ta = new Client();
                    ta.id = Reader.GetValue(0).ToString();
                    ta.name = Reader.GetValue(1).ToString();
                    ta.address = Reader.GetValue(2).ToString();
                    ta.postal_code = Reader.GetValue(3).ToString();
                    ta.city = Reader.GetValue(4).ToString();
                    ta.birthdate = Reader.GetValue(5).ToString();
                    data.Add(ta);
                }
                con.Close();
            }
            return data;
        }
    }
}
