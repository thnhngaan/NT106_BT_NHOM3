using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT106_2._2
{
    internal class Users
    {
        private string Username;
        private string Password;
        private string Email;
        private string MobileNumer;
        private string Fullname;
        
        public Users()
        {
        }

        public Users(string a, string b, string c, string d, string e)
        {
            Username = a;
            Password = b;
            Email = c;
            MobileNumer = d;
            Fullname = e;
        }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string MOBILENUMBER { get; set; }
        public string FULLNAME { get; set; }

    }
}
