using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LoginUser
    {
        private string _username { get; set; }
        private string _password { get; set; }

        public LoginUser(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get { return _password; }
        }
    }
}
