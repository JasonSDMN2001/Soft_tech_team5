using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Admin
    {
        private String username;
        private String password;

        public Admin()
        {
        }

        public void deleteUser(String type, String username)
        {
            if (type == "client")
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                SQLiteCommand deletecmd = new SQLiteCommand("Delete from client where username='" + username + "'", conn);
                deletecmd.ExecuteNonQuery();
                SQLiteCommand delete2cmd = new SQLiteCommand("Delete from client_profile_hidden where username='" + username + "'", conn);
                delete2cmd.ExecuteNonQuery();
                SQLiteCommand projcmd = new SQLiteCommand("Delete from project where client_username='" + username + "'", conn);
                projcmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void deleteProject()
        {
        }

        void searchProject()
        {
        }
    }
}