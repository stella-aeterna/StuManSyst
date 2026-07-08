namespace StuManSyst
{
    partial class DeleteUser
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
            this.teDeleteUser = new System.Windows.Forms.TextBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.dgUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要删除的用户名：";
            // 
            // teDeleteUser
            // 
            this.teDeleteUser.Location = new System.Drawing.Point(236, 36);
            this.teDeleteUser.Name = "teDeleteUser";
            this.teDeleteUser.Size = new System.Drawing.Size(203, 28);
            this.teDeleteUser.TabIndex = 1;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(471, 36);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(98, 28);
            this.btnUserDelete.TabIndex = 2;
            this.btnUserDelete.Text = "删除";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // dgUser
            // 
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Location = new System.Drawing.Point(27, 90);
            this.dgUser.Name = "dgUser";
            this.dgUser.RowHeadersWidth = 62;
            this.dgUser.RowTemplate.Height = 30;
            this.dgUser.Size = new System.Drawing.Size(542, 180);
            this.dgUser.TabIndex = 3;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 310);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.teDeleteUser);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUser";
            this.Text = "删除用户";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teDeleteUser;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.DataGridView dgUser;
    }
}