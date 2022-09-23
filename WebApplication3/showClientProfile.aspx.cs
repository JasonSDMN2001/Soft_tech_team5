using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class showClientProfile : System.Web.UI.Page
    {
        private string emailID;
        protected void Page_Load(object sender, EventArgs e)
        {
            emailID = Request.Params["emailID"];
            string tempuser = "";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from client where email='" + emailID + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email.Text = reader.GetString(0);
                tempuser = reader.GetString(1);
                username.Text = tempuser + "    ";
                fullname.Text = "   " + reader.GetString(3) + " " + reader.GetString(4);
                gender.Text = "     " + reader.GetString(5);
                birthdate.Text = "     " + reader.GetString(6);
                byte[] bytes = (byte[])reader["pic"];
                ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                description.Text = reader.GetString(8);
                pagelink.NavigateUrl = reader.GetString(9);
            }
            String query2 = "Select * from client_profile_hidden where username='" + tempuser + "'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                if (reader2.GetString(0) == "False")
                {
                    email.Visible = false;
                }
                if (reader2.GetString(1) == "False")
                {
                    fullname.Visible = false;
                }
                if (reader2.GetString(2) == "False")
                {
                    gender.Visible = false;
                }
                if (reader2.GetString(3) == "False")
                {
                    birthdate.Visible = false;
                }
                if (reader2.GetString(4) == "False")
                {
                    pagelink.Visible = false;
                }
            }
            conn.Close();
        }
    }
}