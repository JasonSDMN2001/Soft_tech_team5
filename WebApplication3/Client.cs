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
        private String description;
        private Uri link;
        

        public Client()
        {
        }

        public void createProject(string title,string description,string proj_type,string offer_show,string category,string subcategory,string payment_method,string max_price,string interval,string uptime,string rec_tech,string client_username)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into project(title,description,proj_type,offer_show,category,subcategory,payment_method,max_price,interval,uptime,rec_tech,client_username) Values("+
                "@title,@description,@proj_type,@offer_show,@category,@subcategory,@payment_method,@max_price,@interval,@uptime,@rec_tech,@client_username)", conn);
            profileCreatecmd.Parameters.AddWithValue("@title", title);
            profileCreatecmd.Parameters.AddWithValue("@description", description);
            profileCreatecmd.Parameters.AddWithValue("@proj_type", proj_type);
            profileCreatecmd.Parameters.AddWithValue("@offer_show", offer_show);
            profileCreatecmd.Parameters.AddWithValue("@category", category);
            profileCreatecmd.Parameters.AddWithValue("@subcategory", subcategory);
            profileCreatecmd.Parameters.AddWithValue("@payment_method", payment_method);
            profileCreatecmd.Parameters.AddWithValue("@max_price", max_price);
            profileCreatecmd.Parameters.AddWithValue("@interval,", interval);
            profileCreatecmd.Parameters.AddWithValue("@uptime", uptime);
            profileCreatecmd.Parameters.AddWithValue("@rec_tech", rec_tech);
            profileCreatecmd.Parameters.AddWithValue("@client_username", client_username);
            profileCreatecmd.ExecuteNonQuery();
            conn.Close();
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
        public void profileCreateClient(String email, String username, String pass, String firstname, String lastname, Byte[] bytes, String Gender, String birthdate, String desc, String link)
        {

            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into client(email,username,pass,firstname,lastname,gender,birthdate,pic,description,pagelink) Values(@email,@username,@pass,@firstname,@lastname,@gender,@birthdate,@pic,@description,@pagelink)", conn);
            profileCreatecmd.Parameters.AddWithValue("@email", email);
            profileCreatecmd.Parameters.AddWithValue("@username", username);
            profileCreatecmd.Parameters.AddWithValue("@pass", pass);
            profileCreatecmd.Parameters.AddWithValue("@firstname", firstname);
            profileCreatecmd.Parameters.AddWithValue("@lastname", lastname);
            profileCreatecmd.Parameters.AddWithValue("@gender", Gender);
            profileCreatecmd.Parameters.AddWithValue("@birthdate", birthdate);
            profileCreatecmd.Parameters.AddWithValue("@pic", bytes);
            profileCreatecmd.Parameters.AddWithValue("@description", desc);
            profileCreatecmd.Parameters.AddWithValue("@pagelink", link);
            profileCreatecmd.ExecuteNonQuery();
            conn.Close();
        }

        public void searchClient()
        {
        }
    }
}