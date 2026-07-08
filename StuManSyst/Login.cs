using StuManSyst.Mode1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManSyst
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void butLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teUser.Text) || string.IsNullOrEmpty(tePass.Text))
            {
                MessageBox.Show("请输入用户名和密码", "提示");
                return;
            }
            string cate = "";
            foreach (var v in groupBox1.Controls)
            {
                RadioButton radioButton_ad = (RadioButton)v;
                if (radioButton_ad.Checked == true)
                {
                    cate = radioButton_ad.Text;
                }
            }
            if (cate == "")
            {
                MessageBox.Show("请选择用户类型", "提示");
                return;
            }
            try
            {


                StreamReader sr = new StreamReader(@".\data\user.txt", Encoding.UTF8);
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
                    User u = new User("xtsc", "123456", "管理员");
                    users.Add(u);
                    StreamWriter sw = new StreamWriter(@".\data\user.txt", false);
                    sw.WriteLine(u.UserName + "|" + u.Pass + "|" + u.Categeroy);
                    sw.Close();
                }
                int count = 0;
                foreach (User u in users)
                {
                    if (u.UserName == teUser.Text && u.Pass == tePass.Text && u.Categeroy == cate)
                    {
                        MainFrm mainFrm = new MainFrm();
                        mainFrm.currenUser = u;
                        mainFrm.Show();
                        this.Hide();
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("用户名，密码错误或对应的用户类型不匹配，请重新输入！", "提示");
                    teUser.Text = "";
                    tePass.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录出错：" + ex.Message, "错误");
            }
        }

        private void butdClear_Click(object sender, EventArgs e)
        {
            teUser.Text = "";
            tePass.Text = "";
            foreach (RadioButton rd in groupBox1.Controls.OfType<RadioButton>())
            {
                rd.Checked = false;
            }
        }
    }
}

