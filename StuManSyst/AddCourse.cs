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
using StuManSyst.Mode1;

namespace StuManSyst
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void btnCoAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(teCoId.Text) || String.IsNullOrEmpty(teCoName.Text))
            {
                MessageBox.Show("请输入课程名和课程号！");
                return;
            }
            List<Course> courses = new List<Course>();
            StreamReader sr = new StreamReader(@".\data\course.txt", Encoding.UTF8);
            string str = sr.ReadLine();
            while (str != null)
            {
                string[] courseinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                Course course = new Course(courseinfo[0], courseinfo[1]);
                courses.Add(course);
                str = sr.ReadLine();
            }
            sr.Close();
            foreach (Course c in courses)
            {
                if (c.CourseID == teCoId.Text)
                {
                    MessageBox.Show("课程号重复，请重新输入！");
                    teCoId.Text = "";
                    return;
                }
            }
            Course course1 = new Course(teCoId.Text, teCoName.Text);
            courses.Add(course1);
            StreamWriter sw = new StreamWriter(@".\data\course.txt", false);
            foreach (Course c in courses)
            {
                sw.WriteLine(c.CourseID + "|" + c.CourseName);
            }
            sw.Close();
            MessageBox.Show("添加成功！");
        }

        private void btnCoClear_Click(object sender, EventArgs e)
        {
            teCoId.Text = "";
            teCoName.Text = "";
        }
    }
}
