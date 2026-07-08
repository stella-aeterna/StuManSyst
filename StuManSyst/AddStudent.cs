using StuManSyst.Mode1;
using StuManSyst.StuInforMod;
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

namespace StuManSyst
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        string photoPath = "";

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStuID.Text) || string.IsNullOrEmpty(tbStuName.Text) ||
    string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("请填写完整的学生信息。");
                return;
            }
            string gender = "";
            foreach (var v in groupBox2.Controls)
            {
                RadioButton rd = v as RadioButton;
                if (rd != null && rd.Checked)
                    gender = rd.Text;
            }
            if (gender == "")
            {
                MessageBox.Show("请选择性别。");
                return;
            }
            List<Student> students = SuReadInfo.ReadStudent();
            if (students != null)
            {
                foreach (Student s in students)
                {
                    if (s.Id == tbStuID.Text)
                    {
                        MessageBox.Show("要添加的学号已经存在，请重新输入！");
                        tbStuID.Text = "";
                        tbStuID.Focus();
                        return;
                    }
                }
            }
            else
            {
                students = new List<Student>();
            }

            string photoFileName = "";
            if (!string.IsNullOrEmpty(photoPath))
            {
                string photoDir = @".\data\photo\";
                if (!Directory.Exists(photoDir))
                {
                    Directory.CreateDirectory(photoDir);
                }
                photoFileName = tbStuID.Text + Path.GetExtension(photoPath);
                File.Copy(photoPath, photoDir + photoFileName, true);
            }

            Student student = new Student(tbStuID.Text, tbStuName.Text, gender, tbPhone.Text, tbAddress.Text, photoFileName);
            students.Add(student);
            SuWriteInfo.WriteStudent(students);
            MessageBox.Show("学生信息添加成功！");
            tbStuID.Text = "";
            tbStuName.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            picPhoto.Image = null;
            photoPath = "";
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "选择学生照片";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFileDialog.FileName;
                picPhoto.Image = Image.FromFile(photoPath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
