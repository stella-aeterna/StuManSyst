namespace StuManSyst
{
    partial class ModifyGrade
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
            this.label6 = new System.Windows.Forms.Label();
            this.teGrIdStuName = new System.Windows.Forms.TextBox();
            this.teGrIdStuId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teGrad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrClear = new System.Windows.Forms.Button();
            this.btnGrModify = new System.Windows.Forms.Button();
            this.teGrId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teGrName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "姓名：";
            // 
            // teGrIdStuName
            // 
            this.teGrIdStuName.Location = new System.Drawing.Point(117, 175);
            this.teGrIdStuName.Name = "teGrIdStuName";
            this.teGrIdStuName.ReadOnly = true;
            this.teGrIdStuName.Size = new System.Drawing.Size(249, 28);
            this.teGrIdStuName.TabIndex = 27;
            // 
            // teGrIdStuId
            // 
            this.teGrIdStuId.Location = new System.Drawing.Point(117, 125);
            this.teGrIdStuId.Name = "teGrIdStuId";
            this.teGrIdStuId.Size = new System.Drawing.Size(249, 28);
            this.teGrIdStuId.TabIndex = 26;
            this.teGrIdStuId.TextChanged += new System.EventHandler(this.teGrIdStuId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "学号：";
            // 
            // teGrad
            // 
            this.teGrad.Location = new System.Drawing.Point(117, 225);
            this.teGrad.Name = "teGrad";
            this.teGrad.Size = new System.Drawing.Size(249, 28);
            this.teGrad.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "新的成绩：";
            // 
            // btnGrClear
            // 
            this.btnGrClear.Location = new System.Drawing.Point(372, 175);
            this.btnGrClear.Name = "btnGrClear";
            this.btnGrClear.Size = new System.Drawing.Size(143, 78);
            this.btnGrClear.TabIndex = 22;
            this.btnGrClear.Text = "清除";
            this.btnGrClear.UseVisualStyleBackColor = true;
            // 
            // btnGrModify
            // 
            this.btnGrModify.Location = new System.Drawing.Point(372, 25);
            this.btnGrModify.Name = "btnGrModify";
            this.btnGrModify.Size = new System.Drawing.Size(143, 78);
            this.btnGrModify.TabIndex = 21;
            this.btnGrModify.Text = "修改";
            this.btnGrModify.UseVisualStyleBackColor = true;
            this.btnGrModify.Click += new System.EventHandler(this.btnGrModify_Click);
            // 
            // teGrId
            // 
            this.teGrId.Location = new System.Drawing.Point(117, 25);
            this.teGrId.Name = "teGrId";
            this.teGrId.Size = new System.Drawing.Size(249, 28);
            this.teGrId.TabIndex = 20;
            this.teGrId.TextChanged += new System.EventHandler(this.teGrId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "课程号：";
            // 
            // teGrName
            // 
            this.teGrName.Location = new System.Drawing.Point(117, 75);
            this.teGrName.Name = "teGrName";
            this.teGrName.ReadOnly = true;
            this.teGrName.Size = new System.Drawing.Size(249, 28);
            this.teGrName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "课程名：";
            // 
            // ModifyGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrClear);
            this.Controls.Add(this.teGrIdStuName);
            this.Controls.Add(this.btnGrModify);
            this.Controls.Add(this.teGrName);
            this.Controls.Add(this.teGrad);
            this.Controls.Add(this.teGrIdStuId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teGrId);
            this.Controls.Add(this.label5);
            this.Name = "ModifyGrade";
            this.Text = "修改成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teGrIdStuName;
        private System.Windows.Forms.TextBox teGrIdStuId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teGrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrClear;
        private System.Windows.Forms.Button btnGrModify;
        private System.Windows.Forms.TextBox teGrId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teGrName;
        private System.Windows.Forms.Label label1;
    }
}