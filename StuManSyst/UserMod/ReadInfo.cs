using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.UserMod
{
    public class ReadInfo1
    {
        public static List<User> ReadUser()
        {
            try
            {
                StreamReader sr = new StreamReader(@".\data\user.txt");
                string str = sr.ReadLine();
                List<User> users = new List<User>();
                while (str != null)
                {
                    string[] userinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    User user = new User(userinfo[0], userinfo[1], userinfo[2]);
                    users.Add(user);
                    str = sr.ReadLine();
                }
                sr.Close();
                return users;
            }
            catch
            {
                return null;
            }
        }
    }
}
