namespace QLQuanTraSua
{
    partial class MainMenu
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChangePassword = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnAccount = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btnChangePassword);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.btnAccount);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(283, 225);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(510, 333);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu";
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChangePassword.ForeColor = System.Drawing.Color.White;
			this.btnChangePassword.Location = new System.Drawing.Point(276, 152);
			this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new System.Drawing.Size(117, 87);
			this.btnChangePassword.TabIndex = 1;
			this.btnChangePassword.Text = "Đổi Mật Khẩu";
			this.btnChangePassword.UseVisualStyleBackColor = false;
			this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.NavajoWhite;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(276, 46);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 87);
			this.button2.TabIndex = 0;
			this.button2.Text = "Nguyên Liệu";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnAccount
			// 
			this.btnAccount.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccount.ForeColor = System.Drawing.Color.White;
			this.btnAccount.Location = new System.Drawing.Point(122, 152);
			this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(124, 87);
			this.btnAccount.TabIndex = 0;
			this.btnAccount.Text = "Quản lý tài khoản";
			this.btnAccount.UseVisualStyleBackColor = false;
			this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.NavajoWhite;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(122, 46);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 87);
			this.button1.TabIndex = 0;
			this.button1.Text = "Đồ Uống";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(709, 507);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAccount;
    }
}