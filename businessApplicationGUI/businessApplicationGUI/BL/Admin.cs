using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBusiness_.BL
{
    public class Admin : TheUser
    {
        public Admin(string username, string password) : base(username, password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
