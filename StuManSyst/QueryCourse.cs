using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StuManSyst.Mode1;
using StuManSyst.CourseMod;

namespace StuManSyst
{
    public partial class QueryCourse : Form
    {
        public QueryCourse()
        {
            InitializeComponent();
        }
        List<Course> courses;

        private void QueryCourse_Load(object sender, EventArgs e)
        {
            dgCourse.DataSource = null;
            courses = CoReadInfo.ReadCourse();
            dgCourse.DataSource = courses;
        }

        private void btnQueryCourse_Click(object sender, EventArgs e)
        {
            List<Course> queryCourse = new List<Course>();
            if (string.IsNullOrEmpty(teQueryCourse.Text))
            {
                MessageBox.Show("请输入要查询的课程号！");
                return;
            }
            foreach (Course course in courses)
            {
                if (course.CourseID == teQueryCourse.Text)
                {
                    queryCourse.Add(course);
                }
            }
            dgCourse.DataSource = null;
            dgCourse.DataSource = queryCourse;
        }
    }
}
