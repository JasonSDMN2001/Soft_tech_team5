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
    public partial class incomingOffers : System.Web.UI.Page
    {
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";
        protected void Page_Load(object sender, EventArgs e)
        {
           // browseIncomingOffers();
        }

      /*  protected void browseIncomingOffers()
        {
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            string query1 = "Select title from project where client_username= '" + user + "' and dev_username IS NULL ";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string query2 = "Select username,title,sum_offer,date_offer,comments from dev_offer where title = '" + reader.GetString(0) + "'";

                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(query2, conn);
                

            }
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            conn.Close(); 

        } */
    }
}