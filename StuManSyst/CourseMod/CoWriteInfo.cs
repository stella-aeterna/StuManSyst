using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.CourseMod
{
    public class CoWriteInfo
    {
        public static void WriteCourse(List<Course> courses)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@".\data\course.txt", false);
                foreach (Course c in courses)
                {
                    sw.WriteLine(c.CourseID + "|" + c.CourseName);
                }
                sw.Close();
            }
            catch { }
        }
    }
}
