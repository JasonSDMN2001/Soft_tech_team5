using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Client : User , UnregisteredUser
    {
        private DateTime birthdate;
        private String description;
        private Uri link;

        public Client()
        {
        }

        public void createProject()
        {
        }

        public void editProject()
        {
        }

        public void assignProject()
        {
        }

        public void submitReview()
        {
        }

        public void submitRating()
        {
        }

        public void viewDevProfile()
        {
        }

        public void searchProject()
        {
        }

        public void searchDev()
        {
        }

        public void projectDescShow()
        {
        }

        public void profileShow()
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

        public void searchClient()
        {
        }
    }
}