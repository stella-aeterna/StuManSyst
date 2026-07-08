using StuManSyst.Mode1;
using StuManSyst.GradeMod;
using System;
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
    public partial class DeleteGrade : Form
    {
        public DeleteGrade()
        {
            InitializeComponent();
        }
        List<Score> scores = new List<Score>();
        private void DeleteGrade_Load(object sender, EventArgs e)
        {
            dgScore.DataSource = null;
            scores = GrReadInfo.ReadScore();
            if (scores != null)
                dgScore.DataSource = scores;
        }
        private void btnDeleScore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDeleSID.Text) || string.IsNullOrEmpty(tbDeleCID.Text))
            {
                MessageBox.Show("请输入要删除的学号和课程号");
                return;
            }
            if (scores == null) 
                return;
            foreach (Score s in scores)
            {
                if (s.StudentId == tbDeleSID.Text && s.CourseId == tbDeleCID.Text)
                {
                    scores.Remove(s);
                    MessageBox.Show("成绩删除成功！");
                    dgScore.DataSource = null;
                    dgScore.DataSource = scores;
                    GrWriteInfo.WriteScore(scores);
                    return;
                }
            }
            MessageBox.Show("未找到对应的成绩记录");
        }
    }
}
