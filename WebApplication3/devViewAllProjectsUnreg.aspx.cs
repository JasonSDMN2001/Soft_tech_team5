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
    public partial class devViewAllProjectsUnreg : System.Web.UI.Page
    {
        private String browsequery = "Select title,creation_date,max_price,rec_tech,num_offers from project where category='Web Site' and subcategory='Blog' and offer_show='Yes' ";
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";
        protected void Page_Load(object sender, EventArgs e)
        {
           // browseResults();
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
            browsequery = "Select title,creation_date,max_price,rec_tech,num_offers from project where offer_show='Yes' and category='" + category.SelectedValue + "'";
            browseResults();
        }

        protected void subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            browsequery = "Select title,creation_date,max_price,rec_tech,num_offers from project where offer_show='Yes' and subcategory='" + subcategory.SelectedValue + "'";
            browseResults();
        }

        protected void browseResults()
        {
            GridView1.Visible = true;
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            

            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(browsequery, conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

           
            conn.Close();
        }
    }
}