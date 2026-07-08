using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.GradeMod
{
    public class GrWriteInfo
    {
        public static void WriteScore(List<Score> scores)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@".\data\score.txt", false);
                foreach (Score s in scores)
                {
                    sw.WriteLine(s.StudentId + "|" + s.StudentName + "|" + s.CourseId + "|" + s.CourseName + "|" + s.ScoreValue);
                }
                sw.Close();
            }
            catch { }
        }
    }
}
