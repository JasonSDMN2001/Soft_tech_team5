using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class Project
    {
        public String title;
        public String description;
        public Boolean type;
        public Boolean offer_show;
        public String category;
        public String subcategory;
        public String payment_method;
        public int max_price;
        public int interval;
        public int uptime;
        public String rec_tech;
        public String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;";

        public Project()
        {
        }

        public SQLiteDataReader viewProject(String title)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand projectViewcmd = new SQLiteCommand("select * from project where title="+title+"", conn);
            SQLiteDataReader reader = projectViewcmd.ExecuteReader();
            conn.Close();
            return reader;
        }
    }
}
