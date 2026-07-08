namespace StuManSyst
{
    partial class AddGrade
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
            this.teGrName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teGrId = new System.Windows.Forms.TextBox();
            this.btnGrClear = new System.Windows.Forms.Button();
            this.btnGrAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teGrad = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.teGrIdStuId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teGrIdStuName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名：";
            // 
            // teGrName
            // 
            this.teGrName.Location = new System.Drawing.Point(118, 87);
            this.teGrName.Name = "teGrName";
            this.teGrName.ReadOnly = true;
            this.teGrName.Size = new System.Drawing.Size(249, 28);
            this.teGrName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程号：";
            // 
            // teGrId
            // 
            this.teGrId.Location = new System.Drawing.Point(118, 37);
            this.teGrId.Name = "teGrId";
            this.teGrId.Size = new System.Drawing.Size(249, 28);
            this.teGrId.TabIndex = 3;
            this.teGrId.TextChanged += new System.EventHandler(this.teGrId_TextChanged);
            // 
            // btnGrClear
            // 
            this.btnGrClear.Location = new System.Drawing.Point(395, 187);
            this.btnGrClear.Name = "btnGrClear";
            this.btnGrClear.Size = new System.Drawing.Size(143, 78);
            this.btnGrClear.TabIndex = 7;
            this.btnGrClear.Text = "清除";
            this.btnGrClear.UseVisualStyleBackColor = true;
            // 
            // btnGrAdd
            // 
            this.btnGrAdd.Location = new System.Drawing.Point(395, 37);
            this.btnGrAdd.Name = "btnGrAdd";
            this.btnGrAdd.Size = new System.Drawing.Size(143, 78);
            this.btnGrAdd.TabIndex = 6;
            this.btnGrAdd.Text = "添加";
            this.btnGrAdd.UseVisualStyleBackColor = true;
            this.btnGrAdd.Click += new System.EventHandler(this.btnGrAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "成绩：";
            // 
            // teGrad
            // 
            this.teGrad.Location = new System.Drawing.Point(118, 237);
            this.teGrad.Name = "teGrad";
            this.teGrad.Size = new System.Drawing.Size(249, 28);
            this.teGrad.TabIndex = 9;
            // 
            // teGrIdStuId
            // 
            this.teGrIdStuId.Location = new System.Drawing.Point(118, 137);
            this.teGrIdStuId.Name = "teGrIdStuId";
            this.teGrIdStuId.Size = new System.Drawing.Size(249, 28);
            this.teGrIdStuId.TabIndex = 14;
            this.teGrIdStuId.TextChanged += new System.EventHandler(this.teGrIdStuId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "学号：";
            // 
            // teGrIdStuName
            // 
            this.teGrIdStuName.Location = new System.Drawing.Point(118, 187);
            this.teGrIdStuName.Name = "teGrIdStuName";
            this.teGrIdStuName.ReadOnly = true;
            this.teGrIdStuName.Size = new System.Drawing.Size(249, 28);
            this.teGrIdStuName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "姓名：";
            // 
            // AddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 298);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teGrIdStuName);
            this.Controls.Add(this.teGrIdStuId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teGrad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGrClear);
            this.Controls.Add(this.btnGrAdd);
            this.Controls.Add(this.teGrId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teGrName);
            this.Controls.Add(this.label1);
            this.Name = "AddGrade";
            this.Text = "成绩增加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teGrName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teGrId;
        private System.Windows.Forms.Button btnGrClear;
        private System.Windows.Forms.Button btnGrAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teGrad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox teGrIdStuId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teGrIdStuName;
        private System.Windows.Forms.Label label6;
    }
}