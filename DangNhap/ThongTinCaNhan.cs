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
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private bool AddEmployee()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ThemNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        p = new SqlParameter("@maNhanVien", TXB_manv.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@email", TXB_email.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@ho", TXB_ho.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@ten", TXB_ten.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@SDT", TXB_sdt.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@ngaySinh", DTP_ngaysinh.Value); 
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@gioiTinh", Rad_nam.Checked ? 1 : 0);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@queQuan", TXB_quequan.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@maDinhDanh", TXB_cccd.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@loaiNhanVien", TXB_loainv.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@tinhTrangHonNhan", TXB_honnhan.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@maSoBHXH", TXB_bhxh.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@daTungLamNV", CHB_tunglanv.Checked ? 1 : 0);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@ngayKyHDLD", DTP_ngaykyHDLD.Value);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@ngayHetHDLD", DTP_ngayhetHDLD.Value);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@dChiThuongTru", TXB_thuongtru.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@dChiTamTru", TXB_tamtru.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@tinhTrangHDLD", TXB_tinhtrangHDLD.Text);
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@maNhom", TXB_manhom.Text);
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private void BTN_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXB_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(TXB_email.Text))
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }
            if (string.IsNullOrEmpty(TXB_ho.Text))
            {
                MessageBox.Show("Vui lòng nhập họ");
                return;
            }
            if (string.IsNullOrEmpty(TXB_ten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            if (string.IsNullOrEmpty(TXB_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (!Rad_nam.Checked && !Rad_nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }
            if (string.IsNullOrEmpty(TXB_quequan.Text))
            {
                MessageBox.Show("Vui lòng nhập quê quán");
                return;
            }
            if (string.IsNullOrEmpty(TXB_cccd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã định danh");
                return;
            }
            if (string.IsNullOrEmpty(TXB_loainv.Text))
            {
                MessageBox.Show("Vui lòng nhập loại nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(TXB_honnhan.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng hôn nhân");
                return;
            }
            if (string.IsNullOrEmpty(TXB_bhxh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số bảo hiểm xã hội");
                return;
            }
            if (string.IsNullOrEmpty(TXB_thuongtru.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ thường trú");
                return;
            }
            // Địa chỉ tạm trú không cần check
            //if (string.IsNullOrEmpty(TXB_tamtru.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập địa chỉ tạm trú");
            //    return;
            //}
            if (string.IsNullOrEmpty(TXB_tinhtrangHDLD.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng hợp đồng lao động");
                return;
            }
            if (string.IsNullOrEmpty(TXB_manhom.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhóm");
                return;
            }
            if (AddEmployee())
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
