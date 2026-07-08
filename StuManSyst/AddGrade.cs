using StuManSyst.CourseMod;
using StuManSyst.GradeMod;
using StuManSyst.Mode1;
using StuManSyst.StuInforMod;
using StuManSyst.UserMod;
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
    public partial class AddGrade : Form
    {
        public AddGrade()
        {
            InitializeComponent();
        }
        List<Course> courses = new List<Course>();
        List<Student> students = new List<Student>();

        private void teGrId_TextChanged(object sender, EventArgs e)
        {
            string inputId = teGrId.Text.Trim();
            teGrName.Text = "";

            if (string.IsNullOrEmpty(inputId))
                return;
            courses = CoReadInfo.ReadCourse();
            foreach (Course c in courses)
            {
                if (c.CourseID == inputId)
                {

                    teGrName.Text = c.CourseName;
                    return;
                }
            }
            teGrName.Text = "请输入正确课程号";
        }

        private void teGrIdStuId_TextChanged(object sender, EventArgs e)
        {
            string inputId = teGrIdStuId.Text.Trim();
            teGrIdStuName.Text = "";

            if (string.IsNullOrEmpty(inputId))
                return;
            students = SuReadInfo.ReadStudent();
            foreach (Student s in students)
            {
                if (s.Id == inputId)
                {

                    teGrIdStuName.Text = s.Name;
                    return;
                }
            }
            teGrIdStuName.Text = "请输入正确学号";
        }
        private void btnGrAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teGrId.Text))
            {
                MessageBox.Show("请输入课程号", "提示");
                return;
            }
            if (teGrName.Text == "请输入正确课程号")
            {
                MessageBox.Show("请输入正确课程号", "提示");
                return;
            }

            if (string.IsNullOrEmpty(teGrIdStuId.Text))
            {
                MessageBox.Show("请输入学号", "提示");
                return;
            }
            if (teGrIdStuName.Text == "请输入正确学号")
            {
                MessageBox.Show("请输入正确学号", "提示");
                return;
            }

            if (string.IsNullOrEmpty(teGrad.Text))
            {
                MessageBox.Show("请输入成绩", "提示");
                return;
            }
            List<Score> scores = GrReadInfo.ReadScore();
            if (scores == null)
                scores = new List<Score>();
            foreach (Score s in scores)
            {
                if (s.StudentId == teGrIdStuId.Text && s.CourseId == teGrId.Text)
                {
                    MessageBox.Show("该学生该课程的成绩已经存在，请重新选择！");
                    teGrName.Text = "";
                    teGrId.Text = "";
                    teGrIdStuId.Text = "";
                    teGrIdStuName.Text = "";
                    teGrad.Text = "";
                    return;
                }
            }
            Score score = new Score(teGrIdStuId.Text, teGrIdStuName.Text, teGrId.Text, teGrName.Text, teGrad.Text);
            scores.Add(score);
            GrWriteInfo.WriteScore(scores);
            MessageBox.Show("成绩添加成功！");
            teGrName.Text = "";
            teGrId.Text = "";
            teGrIdStuId.Text = "";
            teGrIdStuName.Text = "";
            teGrad.Text = "";
        }
    }
}
