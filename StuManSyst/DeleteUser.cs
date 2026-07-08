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
using StuManSyst.UserMod;

namespace StuManSyst
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }
        
        List<User> users;

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            dgUser.DataSource = null;
            users = ReadInfo1.ReadUser();
            dgUser.DataSource = users;
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (teDeleteUser.Text == "")
            {
                MessageBox.Show("请输入要删除的用户名");
                return;
            }
            User user = null;
            try
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (teDeleteUser.Text == users[i].UserName)
                    {
                        user = users[i];
                        break;
                    }
                }
                if (user != null)
                {
                    users.Remove(user);
                    MessageBox.Show("删除成功！");
                    WriteInfo1.WriteUser(users);
                    dgUser.DataSource = null;
                    dgUser.DataSource = users;
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
