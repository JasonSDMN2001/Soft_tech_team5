using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class viewAllProjects : System.Web.UI.Page
    {
        private String browsequery = "Select title,creation_date,max_price,rec_tech from project";
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";
        protected void Page_Load(object sender, EventArgs e)
        {
            browseResults();
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
            browsequery = "Select title,creation_date,max_price,rec_tech from project where category='" + category.SelectedValue+"'";
            browseResults();
        }

        protected void subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            browsequery = "Select title,creation_date,max_price,rec_tech from project where subcategory='" + subcategory.SelectedValue + "'";
            browseResults();
        }

        protected void browseResults()
        {
            TableID.Controls.Clear();
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand browsecmd = new SQLiteCommand(browsequery, conn);
            SQLiteDataReader reader = browsecmd.ExecuteReader();
            string title, price, rec_tech;
            while (reader.Read())
            {
                title = reader.GetString(0);
                price = reader.GetString(2);
                rec_tech = reader.GetString(3);
                if (price == "")
                {
                    price = " Doesn't exist";
                }
                if (rec_tech=="")
                {
                    rec_tech = " Doesn't exist";
                }
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Controls.Add(new LiteralControl("<a href=\"showClientProfile.aspx?titleID=" + title + "\">" + title + "</a>"));
                TableCell cell1 = new TableCell();
                row.Cells.Add(cell);
                cell1.Controls.Add(new LiteralControl("<label>   Submitted on:" + reader.GetString(1) + ",</label>"));
                cell1.Controls.Add(new LiteralControl("<label>   Payment: " + price + "€, </label>"));
                row.Cells.Add(cell1);
                TableCell cell2 = new TableCell();
                cell2.Controls.Add(new LiteralControl("<label>   Recommended technolgy:" + rec_tech + "</label>"));
                row.Cells.Add(cell2);
                TableID.Rows.Add(row);
            }
            conn.Close();
        }
    }
}