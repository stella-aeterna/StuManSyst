using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StuManSyst.UserMod
{
    public class WriteInfo1
    {
        public static void WriteUser(List<User> users)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@".\data\user.txt", false);
                foreach (User u in users)
                {
                    sw.WriteLine(u.UserName + "|" + u.Pass + "|" + u.Categeroy);
                }
                sw.Close();
            }
            catch { }
        }
    }
}
