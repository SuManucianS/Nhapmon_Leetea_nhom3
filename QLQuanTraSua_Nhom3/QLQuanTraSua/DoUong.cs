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
    public partial class frmDoUong : Form
    {
        public frmDoUong()
        {
            InitializeComponent();
            loadCmbLoaiDoUong();
            // load listview data
            showListViewData();
        }


        void loadCmbLoaiDoUong() // loading combobox loại đồ uống
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection cnn = new SqlConnection(strCon);
            cnn.Open();
            var query = "sp_loadLoaiDoUong";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTb = new DataTable();
            adapter.Fill(dataTb);
            // chuẩn bị dữ liệu
            cmbLoaiDoUong.DataSource = dataTb;
            cmbLoaiDoUong.DisplayMember = "sTenLoaiDoUong";
            cmbLoaiDoUong.ValueMember = "PK_LoaiDoUong";
            cnn.Close();
        }

        private void LvDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDoUong.SelectedItems.Count == 0)
                return;
            ListViewItem lvItem = lvDoUong.SelectedItems[0];
            // lấy id để hiện thị combobox loại đồ uống
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection cnn = new SqlConnection(strCon);
            cnn.Open();
            var query = "sp_getIdLoaiDoUong";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ten", lvItem.SubItems[1].Text);

            cmbLoaiDoUong.SelectedValue = (int)cmd.ExecuteScalar();
            txtTendouong.Text = lvItem.SubItems[2].Text;
            txtDonGia.Text = lvItem.SubItems[3].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTendouong.Text) || String.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đồ uống !!!");
                return;
            }
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_addDoUong";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                // chuẩn bị dữ liệu
                string tenDoUong = txtTendouong.Text;
                double gia = double.Parse(txtDonGia.Text);
                int maLoai = int.Parse(cmbLoaiDoUong.SelectedValue.ToString());
                SqlParameter[] listParam =
                {
                    new SqlParameter("@ten", tenDoUong),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@fkLoai", maLoai)
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
            catch(Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show("Toang rồi ông giáo ạ !");
            }
        }

        void showListViewData(string key = "") // hiển thị dữ liệu lên listview
        {
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_viewDoUong";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@searchKey", key));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTb = new DataTable();
                adapter.Fill(dataTb);
                // đổ dữ liệu lên listview
                lvDoUong.Items.Clear();
                foreach (DataRow item in dataTb.Rows)
                {
                    ListViewItem lvItem = new ListViewItem(item[0].ToString());
                    lvItem.SubItems.Add(item[5].ToString());
                    lvItem.SubItems.Add(item[1].ToString());
                    string[] price = item[2].ToString().Split('.');
                    lvItem.SubItems.Add(price[0]);
                    lvDoUong.Items.Add(lvItem);
                }
                lvDoUong.Show();
            }
            catch(Exception ex)
            {
                string err = ex.Message;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtTimkiem.Text;
            showListViewData(key);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTendouong.Text) || String.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đồ uống !!!");
                return;
            }
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "sp_editDoUong";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                // chuẩn bị dữ liệu
                int ma = int.Parse(lvDoUong.SelectedItems[0].SubItems[0].Text);
                string tenDoUong = txtTendouong.Text;
                double gia = double.Parse(txtDonGia.Text);
                int maLoai = int.Parse(cmbLoaiDoUong.SelectedValue.ToString());
                SqlParameter[] listParam =
                {
                    new SqlParameter("@ma", ma),
                    new SqlParameter("@ten", tenDoUong),
                    new SqlParameter("@gia", gia),
                    new SqlParameter("@fkLoai", maLoai)
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
                    var query = "sp_deleteDoUong";
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
            catch(Exception ex)
            {
                string err = ex.Message;
            }
        }

        void resetForm()
        {
            txtDonGia.Text = "";
            txtTendouong.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
