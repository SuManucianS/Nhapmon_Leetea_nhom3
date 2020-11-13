namespace QLQuanTraSua
{
    partial class frmDangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(404, 286);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tài khoản";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(404, 341);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật khẩu";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaiKhoan.Location = new System.Drawing.Point(407, 306);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(216, 23);
			this.txtTaiKhoan.TabIndex = 3;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(407, 361);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(216, 23);
			this.txtMatKhau.TabIndex = 4;
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.Color.White;
			this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
			this.btnDangNhap.Location = new System.Drawing.Point(407, 410);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(90, 47);
			this.btnDangNhap.TabIndex = 5;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.White;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.Location = new System.Drawing.Point(536, 410);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(87, 47);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(647, 488);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}

