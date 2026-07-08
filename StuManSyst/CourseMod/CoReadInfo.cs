using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.CourseMod
{
    public class CoReadInfo
    {
        public static List<Course> ReadCourse()
        {
            try
            {
                StreamReader sr = new StreamReader(@".\data\course.txt");
                string str = sr.ReadLine();
                List<Course> courses = new List<Course>();
                while (str != null)
                {
                    string[] courseinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Course course = new Course(courseinfo[0], courseinfo[1]);
                    courses.Add(course);
                    str = sr.ReadLine();
                }
                sr.Close();
                return courses;
            }
            catch
            {
                return null;
            }
        }
    }

}
