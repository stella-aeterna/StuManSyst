namespace StuManSyst
{
    partial class DeleteStudent
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
            this.btnDeleStu = new System.Windows.Forms.Button();
            this.tbDeleStu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "学生照片:";
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(684, 71);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(179, 209);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 18;
            this.picPhoto.TabStop = false;
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(16, 71);
            this.dgStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.RowHeadersWidth = 62;
            this.dgStudent.RowTemplate.Height = 23;
            this.dgStudent.Size = new System.Drawing.Size(660, 209);
            this.dgStudent.TabIndex = 17;
            this.dgStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudent_CellClick);
            // 
            // btnDeleStu
            // 
            this.btnDeleStu.Location = new System.Drawing.Point(533, 29);
            this.btnDeleStu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleStu.Name = "btnDeleStu";
            this.btnDeleStu.Size = new System.Drawing.Size(112, 34);
            this.btnDeleStu.TabIndex = 16;
            this.btnDeleStu.Text = "删除";
            this.btnDeleStu.UseVisualStyleBackColor = true;
            this.btnDeleStu.Click += new System.EventHandler(this.btnDeleStu_Click);
            // 
            // tbDeleStu
            // 
            this.tbDeleStu.Location = new System.Drawing.Point(228, 32);
            this.tbDeleStu.Margin = new System.Windows.Forms.Padding(4);
            this.tbDeleStu.Name = "tbDeleStu";
            this.tbDeleStu.Size = new System.Drawing.Size(271, 28);
            this.tbDeleStu.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "请输入要删除的学号：";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.btnDeleStu);
            this.Controls.Add(this.tbDeleStu);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStudent";
            this.Text = "学生信息删除";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.Button btnDeleStu;
        private System.Windows.Forms.TextBox tbDeleStu;
        private System.Windows.Forms.Label label1;
    }
}