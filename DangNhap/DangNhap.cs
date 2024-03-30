using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DangNhap.Model;
using Microsoft.VisualBasic.ApplicationServices;

namespace DangNhap
{
    public partial class DangNhap : Form
    {
        public static Account currentAccount;
        int mov;
        int movX;
        int movY;
        public DangNhap()
        {
            InitializeComponent();
        }
        private void BT_DangNhap_Click(object sender, EventArgs e)
        {
            string userId = TB_TaiKhoan.Text;
            string pwd = TB_MatKhau.Text;

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Vui lòng nhập mã người dùng");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            string password = "";
            string employeeId = "";

            string query = $"select * from TaiKhoan where maNguoiDung = '{userId}'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        password = reader["matKhau"].ToString();
                        employeeId = reader["maNhanVien"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại");
                    return;
                }
            }

            if (password.Equals(pwd))
            {
                string level = phanQuyen(userId);
                currentAccount = new Account(userId, pwd, employeeId, level);
                MessageBox.Show("Đăng nhập thành công");
                Home formTrangChu = new Home();
                formTrangChu.ShowDialog();
            }
            else
            {
                LB_error.Text = "Mật khẩu hoặc tên đăng nhập không đúng";
            }
        }

        private void VB_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (VB_HienMatKhau.Checked)
            {
                TB_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                TB_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void DangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void DangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private static string phanQuyen(string userID)
        {
            string level = "";
            string[] temp = userID.Split('.');
            if (!string.IsNullOrEmpty(temp[0]))
            {
                string loaiNV = temp[0].Substring(0,2);
                switch (loaiNV) {
                    case "GD":
                        level = "CEO";
                        break;
                    case "DV":
                        level = "DV";
                        break;
                    case "TC":
                        level = "TaiChinh";
                        break;
                    case "VS":
                        level = "VeSinh";
                        break;
                    case "AN":
                        level = "AnNinh";
                        break;
                    case "KT":
                        level = "KyThuat";
                        break;
                    case "XD":
                        level = "XayDung";
                        break;
                    default:
                        break;
                }
            }
            return level;
        }
    }
}
