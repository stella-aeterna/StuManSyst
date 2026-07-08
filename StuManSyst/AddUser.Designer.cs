namespace StuManSyst
{
    partial class AddUser
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_ad = new System.Windows.Forms.RadioButton();
            this.radioButton_te = new System.Windows.Forms.RadioButton();
            this.radioButton_in = new System.Windows.Forms.RadioButton();
            this.radioButton_st = new System.Windows.Forms.RadioButton();
            this.tePass = new System.Windows.Forms.TextBox();
            this.teUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(53, 262);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 70);
            this.btnAddUser.TabIndex = 16;
            this.btnAddUser.Text = "添加";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(217, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 70);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_ad);
            this.groupBox1.Controls.Add(this.radioButton_te);
            this.groupBox1.Controls.Add(this.radioButton_in);
            this.groupBox1.Controls.Add(this.radioButton_st);
            this.groupBox1.Location = new System.Drawing.Point(53, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 102);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户类型";
            // 
            // radioButton_ad
            // 
            this.radioButton_ad.AutoSize = true;
            this.radioButton_ad.Location = new System.Drawing.Point(6, 42);
            this.radioButton_ad.Name = "radioButton_ad";
            this.radioButton_ad.Size = new System.Drawing.Size(87, 22);
            this.radioButton_ad.TabIndex = 5;
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
            this.radioButton_st.Text = "学生";
            this.radioButton_st.UseVisualStyleBackColor = true;
            // 
            // tePass
            // 
            this.tePass.Location = new System.Drawing.Point(176, 87);
            this.tePass.Name = "tePass";
            this.tePass.PasswordChar = '*';
            this.tePass.Size = new System.Drawing.Size(351, 28);
            this.tePass.TabIndex = 14;
            // 
            // teUser
            // 
            this.teUser.Location = new System.Drawing.Point(176, 33);
            this.teUser.Name = "teUser";
            this.teUser.Size = new System.Drawing.Size(351, 28);
            this.teUser.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "用户名：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 18;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tePass);
            this.Controls.Add(this.teUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "用户增加";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_ad;
        private System.Windows.Forms.RadioButton radioButton_te;
        private System.Windows.Forms.RadioButton radioButton_in;
        private System.Windows.Forms.RadioButton radioButton_st;
        private System.Windows.Forms.TextBox tePass;
        private System.Windows.Forms.TextBox teUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}