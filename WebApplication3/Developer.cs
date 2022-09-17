using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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

        public void submitProjectOffer()
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

        public void profileCreate(String email, String username, String pass, String firstname, String lastname)
        {
        }

        public void searchClient()
        {
        }
        public void profileCreateDev(String email, String username, String pass, String firstname, String lastname)
        {
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into dev(email,username,pass,firstname,lastname,gender,pic,skills,bio,pagelink) Values(@email,@username,@pass,@firstname,@lastname,@gender,@pic,@skills,@bio,@pagelink)", conn);
            profileCreatecmd.Parameters.AddWithValue("@email", email);
            profileCreatecmd.Parameters.AddWithValue("@username", username);
            profileCreatecmd.Parameters.AddWithValue("@pass", pass);
            profileCreatecmd.Parameters.AddWithValue("@firstname", firstname);
            profileCreatecmd.Parameters.AddWithValue("@lastname", lastname);
            profileCreatecmd.Parameters.AddWithValue("@gender", "");
            profileCreatecmd.Parameters.AddWithValue("@pic", "");
            profileCreatecmd.Parameters.AddWithValue("@skills", "");
            profileCreatecmd.Parameters.AddWithValue("@bio", "");
            profileCreatecmd.Parameters.AddWithValue("@portfolio", "");
            profileCreatecmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
