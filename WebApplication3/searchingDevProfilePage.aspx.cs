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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select email from dev where username='" + SearchBox.Text + "'";
            if (CheckBox1.Checked)
            {
                query1 += "Order by creation_date asc";
            }
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