using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class showDevProfile : System.Web.UI.Page
    {
        private string emailID;
        private string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            emailID = Request.Params["emailID"];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from dev where email='" + emailID + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Email2.Text = reader.GetString(0);
                username2.Text = reader.GetString(1) + "    ";
                user = reader.GetString(1); 
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
                LinkButton1.Text = reader.GetString(9);
                if (reader["bio"].ToString() != "")
                {
                    byte[] byteArray = (byte[])reader["bio"];
                    pdfframe.Src = GetDocument(byteArray).ToString();
                }
            }
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select stars,title from review where dev_username='"+user+"'", conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            SQLiteDataAdapter dataadapter2 = new SQLiteDataAdapter("select title from project where dev_username='"+user+"' and client_done='Yes' and dev_done='Yes'", conn);
            DataSet ds2 = new System.Data.DataSet();
            dataadapter2.Fill(ds2);
            GridView2.DataSource = ds2.Tables[0];
            GridView2.DataBind();
            String query2 = "Select * from dev_profile_hidden where username='"+user+"'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                if (reader2.GetString(0) == "False")
                {
                    Email2.Visible = false;
                }
                if (reader2.GetString(1) == "False")
                {
                    fullname2.Visible = false;
                }
                if (reader2.GetString(2) == "False")
                {
                    gender2.Visible = false;
                }
                if (reader2.GetString(4) == "False")
                {
                    LinkButton1.Visible = false;
                }
                if (reader2.GetString(5) == "False")
                {
                    pdfframe.Visible = false;
                }
            }
            conn.Close();
        }

        public object GetDocument(byte[] byteArray)
        {
            return "data:application/pdf;base64," + Convert.ToBase64String(byteArray);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1.PostBackUrl = LinkButton1.Text;

        }
    }
}