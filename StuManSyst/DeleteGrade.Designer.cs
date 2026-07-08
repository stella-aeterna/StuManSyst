namespace StuManSyst
{
    partial class DeleteGrade
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
            this.dgScore = new System.Windows.Forms.DataGridView();
            this.btnDeleScore = new System.Windows.Forms.Button();
            this.tbDeleCID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDeleSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgScore
            // 
            this.dgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScore.Location = new System.Drawing.Point(24, 102);
            this.dgScore.Margin = new System.Windows.Forms.Padding(4);
            this.dgScore.Name = "dgScore";
            this.dgScore.RowHeadersWidth = 62;
            this.dgScore.RowTemplate.Height = 23;
            this.dgScore.Size = new System.Drawing.Size(742, 225);
            this.dgScore.TabIndex = 21;
            // 
            // btnDeleScore
            // 
            this.btnDeleScore.Location = new System.Drawing.Point(652, 20);
            this.btnDeleScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleScore.Name = "btnDeleScore";
            this.btnDeleScore.Size = new System.Drawing.Size(114, 74);
            this.btnDeleScore.TabIndex = 20;
            this.btnDeleScore.Text = "删除";
            this.btnDeleScore.UseVisualStyleBackColor = true;
            this.btnDeleScore.Click += new System.EventHandler(this.btnDeleScore_Click);
            // 
            // tbDeleCID
            // 
            this.tbDeleCID.Location = new System.Drawing.Point(261, 67);
            this.tbDeleCID.Margin = new System.Windows.Forms.Padding(4);
            this.tbDeleCID.Name = "tbDeleCID";
            this.tbDeleCID.Size = new System.Drawing.Size(326, 28);
            this.tbDeleCID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "请输入要删除的课程号：";
            // 
            // tbDeleSID
            // 
            this.tbDeleSID.Location = new System.Drawing.Point(261, 21);
            this.tbDeleSID.Margin = new System.Windows.Forms.Padding(4);
            this.tbDeleSID.Name = "tbDeleSID";
            this.tbDeleSID.Size = new System.Drawing.Size(326, 28);
            this.tbDeleSID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "请输入要删除的学号：";
            // 
            // DeleteGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 353);
            this.Controls.Add(this.dgScore);
            this.Controls.Add(this.btnDeleScore);
            this.Controls.Add(this.tbDeleCID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDeleSID);
            this.Controls.Add(this.label1);
            this.Name = "DeleteGrade";
            this.Text = "成绩删除";
            this.Load += new System.EventHandler(this.DeleteGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgScore;
        private System.Windows.Forms.Button btnDeleScore;
        private System.Windows.Forms.TextBox tbDeleCID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDeleSID;
        private System.Windows.Forms.Label label1;
    }
}