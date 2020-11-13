using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanTraSua
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            loadCmbRule();
            showListViewData();
        }

        void loadCmbRule() // loading combobox loại quyền
        { 
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection cnn = new SqlConnection(strCon);
            cnn.Open();
            var query = "sp_loadCmbRule";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTb = new DataTable();
            adapter.Fill(dataTb);
            // chuẩn bị dữ liệu
            cmbRule.DataSource = dataTb;
            cmbRule.DisplayMember = "sTenQuyen";
            cmbRule.ValueMember = "PK_Quyen";
            cnn.Close();
        }

        void showListViewData(string key = "") // hiển thị dữ liệu lên listview
        {
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_loadAccountData";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@key", key));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTb = new DataTable();
                adapter.Fill(dataTb);
                // đổ dữ liệu lên listview
                lvTaiKhoan.Items.Clear();
                foreach (DataRow item in dataTb.Rows)
                {
                    ListViewItem lvItem = new ListViewItem(item[0].ToString());
                    lvItem.SubItems.Add(item[6].ToString());
                    lvItem.SubItems.Add(item[1].ToString());
                    lvItem.SubItems.Add(item[2].ToString());
                    lvTaiKhoan.Items.Add(lvItem);
                }
                lvTaiKhoan.Show();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản !!!");
                return;
            }
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_addAcount";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                // chuẩn bị dữ liệu
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                int maQuyen = int.Parse(cmbRule.SelectedValue.ToString());
                SqlParameter[] listParam =
                {
                    new SqlParameter("@username", tenDangNhap),
                    new SqlParameter("@password", matKhau),
                    new SqlParameter("@fkquyen", maQuyen)
                };
                cmd.Parameters.AddRange(listParam);
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
                if (result > 0)
                {
                    showListViewData();
                    MessageBox.Show("Thêm dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show("Toang rồi ông giáo ạ !");
                }
                resetForm();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show("Toang rồi ông giáo ạ !");
            }
        }

        void resetForm()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
                return;
            ListViewItem lvItem = lvTaiKhoan.SelectedItems[0];
            // lấy id để hiện thị combobox loại đồ uống
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection cnn = new SqlConnection(strCon);
            cnn.Open();
            var query = "sp_getIdLoaiTK";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", lvItem.SubItems[1].Text);

            cmbRule.SelectedValue = (int)cmd.ExecuteScalar();
            txtTenDangNhap.Text = lvItem.SubItems[2].Text;
            txtMatKhau.Text = lvItem.SubItems[3].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenDangNhap.Text) || String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản !!!");
                return;
            }
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_editTaiKhoan";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                // chuẩn bị dữ liệu
                int ma = int.Parse(lvTaiKhoan.SelectedItems[0].SubItems[0].Text);
                string tenTK = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                int rule = int.Parse(cmbRule.SelectedValue.ToString());
                SqlParameter[] listParam =
                {
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@username", tenTK),
                    new SqlParameter("@password", mk),
                    new SqlParameter("@fkquyen", rule)
                };
                cmd.Parameters.AddRange(listParam);
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
                if (result > 0)
                {
                    showListViewData();
                    MessageBox.Show("cập nhật dữ liệu thành công");
                }
                else
                {
                    MessageBox.Show("Toang rồi ông giáo ạ !");
                }
                resetForm();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show("Toang rồi ông giáo ạ !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn chắc muốn xóa chứ ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                    SqlConnection cnn = new SqlConnection(strCon);
                    cnn.Open();
                    var query = "sp_deleteAccount";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // chuẩn bị dữ liệu
                    int ma = int.Parse(lvTaiKhoan.SelectedItems[0].SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    int result = cmd.ExecuteNonQuery();
                    cnn.Close();
                    if (result > 0)
                    {
                        showListViewData();
                        MessageBox.Show("xóa dữ liệu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Toang rồi ông giáo ạ !");
                    }
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
                resetForm();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtTimkiem.Text;
            showListViewData(key);
        }


    }
}
