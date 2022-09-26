using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class showProject : System.Web.UI.Page
    {
        private String titlename;
        protected void Page_Load(object sender, EventArgs e)
        {
            //titlename = Request.Params["titlename"];
            Project view = new Project();
            SQLiteDataReader read = view.viewProject(titlename);
            title.Text = read.GetString(0);
            description.Text = read.GetString(1);
            category.Text = read.GetString(4);
            subcategory.Text = read.GetString(5);
            payment_method.Text = read.GetString(6);
            max_price.Text = read.GetString(7);
            interval.Text = read.GetString(8);
            rec_tech.Text = read.GetString(10);
            client_username.Text = read.GetString(12);

        }
    }
}