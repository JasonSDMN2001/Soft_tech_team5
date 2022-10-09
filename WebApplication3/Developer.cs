using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI;

namespace WebApplication3
{
    public class Developer : User , UnregisteredUser
    {
        private String skills;
        private String bio;
        private Uri portfolio;
        
        public Developer()
        {
        }

        public SQLiteDataAdapter viewDevOffers(string username)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,sum_offer,date_offer,comments from dev_offer where username= '" + username + "'", conn);
            conn.Close();
            return dataadapter;
        }

        
        public void submitProjectOffer(String name,String titlos,String sum,String offerdate,String comments)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();

            SQLiteCommand offerCreatecmd = new SQLiteCommand("Insert into dev_offer(username,title,sum_offer,date_offer,comments,available,accepted) Values(@username,@title,@sum_offer,@date_offer,@comments,'Yes','No')", conn);
            offerCreatecmd.Parameters.AddWithValue("@username", name);
            offerCreatecmd.Parameters.AddWithValue("@title", titlos);
            offerCreatecmd.Parameters.AddWithValue("@sum_offer", sum);
            offerCreatecmd.Parameters.AddWithValue("@date_offer", offerdate);
            offerCreatecmd.Parameters.AddWithValue("@comments", comments);
            offerCreatecmd.ExecuteNonQuery();

            String query = "update project set num_offers = num_offers + 1 where title='" + titlos + "'";
            SQLiteCommand increasecmd = new SQLiteCommand(query, conn);
            increasecmd.ExecuteNonQuery();
            conn.Close();

        }

        public SQLiteDataAdapter devInactiveProjects(string username)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,description,category,subcategory,client_username,rec_tech,dev_price,client_done,dev_done from project where dev_username='" + username + "' and client_done='Yes' and dev_done='Yes' ", conn);
            conn.Close();
            return dataadapter;
        }

        public SQLiteDataAdapter devActiveProjects(string username)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("Select title,description,category,subcategory,client_username,rec_tech,dev_price,client_done,dev_done from project where dev_username='" + username + "' and client_done='No' or dev_done='No' ", conn);
            conn.Close();
            return dataadapter;
        }

        public void addProjectCategory()
        {
        }

        public void editOffer(string username,string titlos,string poso,string comments,string day)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query = "update dev_offer set sum_offer=@sum_offer,date_offer=@date_offer,comments=@comments where username='" + username + "' and title='" + titlos + "'";
            SQLiteCommand editOffer2cmd = new SQLiteCommand(query, conn);
            editOffer2cmd.Parameters.AddWithValue("@sum_offer", poso);
            editOffer2cmd.Parameters.AddWithValue("@date_offer", day);
            editOffer2cmd.Parameters.AddWithValue("@comments", comments);
            editOffer2cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void cancelOffer(string username,string titlos)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            string query = "Delete from dev_offer where username='" + username + "' and title='" + titlos + "';";
            SQLiteCommand deletecmd = new SQLiteCommand(query, conn);
            deletecmd.ExecuteNonQuery();
            conn.Close();
        }

        public void acceptProject()
        {
        }


        public void searchDev()
        {
        }

        public void projectDescShow()
        {

        }

        public string[] profileShow(string username,Image ImageID, System.Web.UI.HtmlControls.HtmlIframe pdfframe)
        {
            string []arr = new string[6];
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "hire_dev.client.db;Version=3;");
            conn.Open();
            String query1 = "Select * from dev where username='" + username + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader22 = cmd.ExecuteReader();
            while (reader22.Read())
            {
                
                arr[0] = reader22.GetString(0);
                arr[1] = reader22.GetString(1) + "    ";
                arr[2] = "   " + reader22.GetString(3) + " " + reader22.GetString(4);
                arr[3] = "     " + reader22.GetString(5);
                if (reader22["pic"].ToString() == "")
                {
                    ImageID.ImageUrl = "";
                }
                else
                {
                    byte[] bytes = (byte[])reader22["pic"];
                    ImageID.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                }
                arr[4] = reader22.GetString(7);
                if (reader22["bio"].ToString() != "")
                {
                    byte[] byteArray = (byte[])reader22["bio"];
                    pdfframe.Src = GetDocument(byteArray).ToString();
                }
                arr[5] = reader22.GetString(9);
            }
            conn.Close();
            
            return arr;
           
        }
        public object GetDocument(byte[] byteArray)
        {
            return "data:application/pdf;base64," + Convert.ToBase64String(byteArray);
        }

        public void profileCreate(String email, String username, String pass, String firstname, String lastname)
        {
        }

        public void searchClient()
        {
        }
        public void profileCreateDev(String email, String username, String pass, String firstname, String lastname, Byte[] bytes, Byte[] bytes2, String gender1, String skills, String port,String emailcheck,String namecheck,String gendercheck,String portcheck,String cvcheck)
        {
            string creation_date = DateTime.Now.ToString("dd-MM-yyyy");
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into dev(email,username,pass,firstname,lastname,gender,pic,skills,bio,portfolio,creation_date) Values(@email,@username,@pass,@firstname,@lastname,@gender,@pic,@skills,@bio,@portfolio,@creation_date)", conn);
            profileCreatecmd.Parameters.AddWithValue("@email", email);
            profileCreatecmd.Parameters.AddWithValue("@username", username);
            profileCreatecmd.Parameters.AddWithValue("@pass", pass);
            profileCreatecmd.Parameters.AddWithValue("@firstname", firstname);
            profileCreatecmd.Parameters.AddWithValue("@lastname", lastname);
            profileCreatecmd.Parameters.AddWithValue("@gender", gender1);
            profileCreatecmd.Parameters.AddWithValue("@pic", bytes);
            profileCreatecmd.Parameters.AddWithValue("@skills", skills);
            profileCreatecmd.Parameters.AddWithValue("@bio", bytes2);
            profileCreatecmd.Parameters.AddWithValue("@portfolio", port);
            profileCreatecmd.Parameters.AddWithValue("@creation_date", creation_date);
            profileCreatecmd.ExecuteNonQuery();
            String queryV = "Insert into dev_profile_hidden(email,fullname,gender,username,port,cv) Values(@email,@fullname,@gender,@username,@port,@cv)";
            SQLiteCommand cmdvisible = new SQLiteCommand(queryV, conn);
            cmdvisible.Parameters.AddWithValue("@email", emailcheck);
            cmdvisible.Parameters.AddWithValue("@fullname", namecheck);
            cmdvisible.Parameters.AddWithValue("@gender", gendercheck);
            cmdvisible.Parameters.AddWithValue("@port", portcheck);
            cmdvisible.Parameters.AddWithValue("@cv", cvcheck);
            cmdvisible.Parameters.AddWithValue("@username", username);
            cmdvisible.ExecuteNonQuery();
            conn.Close();
        }
    }
}
