using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data;

namespace WebApplication3
{
    public partial class searchingProjectPage : System.Web.UI.Page
    {
        private String searchquery = "Select title,creation_date,max_price,rec_tech from project";
        private String datecheck = "Order by creation_date desc";
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SQLiteConnection conn = new SQLiteConnection(db);
                conn.Open();
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(searchquery, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                conn.Close();
                ViewState["categorycheck"] = "";
                ViewState["subcategorycheck"] = "";
            }
        }

        protected void searchprojectbtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            if (CheckBox1.Checked)
            {
                datecheck = "Order by creation_date asc";
            }
      
  
            searchquery = "Select title,creation_date,max_price,rec_tech from project where title like '%"+title.Text+"%' and description like '%"+description.Text+"%' and rec_tech like '%"+rec_tech.Text+"%' and proj_type='Public'"+ViewState["categorycheck"]+ ViewState["subcategorycheck"] + datecheck;
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(searchquery, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            conn.Close();
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
            ViewState["categorycheck"] = " and category='" + category.SelectedValue.ToString() + "'";
        }

        protected void subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["subcategorycheck"] = " and category='" + category.SelectedValue.ToString() + "'";
        }
    }
}