namespace QLQuanTraSua
{
    partial class frmDoUong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoUong));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbLoaiDoUong = new System.Windows.Forms.ComboBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtTendouong = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTimkiem = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.lvDoUong = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(369, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "ĐỒ UỐNG";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cmbLoaiDoUong);
			this.groupBox1.Controls.Add(this.txtDonGia);
			this.groupBox1.Controls.Add(this.txtTendouong);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(55, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 175);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin đồ uống";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// cmbLoaiDoUong
			// 
			this.cmbLoaiDoUong.FormattingEnabled = true;
			this.cmbLoaiDoUong.Location = new System.Drawing.Point(126, 28);
			this.cmbLoaiDoUong.Margin = new System.Windows.Forms.Padding(2);
			this.cmbLoaiDoUong.Name = "cmbLoaiDoUong";
			this.cmbLoaiDoUong.Size = new System.Drawing.Size(200, 23);
			this.cmbLoaiDoUong.TabIndex = 8;
			// 
			// txtDonGia
			// 
			this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonGia.Location = new System.Drawing.Point(126, 98);
			this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(200, 23);
			this.txtDonGia.TabIndex = 7;
			// 
			// txtTendouong
			// 
			this.txtTendouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTendouong.Location = new System.Drawing.Point(126, 62);
			this.txtTendouong.Margin = new System.Windows.Forms.Padding(4);
			this.txtTendouong.Name = "txtTendouong";
			this.txtTendouong.Size = new System.Drawing.Size(200, 23);
			this.txtTendouong.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Đơn Giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tên đồ uống";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Loại đồ uống";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.txtTimkiem);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.btnSearch);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(442, 84);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(365, 175);
			this.groupBox2.TabIndex = 3;
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
			this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "Tìm kiếm";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(280, 106);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 27);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Text = "Tìm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(105, 41);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 36);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(16, 41);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 36);
			this.btnThem.TabIndex = 8;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// lvDoUong
			// 
			this.lvDoUong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvDoUong.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvDoUong.FullRowSelect = true;
			this.lvDoUong.GridLines = true;
			this.lvDoUong.HideSelection = false;
			this.lvDoUong.Location = new System.Drawing.Point(0, 281);
			this.lvDoUong.MultiSelect = false;
			this.lvDoUong.Name = "lvDoUong";
			this.lvDoUong.Size = new System.Drawing.Size(872, 255);
			this.lvDoUong.TabIndex = 4;
			this.lvDoUong.UseCompatibleStateImageBehavior = false;
			this.lvDoUong.View = System.Windows.Forms.View.Details;
			this.lvDoUong.SelectedIndexChanged += new System.EventHandler(this.LvDoUong_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã Code";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Loại đồ uống";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên đồ uống";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Đơn Giá";
			this.columnHeader4.Width = 545;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(151, 9);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(68, 69);
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(55, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 69);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(252, 9);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(68, 69);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// frmDoUong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(872, 536);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lvDoUong);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "frmDoUong";
			this.Text = "DoUong";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTendouong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ListView lvDoUong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbLoaiDoUong;
        private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}