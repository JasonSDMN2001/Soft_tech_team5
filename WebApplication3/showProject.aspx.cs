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
            if (!Page.IsPostBack)
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
                    payment_method.Text = "Payment Method:  " + read.GetString(6);
                    string price = read.GetString(7);
                    if (price == "")
                    {
                        max_price.Text = "Doesn't exist";
                    }
                    else
                    {
                        max_price.Text = "Amount:  " + price + " €";
                    }
                    interval.Text = read.GetString(8);
                    string lang = read.GetString(10);
                    if (lang == "")
                    {
                        rec_tech.Text = "Doesn't exist";
                    }
                    else
                    {
                        rec_tech.Text = "Recommended Technologies to use:  " + lang;
                    }
                    client_username.Text = "Submitted by:  " + read.GetString(12);
                    if (read.GetString(16) == "Yes" & read.GetString(17) == "Yes")
                    {
                        //complete1.Visible = true;
                        rec_btn.Visible = false;
                    }
                    else if ((String)Session["Type"] == "Developer")
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
                 } */
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select username,sum_offer,date_offer,comments from dev_offer where title='" + titlename + "' and available='Yes'", conn);
                DataSet ds = new System.Data.DataSet();
                dataadapter.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();




                conn.Close();
            }
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

        protected void complete1_Click(object sender, EventArgs e)
        {
            Session["value"] = titlename;
            Response.Redirect("review.aspx");
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "offering")
            {
                String title = Request.Params["titlename"];
                int idx = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[idx];
                string recdev = row.Cells[1].Text;
                string sum = row.Cells[2].Text;
                string date = row.Cells[3].Text;
                string com = row.Cells[4].Text;
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("Update project set dev_username=@dev where title='" + title + "'", conn);
                cmd.Parameters.AddWithValue("@dev", recdev);
                cmd.ExecuteNonQuery();
                SQLiteCommand ucmd = new SQLiteCommand("Update dev_offer set accepted='Yes',available='No' where title='" + title + "' and sum_offer='"+sum+"' and date_offer='"+date+"' and comments='"+com+"'", conn);
                ucmd.ExecuteNonQuery();
                row.Cells.Clear();
                conn.Close();
            }
        }

        
    }
}