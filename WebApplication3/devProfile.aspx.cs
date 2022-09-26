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
    public partial class devProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from dev where username='" + user + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Email2.Text = reader.GetString(0);
                username2.Text = reader.GetString(1) + "    ";
                fullname2.Text = "   " + reader.GetString(3) + " " + reader.GetString(4);
                gender2.Text = "     " + reader.GetString(5);
                if (reader["pic"].ToString() == "")
                {
                    ImageID.ImageUrl = "";
                }
                else
                {
                    byte[] bytes = (byte[])reader["pic"];
                    ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                }   
                skills2.Text = reader.GetString(7);
                try{
                    byte[] byteArray = (byte[])reader["bio"];
                    pdfframe.Src = GetDocument(byteArray).ToString();
                }
                catch { }
                //pagelink.NavigateUrl = reader.GetString(9);
            }
            conn.Close();
        }



        public object GetDocument(byte[] byteArray)
        {
            return "data:application/pdf;base64," + Convert.ToBase64String(byteArray);
        }
        


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("devProfileEdit.aspx");



        }
    }
}