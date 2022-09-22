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
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from client where email='" + emailID + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email.Text = reader.GetString(0);
                username.Text = reader.GetString(1) + "    ";
                fullname.Text = "   " + reader.GetString(3) + " " + reader.GetString(4);
                gender.Text = "     " + reader.GetString(5);
                birthdate.Text = "     " + reader.GetString(6);
                byte[] bytes = (byte[])reader["pic"];
                ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                description.Text = reader.GetString(8);
                pagelink.NavigateUrl = reader.GetString(9);
            }
            conn.Close();
        }
    }
}