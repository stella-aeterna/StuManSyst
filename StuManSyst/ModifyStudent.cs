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
    public partial class ModifyStudent : Form
    {
        public User currenUser;
        List<Student> students = new List<Student>();
        string newPhotoPath = "";
        public ModifyStudent()
        {
            InitializeComponent();
        }
        private void ModifyStudent_Load(object sender, EventArgs e)
        {
            if (currenUser != null && currenUser.Categeroy == "学生")
            {
                students = SuReadInfo.ReadStudent();
                foreach (Student s in students)
                {
                    if (s.Name == currenUser.UserName)
                    {
                        tbQuerySID.Text = s.Id;
                        tbQuerySID.ReadOnly = true;
                        tbStuID.ReadOnly = true;
                        break;
                    }
                }
            }
        }

        private void btnQueryStu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuerySID.Text))
            {
                MessageBox.Show("请输入要修改的学号。");
                return;
            }
            students = SuReadInfo.ReadStudent();
            if (students == null) return;
            foreach (Student s in students)
            {
                if (tbQuerySID.Text == s.Id)
                {
                    tbStuID.Text = s.Id;
                    tbStuName.Text = s.Name;
                    if (s.Gender == "男")
                        rbMale.Checked = true;
                    else
                        rbFemale.Checked = true;
                    tbPhone.Text = s.Phone;
                    tbAddress.Text = s.Address;
                    newPhotoPath = "";
                    if (!string.IsNullOrEmpty(s.Photo))
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
                    }
                    else
                    {
                        picPhoto.Image = null;
                    }
                    return;
                }
            }
            MessageBox.Show("未找到该学号的学生信息","提示");
        }

        private void btnModifyStu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStuID.Text))
            {
                MessageBox.Show("没有要修改的学生信息。");
                return;
            }
            if (string.IsNullOrEmpty(tbStuID.Text)||string.IsNullOrEmpty(tbStuName.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("请填写完整的学生信息。");
                return;
            }
            string gender = rbMale.Checked ? "男" : "女";

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == tbQuerySID.Text)
                {
                    students[i].Id = tbStuID.Text;
                    students[i].Name = tbStuName.Text;
                    students[i].Gender = gender;
                    students[i].Phone = tbPhone.Text;
                    students[i].Address = tbAddress.Text;

                    if (!string.IsNullOrEmpty(newPhotoPath))
                    {
                        string photoDir = @".\data\photo\";
                        if (!Directory.Exists(photoDir))
                        {
                            Directory.CreateDirectory(photoDir);
                        }
                        string photoFileName = tbStuID.Text + Path.GetExtension(newPhotoPath);
                        File.Copy(newPhotoPath, photoDir + photoFileName, true);
                        students[i].Photo = photoFileName;
                    }

                    MessageBox.Show("学生信息修改成功。");
                    SuWriteInfo.WriteStudent(students);
                    return;
                }
            }
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "选择学生照片";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPhotoPath = openFileDialog.FileName;
                picPhoto.Image = Image.FromFile(newPhotoPath);
            }
        }
    }
}
