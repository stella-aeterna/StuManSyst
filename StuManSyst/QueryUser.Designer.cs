namespace StuManSyst
{
    partial class QueryUser
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
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.btnUserQuery = new System.Windows.Forms.Button();
            this.teQueryUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUser
            // 
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Location = new System.Drawing.Point(27, 81);
            this.dgUser.Name = "dgUser";
            this.dgUser.RowHeadersWidth = 62;
            this.dgUser.RowTemplate.Height = 30;
            this.dgUser.Size = new System.Drawing.Size(542, 180);
            this.dgUser.TabIndex = 7;
            // 
            // btnUserQuery
            // 
            this.btnUserQuery.Location = new System.Drawing.Point(471, 27);
            this.btnUserQuery.Name = "btnUserQuery";
            this.btnUserQuery.Size = new System.Drawing.Size(98, 28);
            this.btnUserQuery.TabIndex = 6;
            this.btnUserQuery.Text = "查询";
            this.btnUserQuery.UseVisualStyleBackColor = true;
            this.btnUserQuery.Click += new System.EventHandler(this.btnUserQuery_Click);
            // 
            // teQueryUser
            // 
            this.teQueryUser.Location = new System.Drawing.Point(236, 27);
            this.teQueryUser.Name = "teQueryUser";
            this.teQueryUser.Size = new System.Drawing.Size(203, 28);
            this.teQueryUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入要查询的用户名：";
            // 
            // QueryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.btnUserQuery);
            this.Controls.Add(this.teQueryUser);
            this.Controls.Add(this.label1);
            this.Name = "QueryUser";
            this.Text = "用户查询";
            this.Load += new System.EventHandler(this.QueryUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.Button btnUserQuery;
        private System.Windows.Forms.TextBox teQueryUser;
        private System.Windows.Forms.Label label1;
    }
}