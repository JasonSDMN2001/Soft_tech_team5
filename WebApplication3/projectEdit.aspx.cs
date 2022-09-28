using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace WebApplication3
{
    public partial class projectEdit : System.Web.UI.Page
    {
        String titleID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                titleID = Request.QueryString["ogtitle"]; 
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                String query1 = "Select * from project where title='" + titleID + "';";
                SQLiteCommand projectEditcmd = new SQLiteCommand(query1, conn);
                SQLiteDataReader reader = projectEditcmd.ExecuteReader();
                while (reader.Read())
                {
                    title.Text = titleID;
                    description.Text = reader.GetString(1);
                    max_price.Text = reader.GetString(7);
                    rec_tech.Text = reader.GetString(10);
                }
                conn.Close();
            }
        }

        protected void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = category.SelectedItem.Text;
            subcategory.Items.Clear();

            switch (selectedCategory)
            {
                case "Web Site":
                    subcategory.Items.Add("Blog");
                    subcategory.Items.Add("Corporate");
                    subcategory.Items.Add("Ecommerce");
                    subcategory.Items.Add("Portal");
                    subcategory.Items.Add("Video Streaming");
                    break;
                case "Database":
                    subcategory.Items.Add("Bank Management System");
                    subcategory.Items.Add("Inventory Control");
                    subcategory.Items.Add("Insurance Management System");
                    subcategory.Items.Add("Booking Services");
                    break;
                case "Mobile app":
                    subcategory.Items.Add("Social Media");
                    subcategory.Items.Add("Entertainment");
                    subcategory.Items.Add("News Outlet");
                    subcategory.Items.Add("Game");
                    subcategory.Items.Add("Utility Software");
                    break;
                case "Security":
                    subcategory.Items.Add("Anti-virus");
                    subcategory.Items.Add("Firewall Software");
                    subcategory.Items.Add("Network Security");
                    subcategory.Items.Add("Internet Software");
                    subcategory.Items.Add("Malware Removal");
                    break;
            }
        }

        protected void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                titleID = Request.QueryString["ogtitle"];
                Client updating = new Client();
                updating.editProject(titleID, title.Text, description.Text, proj_type.SelectedValue.ToString(), offer_show.SelectedValue.ToString(), category.SelectedValue.ToString(), subcategory.SelectedValue.ToString(), payment_method.SelectedValue.ToString(), max_price.Text, interval.SelectedValue.ToString(), uptime.SelectedValue.ToString(), rec_tech.Text);
                Response.Redirect("clientProfile.aspx");
                }
                catch
                {
                    String script = "alert(\"Check if all the required fields are filled\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
    }
}