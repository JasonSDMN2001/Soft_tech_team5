using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Web.UI.WebControls;

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

        public void submitProjectOffer(String name,String titlos,String sum,String offerdate,String comments)
        {
           

        }

        public void addProjectCategory()
        {
        }

        public void editCancelOffer()
        {
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

        public void profileShow()
        {
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
