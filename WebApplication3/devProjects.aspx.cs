using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class devProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Active")
            {
                string user = Session["Username"].ToString();
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                String query1 = "Select title,description,category,subcategory,client_username,language,dev_price,client_done,dev_done from project where dev_username=@dev_username and client_done=@client_done and dev_done=@dev_done";
              /*  if (CheckBox1.Checked)
                {
                    query1 += "Order by creation_date asc";
                } */
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                cmd.Parameters.AddWithValue("@dev_username", user);
                cmd.Parameters.AddWithValue("@client_done", "Yes");
                cmd.Parameters.AddWithValue("@dev_done", "Yes");
                SQLiteDataReader reader = cmd.ExecuteReader();
                // string temp;
               // Response.Write(reader.);
                while (reader.Read())
                {
                   // int i = 0;
                   
                    string temp = reader.GetString(0);
                    string temp1 = reader.GetString(1);
                    string temp2 = reader.GetString(2);
                    string temp3 = reader.GetString(3);
                    string temp4 = reader.GetString(4);
                    string temp5 = reader.GetString(5);
                    string temp6 = reader.GetString(6);
                    string temp7 = reader.GetString(7);
                    string temp8 = reader.GetString(8); 
                   
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                   /* for(int j = 0; j < 7; j++)
                    {
                        
                    } */

                    // cell.Controls.Add(new LiteralControl("<iframe id=" + temp + " width='100%' height='100%' src='showClientProfile.aspx?emailID=" + temp + "'></iframe>"));
                    // row.Cells.Add(cell);
                    cell.Controls.Add(new LiteralControl(temp));
                    cell.Controls.Add(new LiteralControl(temp1));
                    cell.Controls.Add(new LiteralControl(temp2));
                    cell.Controls.Add(new LiteralControl(temp3));
                    cell.Controls.Add(new LiteralControl(temp4));
                    cell.Controls.Add(new LiteralControl(temp5));
                    cell.Controls.Add(new LiteralControl(temp6));
                    cell.Controls.Add(new LiteralControl(temp7));
                    cell.Controls.Add(new LiteralControl(temp8));
                    row.Cells.Add(cell);
                    Table1.Rows.Add(row);
                }
                conn.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}