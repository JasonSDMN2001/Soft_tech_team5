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
                max_price.Text = read.GetString(7);
                interval.Text = read.GetString(8);
                rec_tech.Text = read.GetString(10);
                client_username.Text = "Submitted by:  " + read.GetString(12);
            }
            conn.Close();
        }
    }
}