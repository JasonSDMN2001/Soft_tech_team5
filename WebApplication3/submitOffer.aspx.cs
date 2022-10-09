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
        string title;
        string user;
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Text = Session["Username"].ToString();
            TextBox4.Text = Session["value"].ToString();
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            date = DateTime.Now.ToString("dd-MM-yyyy");
            Developer d4 = new Developer();
            d4.submitProjectOffer(TextBox3.Text,TextBox4.Text,TextBox1.Text,date,TextBox2.Text);
            
            Response.Redirect("showProject.aspx");
        }
    }
}