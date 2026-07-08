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
using StuManSyst.UserMod;

namespace StuManSyst
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>();
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teUser.Text) || string.IsNullOrEmpty(tePass.Text))
            {
                MessageBox.Show("请输入用户名和密码。");
                return;
            }
            string cate = "";
            foreach (var v in groupBox1.Controls)
            {
                RadioButton rd = (RadioButton)v;
                if (rd.Checked == true)
                    cate = rd.Text;
            }
            if (cate == "")
            {
                MessageBox.Show("请选择用户类型。");
                return;
            }
            users = ReadInfo1.ReadUser();
            User user = new User(teUser.Text, tePass.Text, cate);
            users.Add(user);
            WriteInfo1.WriteUser(users);
            MessageBox.Show("用户添加成功！");
            teUser.Text = "";
            tePass.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            teUser.Text = "";
            tePass.Text = "";
            foreach (RadioButton rd in groupBox1.Controls.OfType<RadioButton>())
            {
                rd.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
