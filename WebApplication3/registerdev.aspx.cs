using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication3
{
    public partial class Registerdev : System.Web.UI.Page
    {
        
        Byte[] bytes;
        Byte[] bytes2;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void cancelBack(object sender, EventArgs e)
        {
            Response.Redirect("mode_registration.aspx");
        }
        protected void makeDev_Click(object sender, EventArgs e)
        {
            
            bool bol = true;
            bool bol1 = true;
            bool bol2 = true;
            string script = "alert(\"There is already an account with that E-mail address\");";
            if (email1.Text.Length == 0)//Zero length check
            {
                script = "alert(\"Email Address cannot be blank\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (!email1.Text.Contains(".") || !email1.Text.Contains("@")) //some other basic checks
            {
                script = "alert(\"Not a valid email address\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (pass1.Text != passw2.Text)
            {
                script = "alert(\"Passwords are not identical\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (pass1.Text.Length < 6)
            {
                script = "alert(\"Password cannot be less than 6 chars\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (username1.Text.Length < 3)
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
                bol1 = false;
            }
            HttpPostedFile postedFile2 = FileUpload2.PostedFile;
            string filename2 = Path.GetFileName(postedFile2.FileName);
            //string fileExtension2 = Path.GetExtension(filename2);
            int fileSize2 = postedFile2.ContentLength;

            if (postedFile2.ContentType == "application/pdf")
            {
                Stream stream2 = postedFile2.InputStream;
                BinaryReader binaryReader2 = new BinaryReader(stream2);
                bytes2 = binaryReader2.ReadBytes((int)stream2.Length);
                
            }
            else
            {
                script = "alert(\"File is not an accepted type\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                
                bol2 = false;
            }
            if (bol&&bol1&&bol2)
            {
                Developer d0 = new Developer();
                d0.profileCreateDev(email1.Text, username1.Text, pass1.Text, firstname1.Text, lastname1.Text, bytes,bytes2);
                Response.Redirect("index.aspx");
            }

        }
        
    }
}