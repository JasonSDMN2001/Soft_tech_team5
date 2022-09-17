using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                String query1 = "Select * from client where username='"+name1.Text+"' and pass='"+pwd.Text+"'";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                while (reader.Read())
                {
                    builder.Append(reader.GetString(1) + "/").Append(reader.GetString(2));
                }
                conn.Close();
                if (builder.ToString()=="")
                {
                    
                    string script = "alert(\"Incorrect username/password\")";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
                else
                {
                Session["Username"] = name1.Text;
                    Response.Redirect("clientMainPage.aspx");
                }
          
        }
    }
}