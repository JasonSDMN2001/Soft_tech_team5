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
    public partial class devProjects : System.Web.UI.Page
    {
        private string accepted;
        private string titlename;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string user = Session["Username"].ToString();
                Developer d9 = new Developer();
                SQLiteDataAdapter dataadapter2 = d9.devActiveProjects(user);
                DataSet ds = new System.Data.DataSet();
                dataadapter2.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                /*SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,description,category,subcategory,client_username,rec_tech,dev_price,client_done,dev_done from project where dev_username='" + user + "' and client_done='No' and dev_done='No' ", conn);
                DataSet ds = new System.Data.DataSet();
                dataadapter.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                conn.Close(); */

                /*conn.Open();
                SQLiteCommand titlecmd = new SQLiteCommand("Select title from project where dev_username='" + user + "' and client_done='No' or dev_done='No' ", conn);
                SQLiteDataReader reader = titlecmd.ExecuteReader();
                while (reader.Read())
                {
                    titlename = reader.GetString(0);
                }
                SQLiteCommand offercmd = new SQLiteCommand("Select accepted from dev_offer where username='" +user + "' and title='"+titlename+"'", conn);
                SQLiteDataReader read = offercmd.ExecuteReader();
                while (read.Read())
                {
                    accepted = read.GetString(0);
                }
                conn.Close();*/

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedItem.Text == "Active")
            {
                string user = Session["Username"].ToString();
                Developer d9 = new Developer();
                SQLiteDataAdapter dataadapter2 = d9.devActiveProjects(user);
                DataSet ds = new System.Data.DataSet();
                dataadapter2.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
               /* SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                

                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,description,category,subcategory,client_username,rec_tech,dev_price,client_done,dev_done from project where dev_username='" + user + "' and client_done='No' or dev_done='No' ", conn);
                DataSet ds = new System.Data.DataSet();
                dataadapter.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

                conn.Close();*/
                
            }
            else if(DropDownList1.SelectedItem.Text == "Inactive")
            {
                string user = Session["Username"].ToString();
                /* SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                 conn.Open();

                 SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,description,category,subcategory,client_username,rec_tech,dev_price,client_done,dev_done from project where dev_username='" + user + "' and client_done='Yes' and dev_done='Yes' ", conn);
                 DataSet ds = new System.Data.DataSet();
                 dataadapter.Fill(ds);
                 GridView1.DataSource = ds.Tables[0];
                 GridView1.DataBind();

                 conn.Close(); */
                Developer d9 = new Developer();
                SQLiteDataAdapter dataadapter2 = d9.devInactiveProjects(user);
                DataSet ds = new System.Data.DataSet();
                dataadapter2.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();


            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dev_done")
            {
                String dev = Session["Username"].ToString();
                int idx = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[idx];
                string title = row.Cells[1].Text;
                
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand("Update project set dev_done='Yes' where title='" + title +"' and dev_username='"+dev+"'", conn);
                cmd.Parameters.AddWithValue("@dev", dev);
                cmd.ExecuteNonQuery();
                
                row.Cells.Clear();

            }
        }
    }
}