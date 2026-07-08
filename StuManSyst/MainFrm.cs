using StuManSyst;
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
    public partial class MainFrm : Form
    {
        public User currenUser;
        public MainFrm()
        {
            InitializeComponent();
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "用户名" + currenUser.UserName + "|" +"用户类别：" + currenUser.Categeroy;
            toolStripStatusLabel2.Text = "当前用户时间：" + DateTime.Now.ToString();
            if (currenUser.Categeroy == "教师")
            {
                用户增加ToolStripMenuItem.Enabled = false;
                用户删除ToolStripMenuItem.Enabled = false;
                用户修改ToolStripMenuItem.Enabled = false;
                用户查询ToolStripMenuItem.Enabled = false;

                课程增加ToolStripMenuItem.Enabled = false;
                课程删除ToolStripMenuItem.Enabled = false;
                课程修改ToolStripMenuItem.Enabled = false;
                //课程查询ToolStripMenuItem.Enabled = false;

                //成绩增加ToolStripMenuItem.Enabled = false;
                //成绩删除ToolStripMenuItem.Enabled = false;
                //成绩修改ToolStripMenuItem.Enabled = false;
                //成绩查询ToolStripMenuItem.Enabled = false;

                学生信息增加ToolStripMenuItem.Enabled = false;
                学生信息删除ToolStripMenuItem.Enabled = false;
                学生信息修改ToolStripMenuItem.Enabled = false;
                学生信息查询ToolStripMenuItem.Enabled = false;
            }
            else if (currenUser.Categeroy == "辅导员")
            {
                用户增加ToolStripMenuItem.Enabled = false;
                用户删除ToolStripMenuItem.Enabled = false;
                用户修改ToolStripMenuItem.Enabled = false;
                用户查询ToolStripMenuItem.Enabled = false;

                课程增加ToolStripMenuItem.Enabled = false;
                课程删除ToolStripMenuItem.Enabled = false;
                课程修改ToolStripMenuItem.Enabled = false;
                课程查询ToolStripMenuItem.Enabled = false;

                成绩增加ToolStripMenuItem.Enabled = false;
                成绩删除ToolStripMenuItem.Enabled = false;
                成绩修改ToolStripMenuItem.Enabled = false;
                //成绩查询ToolStripMenuItem.Enabled = false;

                //学生信息增加ToolStripMenuItem.Enabled = false;
                //学生信息删除ToolStripMenuItem.Enabled = false;
                //学生信息修改ToolStripMenuItem.Enabled = false;
                //学生信息查询ToolStripMenuItem.Enabled = false;
            }
            else if (currenUser.Categeroy == "学生")
            {
                用户增加ToolStripMenuItem.Enabled = false;
                用户删除ToolStripMenuItem.Enabled = false;
                用户修改ToolStripMenuItem.Enabled = false;
                用户查询ToolStripMenuItem.Enabled = false;

                课程增加ToolStripMenuItem.Enabled = false;
                课程删除ToolStripMenuItem.Enabled = false;
                课程修改ToolStripMenuItem.Enabled = false;
                //课程查询ToolStripMenuItem.Enabled = false;

                成绩增加ToolStripMenuItem.Enabled = false;
                成绩删除ToolStripMenuItem.Enabled = false;
                成绩修改ToolStripMenuItem.Enabled = false;
                //成绩查询ToolStripMenuItem.Enabled = false;

                学生信息增加ToolStripMenuItem.Enabled = false;
                学生信息删除ToolStripMenuItem.Enabled = false;
                //学生信息修改ToolStripMenuItem.Enabled = false;
                //学生信息查询ToolStripMenuItem.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "当前用户时间：" + DateTime.Now.ToString();
        }

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyPass modifyPassFrm = new ModifyPass(currenUser);
            modifyPassFrm.MdiParent = this;
            modifyPassFrm.Show();
        }

        //用户管理
        private void 用户增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.MdiParent = this;
            addUser.Show();
        }
        private void 用户删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.MdiParent = this;
            deleteUser.Show();
        }

        private void 用户修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyUser modifyUser = new ModifyUser();
            modifyUser.MdiParent = this;
            modifyUser.Show();
        }

        private void 用户查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryUser queryUser = new QueryUser();
            queryUser.MdiParent = this;
            queryUser.Show();
        }

        //课程管理
        private void 课程增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse addCourse = new AddCourse();
            addCourse.MdiParent = this;
            addCourse.Show();
        }

        private void 课程删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCourse deleteCourse = new DeleteCourse();
            deleteCourse.MdiParent = this;
            deleteCourse.Show();
        }

        private void 课程修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCourse modifyCourse = new ModifyCourse();
            modifyCourse.MdiParent = this;
            modifyCourse.Show();
        }

        private void 课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryCourse queryCourse = new QueryCourse();
            queryCourse.MdiParent = this;
            queryCourse.Show();
        }

        //成绩管理
        private void 成绩增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrade addGrade = new AddGrade();
            addGrade.MdiParent = this;
            addGrade.Show();
        }

        private void 成绩删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGrade deleteGrade = new DeleteGrade();
            deleteGrade.MdiParent = this;
            deleteGrade.Show();
        }

        private void 成绩修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyGrade modifyGrade = new ModifyGrade();
            modifyGrade.MdiParent = this;
            modifyGrade.Show();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryGrade queryGrade = new QueryGrade();
            queryGrade.MdiParent = this;
            queryGrade.currenUser = currenUser;
            queryGrade.Show();
        }

        //学生管理
        private void 学生信息增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.MdiParent = this;
            addStudent.Show();
        }

        private void 学生信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.MdiParent = this;
            deleteStudent.Show();
        }

        private void 学生信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

