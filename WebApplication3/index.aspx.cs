using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;

namespace WebApplication3
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = "Postgre";
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hire_dev_db;User Id=getdevadmin;Password=getdev");
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select * from hire_dev.client";
                NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
                DataTable dt = new DataTable();
                nda.Fill(dt);
                comm.Dispose();
                conn.Close();
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Label1.Text = "fail";
            }
        }
    }
}