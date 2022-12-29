using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DL
{
    class Registration_DTO
    {
        private string _username;
        private string _password;
        private string _role;

        public Registration_DTO()
        {
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
