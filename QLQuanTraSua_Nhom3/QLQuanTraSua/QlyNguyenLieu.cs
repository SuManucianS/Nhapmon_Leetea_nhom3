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
    public partial class QlyNguyenLieu : Form
    {
        public QlyNguyenLieu()
        {
            InitializeComponent();
            showListViewData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenNguyenLieu.Text) || String.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đồ uống !!!");
                return;
            }
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_addNguyenLieu";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                // chuẩn bị dữ liệu
                string tenNguyenLieu = txtTenNguyenLieu.Text;
                string dvt = txtDonViTinh.Text;
                SqlParameter[] listParam =
                {
                    new SqlParameter("@ten", tenNguyenLieu),
                    new SqlParameter("@dvt", dvt)
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
            txtDonViTinh.Text = "";
            txtTenNguyenLieu.Text = "";
        }

        void showListViewData(string key = "") // hiển thị dữ liệu lên listview
        {
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_viewNguyenLieu";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@key", key));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTb = new DataTable();
                adapter.Fill(dataTb);
                // đổ dữ liệu lên listview
                lvDoUong.Items.Clear();
                foreach (DataRow item in dataTb.Rows)
                {
                    ListViewItem lvItem = new ListViewItem(item[0].ToString());
                    lvItem.SubItems.Add(item[1].ToString());
                    lvItem.SubItems.Add(item[2].ToString());
                    lvDoUong.Items.Add(lvItem);
                }
                lvDoUong.Show();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
        }

        private void lvDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDoUong.SelectedItems.Count == 0)
                return;

            ListViewItem lvItem = lvDoUong.SelectedItems[0];
            txtTenNguyenLieu.Text = lvItem.SubItems[1].Text;
            txtDonViTinh.Text = lvItem.SubItems[2].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenNguyenLieu.Text) || String.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đồ uống !!!");
                return;
            }
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_editNguyenLieu";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                // chuẩn bị dữ liệu
                int ma = int.Parse(lvDoUong.SelectedItems[0].SubItems[0].Text);
                string tenNl = txtTenNguyenLieu.Text;
                string dvt = txtDonViTinh.Text;
                SqlParameter[] listParam =
                {
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", tenNl),
                    new SqlParameter("@dvt", dvt)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtTimkiem.Text;
            showListViewData(key);
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
                    var query = "sp_deleteNguyenLieu";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // chuẩn bị dữ liệu
                    int ma = int.Parse(lvDoUong.SelectedItems[0].SubItems[0].Text);
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
    }
}
