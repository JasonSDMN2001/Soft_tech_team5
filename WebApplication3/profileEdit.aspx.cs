﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class profileEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from client where username='" + user + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email.Text = reader.GetString(0);
                username.Text = reader.GetString(1);
                firstname.Text = reader.GetString(3);
                lastname.Text = reader.GetString(4);
                gender.Text = reader.GetString(5);
                birthdate.Text = reader.GetString(6);
                byte[] bytes = (byte[])reader["pic"];
                ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                description.Text = reader.GetString(8);
                pagelink.Text = reader.GetString(9);
            }
            conn.Close();
        }

        protected void cancelbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("clientProfile.aspx");
        }
    }
}