namespace StuManSyst
{
    partial class DeleteCourse
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
            this.dgCourse = new System.Windows.Forms.DataGridView();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.teDeleteCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCourse
            // 
            this.dgCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourse.Location = new System.Drawing.Point(35, 92);
            this.dgCourse.Name = "dgCourse";
            this.dgCourse.RowHeadersWidth = 62;
            this.dgCourse.RowTemplate.Height = 30;
            this.dgCourse.Size = new System.Drawing.Size(542, 180);
            this.dgCourse.TabIndex = 7;
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Location = new System.Drawing.Point(479, 38);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(98, 28);
            this.btnCourseDelete.TabIndex = 6;
            this.btnCourseDelete.Text = "删除";
            this.btnCourseDelete.UseVisualStyleBackColor = true;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // teDeleteCourse
            // 
            this.teDeleteCourse.Location = new System.Drawing.Point(244, 38);
            this.teDeleteCourse.Name = "teDeleteCourse";
            this.teDeleteCourse.Size = new System.Drawing.Size(217, 28);
            this.teDeleteCourse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入要删除的课程：";
            // 
            // DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 320);
            this.Controls.Add(this.dgCourse);
            this.Controls.Add(this.btnCourseDelete);
            this.Controls.Add(this.teDeleteCourse);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCourse";
            this.Text = "课程删除";
            this.Load += new System.EventHandler(this.DeleteCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCourse;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.TextBox teDeleteCourse;
        private System.Windows.Forms.Label label1;
    }
}