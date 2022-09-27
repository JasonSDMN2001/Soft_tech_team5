using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class submitOffer : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //string value = Request.QueryString["titlename"].ToString();
            //string value = Request.Params["titlename"].ToString();
            
            //string title = Session["value"].ToString();
            //Response.Write(Request.QueryString["val"]);
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            //title = Request.Params["title"];
            string title = Session["value"].ToString();
            string user = Session["Username"].ToString();
            string date = DateTime.Now.ToString("dd-MM-yyyy");
       
            Developer devoffer = new Developer();
            devoffer.submitProjectOffer(user,title,TextBox1.Text,date,TextBox2.Text);
            //devoffer.submitProjectOffer(date);

            //string script = "alert(\"Offer has been submitted successfully\");";
           // ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true); 
        }
    }
}