using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBusiness_.BL
{
    public class TheUser
    {
        protected string username;
        protected string password;
        protected string role;

        public TheUser(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public TheUser(string username, string password, string role) : this(username, password)
        {
            this.role = role;
        }

        public TheUser()
        {

        }

        public void setName(string username)
        {
            this.username = username;
        }

        public string getUserName()
        {
            return this.username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

        public string getRole()
        {
            return this.role;
        }

        public string toString()
        {
            return "TheUSer[Role: " + role + ", UserName: " + username + ", Password: " + password + "]";
        }
    }
}
