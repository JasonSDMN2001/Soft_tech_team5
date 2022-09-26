using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class devSearchProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void browsebtn_Click(object sender, EventArgs e)
        {
            searchbtn.Enabled = true;
            browsebtn.Enabled = false;
            searchbtn.BackColor = System.Drawing.Color.Gray;
            browsebtn.BackColor = System.Drawing.Color.White;
            projframe.Src = "devViewAllProjects.aspx";
        }

        protected void searchbtn_Click(object sender, EventArgs e)
        {
            searchbtn.Enabled = false;
            browsebtn.Enabled = true;
            searchbtn.BackColor = System.Drawing.Color.White;
            browsebtn.BackColor = System.Drawing.Color.Gray;
            //projframe.Src = "searchingProjectPage.aspx";
        }
    }
}