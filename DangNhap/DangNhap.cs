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
                    MessageBox.Show("Login successfully");
                    Home formTrangChu = new Home();
                    formTrangChu.Show();
                }
                else
                {
                    MessageBox.Show("Failed to login");
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
    }
}
