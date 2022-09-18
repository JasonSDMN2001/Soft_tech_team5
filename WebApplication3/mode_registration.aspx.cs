using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Mode_registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            clientframe.Src = "register.aspx";
            Button3.Visible = false;
            Button4.Visible = false;
            Label2.Text = "A Client";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            clientframe.Src = "registerdev.aspx";
            Button3.Visible = false;
            Button4.Visible = false;
            Label2.Text = "A Developer";
        }
    }
}