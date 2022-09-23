using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


namespace WebApplication3
{
    public class Client : User , UnregisteredUser
    {
        private String birthdate;
        //private String description;
        private Uri link;
        

        public Client()
        {
        }

        public void createProject(string title, string description, string proj_type, string offer_show, string category, string subcategory, string payment_method, string max_price, string interval,string uptime, string rec_tech, string client_username)
        {
            string creation_date = DateTime.Now.ToString("dd-MM-yyyy");
            SQLiteConnection connC = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            connC.Open();
            string queryC = "Insert into project(title,description,proj_type,offer_show,category,subcategory,payment_method,max_price,interval,uptime,rec_tech,dev_username,client_username,creation_date) Values(@title,@description,@proj_type,@offer_show,@category,@subcategory,@payment_method,@max_price,@interval,@uptime,@rec_tech,@dev_username,@client_username,@creation_date)";
            SQLiteCommand cmd4 = new SQLiteCommand(queryC, connC);          
            cmd4.Parameters.AddWithValue("@title", title);
            cmd4.Parameters.AddWithValue("@description", description);
            cmd4.Parameters.AddWithValue("@proj_type", proj_type);
            cmd4.Parameters.AddWithValue("@offer_show", offer_show);
            cmd4.Parameters.AddWithValue("@category", category);
            cmd4.Parameters.AddWithValue("@subcategory", subcategory);
            cmd4.Parameters.AddWithValue("@payment_method", payment_method);
            cmd4.Parameters.AddWithValue("@max_price", max_price);
            cmd4.Parameters.AddWithValue("@interval", interval);
            cmd4.Parameters.AddWithValue("@uptime", uptime); 
            cmd4.Parameters.AddWithValue("@rec_tech", rec_tech);
            cmd4.Parameters.AddWithValue("@client_username", client_username);
            cmd4.Parameters.AddWithValue("@dev_username", "mitsos");
            cmd4.Parameters.AddWithValue("@creation_date", creation_date);           
            cmd4.ExecuteNonQuery();
            connC.Close();
        }

        public void editProject()
        {
        }

        public void assignProject()
        {
        }

        public void submitReview()
        {
        }

        public void submitRating()
        {
        }

        public void viewDevProfile()
        {
        }

        public void searchProject()
        {
        }

        public void searchDev()
        {
        }

        public void projectDescShow()
        {
        }

        public void profileShow()
        {
        }
        public void profileCreate(String email,String username,String pass,String firstname,String lastname)
        {

        }
        public void profileCreateClient(String email, String username, String pass, String firstname, String lastname, Byte[] bytes, String gender, String birthdate, String desc, String link)
        {
            string creation_date = DateTime.Now.ToString("dd-MM-yyyy");
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into client(email,username,pass,firstname,lastname,gender,birthdate,pic,description,pagelink,creation_date) Values(@email,@username,@pass,@firstname,@lastname,@gender,@birthdate,@pic,@description,@pagelink,@creation_date)", conn);
            profileCreatecmd.Parameters.AddWithValue("@email", email);
            profileCreatecmd.Parameters.AddWithValue("@username", username);
            profileCreatecmd.Parameters.AddWithValue("@pass", pass);
            profileCreatecmd.Parameters.AddWithValue("@firstname", firstname);
            profileCreatecmd.Parameters.AddWithValue("@lastname", lastname);
            profileCreatecmd.Parameters.AddWithValue("@gender", gender);
            profileCreatecmd.Parameters.AddWithValue("@birthdate", birthdate);
            profileCreatecmd.Parameters.AddWithValue("@pic", bytes);
            profileCreatecmd.Parameters.AddWithValue("@description", desc);
            profileCreatecmd.Parameters.AddWithValue("@pagelink", link);
            profileCreatecmd.Parameters.AddWithValue("@creation_date", creation_date);
            profileCreatecmd.ExecuteNonQuery();
            conn.Close();
        }

        public void searchClient()
        {
        }
    }
}