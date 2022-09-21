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
        Byte[] bytes;
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
                    skills.Text = reader.GetString(7);
                    if (reader["pic"].ToString() == "")
                    {
                        ImageID.ImageUrl = "";
                    }
                    else
                    {
                        byte[] bytes = (byte[])reader["pic"];
                        ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                    }

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
                    bytes = binaryReader.ReadBytes((int)stream.Length);
                }
                else
                {
                    script = "alert(\"File is not an accepted picture type\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            string user = Session["Username"].ToString();
            SQLiteConnection conU = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conU.Open();
            String queryU = "UPDATE dev SET username=@username, email=@email, firstname=@firstname, lastname=@lastname, "
                + "gender=@gender, skills=@skills, pic=@pic"
                + " where username='" + user + "';";
            SQLiteCommand cmd = new SQLiteCommand(queryU, conU);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@firstname", firstname.Text);
            cmd.Parameters.AddWithValue("@lastname", lastname.Text);
            cmd.Parameters.AddWithValue("@gender", gender.Text);
            cmd.Parameters.AddWithValue("@skills", skills.Text);
            cmd.Parameters.AddWithValue("@pic", bytes);
            Response.Write(firstname.Text);
            cmd.ExecuteNonQuery();
            conU.Close();
            Response.Redirect("devProfile.aspx");
        }
    }
}