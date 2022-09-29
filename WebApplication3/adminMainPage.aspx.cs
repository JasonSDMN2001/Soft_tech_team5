using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class adminMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminDeleteClient_Click(object sender, EventArgs e)
        {
            adminframe.Src = "adminDeleteClient";
        }

        protected void adminDeleteDev_Click(object sender, EventArgs e)
        {
            adminframe.Src = "adminDeleteDev";
        }

        protected void adminDeleteProject_Click(object sender, EventArgs e)
        {
            adminframe.Src = "adminDeleteProject";
        }
    }
}