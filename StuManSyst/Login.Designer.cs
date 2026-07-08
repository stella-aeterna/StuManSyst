namespace StuManSyst
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teUser = new System.Windows.Forms.TextBox();
            this.tePass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ad = new System.Windows.Forms.RadioButton();
            this.radioButton_te = new System.Windows.Forms.RadioButton();
            this.radioButton_in = new System.Windows.Forms.RadioButton();
            this.radioButton_st = new System.Windows.Forms.RadioButton();
            this.butLogin = new System.Windows.Forms.Button();
            this.butdClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // teUser
            // 
            this.teUser.Location = new System.Drawing.Point(167, 33);
            this.teUser.Name = "teUser";
            this.teUser.Size = new System.Drawing.Size(351, 28);
            this.teUser.TabIndex = 2;
            this.teUser.Text = "xtsc";
            // 
            // tePass
            // 
            this.tePass.Location = new System.Drawing.Point(167, 87);
            this.tePass.Name = "tePass";
            this.tePass.PasswordChar = '*';
            this.tePass.Size = new System.Drawing.Size(351, 28);
            this.tePass.TabIndex = 3;
            this.tePass.Text = "123456";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ad);
            this.groupBox1.Controls.Add(this.radioButton_te);
            this.groupBox1.Controls.Add(this.radioButton_in);
            this.groupBox1.Controls.Add(this.radioButton_st);
            this.groupBox1.Location = new System.Drawing.Point(44, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户类型";
            // 
            // radioButton_ad
            // 
            this.radioButton_ad.AutoSize = true;
            this.radioButton_ad.Checked = true;
            this.radioButton_ad.Location = new System.Drawing.Point(6, 42);
            this.radioButton_ad.Name = "radioButton_ad";
            this.radioButton_ad.Size = new System.Drawing.Size(87, 22);
            this.radioButton_ad.TabIndex = 5;
            this.radioButton_ad.TabStop = true;
            this.radioButton_ad.Text = "管理员";
            this.radioButton_ad.UseVisualStyleBackColor = true;
            // 
            // radioButton_te
            // 
            this.radioButton_te.AutoSize = true;
            this.radioButton_te.Location = new System.Drawing.Point(131, 42);
            this.radioButton_te.Name = "radioButton_te";
            this.radioButton_te.Size = new System.Drawing.Size(69, 22);
            this.radioButton_te.TabIndex = 6;
            this.radioButton_te.TabStop = true;
            this.radioButton_te.Text = "教师";
            this.radioButton_te.UseVisualStyleBackColor = true;
            // 
            // radioButton_in
            // 
            this.radioButton_in.AutoSize = true;
            this.radioButton_in.Location = new System.Drawing.Point(238, 42);
            this.radioButton_in.Name = "radioButton_in";
            this.radioButton_in.Size = new System.Drawing.Size(87, 22);
            this.radioButton_in.TabIndex = 7;
            this.radioButton_in.TabStop = true;
            this.radioButton_in.Text = "辅导员";
            this.radioButton_in.UseVisualStyleBackColor = true;
            // 
            // radioButton_st
            // 
            this.radioButton_st.AutoSize = true;
            this.radioButton_st.Location = new System.Drawing.Point(363, 42);
            this.radioButton_st.Name = "radioButton_st";
            this.radioButton_st.Size = new System.Drawing.Size(69, 22);
            this.radioButton_st.TabIndex = 8;
            this.radioButton_st.TabStop = true;
            this.radioButton_st.Text = "学生";
            this.radioButton_st.UseVisualStyleBackColor = true;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(44, 262);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(200, 70);
            this.butLogin.TabIndex = 9;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butdClear
            // 
            this.butdClear.Location = new System.Drawing.Point(318, 262);
            this.butdClear.Name = "butdClear";
            this.butdClear.Size = new System.Drawing.Size(200, 70);
            this.butdClear.TabIndex = 10;
            this.butdClear.Text = "清除";
            this.butdClear.UseVisualStyleBackColor = true;
            this.butdClear.Click += new System.EventHandler(this.butdClear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 390);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butdClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tePass);
            this.Controls.Add(this.teUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "登录";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teUser;
        private System.Windows.Forms.TextBox tePass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_ad;
        private System.Windows.Forms.RadioButton radioButton_te;
        private System.Windows.Forms.RadioButton radioButton_in;
        private System.Windows.Forms.RadioButton radioButton_st;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butdClear;
    }
}

