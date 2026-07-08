using StuManSyst.Mode1;
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
    public partial class ModifyPass : Form
    {
        private User currenUser;
        public ModifyPass(User user)
        {
            InitializeComponent();
            currenUser = user;
        }

        private void bu_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(te_oldPass.Text) || string.IsNullOrEmpty(te_newPass.Text) || string.IsNullOrEmpty(te_Re_enter.Text))
            {
                MessageBox.Show("必须输入密码！");
                return;
            }
            if (te_oldPass.Text != currenUser.Pass)
            {
                MessageBox.Show("旧密码输入错误。");
                return;
            }
            if (te_newPass.Text != te_Re_enter.Text)
            {
                MessageBox.Show("新密码和确认密码不一致。");
                return;
            }
            if (te_oldPass.Text == te_newPass.Text)
            {
                MessageBox.Show("新密码和旧密码一致，请重新输入新密码！");
                return;
            }

            try
            {
                List<User> users = new List<User>();
                StreamReader sr = new StreamReader(@".\data\user.txt", Encoding.UTF8);
                string str = sr.ReadLine();
                while (str != null)
                {
                    string[] userinfo = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    User u = new User(userinfo[0], userinfo[1], userinfo[2]);
                    users.Add(u);
                    str = sr.ReadLine();
                }
                sr.Close();
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].UserName == currenUser.UserName)
                    {
                        users[i].Pass = te_newPass.Text;
                    }
                }

                StreamWriter sw = new StreamWriter(@".\data\user.txt", false, Encoding.UTF8);
                foreach (User u in users)
                {
                    sw.WriteLine(u.UserName + "|" + u.Pass + "|" + u.Categeroy);
                }
                sw.Close();
                MessageBox.Show("密码修改成功！");
                this.Close();
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
