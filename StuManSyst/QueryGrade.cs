using StuManSyst.GradeMod;
using StuManSyst.StuInforMod;
using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManSyst
{
    public partial class QueryGrade : Form
    {

        public QueryGrade()
        {
            InitializeComponent();
        }
        public User currenUser;
        List<Score> scores = new List<Score>();
        List<Student> students = new List<Student>();
        private void DoQuery(string tbStuId = null, string tbQuCoId = null)
        {
            if (scores == null) return;
            List<Score> queryScores = new List<Score>();
            foreach (Score s in scores)
            {
                bool matchStudent = string.IsNullOrEmpty(tbStuId) || s.StudentId == tbStuId;
                bool matchCourse = string.IsNullOrEmpty(tbQuCoId) || s.CourseId == tbQuCoId;

                if (matchStudent && matchCourse)
                {
                    queryScores.Add(s);
                }
            }

            dgScore.DataSource = null;
            dgScore.DataSource = queryScores;
        }


        private void QueryGrade_Load(object sender, EventArgs e)
        {
            dgScore.DataSource = null;
            scores = GrReadInfo.ReadScore();
            if (scores != null)
                dgScore.DataSource = scores;

            if (currenUser != null && currenUser.Categeroy == "学生")
            {
                // 学生只能看自己的成绩，禁用输入学号
                students = SuReadInfo.ReadStudent();
                foreach (Student s in students)
                {
                    if (s.Name == currenUser.UserName)
                    {
                        tbQuStuId.Text = s.Id;
                        break;
                    }
                }
                tbQuStuId.Enabled = false;
                DoQuery(tbQuStuId.Text);
            }
            else
            {
                dgScore.DataSource = scores;
            }
        }

        private void btnQuScore_Click(object sender, EventArgs e)
        {

            DoQuery(tbQuStuId.Text, tbQuCoId.Text);
        }
    }
}
