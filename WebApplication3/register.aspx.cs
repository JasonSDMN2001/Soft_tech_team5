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
            if (bol) {
                Client c0 = new Client();
                c0.profileCreateClient(email.Text, username.Text, pass.Text, firstname.Text, lastname.Text, image);
                Response.Redirect("index.aspx");
            }


        }
        protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Images/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            //Display the Picture in Image control.
            image.ImageUrl = "~/Images/" + Path.GetFileName(FileUpload1.FileName);
            //string img = (string)image;
        }
        public byte[] ImageToByteArray(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            
            return data;
        }
        
            
    }
}