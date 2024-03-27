using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class DangNhap : Form
    {
        //
        int mov;
        int movX;
        int movY;
        public DangNhap()
        {
            InitializeComponent();
        }
        private void BT_DangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_TKNhanVien;Integrated Security=True;TrustServerCertificate=True");
            try
            {
                conn.Open();
                string tk = TB_TaiKhoan.Text;
                string mk = TB_MatKhau.Text;
                string sql = "select * from Taikhoan where maNguoiDung = '" + tk + "' and matKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Home formTrangChu = new Home();
                    formTrangChu.Show();
                }
                else
                {
                    LB_error.Text = "Sai tài khoản hoặc mật khẩu";
                }
            }

            catch (Exception)
            {
                throw new Exception("Connection Error");
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
    }
}
