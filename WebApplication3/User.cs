using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.SQLite;

namespace WebApplication3
{
    public class User
    {
        private String email;
        private String username;
        private String password;
        private String name;
        private String lastname;
        private String gender;
        private Image profilepic;
        public String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";

        public User()
        {
        }

        public void profileEdit()
        {
        }

        public void projectFollow()
        {
        }

        public void projectComment()
        {
        }

        public void projectRecommend(String dev_title, String project_title, String recommended_by)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand projectReccmd = new SQLiteCommand("Insert into recommendation(dev_name, project_title, recommended_by, viewed) Values('" + dev_title+"','"+project_title+ "','" + recommended_by +"','No')", conn);
            projectReccmd.ExecuteNonQuery();
            conn.Close();
        }

        public void profileCreate()
        {
        }

        public void searchProject()
        {

        }
    }
}