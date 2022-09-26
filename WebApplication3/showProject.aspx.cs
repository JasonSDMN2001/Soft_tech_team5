using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class showProject : System.Web.UI.Page
    {
        private String titlename;
        protected void Page_Load(object sender, EventArgs e)
        {
            titlename = Request.Params["titlename"];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteCommand projectViewcmd = new SQLiteCommand("Select * from project where title='" + titlename + "'", conn);
            SQLiteDataReader read = projectViewcmd.ExecuteReader();
            while (read.Read())
            {
                title.Text = read.GetString(0);
                description.Text = read.GetString(1);
                category.Text = read.GetString(4);
                subcategory.Text = read.GetString(5);
                payment_method.Text = read.GetString(6);
                string price = read.GetString(7);
                if (price == "")
                {
                    max_price.Text = "Doesn't exist";
                }
                else
                {
                    max_price.Text = price;
                }
                interval.Text = read.GetString(8);
                string lang = read.GetString(10);
                if (lang == "") 
                {
                    rec_tech.Text = "Doesn't exist";
                }
                else
                {
                    rec_tech.Text = lang;
                }
                client_username.Text = "Submitted by:  " + read.GetString(12);
                if (read.GetString(14) == "true" & read.GetString(15) == "true")
                {
                    complete.Visible = true;
                }
            }
            conn.Close();
        }
    }
}