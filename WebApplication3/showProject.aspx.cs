using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
                payment_method.Text = "Payment Method"+read.GetString(6);
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
                    rec_tech.Text = "Recommended Technologies to use:"+lang;
                }
                client_username.Text = "Submitted by:  " + read.GetString(12);
                if (read.GetString(17) == "Yes" & read.GetString(18) == "Yes")
                {
                    complete.Visible = true;
                }
                else if((String)Session["Type"]=="Developer")
                {
                    offerbtn.Visible = true;
                }
            }


           /* SQLiteCommand offerViewcmd = new SQLiteCommand("Select name_offer, sum_offer, date_offer, devs_comment from suboffer where title ='" + titlename + "'", conn);
            SQLiteDataReader reader = offerViewcmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == titlename)
                {
                    Label1.Visible = true;
                }
            }
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select name_offer,sum_offer,date_offer,devs_comment from offer where title='" + titlename + "'", conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind(); */
            



            conn.Close();
        }

        protected void offerbtn_Click(object sender, EventArgs e)
        {
            Session["value"] = titlename;
            Response.Redirect("submitOffer.aspx");
           
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Session["value"] = titlename;
            Response.Redirect("Recommend.aspx");
        }
    }
}