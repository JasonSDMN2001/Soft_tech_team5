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
        Boolean anyNotifications = false;
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
                if (reader["bio"].ToString() != "")
                {
                    byte[] byteArray = (byte[])reader["bio"];
                    pdfframe.Src = GetDocument(byteArray).ToString();
                }
                LinkButton1.Text = reader.GetString(9);
            }
            String query2 = "Select * from recommendation where dev_name='" + user + "' and viewed='No'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                anyNotifications = true;
                String notified = reader2.GetString(0)+" recommended you to check out the project '"+reader2.GetString(1)+"'";
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Controls.Add(new LiteralControl("<label>• " + notified+ "</label>"));
                row.Cells.Add(cell);
                TableNotifications.Rows.Add(row);
            }
            if (!anyNotifications)
            {
                TableNotifications.Visible = false;
            }
            String query3 = "Delete from recommendation where dev_name='"+user+"'";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
            cmd3.ExecuteNonQuery();
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1.PostBackUrl = LinkButton1.Text;
        }
    }
}