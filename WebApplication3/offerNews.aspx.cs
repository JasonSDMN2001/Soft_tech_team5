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
    public partial class offerNews : System.Web.UI.Page
    {
        Boolean anyNotifications = false;
        private String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";
        protected void Page_Load(object sender, EventArgs e)
        {
            browseOffers();
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            try
            {
                String query = "Select title from dev_offer where username= '" + user + "' and accepted='Yes' ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    anyNotifications = true;
                    String query2 = "Select client_username from project where title= '" + reader.GetString(0) + "'";
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        String notified = reader2.GetString(0) + " accepted your offer to the project '" + reader.GetString(0) + "'";
                        TableRow row1 = new TableRow();
                        TableCell cell3 = new TableCell();
                        cell3.Controls.Add(new LiteralControl("<label>• " + notified + "</label>"));
                        row1.Cells.Add(cell3);
                        TableNotifications.Rows.Add(row1);
                    }
                }
                if (!anyNotifications)
                {
                    TableNotifications.Visible = false;
                }
                //String query3 = "Delete from dev_offer where username='" + user + "' and accepted='Yes' ";
                //SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
                //cmd3.ExecuteNonQuery(); 
            }
            catch
            {
                TableRow row1 = new TableRow();
                TableCell cell3 = new TableCell();
                cell3.Controls.Add(new LiteralControl("<label>• " + "no new notifications" + "</label>"));
            }
            conn.Close();
        }

        protected void browseOffers()
        {
            string user = Session["Username"].ToString();
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,sum_offer,date_offer,comments,accepted from dev_offer where username= '" + user + "'", conn);
            DataSet ds = new System.Data.DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            conn.Close();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                for (int i = 4; i < 5; i++)
                {
                    foreach (Control control in e.Row.Cells[i].Controls)
                    {
                        if (control.GetType().Name == "Label")
                        {
                            if (string.IsNullOrEmpty((control as Label).Text))
                            {
                                e.Row.Cells[i].Text = "unknown";
                            }
                        }
                    }
                    if (e.Row.Cells[i].Text == "&nbsp;")
                    {
                        e.Row.Cells[i].Text = "unknown";
                    }
                }
            }
        }
    }
}