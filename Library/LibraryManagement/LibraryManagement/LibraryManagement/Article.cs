using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class Article
    {
        SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS2012;Initial Catalog=library_app;Integrated Security=False;Trusted_Connection=True;uid=library_user;Password=123");

        public string id { get; set; }
        public string typeArticle { get; set; }
        public string article { get; set; }

        public bool save()
        {
            if (this.id == null)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tblArticle(TypeArticleID, Article) VALUES(@TypeArticleID, @Article);", this.con);
                cmd.Parameters.Add("@TypeArticleID", this.typeArticle);
                cmd.Parameters.Add("@Article", this.article);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.tblArticle SET TypeArticleID = @TypeArticleID, Article = @Article WHERE ArticleID=@id;", this.con);
                cmd.Parameters.Add("@TypeArticleID", this.typeArticle);
                cmd.Parameters.Add("@Article", this.article);
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
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tblLoans WHERE ArticleID='" + this.id + "';DELETE FROM dbo.tblArticle WHERE ArticleID='" + this.id + "';", con);
            
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void get(string _id)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblArticle WHERE ArticleID='" + _id + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.typeArticle = Reader.GetValue(1).ToString();
                    this.article = Reader.GetValue(2).ToString();
                }
                con.Close();
            }
        }

        public void loadByUnique(string _name)
        {
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblArticle WHERE Article='" + _name + "';", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                if (Reader.Read())
                {
                    this.id = Reader.GetValue(0).ToString();
                    this.typeArticle = Reader.GetValue(1).ToString();
                    this.article = Reader.GetValue(2).ToString();
                }
                con.Close();
            }
        }

        public List<Article> getAll()
        {
            List<Article> data = new List<Article>();
            con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.tblArticle;", con);
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Article ta = new Article();
                    ta.id = Reader.GetValue(0).ToString();
                    ta.typeArticle = Reader.GetValue(1).ToString();
                    ta.article = Reader.GetValue(2).ToString();
                    data.Add(ta);
                }
                con.Close();
            }
            return data;
        }

    }
}
