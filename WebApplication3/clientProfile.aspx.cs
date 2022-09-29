using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication3
{
    public partial class clientProfile : System.Web.UI.Page
    {
        private string title;
        private string user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from client where username='" + user + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email.Text = reader.GetString(0);
                username.Text = reader.GetString(1) + "    ";
                fullname.Text = "   " + reader.GetString(3) + " " + reader.GetString(4);
                gender.Text = "     " + reader.GetString(5);
                birthdate.Text = "     " + reader.GetString(6);

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
                pagelink.NavigateUrl = reader.GetString(9);
            }
            String query2 = "Select title,proj_type,client_done,dev_done from project where client_username='" + user + "'";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                title= reader2.GetString(0);
                String projectcell;
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Controls.Add(new LiteralControl("<label>• " + reader2.GetString(0)));
                TableCell cell1 = new TableCell();
                cell1.Controls.Add(new LiteralControl(reader2.GetString(1)));
                row.Cells.Add(cell);
                row.Cells.Add(cell1);
                TableCell cell2 = new TableCell();
                if (reader2.GetString(2) == "Yes" & reader2.GetString(3) == "Yes")
                {
                    projectcell = "Completed";
                    cell2.Controls.Add(new LiteralControl(projectcell + "</label>"));
                }
                else if(reader2.GetString(2) == "No" & reader2.GetString(3) == "Yes")
                {
                    projectcell = "Active,press to finish";
                    LinkButton btnM = new LinkButton();
                    btnM.Text = "Complete";
                    btnM.Enabled = true;
                    btnM.Click += new System.EventHandler(this.btnM_Click);
                    cell2.Controls.Add(btnM);
                }
                row.Cells.Add(cell2);
                TableCell cell3 = new TableCell();
                cell3.Controls.Add(new LiteralControl("<a href=\"showProject.aspx?titlename=" + title + "\">" + title + "</a>"));
                row.Cells.Add(cell3);
                projectTable.Rows.Add(row);
            }
            conn.Close();
        }

        protected void btnM_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            string query3 = "Update project set client_done='Yes' where client_username='"+user+"'";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
            cmd3.ExecuteNonQuery();
            conn.Clone();
            Session["username"] = user;
            Session["value"] = title;
            Response.Redirect("review.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("profileEdit.aspx");
        }
    }
}