using projectBusiness_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projectBusiness_.DL
{
    public class TheUserDL
    {
        private static List<TheUser> users = new List<TheUser>();

        public static TheUser isUserExists(string name)
        {
            foreach (TheUser s in users)
            {
                if (s.getUserName() == name)
                {
                    return s;
                }
            }
            return null;
        }
        public static void addTolist(TheUser user)
        {
            users.Add(user);
        }

        public static void addToFile(string path, TheUser user)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(user.getUserName() + "," + user.getPassword() + "," + user.getRole());
            f.Flush();
            f.Close();
        }

        public static bool loadFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while((record = f.ReadLine())!= null)
                {
                    string[] splittedRecord = record.Split(',');
                    string username = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = splittedRecord[2];
                    TheUser data = new TheUser(username, password, role);
                    TheUserDL.addTolist(data);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TheUser signIn(TheUser d)
        {
            foreach (TheUser s in users)
            {
                if (d.getUserName() == s.getUserName() && d.getPassword() == s.getPassword())
                {
                    return s;
                }
            }
            return null;
        }
    }
}
