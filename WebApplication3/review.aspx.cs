using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace WebApplication3
{
    public partial class review : System.Web.UI.Page
    {
        string user;
        string title;
        string dev;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["Username"].ToString();
            title = Session["value"].ToString();
            Label2.Text = title;    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteCommand devusernamecmd = new SQLiteCommand("select dev_username from project where title='" + title + "'", conn);
            SQLiteDataReader reader = devusernamecmd.ExecuteReader();
            while (reader.Read())
            {
                dev = reader.GetString(0);
            }
            
            SQLiteCommand reviewcmd = new SQLiteCommand("Insert into review(cli_username,dev_username,title,stars,comment) Values(@cli_username,@dev_username,@title,@stars,@comment)", conn);
            reviewcmd.Parameters.AddWithValue("@cli_username",user);
            reviewcmd.Parameters.AddWithValue("@dev_username", dev);
            reviewcmd.Parameters.AddWithValue("@title", title);
            reviewcmd.Parameters.AddWithValue("@stars",DropDownList1.SelectedItem.Text);
            reviewcmd.Parameters.AddWithValue("@comment", TextBox2.Text);
            reviewcmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("showProject.aspx");
        }
    }
}