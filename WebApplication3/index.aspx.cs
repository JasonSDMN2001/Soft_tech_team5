using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace WebApplication3
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "bin\\hire_dev.client.db;Version=3;");
                conn.Open();
                String query1 = "Select * from client";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                StringBuilder builder = new StringBuilder();
                while (reader.Read())              
                {
                    builder.Append(reader.GetString(0) + "  ").Append(reader.GetString(1) + "  ").Append(reader.GetString(2) + "  ").Append(reader.GetString(3) + "  ");  
                }
                conn.Close();
                Label1.Text = builder.ToString();
            }

            catch (Exception)
            {
                Label1.Text = "fail";
            }
            
        }
    }
}