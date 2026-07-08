using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.StuInforMod
{
    public class SuReadInfo
    {
        public static List<Student> ReadStudent()
        {
            try
            {
                List<Student> students = new List<Student>();
                StreamReader sr = new StreamReader(@".\data\student.txt");
                string str = sr.ReadLine();
                while (str != null)
                {
                    string[] stuinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student(stuinfo[0], stuinfo[1], stuinfo[2], stuinfo[3], stuinfo[4], stuinfo[5]);
                    students.Add(student);
                    str = sr.ReadLine();
                }
                sr.Close();
                return students;
            }
            catch
            {
                return null;
            }
        }
    }
}
