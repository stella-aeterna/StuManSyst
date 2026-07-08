namespace StuManSyst
{
    partial class AddCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.teCoName = new System.Windows.Forms.TextBox();
            this.teCoId = new System.Windows.Forms.TextBox();
            this.btnCoAdd = new System.Windows.Forms.Button();
            this.btnCoClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程号：";
            // 
            // teCoName
            // 
            this.teCoName.Location = new System.Drawing.Point(110, 82);
            this.teCoName.Name = "teCoName";
            this.teCoName.Size = new System.Drawing.Size(265, 28);
            this.teCoName.TabIndex = 2;
            // 
            // teCoId
            // 
            this.teCoId.Location = new System.Drawing.Point(110, 34);
            this.teCoId.Name = "teCoId";
            this.teCoId.Size = new System.Drawing.Size(265, 28);
            this.teCoId.TabIndex = 3;
            // 
            // btnCoAdd
            // 
            this.btnCoAdd.Location = new System.Drawing.Point(43, 128);
            this.btnCoAdd.Name = "btnCoAdd";
            this.btnCoAdd.Size = new System.Drawing.Size(143, 54);
            this.btnCoAdd.TabIndex = 4;
            this.btnCoAdd.Text = "添加";
            this.btnCoAdd.UseVisualStyleBackColor = true;
            this.btnCoAdd.Click += new System.EventHandler(this.btnCoAdd_Click);
            // 
            // btnCoClear
            // 
            this.btnCoClear.Location = new System.Drawing.Point(232, 128);
            this.btnCoClear.Name = "btnCoClear";
            this.btnCoClear.Size = new System.Drawing.Size(143, 54);
            this.btnCoClear.TabIndex = 5;
            this.btnCoClear.Text = "清除";
            this.btnCoClear.UseVisualStyleBackColor = true;
            this.btnCoClear.Click += new System.EventHandler(this.btnCoClear_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 218);
            this.Controls.Add(this.btnCoClear);
            this.Controls.Add(this.btnCoAdd);
            this.Controls.Add(this.teCoId);
            this.Controls.Add(this.teCoName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourse";
            this.Text = "课程增加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teCoName;
        private System.Windows.Forms.TextBox teCoId;
        private System.Windows.Forms.Button btnCoAdd;
        private System.Windows.Forms.Button btnCoClear;
    }
}