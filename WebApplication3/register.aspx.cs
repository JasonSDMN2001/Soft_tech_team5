using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void makeUser_Click(object sender, EventArgs e)
        {
            bool bol = true;
            string script = "alert(\"There is already an account with that E-mail address\");";
            if (email.Text.Length == 0)//Zero length check
            {
                script = "alert(\"Email Address cannot be blank\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol= false;
            }
            else if (!email.Text.Contains(".") || !email.Text.Contains("@")) //some other basic checks
            {
                script = "alert(\"Not a valid email address\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (pass.Text.Length < 6)
            {
                script = "alert(\"Password cannot be less than 6 chars\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (username.Text.Length < 3)
            {
                script = "alert(\"Username cannot be less than 3 chars\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            if (bol && client.Checked) {
                Client c0 = new Client();
                c0.profileCreate(email.Text, username.Text, pass.Text, firstname.Text, lastname.Text);
                Response.Redirect("index.aspx");
            }
            else if (developer.Checked)
            {
                Developer d0 = new Developer();
                d0.profileCreate(email.Text, username.Text, pass.Text, firstname.Text, lastname.Text);
            }
            
        }
    }
}