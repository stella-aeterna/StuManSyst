using StuManSyst.CourseMod;
using StuManSyst.Mode1;
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
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }
        List<Course> courses;
        private void DeleteCourse_Load(object sender, EventArgs e)
        {
            dgCourse.DataSource = null;
            courses = CoReadInfo.ReadCourse();
            dgCourse.DataSource = courses;
        }
        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            if (teDeleteCourse.Text == "")
            {
                MessageBox.Show("请输入要删除的课程号");
                return;
            }
            Course course = null;
            try
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    if (teDeleteCourse.Text == courses[i].CourseID)
                    {
                        course = courses[i];
                        break;
                    }
                }
                if (course != null)
                {
                    courses.Remove(course);
                    MessageBox.Show("删除成功！");
                    CoWriteInfo.WriteCourse(courses);
                    dgCourse.DataSource = null;
                    dgCourse.DataSource = courses;
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            catch
            {
                MessageBox.Show("删除失败！");
            }
        }


    }
}
