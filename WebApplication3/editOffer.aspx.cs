using System;
using System.Collections.Generic;
using System.Data;
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
        string titlos;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
                string user = Session["Username"].ToString();
                string title = Request.Params["titlename"];
           
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("Select title from project where title='" + title + "' and dev_username IS NULL ", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    titlos = reader.GetString(0);
                    if (titlos != null)
                    {
                       i = i + 1;
                    }

                }

                if (i>0)
                {


                        SQLiteConnection conn2 = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                        conn2.Open();
                        SQLiteCommand editOffercmd = new SQLiteCommand("Select * from dev_offer where username='" + user + "' and title='" + title + "'", conn2);
                        SQLiteDataReader reader2 = editOffercmd.ExecuteReader();
                        while (reader2.Read())
                        {
                            Label6.Text = reader2.GetString(2);
                            Label7.Text = reader2.GetString(4);
                        }
                        conn2.Close();
                }
                else
                {
                        Label2.Visible = false;
                        Label3.Visible = false;
                        Label4.Visible = false;
                        Label5.Visible = false;
                        Label6.Visible = false;
                        Label7.Visible = false;
                        TextBox1.Visible = false;
                        TextBox2.Visible = false;
                        Button1.Visible = false;
                        Label8.Visible = true;
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
            Developer d3 = new Developer();
            d3.editOffer(user,title,sum,comm,date);
            
            Response.Redirect("viewDevOffers.aspx");
            


        }
    }
}