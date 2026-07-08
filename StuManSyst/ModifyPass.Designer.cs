namespace StuManSyst
{
    partial class ModifyPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.te_oldPass = new System.Windows.Forms.TextBox();
            this.bu_OK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.te_newPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.te_Re_enter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // te_oldPass
            // 
            this.te_oldPass.Location = new System.Drawing.Point(137, 53);
            this.te_oldPass.Name = "te_oldPass";
            this.te_oldPass.Size = new System.Drawing.Size(243, 28);
            this.te_oldPass.TabIndex = 1;
            // 
            // bu_OK
            // 
            this.bu_OK.Location = new System.Drawing.Point(32, 204);
            this.bu_OK.Name = "bu_OK";
            this.bu_OK.Size = new System.Drawing.Size(141, 58);
            this.bu_OK.TabIndex = 3;
            this.bu_OK.Text = "确定";
            this.bu_OK.UseVisualStyleBackColor = true;
            this.bu_OK.Click += new System.EventHandler(this.bu_OK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 58);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // te_newPass
            // 
            this.te_newPass.Location = new System.Drawing.Point(105, 21);
            this.te_newPass.Name = "te_newPass";
            this.te_newPass.Size = new System.Drawing.Size(240, 28);
            this.te_newPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "再次输入";
            // 
            // te_Re_enter
            // 
            this.te_Re_enter.Location = new System.Drawing.Point(105, 68);
            this.te_Re_enter.Name = "te_Re_enter";
            this.te_Re_enter.Size = new System.Drawing.Size(240, 28);
            this.te_Re_enter.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.te_Re_enter);
            this.groupBox1.Controls.Add(this.te_newPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ModifyPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bu_OK);
            this.Controls.Add(this.te_oldPass);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPass";
            this.Text = "修改密码";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox te_oldPass;
        private System.Windows.Forms.Button bu_OK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox te_newPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox te_Re_enter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}