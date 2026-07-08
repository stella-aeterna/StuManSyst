using StuManSyst.Mode1;
using StuManSyst.StuInforMod;
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

namespace StuManSyst
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            dgStudent.DataSource = null;
            students = SuReadInfo.ReadStudent();
            if (students != null)
            {
                dgStudent.DataSource = students;
                dgStudent.Columns["Photo"].Visible = false;
            }
        }

        private void btnDeleStu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDeleStu.Text))
            {
                MessageBox.Show("请输入要删除的学号。");
                return;
            }
            if (students == null) return;
            foreach (Student s in students)
            {
                if (s.Id == tbDeleStu.Text)
                {
                    students.Remove(s);
                    MessageBox.Show("学生信息删除成功。");
                    dgStudent.DataSource = null;
                    dgStudent.DataSource = students;
                    dgStudent.Columns["Photo"].Visible = false;
                    SuWriteInfo.WriteStudent(students);
                    return;
                }
            }
            MessageBox.Show("未找到该学号的学生信息。");
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
