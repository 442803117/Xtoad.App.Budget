using System;
using System.Collections.Generic;
using System.Text;

namespace Xtoad.App.Budget.Models
{
    public class Login
    {
        public string LoginNo { get; set; }
        public string Password { get; set; }

        public Login(string loginNo, string password)
        {
            LoginNo = loginNo;
            Password = password;
        }
    }
}
