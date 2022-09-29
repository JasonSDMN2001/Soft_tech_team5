using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class deleteOffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string user = Session["Username"].ToString();
            string title = Request.Params["titlename"];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteCommand deleteOffercmd = new SQLiteCommand("Select * from dev_offer where username='" + user + "' and title='" + title + "'", conn);
            SQLiteDataReader reader = deleteOffercmd.ExecuteReader();
            while (reader.Read())
            {
                Label6.Text = reader.GetString(1);
                Label7.Text = reader.GetString(2);
                Label8.Text = reader.GetString(3);
                Label9.Text = reader.GetString(4);
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query;
            string user = Session["Username"].ToString();
            string title = Request.Params["titlename"];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            query = "Delete from dev_offer where username='" + user + "' and title='" + title + "';";
            SQLiteCommand deletecmd = new SQLiteCommand(query, conn);
            deletecmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("viewDevOffers.aspx");
        }
    }
}