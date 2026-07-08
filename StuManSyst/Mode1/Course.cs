using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.Mode1
{
    public class Course
    {
        string courseID;
        string courseName;

        public Course(string courseID, string courseName)
        {
            this.CourseID = courseID;
            this.CourseName = courseName;
        }

        public string CourseID { get => courseID; set => courseID = value; }
        public string CourseName { get => courseName; set => courseName = value; }
    }
}
