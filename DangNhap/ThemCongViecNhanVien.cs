using DTO;
using System;
using System.Collections;
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
    public partial class ThemCongViecNhanVien : Form
    {
        //
        public List<Division> listMaBP = new List<Division>();
        int mov;
        int movX;
        int movY;
        public ThemCongViecNhanVien()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_hienthithemcongviec.Controls.Add(childForm);
            PN_hienthithemcongviec.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            BTN_nhanvien.BackColor = Color.Silver;
            BTN_nhanvien.ForeColor = Color.Black;
            BTN_nhom.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhom.ForeColor = Color.White;
            BTN_phongban.BackColor = Color.FromArgb(40, 40, 40);
            BTN_phongban.ForeColor = Color.White;
        }

        private void BTN_phongban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemCongViecPhongBan());
            BTN_phongban.BackColor = Color.Silver;
            BTN_phongban.ForeColor = Color.Black;
            BTN_nhanvien.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhanvien.ForeColor = Color.White;
            BTN_nhom.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhom.ForeColor = Color.White;
        }

        private void BTN_nhom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemCongViecNhom());
            BTN_nhom.BackColor = Color.Silver;
            BTN_nhom.ForeColor = Color.Black;
            BTN_phongban.BackColor = Color.FromArgb(40, 40, 40);
            BTN_phongban.ForeColor = Color.White;
            BTN_nhanvien.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhanvien.ForeColor = Color.White;
        }

        private void ThemCongViecNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ThemCongViecNhanVien_MousMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void ThemCongViecNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void readPhongBan()
        {
            CBB_phongban.Enabled = true;
            CBB_phongban.Items.Clear();
            string query = $"Select * from PhongBan";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maBoPhan = reader["maBoPhan"].ToString();
                        string tenBP = reader["tenPB"].ToString();
                        string sdt = reader["sdt"].ToString();
                        string email = reader["email"].ToString();
                        Division boPhan = new Division(maBoPhan, tenBP, sdt, email);
                        listMaBP.Add(boPhan);
                        CBB_phongban.Items.Add(maBoPhan + "-" + tenBP);
                    }
                    reader.Close();
                    cmd.Dispose();
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại");
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void readNhom()
        {
            CBB_nhom.Enabled = true;
            CBB_nhom.Items.Clear();
            string maBoPhan = CBB_phongban.SelectedItem.ToString().Split('-')[0];
            string query = $"Select * from Nhom N where N.maBoPhan = '{maBoPhan}'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string nhom = reader["maNhom"].ToString();
                        CBB_nhom.Items.Add(nhom);
                    }
                    reader.Close();
                    cmd.Dispose();
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại");
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void readNV()
        {
            CBB_manhanvien.Enabled = true;
            CBB_manhanvien.Items.Clear();   
            string query = $"Select * from NhanVien NV where NV.maNhom = '" + CBB_nhom.SelectedItem.ToString() +"'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maNV = reader["maNhanVien"].ToString();
                        string ho = reader["ho"].ToString();
                        string ten = reader["ten"].ToString();
                        string NV = maNV + "_" + ho + " " + ten; 
                        CBB_manhanvien.Items.Add(NV);
                    }
                    reader.Close();
                    cmd.Dispose();
                }
                catch
                {
                    MessageBox.Show("Kết nối thất bại");
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void ThemCongViecNhanVien_Load(object sender, EventArgs e)
        {
            readPhongBan();
        }


        private void CBB_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBB_nhom.SelectedIndex != -1)
            {
                readNV();
            }
        }

        private void CBB_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBB_phongban.SelectedIndex != -1)
            {
                readNhom();
            }
        }

        private void CBB_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBB_manhanvien.SelectedIndex != -1) 
            {
                TXB_noidung.Enabled = true;
                TXB_macanho.Enabled = true;
                TXB_MaCongViec.Enabled = true;
            }
        }

        private void CB_thoihan_CheckStateChanged(object sender, EventArgs e)
        {
            if (CB_thoihan.Checked)
            {
                DTP_gio.Enabled = true;
                DTP_ngay.Enabled = true;
            }
            else
            {
                DTP_gio.Enabled = false;
                DTP_ngay.Enabled = false;
            }
        }

        private void CBB_phongban_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBB_phongban.SelectedIndex != -1)
            {
                CBB_nhom.SelectedIndex = -1;
                CBB_manhanvien.SelectedIndex = -1;
                readNhom();
            }
        }

        private void CBB_nhom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBB_nhom.SelectedIndex != -1)
            {
                CBB_manhanvien.SelectedIndex = -1;
                readNV();
            }
        }

        private bool saveCongViec()
        {
            string query = @"INSERT INTO CongViec VALUES (@maCongViec, @noiDung, @thoiHan, @trangThai); INSERT INTO CongViec_NhanVien (maNhanVien, maCongViec) VALUES (@maNhanVien, @maCongViec); INSERT INTO YeuCau (maCongViec, maCanHo) VALUES (@maCongViec, @maCanHo);";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    string thoiHan = DTP_ngay.Value.ToString("yyyy-MM-dd") + " " + DTP_gio.Text.Split(' ')[0].ToString();
                    string maNV = CBB_manhanvien.SelectedItem.ToString().Split('_')[0].ToString();
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maCongViec", TXB_MaCongViec.Text);
                        cmd.Parameters.AddWithValue("@noiDung", TXB_noidung.Text);
                        cmd.Parameters.AddWithValue("@thoiHan", thoiHan);
                        cmd.Parameters.AddWithValue("@trangThai", "Chưa bắt đầu");
                        cmd.Parameters.AddWithValue("@maNhanVien", maNV);
                        cmd.Parameters.AddWithValue("@maCanHo", TXB_macanho.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if (TXB_MaCongViec != null & TXB_macanho != null & TXB_noidung != null)
            {
                if (saveCongViec()) 
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
