using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.Mode1
{
    public class Score
    {
        string studentId;
        string studentName;
        string courseId;
        string courseName;
        string scoreValue;

        public Score(string studentId, string studentName, string courseId, string courseName,string scoreValue)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.CourseId = courseId;
            this.CourseName = courseName;
            this.ScoreValue = scoreValue;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string CourseId { get => courseId; set => courseId = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string ScoreValue { get => scoreValue; set => scoreValue = value; }
    }
}
