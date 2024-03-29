﻿using System;
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

        public void createProject(string title,string description,string proj_type,string offer_show,string category,string subcategory,string payment_method,string max_price,string interval,string uptime,string rec_tech,string client_username,string creation_date)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            string dev = "mitsos";
            conn.Open();
            SQLiteCommand projectCreatecmd = new SQLiteCommand("Insert into project(title,description,proj_type,offer_show,category,subcategory,payment_method,max_price,interval,uptime,rec_tech,client_username,dev_username,creation_date,dev_done,client_done) Values("+
                "@title,@description,@proj_type,@offer_show,@category,@subcategory,@payment_method,@max_price,@interval,@uptime,@rec_tech,@client_username,@dev_username,@creation_date,'No','No')", conn);
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
            projectCreatecmd.ExecuteNonQuery();
            conn.Close();
        }

        public void editProject(string previoustitle, string title, string description, string proj_type, string offer_show, string category, string subcategory, string payment_method, string max_price, string interval, string uptime, string rec_tech)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand projectCreatecmd = new SQLiteCommand("UPDATE project SET title=@title,description=@description,proj_type=@proj_type,offer_show=@offer_show,category=@category,subcategory=@subcategory,payment_method=@payment_method,max_price=@max_price,interval=@interval,uptime=@uptime,rec_tech=@rec_tech where title ='"+previoustitle+"'", conn);
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
            projectCreatecmd.ExecuteNonQuery();
            conn.Close();
        }

        public void assignProject()
        {
        }

        public void submitReview(string username,string dev,string title,int list,string comment)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand reviewcmd = new SQLiteCommand("Insert into review(cli_username,dev_username,title,stars,comment) Values(@cli_username,@dev_username,@title,@stars,@comment)", conn);
            reviewcmd.Parameters.AddWithValue("@cli_username", username);
            reviewcmd.Parameters.AddWithValue("@dev_username", dev);
            reviewcmd.Parameters.AddWithValue("@title", title);
            reviewcmd.Parameters.AddWithValue("@stars", list);
            reviewcmd.Parameters.AddWithValue("@comment", comment);
            reviewcmd.ExecuteNonQuery();
            conn.Close();
        }


        public void submitRating()
        {
        }

        public void viewDevProfile()
        {
        }

        public void searchDev()
        {
          
        }

        public void projectDescShow()
        {
        }

        public string[] profileShow(string username, Image ImageID, HyperLink pagelink)
        {
            string[] arr = new string[6];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from client where username='" + username + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                arr[0] = reader.GetString(0);
                arr[1] = reader.GetString(1) + "    ";
                arr[2] = "   " + reader.GetString(3) + " " + reader.GetString(4);
                arr[3] = "     " + reader.GetString(5);
                arr[4] = "     " + reader.GetString(6);

                if (reader["pic"].ToString() == "")
                {
                    ImageID.ImageUrl = "";
                }
                else
                {
                    byte[] bytes = (byte[])reader["pic"];
                    ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                }
                arr[5] = reader.GetString(8);
                pagelink.NavigateUrl = reader.GetString(9);
            }
            conn.Close();
            return arr;
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