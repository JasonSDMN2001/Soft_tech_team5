using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class clientProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from client where username='"+user+"'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email.Text = reader.GetString(0);
                username.Text = reader.GetString(1);
                fullname.Text = "   " + reader.GetString(3) + " " + reader.GetString(4);
                gender.Text = "     " + reader.GetString(5);
                birthdate.Text = "     " + reader.GetString(6);
                //ImageID.ImageUrl = reader.GetString(7);
                description.Text = reader.GetString(8);
                pagelink.NavigateUrl = reader.GetString(9);
            }
            conn.Close();
        }
    }
}