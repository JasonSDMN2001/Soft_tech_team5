﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class submitOffer : System.Web.UI.Page
    {
        string title;
        string user;
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Text = Session["Username"].ToString();
            TextBox4.Text = Session["value"].ToString();
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            //title = Session["value"].ToString();
            //user = Session["Username"].ToString();
            date = DateTime.Now.ToString("dd-MM-yyyy");
            Response.Redirect("showProject.aspx");
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteCommand offerCreatecmd = new SQLiteCommand("Insert into dev_profile_hidden(email,fullname,gender,username,port,cv) Values(@email,@fullname,@gender,@username,@port,@cv)", conn);

            //SQLiteCommand offerCreatecmd = new SQLiteCommand("Insert into dev_offer(username,title,sum_offer,date_offer,comments) Values(@username,@title,@sum_offer,@date_offer,@comments)", conn);
            offerCreatecmd.Parameters.AddWithValue("@username", TextBox3.Text);
            /*offerCreatecmd.Parameters.AddWithValue("@email", "hey");
            offerCreatecmd.Parameters.AddWithValue("@fullname", "hey");
            offerCreatecmd.Parameters.AddWithValue("@gender", "hey");
            offerCreatecmd.Parameters.AddWithValue("@port", "hey");
            offerCreatecmd.Parameters.AddWithValue("@cv", "hey");*/
            offerCreatecmd.Parameters.AddWithValue("@title", TextBox4.Text);
            offerCreatecmd.Parameters.AddWithValue("@sum_offer", TextBox1.Text);
            offerCreatecmd.Parameters.AddWithValue("@date_offer", date);
            offerCreatecmd.Parameters.AddWithValue("@comments", TextBox2.Text);
            offerCreatecmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("showProject.aspx");
        }
    }
}