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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoUong frmDoUong = new frmDoUong();
            frmDoUong.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QlyNguyenLieu frmQlNguyenLieu = new QlyNguyenLieu();
            frmQlNguyenLieu.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassWord frmDoiMk = new ChangePassWord();
            frmDoiMk.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(checkRule() == 1)
            {
                QuanLyTaiKhoan frmQLTK = new QuanLyTaiKhoan();
                frmQLTK.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này !!");
            }
        }

        int checkRule()
        {
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(strCon);
                cnn.Open();
                var query = "checkPermission";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", Session.Username);
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return -1;
            }
        }
    }
}
