using QLQuanTraSua.MODEL;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if(checkValid())
            { 
                string constr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = null;
                // Kiểm tra trạng thái kết nối
                if (cnn == null)
                {
                    cnn = new SqlConnection(constr);
                }
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_dangnhap"; // Tên procedure
                cmd.Parameters.AddWithValue("@taikhoan",txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@matkhau",txtMatKhau.Text);
                cmd.Connection = cnn;
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd.HasRows)
                {
                    Session.Username = txtTaiKhoan.Text;
                    int maquyen = 1;
                    while (rd.Read())
                    {
                        maquyen = rd.GetInt32(4);
                        break;
                    }
                    rd.Close();
                    if (maquyen == 1)
                    {
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.ShowDialog();
                        this.Close();
                    }
               
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
        }
        private bool checkValid()
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (taikhoan.Trim().Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return false;
            }
            else if (matkhau.Trim().Length <= 0) 
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return false;
            }
            else if (matkhau.Trim().Length < 6)
            {
                MessageBox.Show("Mật khẩu phải >= 6 ký tự");
                return false;
            }            
            else
            {
                return true;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn có muốn thoát ?", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rt == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

		
	}
}
