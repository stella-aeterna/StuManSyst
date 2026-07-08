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
    public partial class QueryUser : Form
    {

        List<User> users;
        public QueryUser()
        {
            InitializeComponent();
        }
        private void QueryUser_Load(object sender, EventArgs e)
        {
            dgUser.DataSource = null;
            users = ReadInfo1.ReadUser();
            dgUser.DataSource = users;
        }

        private void btnUserQuery_Click(object sender, EventArgs e)
        {
            if (teQueryUser.Text == "")
            {
                MessageBox.Show("请输入要查询的用户名。");
                return;
            }
            List<User> queryUsers = new List<User>();
            foreach (User u in users)
            {
                if (u.UserName == teQueryUser.Text)
                {
                    queryUsers.Add(u);
                }
            }
            dgUser.DataSource = null;
            dgUser.DataSource = queryUsers;
        }

    }
}
