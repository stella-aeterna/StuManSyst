using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.Mode1
{

    public class User
    {
        string userName;
        string pass;
        string categeroy;  
        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Categeroy { get => categeroy; set => categeroy = value; }
        
        
        public User(string userName, string pass, string categeroy)
        {
            this.UserName = userName;
            this.Pass = pass;
            this.Categeroy = categeroy;
        }


    }
}
