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
    public partial class ChangePassWord : Form
    {
        public ChangePassWord()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = Session.Username;
            string oldPass = txtOLdPass.Text;
            string newPass = txtPassword.Text;
            string confirm = txtPassword.Text;
            if(checkOldPassword(username, oldPass))
            {
                if(confirmPassword())
                {
                    if(newPass.Length >= 6)
                    {
                        changePassword(username, newPass);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải >= 6 ký tự");
                    }
                }
                else
                {
                    MessageBox.Show("Hai mật khẩu mới không trung khớp");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");
            }
        }

        bool checkOldPassword(string username, string password)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection cnn = new SqlConnection(constr);
                cnn.Open();
                var query = "sp_checkOldPassword";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int result = (int)cmd.ExecuteScalar();
                cnn.Close();

                if (result > 0)
                    return true;
                else return false;
            }
            catch(Exception ex)
            {
                string err = ex.Message;
                return false;
            }
        }

        bool confirmPassword()
        {
            if (txtPassword.Text.Equals(txtConfirm.Text))
            {
                return true;
            }
            else return false;
        }

        void changePassword(string username, string password)
        {
            string constr = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            var query = "sp_changePassword";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@newpass", password);
            int result = (int)cmd.ExecuteNonQuery();
            cnn.Close();
            if(result > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
