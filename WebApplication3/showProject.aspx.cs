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
    public partial class showProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Request.QueryString["title"];
            //string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select title,description,category,subcategory,client_username,language,dev_price,client_done,dev_done from project where dev_username=@dev_username and client_done=@client_done and dev_done=@dev_done";

            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
           // cmd.Parameters.AddWithValue("@dev_username", user);
            cmd.Parameters.AddWithValue("@client_done", "Yes");
            cmd.Parameters.AddWithValue("@dev_done", "Yes");
            // SQLiteDataReader reader = cmd.ExecuteReader();

            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,description,category,subcategory,payment_method,max_price,interval,uptime,client_username,creation_date,language,num_offers from project where title='" + Request.QueryString["title"] + "' " , conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            conn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}