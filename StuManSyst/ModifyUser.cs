using StuManSyst.Mode1;
using StuManSyst.UserMod;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace StuManSyst
{
    public partial class ModifyUser : Form
    {
        public ModifyUser()
        {
            InitializeComponent();
        }
        List<User> users;
        private void btnUserIfy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teOldUser.Text) || string.IsNullOrEmpty(teOldPass.Text))
            {
                MessageBox.Show("请输入要修改的用户名和密码", "提示");
                return;
            }

            if (string.IsNullOrEmpty(teNewUser.Text) || string.IsNullOrEmpty(teNewPass.Text))
            {
                MessageBox.Show("请输入新的用户名和密码", "提示");
                return;
            }

            string oldCate = "";
            foreach (var v in groupBox1.Controls)
            {
                System.Windows.Forms.RadioButton rbOld = (System.Windows.Forms.RadioButton)v;
                if (rbOld.Checked == true)
                {
                    oldCate = rbOld.Text;
                    break;
                }
            }

            string newCate = "";
            foreach (var v in groupBox2.Controls)
            {
                System.Windows.Forms.RadioButton rbNew = (System.Windows.Forms.RadioButton)v;
                if (rbNew.Checked == true)
                {
                    newCate = rbNew.Text;
                    break;
                }
            }

            if (oldCate == "")
            {
                MessageBox.Show("请选择修改用户对于的用户类型", "提示");
                return;
            }

            if (newCate == "")
            {
                MessageBox.Show("请重选用户类型", "提示");
                return;
            }

            try
            {
                string path = @".\data\user.txt";
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string str = sr.ReadLine();
                List<User> users = new List<User>();
                while (str != null)
                {
                    string[] userinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    User user = new User(userinfo[0], userinfo[1], userinfo[2]);
                    users.Add(user);
                    str = sr.ReadLine();
                }

                sr.Close();
                if (users.Count == 0)
                {
                    MessageBox.Show("系统还未添加用户", "提示");
                    return;
                }
                User targetUser = null;
                foreach (User u in users)
                {
                    if (u.UserName == teOldUser.Text && u.Pass == teOldPass.Text && u.Categeroy == oldCate)
                    {
                        targetUser = u;
                        break;
                    }
                }

                if (targetUser == null)
                {
                    MessageBox.Show("用户名，密码错误或对应的用户类型不匹配，请重新输入！", "提示");
                    teOldUser.Text = "";
                    teOldPass.Text = "";
                    return;

                }

                targetUser.UserName = teNewUser.Text.Trim();   // 新用户名
                targetUser.Pass = teNewPass.Text.Trim();       // 新密码
                targetUser.Categeroy = newCate;  // 新用户类型

                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    foreach (User u in users)
                    {
                        sw.WriteLine($"{u.UserName}|{u.Pass}|{u.Categeroy}");
                    }
                }

                MessageBox.Show("用户信息修改成功！", "提示");

                // 清空输入
                teOldUser.Clear();
                teOldPass.Clear();
                teNewUser.Clear();
                teNewPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错：" + ex.Message, "错误");
            }
        }


    }
}
