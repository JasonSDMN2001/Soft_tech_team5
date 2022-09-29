using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class editOffer : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            string title = Request.Params["titlename"];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteCommand editOffercmd = new SQLiteCommand("Select * from dev_offer where username='" + user + "' and title='" + title + "'", conn);
            SQLiteDataReader reader = editOffercmd.ExecuteReader();
            while (reader.Read())
            {
                Label6.Text = reader.GetString(2);
                Label7.Text = reader.GetString(4);
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            string title = Request.Params["titlename"];
            string sum = TextBox1.Text;
            string comm = TextBox2.Text;
            date = DateTime.Now.ToString("dd-MM-yyyy");
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open(); 
            String query = "update dev_offer set sum_offer=@sum_offer,date_offer=@date_offer,comments=@comments where username='" + user + "' and title='" + title + "'";
            SQLiteCommand editOffer2cmd = new SQLiteCommand(query, conn);
            editOffer2cmd.Parameters.AddWithValue("@sum_offer", sum);
            editOffer2cmd.Parameters.AddWithValue("@date_offer", date);
            editOffer2cmd.Parameters.AddWithValue("@comments", comm);
            editOffer2cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("viewDevOffers.aspx");
            


        }
    }
}