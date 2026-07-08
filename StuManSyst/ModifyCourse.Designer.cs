namespace StuManSyst
{
    partial class ModifyCourse
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.teNewCoId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teNewCoName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teOldCoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnteCoId = new System.Windows.Forms.Button();
            this.teOldCoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 78);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(161, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 78);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // teNewCoId
            // 
            this.teNewCoId.Location = new System.Drawing.Point(206, 115);
            this.teNewCoId.Name = "teNewCoId";
            this.teNewCoId.Size = new System.Drawing.Size(203, 28);
            this.teNewCoId.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "新 的 课 程 号：";
            // 
            // teNewCoName
            // 
            this.teNewCoName.Location = new System.Drawing.Point(206, 157);
            this.teNewCoName.Name = "teNewCoName";
            this.teNewCoName.Size = new System.Drawing.Size(203, 28);
            this.teNewCoName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "新 的 课 程 名：";
            // 
            // teOldCoId
            // 
            this.teOldCoId.Location = new System.Drawing.Point(206, 31);
            this.teOldCoId.Name = "teOldCoId";
            this.teOldCoId.Size = new System.Drawing.Size(203, 28);
            this.teOldCoId.TabIndex = 29;
            this.teOldCoId.TextChanged += new System.EventHandler(this.teOldCoId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "请输入要修改课程号：";
            // 
            // btnteCoId
            // 
            this.btnteCoId.Location = new System.Drawing.Point(28, 199);
            this.btnteCoId.Name = "btnteCoId";
            this.btnteCoId.Size = new System.Drawing.Size(109, 78);
            this.btnteCoId.TabIndex = 27;
            this.btnteCoId.Text = "修改";
            this.btnteCoId.UseVisualStyleBackColor = true;
            this.btnteCoId.Click += new System.EventHandler(this.btnteCoId_Click);
            // 
            // teOldCoName
            // 
            this.teOldCoName.Location = new System.Drawing.Point(206, 73);
            this.teOldCoName.Name = "teOldCoName";
            this.teOldCoName.ReadOnly = true;
            this.teOldCoName.Size = new System.Drawing.Size(203, 28);
            this.teOldCoName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "要修改的课程名：";
            // 
            // ModifyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 302);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.teNewCoId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teNewCoName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teOldCoId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnteCoId);
            this.Controls.Add(this.teOldCoName);
            this.Controls.Add(this.label1);
            this.Name = "ModifyCourse";
            this.Text = "课程修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox teNewCoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teNewCoName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teOldCoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnteCoId;
        private System.Windows.Forms.TextBox teOldCoName;
        private System.Windows.Forms.Label label1;
    }
}