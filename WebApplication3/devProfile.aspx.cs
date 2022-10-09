using System;
using System.Collections.Generic;
using System.Data;
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
        Boolean anyNotifications = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Session["Username"].ToString();
            Developer d8 = new Developer();
            string []arr = d8.profileShow(user, ImageID, pdfframe);

            Email2.Text = arr[0];
            username2.Text = arr[1];
            fullname2.Text = arr[2];
            gender2.Text = arr[3];
            skills2.Text = arr[4];
            LinkButton1.Text = arr[5];
            /*SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from dev where username='" + user + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader(); */
            //SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            //conn.Open();
            /* while (reader22.Read())
             {
                 Email2.Text = reader22.GetString(0);
                 username2.Text = reader22.GetString(1) + "    ";
                 fullname2.Text = "   " + reader22.GetString(3) + " " + reader22.GetString(4);
                 gender2.Text = "     " + reader22.GetString(5);
                 if (reader22["pic"].ToString() == "")
                 {
                     ImageID.ImageUrl = "";
                 }
                 else
                 {
                     byte[] bytes = (byte[])reader22["pic"];
                     ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                 }   
                 skills2.Text = reader22.GetString(7);
                 if (reader22["bio"].ToString() != "")
                 {
                     byte[] byteArray = (byte[])reader22["bio"];
                     pdfframe.Src = GetDocument(byteArray).ToString();
                 }
                 LinkButton1.Text = reader22.GetString(9);
             } */
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            try
            {
                String query2 = "Select * from recommendation where dev_name='" + user + "' and viewed='No'";
                SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    anyNotifications = true;
                    String notified = reader2.GetString(2) + " recommended you to check out the project '" + reader2.GetString(1) + "'";
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                    cell.Controls.Add(new LiteralControl("<label>• " + notified + "</label>"));
                    row.Cells.Add(cell);
                    TableNotifications.Rows.Add(row);
                }
                if (!anyNotifications)
                {
                    TableNotifications.Visible = false;
                }
                String query3 = "Delete from recommendation where dev_name='" + user + "'";
                SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
                cmd3.ExecuteNonQuery();
            }
            catch
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Controls.Add(new LiteralControl("<label>• " + "no new notifications" + "</label>"));
            }
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("select stars,title from review where dev_username='"+user+"'", conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            SQLiteDataAdapter dataadapter2 = new SQLiteDataAdapter("select title from project where dev_username='" + user + "' and client_done='Yes' and dev_done='Yes'", conn);
            DataSet ds2 = new System.Data.DataSet();
            dataadapter2.Fill(ds2);
            GridView2.DataSource = ds2.Tables[0];
            GridView2.DataBind();
            conn.Close();
        }

        public string getEmail2()
        {
            return Email2.Text;
        }
        public void setEmail2(string newName)
        {
            this.Email2.Text = newName;
        }


        public object GetDocument(byte[] byteArray)
        {
            return "data:application/pdf;base64," + Convert.ToBase64String(byteArray);
        }
        


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("devProfileEdit.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1.PostBackUrl = LinkButton1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("offerNews.aspx");
        }
    }
}