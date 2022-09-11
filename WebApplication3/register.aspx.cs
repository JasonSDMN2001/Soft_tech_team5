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
            try
            {
                if (client.Checked) {
                    Client c0 = new Client();
                    c0.profileCreate(email.Text, username.Text, pass.Text, firstname.Text, lastname.Text);
                    Response.Redirect("indexing.aspx");
                }
                else
                {
                    Developer d0 = new Developer();
                    d0.profileCreate(email.Text, username.Text, pass.Text, firstname.Text, lastname.Text);
                }
            }
            catch
            {
                string script = "alert(\"There is already an account with that E-mail address\");";
                if (email.Text.Length == 0)//Zero length check
                {
                    script = "Email Address cannot be blank";
                }
                else if (!email.Text.Contains(".") || !email.Text.Contains("@")) //some other basic checks
                {
                    script = "Not a valid email address";
                }
                else if (pass.Text.Length < 5)
                {
                    script = "Password cannot be less than 5 chars";
                }
                else if (username.Text.Length < 3)
                {
                    script = "Username cannot be less than 3 chars";
                }
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
    }
}