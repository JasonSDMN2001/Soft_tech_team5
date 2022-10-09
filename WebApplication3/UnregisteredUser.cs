using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    interface UnregisteredUser
    {
        void searchProject();

        void searchDev();

        void projectDescShow();

        //void profileShow();

        void profileCreate(String email, String username, String pass, String firstname, String lastname);

        void searchClient();
    }
}
