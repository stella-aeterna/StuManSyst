namespace StuManSyst
{
    partial class QueryStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.btnQueryStu = new System.Windows.Forms.Button();
            this.tbQueryStu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "学生照片";
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(658, 121);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(179, 209);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 14;
            this.picPhoto.TabStop = false;
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(22, 63);
            this.dgStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.RowHeadersWidth = 62;
            this.dgStudent.RowTemplate.Height = 23;
            this.dgStudent.Size = new System.Drawing.Size(628, 267);
            this.dgStudent.TabIndex = 13;
            this.dgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudent_CellClick);
            // 
            // btnQueryStu
            // 
            this.btnQueryStu.Location = new System.Drawing.Point(658, 21);
            this.btnQueryStu.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryStu.Name = "btnQueryStu";
            this.btnQueryStu.Size = new System.Drawing.Size(179, 49);
            this.btnQueryStu.TabIndex = 12;
            this.btnQueryStu.Text = "查询";
            this.btnQueryStu.UseVisualStyleBackColor = true;
            this.btnQueryStu.Click += new System.EventHandler(this.btnQueryStu_Click);
            // 
            // tbQueryStu
            // 
            this.tbQueryStu.Location = new System.Drawing.Point(233, 27);
            this.tbQueryStu.Margin = new System.Windows.Forms.Padding(4);
            this.tbQueryStu.Name = "tbQueryStu";
            this.tbQueryStu.Size = new System.Drawing.Size(417, 28);
            this.tbQueryStu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "请输入要查询的学号：";
            // 
            // QueryStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.btnQueryStu);
            this.Controls.Add(this.tbQueryStu);
            this.Controls.Add(this.label1);
            this.Name = "QueryStudent";
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.QueryStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.Button btnQueryStu;
        private System.Windows.Forms.TextBox tbQueryStu;
        private System.Windows.Forms.Label label1;
    }
}