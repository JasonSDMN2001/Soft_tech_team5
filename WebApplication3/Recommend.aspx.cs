using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data;

namespace WebApplication3
{
    public partial class Recommend : System.Web.UI.Page
    {
        protected String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            String recquery = "Select username,email from dev where username like '%" + SearchBox.Text + "%'";
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(recquery, conn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            conn.Close();
        }   

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Recommending")
            {
                String title = Session["value"].ToString();
                String user = Session["Username"].ToString();
                int idx = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[idx];
                string recdev = row.Cells[1].Text;
                User userrec = new User();
                userrec.projectRecommend(recdev, title, user);
                row.Cells.Clear();
            }
        }
    }
}