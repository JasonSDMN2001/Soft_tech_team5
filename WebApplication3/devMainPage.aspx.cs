using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class devMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void profileShow_Click(object sender, EventArgs e)
        {
            devframe.Src = "devProfile.aspx";
        }

        protected void projinprogress_Click(object sender, EventArgs e)
        {
            Response.Redirect("devProjects.aspx");
        }

        protected void searchProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("devSearchProject.aspx");
        }

        protected void searchuser_Click(object sender, EventArgs e)
        {
            devframe.Src = "searchingProfilePage.aspx";
        }
        protected void searchdev_Click(object sender, EventArgs e)
        {
            devframe.Src = "searchingDevProfilePage.aspx";
        }
    }
}