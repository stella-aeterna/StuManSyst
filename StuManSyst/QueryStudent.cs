using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StuManSyst.Mode1;
using StuManSyst.StuInforMod;

namespace StuManSyst
{
    public partial class QueryStudent : Form
    {

        public QueryStudent()
        {
            InitializeComponent();
        }
        public User currenUser;
        List<Student> students = new List<Student>();


        private void QueryStudent_Load(object sender, EventArgs e)
        {
            dgStudent.DataSource = null;
            students = SuReadInfo.ReadStudent();
            if (students == null) return;

            if (currenUser != null && currenUser.Categeroy == "学生")
            {
                // 学生只能看自己的信息，禁用查询输入
                tbQueryStu.Text = currenUser.UserName;
                tbQueryStu.Enabled = false;
                btnQueryStu.Enabled = false;
                DoQuery(currenUser.UserName);
            }
            else
            {
                dgStudent.DataSource = students;
                dgStudent.Columns["Photo"].Visible = false;
            }
        }

        private void btnQueryStu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbQueryStu.Text))
            {
                MessageBox.Show("请输入要查询的学号。");
                return;
            }
            DoQuery(tbQueryStu.Text);
        }

        private void DoQuery(string studentId)
        {
            if (students == null) return;
            List<Student> queryStu = new List<Student>();
            foreach (Student s in students)
            {
                if (s.Id == studentId)
                {
                    queryStu.Add(s);
                }
            }
            dgStudent.DataSource = null;
            dgStudent.DataSource = queryStu;
            dgStudent.Columns["Photo"].Visible = false;
        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && students != null)
            {
                string sid = dgStudent.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                foreach (Student s in students)
                {
                    if (s.Id == sid && !string.IsNullOrEmpty(s.Photo))
                    {
                        string photoFullPath = @".\data\photo\" + s.Photo;
                        if (File.Exists(photoFullPath))
                        {
                            picPhoto.Image = Image.FromFile(photoFullPath);
                        }
                        else
                        {
                            picPhoto.Image = null;
                        }
                        return;
                    }
                }
            }
            picPhoto.Image = null;
        }
    }
}
