using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManSyst.GradeMod
{
    public class GrReadInfo
    {
        public static List<Score> ReadScore()
        {
            try
            {
                StreamReader sr = new StreamReader(@".\data\score.txt");
                string str = sr.ReadLine();
                List<Score> scores = new List<Score>();
                while (str != null)
                {
                    string[] scoreinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Score score = new Score(scoreinfo[0], scoreinfo[1], scoreinfo[2], scoreinfo[3], scoreinfo[4]);
                    scores.Add(score);
                    str = sr.ReadLine();
                }
                sr.Close();
                return scores;
            }
            catch
            {
                return null;
            }
        }
    }
}
