namespace QLQuanTraSua
{
    partial class QuanLyTaiKhoan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTimkiem = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbRule = new System.Windows.Forms.ComboBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lvTaiKhoan = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTimkiem);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.btnSearch);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(396, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(365, 175);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tác vụ";
			// 
			// txtTimkiem
			// 
			this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimkiem.Location = new System.Drawing.Point(70, 108);
			this.txtTimkiem.Name = "txtTimkiem";
			this.txtTimkiem.Size = new System.Drawing.Size(205, 23);
			this.txtTimkiem.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "Tìm kiếm";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(280, 73);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 60);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Text = "Tìm";
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.White;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
			this.btnSua.Location = new System.Drawing.Point(105, 41);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(81, 61);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.White;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.Location = new System.Drawing.Point(9, 41);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(90, 61);
			this.btnThem.TabIndex = 8;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbRule);
			this.groupBox1.Controls.Add(this.txtMatKhau);
			this.groupBox1.Controls.Add(this.txtTenDangNhap);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(9, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 175);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tài khoản";
			// 
			// cmbRule
			// 
			this.cmbRule.FormattingEnabled = true;
			this.cmbRule.Location = new System.Drawing.Point(126, 28);
			this.cmbRule.Margin = new System.Windows.Forms.Padding(2);
			this.cmbRule.Name = "cmbRule";
			this.cmbRule.Size = new System.Drawing.Size(200, 23);
			this.cmbRule.TabIndex = 8;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatKhau.Location = new System.Drawing.Point(126, 98);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(200, 23);
			this.txtMatKhau.TabIndex = 7;
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenDangNhap.Location = new System.Drawing.Point(126, 62);
			this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new System.Drawing.Size(200, 23);
			this.txtTenDangNhap.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Mật khẩu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Loại tài khoản";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(327, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 26);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tài Khoản";
			// 
			// lvTaiKhoan
			// 
			this.lvTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvTaiKhoan.FullRowSelect = true;
			this.lvTaiKhoan.GridLines = true;
			this.lvTaiKhoan.HideSelection = false;
			this.lvTaiKhoan.Location = new System.Drawing.Point(0, 268);
			this.lvTaiKhoan.MultiSelect = false;
			this.lvTaiKhoan.Name = "lvTaiKhoan";
			this.lvTaiKhoan.Size = new System.Drawing.Size(773, 255);
			this.lvTaiKhoan.TabIndex = 8;
			this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
			this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
			this.lvTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lvTaiKhoan_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã Code";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Loại TK";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên đăng nhập";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Mật khẩu";
			this.columnHeader4.Width = 545;
			// 
			// QuanLyTaiKhoan
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(773, 523);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvTaiKhoan);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "QuanLyTaiKhoan";
			this.Text = "QuanLyTaiKhoan";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRule;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvTaiKhoan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
    }
}