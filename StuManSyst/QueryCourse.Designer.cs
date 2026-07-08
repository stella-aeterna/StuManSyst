namespace StuManSyst
{
    partial class QueryCourse
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
            this.btnQueryCourse = new System.Windows.Forms.Button();
            this.teQueryCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCourse
            // 
            this.dgCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourse.Location = new System.Drawing.Point(29, 83);
            this.dgCourse.Name = "dgCourse";
            this.dgCourse.RowHeadersWidth = 62;
            this.dgCourse.RowTemplate.Height = 30;
            this.dgCourse.Size = new System.Drawing.Size(542, 180);
            this.dgCourse.TabIndex = 11;
            // 
            // btnQueryCourse
            // 
            this.btnQueryCourse.Location = new System.Drawing.Point(473, 29);
            this.btnQueryCourse.Name = "btnQueryCourse";
            this.btnQueryCourse.Size = new System.Drawing.Size(98, 28);
            this.btnQueryCourse.TabIndex = 10;
            this.btnQueryCourse.Text = "查询";
            this.btnQueryCourse.UseVisualStyleBackColor = true;
            this.btnQueryCourse.Click += new System.EventHandler(this.btnQueryCourse_Click);
            // 
            // teQueryCourse
            // 
            this.teQueryCourse.Location = new System.Drawing.Point(238, 29);
            this.teQueryCourse.Name = "teQueryCourse";
            this.teQueryCourse.Size = new System.Drawing.Size(203, 28);
            this.teQueryCourse.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "请输入要查询的课程号：";
            // 
            // QueryCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 302);
            this.Controls.Add(this.dgCourse);
            this.Controls.Add(this.btnQueryCourse);
            this.Controls.Add(this.teQueryCourse);
            this.Controls.Add(this.label1);
            this.Name = "QueryCourse";
            this.Text = "课程查询";
            this.Load += new System.EventHandler(this.QueryCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCourse;
        private System.Windows.Forms.Button btnQueryCourse;
        private System.Windows.Forms.TextBox teQueryCourse;
        private System.Windows.Forms.Label label1;
    }
}