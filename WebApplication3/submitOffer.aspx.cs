using System;
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
            
            date = DateTime.Now.ToString("dd-MM-yyyy");
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();

            SQLiteCommand offerCreatecmd = new SQLiteCommand("Insert into dev_offer(username,title,sum_offer,date_offer,comments) Values(@username,@title,@sum_offer,@date_offer,@comments)", conn);
            offerCreatecmd.Parameters.AddWithValue("@username", TextBox3.Text);
            offerCreatecmd.Parameters.AddWithValue("@title", TextBox4.Text);
            offerCreatecmd.Parameters.AddWithValue("@sum_offer", TextBox1.Text);
            offerCreatecmd.Parameters.AddWithValue("@date_offer", date);
            offerCreatecmd.Parameters.AddWithValue("@comments", TextBox2.Text);
            offerCreatecmd.ExecuteNonQuery();

            String query = "update project set num_offers = num_offers + 1 where title='" + TextBox4.Text + "'";
            SQLiteCommand increasecmd = new SQLiteCommand(query, conn);
            increasecmd.ExecuteNonQuery();
            conn.Close(); 
            Response.Redirect("showProject.aspx");
        }
    }
}