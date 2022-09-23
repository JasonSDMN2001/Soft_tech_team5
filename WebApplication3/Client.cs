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

        public void createProject(string title,string description,string proj_type,string offer_show,string category,string subcategory,string payment_method,string max_price,string interval,string uptime,string rec_tech,string client_username,string creation_date, string language)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            string dev = "mitsos";
            conn.Open();
            SQLiteCommand projectCreatecmd = new SQLiteCommand("Insert into project(title,description,proj_type,offer_show,category,subcategory,payment_method,max_price,interval,uptime,rec_tech,client_username,dev_username,creation_date,language) Values("+
                "@title,@description,@proj_type,@offer_show,@category,@subcategory,@payment_method,@max_price,@interval,@uptime,@rec_tech,@client_username,@dev_username,@creation_date,@language)", conn);
            projectCreatecmd.Parameters.AddWithValue("@title", title);
            projectCreatecmd.Parameters.AddWithValue("@description", description);
            projectCreatecmd.Parameters.AddWithValue("@proj_type", proj_type);
            projectCreatecmd.Parameters.AddWithValue("@offer_show", offer_show);
            projectCreatecmd.Parameters.AddWithValue("@category", category);
            projectCreatecmd.Parameters.AddWithValue("@subcategory", subcategory);
            projectCreatecmd.Parameters.AddWithValue("@payment_method", payment_method);
            projectCreatecmd.Parameters.AddWithValue("@max_price", max_price);
            projectCreatecmd.Parameters.AddWithValue("@interval", interval);
            projectCreatecmd.Parameters.AddWithValue("@uptime", uptime);
            projectCreatecmd.Parameters.AddWithValue("@rec_tech", rec_tech);
            projectCreatecmd.Parameters.AddWithValue("@client_username", client_username);
            projectCreatecmd.Parameters.AddWithValue("@dev_username", dev);
            projectCreatecmd.Parameters.AddWithValue("@creation_date", creation_date);
            projectCreatecmd.Parameters.AddWithValue("@language", language);
            projectCreatecmd.ExecuteNonQuery();
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
        public void profileCreateClient(String email, String username, String pass, String firstname, String lastname, Byte[] bytes, String gender, String birthdate, String desc, String link, String emailcheck, String fullnamecheck, String gendercheck, String birthdatecheck, String pagelinkcheck)
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
            String queryV = "Insert into client_profile_hidden(email,fullname,gender,birthdate,pagelink,username) Values(@email,@fullname,@gender,@birthdate,@pagelink,@username)";
            SQLiteCommand cmdvisible = new SQLiteCommand(queryV, conn);
            cmdvisible.Parameters.AddWithValue("@email", emailcheck);
            cmdvisible.Parameters.AddWithValue("@fullname", fullnamecheck);
            cmdvisible.Parameters.AddWithValue("@gender", gendercheck);
            cmdvisible.Parameters.AddWithValue("@birthdate", birthdatecheck);
            cmdvisible.Parameters.AddWithValue("@pagelink", pagelinkcheck);
            cmdvisible.Parameters.AddWithValue("@username", username);
            cmdvisible.ExecuteNonQuery();
            conn.Close();

        }

        public void searchClient()
        {
        }
    }
}