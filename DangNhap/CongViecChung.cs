using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


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
        
        private void CongViecChung_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);
            dt = new DataTable();
            con.Open();

            cmd = new SqlCommand("SP_LayCV", con);

            adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            DGV_hienthicongviec.DataSource = dt;
            DGV_hienthicongviec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }


        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            if (DGV_hienthicongviec.Rows.Count>0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf|*.pdf)";
                save.FileName = "CongViec";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(save.FileName))
                    { 
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pt = new PdfPTable(DGV_hienthicongviec.ColumnCount);
                            pt.DefaultCell.Padding = 2;
                            pt.WidthPercentage = 100;
                            pt.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in DGV_hienthicongviec.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pt.AddCell(pCell);
                            }

                            foreach (DataGridViewRow viewRow in DGV_hienthicongviec.Rows)
                            {
                                foreach (DataGridViewCell dCell in viewRow.Cells)
                                {
                                    pt.AddCell(dCell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create) )
                            {
                                var pgSize = new iTextSharp.text.Rectangle(60, 120);
                                var doc = new iTextSharp.text.Document(pgSize, 8f, 16f, 16f, 8f);
                                doc.Open();
                                doc.Add(pt);
                                doc.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Successful", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "Info");
            }
        }

        private void BTN_excel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã nhân viên");
            DataColumn col2 = new DataColumn("Họ và tên");
            DataColumn col3 = new DataColumn("Nội dung");
            DataColumn col4 = new DataColumn("Mã căn hộ");
            DataColumn col5 = new DataColumn("Thời hạn");
            DataColumn col6 = new DataColumn("Ngày hoàn thành");
            DataColumn col7 = new DataColumn("Trạng thái");
            DataColumn col8 = new DataColumn("Ghi chú");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);

            foreach (DataGridViewRow dtgvRow in DGV_hienthicongviec.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;
                dtRow[4] = dtgvRow.Cells[4].Value;
                dtRow[5] = dtgvRow.Cells[5].Value;
                dtRow[6] = dtgvRow.Cells[6].Value;
                dtRow[7] = dtgvRow.Cells[7].Value;

                dataTable.Rows.Add(dtRow);
            }
            Export export = new Export();
            export.ToExcel(dataTable, "Cong_viec", "CÔNG VIỆC CHUNG");
        }
    }
}
