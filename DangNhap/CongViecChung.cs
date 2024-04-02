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
    public partial class CongViecChung : Form
    {
        string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TasMana;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public CongViecChung()
        {
            InitializeComponent();
        }

        private void BTN_themcongviec_Click(object sender, EventArgs e)
        {
            ThemCongViecNhanVien tcv = new ThemCongViecNhanVien();
            tcv.Show();
        }

        private void BTN_chitietcongviec_Click(object sender, EventArgs e)
        {
            ChiTietCongViec ctcv = new ChiTietCongViec();
            ctcv.Show();
        }
        private void CV_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);
            dt = new DataTable();
            con.Open();
            // Sử dụng tham số @TuNgay và @DenNgay trong câu truy vấn SQL
            cmd = new SqlCommand("SP_LayCV", con);

            // Thêm các tham số vào câu truy vấn SQL

            adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            DGV_hienthicongviec.DataSource = dt;
            con.Close();
        }
        private void BTN_in_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã nhân viên");
            DataColumn col2 = new DataColumn("TenMon");
            DataColumn col3 = new DataColumn("TenTruong");
            DataColumn col4 = new DataColumn("Luong1CaDay");
            DataColumn col5 = new DataColumn("SoCaDay");
            DataColumn col6 = new DataColumn("LuongTongTheoCa");
            DataColumn col7 = new DataColumn("LuongTong");
            DataColumn col8 = new DataColumn("LuongTong");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);

            int temp = 0;
            foreach (DataGridViewRow dtgvRow in DGV_hienthicongviec.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;
                dtRow[4] = dtgvRow.Cells[4].Value;
                dtRow[5] = dtgvRow.Cells[5].Value;
                dtRow[6] = dtgvRow.Cells[5].Value;
                dtRow[7] = dtgvRow.Cells[5].Value;
                if (temp == 0)
                {
                    dtRow[8] = dtgvRow.Cells[8].Value;
                    temp += 1;
                }
                dataTable.Rows.Add(dtRow);
            }
            Export export = new Export();
            export.ToExcel(dataTable, "Luong", "BẢN TÍNH LƯƠNG");
        }


    }
}
