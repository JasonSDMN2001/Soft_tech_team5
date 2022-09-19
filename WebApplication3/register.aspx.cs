using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;



namespace WebApplication3
{
    public partial class Register : System.Web.UI.Page
    {
        string Gender;
        Byte[] bytes;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void cancelBack(object sender, EventArgs e)
        {
            Response.Redirect("mode_registration.aspx");
        }
        protected void makeUser_Click(object sender, EventArgs e)
        {
            
            bool bol = true;
            string script = "alert(\"There is already an account with that E-mail address\");";
            if (email.Text.Length == 0)//Zero length check
            {
                script = "alert(\"Email Address cannot be blank\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (!email.Text.Contains(".") || !email.Text.Contains("@")) //some other basic checks
            {
                script = "alert(\"Not a valid email address\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (pass.Text != pass2.Text)
            {
                script = "alert(\"Passwords are not identical\");";
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
            HttpPostedFile postedFile = FileUpload1.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filename);
            int fileSize = postedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".gif"
                || fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".bmp")
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                bytes = binaryReader.ReadBytes((int)stream.Length);
            }
            else
            {
                script = "alert(\"File is not an accepted picture type\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            if (bol) {
                Client c0 = new Client();
                c0.profileCreateClient(email.Text, username.Text, pass.Text, firstname.Text, lastname.Text, bytes);
                Response.Redirect("index.aspx");
            }


        }
        

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
            
        }
    }
}