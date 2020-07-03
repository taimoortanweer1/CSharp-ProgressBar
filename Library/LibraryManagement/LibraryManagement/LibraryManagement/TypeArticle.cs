using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class TypeArticle
    {
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public string id { get; set; }
        public string typeArticle { get; set; }

        public bool save()
        {
            if (this.id == null)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tblTypeArticle(TypeArticle) VALUES(@value);", this.con);
                cmd.Parameters.Add("@value", this.typeArticle);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.tblTypeArticle SET TypeArticle = @value WHERE TypeArticleID=@id;", this.con);
                cmd.Parameters.Add("@value", this.typeArticle);
                cmd.Parameters.Add("@id", this.id);
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
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tblArticle WHERE TypeArticleID='" + this.id + "';DELETE FROM dbo.tblTypeArticle WHERE TypeArticleID='" + this.id + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void get(string _id)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblTypeArticle WHERE TypeArticleID='" + _id + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.typeArticle = Reader.GetValue(1).ToString();
                }
                con.Close();
            }
        }

        public void loadByUnique(string _name)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblTypeArticle WHERE TypeArticle='" + _name + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.typeArticle = Reader.GetValue(1).ToString();
                }
                con.Close();
            }
        }

        public List<TypeArticle> getAll()
        {
            List<TypeArticle> data = new List<TypeArticle>();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblTypeArticle;", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    TypeArticle ta = new TypeArticle();
                    ta.id = Reader.GetValue(0).ToString();
                    ta.typeArticle = Reader.GetValue(1).ToString();
                    data.Add(ta);
                }
                con.Close();
            }
            return data;
        }

    }
}
