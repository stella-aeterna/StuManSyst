namespace StuManSyst
{
    partial class ModifyUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserIfy = new System.Windows.Forms.Button();
            this.teOldUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teOldPass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOld_ad = new System.Windows.Forms.RadioButton();
            this.rbOld_te = new System.Windows.Forms.RadioButton();
            this.rbOld_in = new System.Windows.Forms.RadioButton();
            this.rbOld_st = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNew_ad = new System.Windows.Forms.RadioButton();
            this.rbNew_te = new System.Windows.Forms.RadioButton();
            this.rbNew_in = new System.Windows.Forms.RadioButton();
            this.rbNew_st = new System.Windows.Forms.RadioButton();
            this.teNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teNewUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserIfy
            // 
            this.btnUserIfy.Location = new System.Drawing.Point(481, 28);
            this.btnUserIfy.Name = "btnUserIfy";
            this.btnUserIfy.Size = new System.Drawing.Size(109, 78);
            this.btnUserIfy.TabIndex = 10;
            this.btnUserIfy.Text = "修改";
            this.btnUserIfy.UseVisualStyleBackColor = true;
            this.btnUserIfy.Click += new System.EventHandler(this.btnUserIfy_Click);
            // 
            // teOldUser
            // 
            this.teOldUser.Location = new System.Drawing.Point(257, 25);
            this.teOldUser.Name = "teOldUser";
            this.teOldUser.Size = new System.Drawing.Size(203, 28);
            this.teOldUser.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入要修改的用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "请输入要修改用户的密码：";
            // 
            // teOldPass
            // 
            this.teOldPass.Location = new System.Drawing.Point(257, 66);
            this.teOldPass.Name = "teOldPass";
            this.teOldPass.Size = new System.Drawing.Size(203, 28);
            this.teOldPass.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOld_ad);
            this.groupBox1.Controls.Add(this.rbOld_te);
            this.groupBox1.Controls.Add(this.rbOld_in);
            this.groupBox1.Controls.Add(this.rbOld_st);
            this.groupBox1.Location = new System.Drawing.Point(48, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户类型";
            // 
            // rbOld_ad
            // 
            this.rbOld_ad.AutoSize = true;
            this.rbOld_ad.Location = new System.Drawing.Point(6, 27);
            this.rbOld_ad.Name = "rbOld_ad";
            this.rbOld_ad.Size = new System.Drawing.Size(87, 22);
            this.rbOld_ad.TabIndex = 5;
            this.rbOld_ad.Text = "管理员";
            this.rbOld_ad.UseVisualStyleBackColor = true;
            // 
            // rbOld_te
            // 
            this.rbOld_te.AutoSize = true;
            this.rbOld_te.Location = new System.Drawing.Point(114, 25);
            this.rbOld_te.Name = "rbOld_te";
            this.rbOld_te.Size = new System.Drawing.Size(69, 22);
            this.rbOld_te.TabIndex = 6;
            this.rbOld_te.TabStop = true;
            this.rbOld_te.Text = "教师";
            this.rbOld_te.UseVisualStyleBackColor = true;
            // 
            // rbOld_in
            // 
            this.rbOld_in.AutoSize = true;
            this.rbOld_in.Location = new System.Drawing.Point(220, 27);
            this.rbOld_in.Name = "rbOld_in";
            this.rbOld_in.Size = new System.Drawing.Size(87, 22);
            this.rbOld_in.TabIndex = 7;
            this.rbOld_in.Text = "辅导员";
            this.rbOld_in.UseVisualStyleBackColor = true;
            // 
            // rbOld_st
            // 
            this.rbOld_st.AutoSize = true;
            this.rbOld_st.Location = new System.Drawing.Point(343, 31);
            this.rbOld_st.Name = "rbOld_st";
            this.rbOld_st.Size = new System.Drawing.Size(69, 22);
            this.rbOld_st.TabIndex = 8;
            this.rbOld_st.TabStop = true;
            this.rbOld_st.Text = "学生";
            this.rbOld_st.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNew_ad);
            this.groupBox2.Controls.Add(this.rbNew_te);
            this.groupBox2.Controls.Add(this.rbNew_in);
            this.groupBox2.Controls.Add(this.rbNew_st);
            this.groupBox2.Location = new System.Drawing.Point(48, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 53);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重选用户类型";
            // 
            // rbNew_ad
            // 
            this.rbNew_ad.AutoSize = true;
            this.rbNew_ad.Location = new System.Drawing.Point(6, 27);
            this.rbNew_ad.Name = "rbNew_ad";
            this.rbNew_ad.Size = new System.Drawing.Size(87, 22);
            this.rbNew_ad.TabIndex = 5;
            this.rbNew_ad.Text = "管理员";
            this.rbNew_ad.UseVisualStyleBackColor = true;
            // 
            // rbNew_te
            // 
            this.rbNew_te.AutoSize = true;
            this.rbNew_te.Location = new System.Drawing.Point(114, 25);
            this.rbNew_te.Name = "rbNew_te";
            this.rbNew_te.Size = new System.Drawing.Size(69, 22);
            this.rbNew_te.TabIndex = 6;
            this.rbNew_te.TabStop = true;
            this.rbNew_te.Text = "教师";
            this.rbNew_te.UseVisualStyleBackColor = true;
            // 
            // rbNew_in
            // 
            this.rbNew_in.AutoSize = true;
            this.rbNew_in.Location = new System.Drawing.Point(220, 27);
            this.rbNew_in.Name = "rbNew_in";
            this.rbNew_in.Size = new System.Drawing.Size(87, 22);
            this.rbNew_in.TabIndex = 7;
            this.rbNew_in.TabStop = true;
            this.rbNew_in.Text = "辅导员";
            this.rbNew_in.UseVisualStyleBackColor = true;
            // 
            // rbNew_st
            // 
            this.rbNew_st.AutoSize = true;
            this.rbNew_st.Location = new System.Drawing.Point(343, 31);
            this.rbNew_st.Name = "rbNew_st";
            this.rbNew_st.Size = new System.Drawing.Size(69, 22);
            this.rbNew_st.TabIndex = 8;
            this.rbNew_st.TabStop = true;
            this.rbNew_st.Text = "学生";
            this.rbNew_st.UseVisualStyleBackColor = true;
            // 
            // teNewPass
            // 
            this.teNewPass.Location = new System.Drawing.Point(190, 226);
            this.teNewPass.Name = "teNewPass";
            this.teNewPass.Size = new System.Drawing.Size(270, 28);
            this.teNewPass.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "新的密码：";
            // 
            // teNewUser
            // 
            this.teNewUser.Location = new System.Drawing.Point(190, 185);
            this.teNewUser.Name = "teNewUser";
            this.teNewUser.Size = new System.Drawing.Size(270, 28);
            this.teNewUser.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "新的用户名：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(481, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 78);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 78);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 354);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.teNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teNewUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUserIfy);
            this.Controls.Add(this.teOldUser);
            this.Controls.Add(this.label1);
            this.Name = "ModifyUser";
            this.Text = "用户修改";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUserIfy;
        private System.Windows.Forms.TextBox teOldUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teOldPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOld_ad;
        private System.Windows.Forms.RadioButton rbOld_te;
        private System.Windows.Forms.RadioButton rbOld_in;
        private System.Windows.Forms.RadioButton rbOld_st;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNew_ad;
        private System.Windows.Forms.RadioButton rbNew_te;
        private System.Windows.Forms.RadioButton rbNew_in;
        private System.Windows.Forms.RadioButton rbNew_st;
        private System.Windows.Forms.TextBox teNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teNewUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}