namespace StuManSyst
{
    partial class QueryGrade
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
            this.btnQuScore = new System.Windows.Forms.Button();
            this.tbQuCoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuStuId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgScore
            // 
            this.dgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScore.Location = new System.Drawing.Point(22, 111);
            this.dgScore.Margin = new System.Windows.Forms.Padding(4);
            this.dgScore.Name = "dgScore";
            this.dgScore.RowHeadersWidth = 62;
            this.dgScore.RowTemplate.Height = 23;
            this.dgScore.Size = new System.Drawing.Size(742, 225);
            this.dgScore.TabIndex = 27;
            // 
            // btnQuScore
            // 
            this.btnQuScore.Location = new System.Drawing.Point(650, 29);
            this.btnQuScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuScore.Name = "btnQuScore";
            this.btnQuScore.Size = new System.Drawing.Size(114, 74);
            this.btnQuScore.TabIndex = 26;
            this.btnQuScore.Text = "查询";
            this.btnQuScore.UseVisualStyleBackColor = true;
            this.btnQuScore.Click += new System.EventHandler(this.btnQuScore_Click);
            // 
            // tbQuCoId
            // 
            this.tbQuCoId.Location = new System.Drawing.Point(226, 75);
            this.tbQuCoId.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuCoId.Name = "tbQuCoId";
            this.tbQuCoId.Size = new System.Drawing.Size(380, 28);
            this.tbQuCoId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "请 输 入 课 程 号：";
            // 
            // tbQuStuId
            // 
            this.tbQuStuId.Location = new System.Drawing.Point(226, 29);
            this.tbQuStuId.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuStuId.Name = "tbQuStuId";
            this.tbQuStuId.Size = new System.Drawing.Size(380, 28);
            this.tbQuStuId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "请 输 入 学 号：";
            // 
            // QueryGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 357);
            this.Controls.Add(this.dgScore);
            this.Controls.Add(this.btnQuScore);
            this.Controls.Add(this.tbQuCoId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbQuStuId);
            this.Controls.Add(this.label1);
            this.Name = "QueryGrade";
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.QueryGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgScore;
        private System.Windows.Forms.Button btnQuScore;
        private System.Windows.Forms.TextBox tbQuCoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuStuId;
        private System.Windows.Forms.Label label1;
    }
}