using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class adminDeleteClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select username,email from client", conn);
                System.Data.DataSet ds = new System.Data.DataSet();
                dataadapter.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                conn.Close();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int idx = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[idx];
                string clientname = row.Cells[1].Text;
                Admin admin = new Admin();
                admin.deleteUser("client",clientname);
                row.Cells.Clear();
            }
        }
    }
}