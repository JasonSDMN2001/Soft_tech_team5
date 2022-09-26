using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class clientMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void profileShow_Click(object sender, EventArgs e)
        {
            clientframe.Src = "clientProfile.aspx";
        }

        protected void createProject_Click(object sender, EventArgs e)
        {
            clientframe.Src = "createProject.aspx";
        }

        protected void searchClient_Click(object sender, EventArgs e)
        {
            clientframe.Src = "searchingProfilePage.aspx";
        }

        protected void searchProject_Click(object sender, EventArgs e)
        {
            clientframe.Src = "searchProject.aspx";
        }

        protected void searchDev_Click(object sender, EventArgs e)
        {
            clientframe.Src = "searchingDevProfilePage.aspx";
        }
    }
}