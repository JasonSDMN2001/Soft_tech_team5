using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class searchingDevProfilePage : System.Web.UI.Page
    {
        private string dev;
        private int projcount;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select email from dev where username='" + SearchBox.Text + "'";
            if (CheckBox2.Checked)
            {
                query1 = "select email from dev where skills like '%" + subcategory.SelectedItem.Text + "%'";
            }
            if (CheckBox1.Checked)
            {
                query1 += "Order by creation_date asc";
            }
            if (CheckBox3.Checked)
            {
                String query2 = "select dev_username from review where stars between " + Int32.Parse(DropDownList1.SelectedValue) + " and " + Int32.Parse(DropDownList2.SelectedValue) + "";
                SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                SQLiteDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    dev = reader2.GetString(0);
                }
                query1 = "Select email from dev where username='" + dev + "'";

            }
            if (CheckBox4.Checked)
            {
                String query3 = "select count(dev_username),dev_username from project where client_done='Yes' and dev_done='Yes'";
                SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
                SQLiteDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    projcount = reader3.GetInt32(0);
                    dev = reader3.GetString(1);
                }
                try
                {
                    if (projcount > Int32.Parse(TextBox1.Text))
                    {
                        query1 = "Select email from dev where username='" + dev + "'";
                    }
                }
                catch
                {
                    Label2.Text = "there are no devs with these characteristics";
                }

            }
           // Client c1 = new Client();
           // c1.searchDev(query1);
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            string temp;
            while (reader.Read())
            {
                temp = reader.GetString(0);
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                cell.Controls.Add(new LiteralControl("<iframe id=" + temp + " width='100%' height='100%' src='showDevProfile.aspx?emailID=" + temp + "'></iframe>"));
                row.Cells.Add(cell);
                TableShow.Rows.Add(row);
            }
            conn.Close();
        }
    }
}