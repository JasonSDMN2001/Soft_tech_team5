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
    public partial class viewDevOffers : System.Web.UI.Page
    {
        
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                if (DropDownList1.SelectedItem.Text == "Active Projects")
                {
                    string user = Session["Username"].ToString();
                    SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                    conn.Open();
                    String query1 = "Select title from project where dev_username='' ";
                    SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    string [] title = new string[];
                    int i = 0;
                    while (reader.Read())
                    {
                        title[i] = reader.GetString(0);
                        //if (title != null)
                       // {
                        //    browseOffers(title);
                        //}
                        i = i + 1;
                    }
                    conn.Close();
                    //browseOffers();
                }
            } */
            browseOffers();
                
        }

        protected void browseOffers()
        {
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,sum_offer,date_offer,comments from dev_offer where username= '" + user + "'", conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            conn.Close();
        }

    }
}