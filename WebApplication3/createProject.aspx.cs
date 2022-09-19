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
            //cproj.createProject(title.Text,proj_description.Text,publicity.Text,view_offer.Text,category.Text,"",payment_method.SelectedValue,maxprice.Text,devduration.Text,offerduration.Text,"",user);
        }
    }
}