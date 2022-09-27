using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication3
{
    public partial class devProfileEdit : System.Web.UI.Page
    {
        Byte[] bytes1= null;
        Byte[] bytes2=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string user = Session["Username"].ToString();
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                String query1 = "Select * from dev where username='" + user + "';";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email.Text = reader.GetString(0);
                    username.Text = reader.GetString(1);
                    firstname.Text = reader.GetString(3);
                    lastname.Text = reader.GetString(4);
                    gender.Text = reader.GetString(5);
                    if (reader["pic"].ToString() == "")
                    {
                        ImageID.ImageUrl = "";
                    }
                    else
                    {
                        byte[] bytes = (byte[])reader["pic"];
                        ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                        bytes1 = bytes;
                    }
                    if (reader["bio"].ToString() != "")
                    {
                        byte[] byteArray = (byte[])reader["bio"];
                        bytes2 = byteArray;
                    }
                    
                    skills.Text = reader.GetString(7);
                    
                    port.Text=reader.GetString(9);
                }
                conn.Close();
            }
        }



        protected void cancelbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("devProfile.aspx");
        }



        protected void savebtn_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
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
                    bytes1 = binaryReader.ReadBytes((int)stream.Length);
                }
                else
                {
                    script = "alert(\"File is not an accepted picture type\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            if (FileUpload1.HasFile)
            {
                string script = "alert(\"\");";
                HttpPostedFile postedFile2 = FileUpload1.PostedFile;
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
                }
            }
            string user = Session["Username"].ToString();
            SQLiteConnection conU = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conU.Open();
            String queryU = "UPDATE dev SET username=@username, email=@email, firstname=@firstname, lastname=@lastname, "
                + "gender=@gender, skills=@skills, pic=@pic ,portfolio=@portfolio, bio=@bio"
                + " where username='" + user + "';";
            SQLiteCommand cmd = new SQLiteCommand(queryU, conU);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@firstname", firstname.Text);
            cmd.Parameters.AddWithValue("@lastname", lastname.Text);
            cmd.Parameters.AddWithValue("@gender", gender.Text);
            cmd.Parameters.AddWithValue("@skills", skills.Text);
            cmd.Parameters.AddWithValue("@pic", bytes1);
            cmd.Parameters.AddWithValue("@bio", bytes2);
            cmd.Parameters.AddWithValue("@portfolio", port.Text);
            Response.Write(firstname.Text);
            cmd.ExecuteNonQuery();
            String queryV = "update dev_profile_hidden set email=@email,fullname=@fullname,gender=@gender,port=@port,cv=@cv where username='" + user + "'";
            SQLiteCommand cmdvisible = new SQLiteCommand(queryV, conU);
            cmdvisible.Parameters.AddWithValue("@email", emailcheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@fullname", namecheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@gender", gendercheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@port", portcheck.Checked.ToString());
            cmdvisible.Parameters.AddWithValue("@cv", Cvcheck.Checked.ToString());
            cmdvisible.ExecuteNonQuery();
            conU.Close();
            Response.Redirect("devProfile.aspx");
        }
    }
}