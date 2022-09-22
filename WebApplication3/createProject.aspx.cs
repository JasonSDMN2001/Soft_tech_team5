using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class createProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            Client cproj = new Client();
            string creation_date = DateTime.Now.ToString("yyyy-mm-dd");
            cproj.createProject(title.Text,proj_description.Text,publicity.SelectedItem.Text,view_offer.SelectedItem.Text,category.SelectedItem.Text,subcategory.SelectedItem.Text,payment_method.SelectedItem.Text,maxprice.Text,devduration.SelectedItem.Text,offerduration.SelectedItem.Text,"",user,creation_date);
            string script = "alert(\"Project has been submitted successfully\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }

        protected void category_SelectedIndexChanged(object sender,EventArgs e)
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
    }
}