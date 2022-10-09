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
            
            browseOffers();
                
        }

        protected void browseOffers()
        {
            string user = Session["Username"].ToString();
            Developer d2 = new Developer();
           // d2.viewDevOffers(user);
    
            DataSet ds = new System.Data.DataSet();
            d2.viewDevOffers(user).Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            
        }

    }
}