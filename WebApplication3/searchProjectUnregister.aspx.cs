using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class searchProjectUnregister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void searchbtn_Click2(object sender, EventArgs e)
        {
            searchbtn2.Enabled = false;
            browsebtn2.Enabled = true;
            searchbtn2.BackColor = System.Drawing.Color.White;
            browsebtn2.BackColor = System.Drawing.Color.Gray;
            resframe2.Src = "searchingProjectPage.aspx";
        }

        protected void browsebtn_Click2(object sender, EventArgs e)
        {
            searchbtn2.Enabled = true;
            browsebtn2.Enabled = false;
            searchbtn2.BackColor = System.Drawing.Color.Gray;
            browsebtn2.BackColor = System.Drawing.Color.White;
            resframe2.Src = "viewAllProjectsUnreg.aspx";
        }
    }
}