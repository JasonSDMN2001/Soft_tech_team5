using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.SQLite;

namespace WebApplication3
{
    public class User
    {
        private String email;
        private String username;
        private String password;
        private String name;
        private String lastname;
        private String gender;
        private Image profilepic;
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";

        public User()
        {
        }

        public void profileEdit()
        {
        }

        public void projectFollow()
        {
        }

        public void projectComment()
        {
        }

        public void projectRecommend()
        {
        }

        public void profileCreate(String email, String username, String pass, String firstname, String lastname)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into client(email,username,pass,firstname,lastname,gender,birthdate,pic,description,pagelink) Values(@email,@username,@pass,@firstname,@lastname,@gender,@birthdate,@pic,@description,@pagelink)", conn);
            profileCreatecmd.Parameters.AddWithValue("@email", email);
            profileCreatecmd.Parameters.AddWithValue("@username", username);
            profileCreatecmd.Parameters.AddWithValue("@pass", pass);
            profileCreatecmd.Parameters.AddWithValue("@firstname", firstname);
            profileCreatecmd.Parameters.AddWithValue("@lastname", lastname);
            profileCreatecmd.Parameters.AddWithValue("@gender", "");
            profileCreatecmd.Parameters.AddWithValue("@birthdate", "");
            profileCreatecmd.Parameters.AddWithValue("@pic", "");
            profileCreatecmd.Parameters.AddWithValue("@description", "");
            profileCreatecmd.Parameters.AddWithValue("@pagelink", "");
            profileCreatecmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}