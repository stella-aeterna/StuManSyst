using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StuManSyst.Mode1;

namespace StuManSyst.StuInforMod
{
    public class SuWriteInfo
    {
        public static void WriteStudent(List<Student> students)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@".\data\student.txt", false);
                foreach (Student s in students)
                {
                    sw.WriteLine(s.Id + "|" + s.Name + "|" + s.Gender + "|" + s.Phone + "|" + s.Address + "|" + s.Photo);
                }
                sw.Close();
            }
            catch { }
        }
    }
}
