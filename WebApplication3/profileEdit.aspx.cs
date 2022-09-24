using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Linq;





namespace WebApplication3
{
    public partial class profileEdit : System.Web.UI.Page
    {
        byte[] bytes;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string user = Session["Username"].ToString();
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                String query1 = "Select * from client where username='" + user + "';";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email.Text = reader.GetString(0);
                    username.Text = reader.GetString(1);
                    firstname.Text = reader.GetString(3);
                    lastname.Text = reader.GetString(4);
                    gender.Text = reader.GetString(5);
                    birthdate.Text = reader.GetString(6);
                    if (reader["pic"].ToString() == "")
                    {
                        ImageID.ImageUrl = "";
                    }
                    else
                    {
                        byte[] bytes = (byte[])reader["pic"];
                        ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                    }
                    description.Text = reader.GetString(8);
                    pagelink.Text = reader.GetString(9);
                }
                conn.Close();
            }
        }



        protected void cancelbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("clientProfile.aspx");
        }



        protected void savebtn_Click(object sender, EventArgs e)
        {
            string script = "alert(\"\");";
            HttpPostedFile postedFile = FileUpload2.PostedFile;
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
            }
            string user = Session["Username"].ToString();
            SQLiteConnection conU = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conU.Open();
            String queryU = "UPDATE client SET username=@username, email=@email, firstname=@firstname, lastname=@lastname, "
                + "gender=@gender, birthdate=@birthdate, pic=@pic, pagelink=@pagelink, description=@description"
                + " where username='" + user + "';";
            SQLiteCommand cmd = new SQLiteCommand(queryU, conU);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@firstname", firstname.Text);
            cmd.Parameters.AddWithValue("@lastname", lastname.Text);
            cmd.Parameters.AddWithValue("@gender", gender.Text);
            cmd.Parameters.AddWithValue("@birthdate", birthdate.Text);
            cmd.Parameters.AddWithValue("@pic", bytes);
            cmd.Parameters.AddWithValue("@pagelink", pagelink.Text);
            cmd.Parameters.AddWithValue("@description", description.Text);
            Response.Write(firstname.Text);
            cmd.ExecuteNonQuery();
            String queryV = "update client_profile_hidden set email=@email,fullname=@fullname,gender=@gender,birthdate=@birthdate,pagelink=@pagelink where username='"+user+"'";
            SQLiteCommand cmdvisible = new SQLiteCommand(queryV, conU);
            cmdvisible.Parameters.AddWithValue("@email",emailcheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@fullname", fullnamecheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@gender", gendercheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@birthdate", birthdatecheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@pagelink", pagelinkcheck.Checked.ToString());
            cmdvisible.ExecuteNonQuery();
            conU.Close();
            Response.Redirect("clientProfile.aspx");
        }
    }
}