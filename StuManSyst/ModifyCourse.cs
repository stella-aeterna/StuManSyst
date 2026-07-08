using StuManSyst.CourseMod;
using StuManSyst.GradeMod;
using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StuManSyst
{
    public partial class ModifyCourse : Form
    {
        public ModifyCourse()
        {
            InitializeComponent();
        }

        List<Course> courses = new List<Course>();
        Course course = null;

        private void teOldCoId_TextChanged(object sender, EventArgs e)
        {
            string inputId = teOldCoId.Text.Trim();
            teOldCoName.Text = ""; 

            if (string.IsNullOrEmpty(inputId))
                return;
            courses = CoReadInfo.ReadCourse();
            foreach (var c in courses)
            {
                if (c.CourseID == inputId)
                {

                    teOldCoName.Text = c.CourseName;
                    course = c;
                    return;
                }
            }

            teOldCoName.Text = "请输入正确课程号";
        }
        private void btnteCoId_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teOldCoId.Text))
            {
                MessageBox.Show("请输入要修改的课程号", "提示");
                return;
            }
            if(teOldCoName.Text == "请输入正确课程号")
            {
                MessageBox.Show("请输入正确课程号", "提示");
                return;
            }

            if (string.IsNullOrEmpty(teNewCoName.Text) || string.IsNullOrEmpty(teNewCoId.Text))
            {
                MessageBox.Show("请输入新的课程名与课程号", "提示");
                return;
            }
            course.CourseID = teNewCoId.Text;
            course.CourseName = teNewCoName.Text;
            CoWriteInfo.WriteCourse(courses);
            MessageBox.Show("课程信息修改成功！", "提示");
            teOldCoId.Text = "";
            teOldCoName.Text = "";
            teNewCoId.Text = "";
            teNewCoName.Text = "";
        }

    }
}
