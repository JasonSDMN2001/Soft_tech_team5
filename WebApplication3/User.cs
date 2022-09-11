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

        public void projectRecommend()
        {
        }

        public void profileCreate()
        {
        }
    }
}