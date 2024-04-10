using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;
using Syncfusion.Grouping;
using Syncfusion.Licensing;



namespace DangNhap
{
    public partial class CongViecChung : Form
    {
        string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TasMana;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        DataSet dataSet;
        public CongViecChung()
        {
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCekx3Qnxbf1x0ZFREalxWTndfUiweQnxTdEFjXX5ecHRVQWFcWUN+WA==");
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
            //DGV_hienthicongviec.DataSource = dt;
            //DGV_hienthicongviec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

            // Gán DataTable làm nguồn dữ liệu cho GridGroupingControl
            GGC_hienthicongviec.DataSource = dt;
            GGC_hienthicongviec.TopLevelGroupOptions.ShowFilterBar = true;

            // Tạo đối tượng GridColumnDescriptorCollection để quản lý các cột
            GridColumnDescriptorCollection columns = GGC_hienthicongviec.TableDescriptor.Columns;
            foreach (GridColumnDescriptor column in columns)
            {
                column.AllowFilter = true;
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_hienthicongviec);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_hienthicongviec);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
            

            if (!DangNhap.currentAccount.Level.Equals("CEO"))
            {
                BTN_themcongviec.Enabled = false;
                BTN_themcongviec.Visible = false;
            }
        }


        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            if (GGC_hienthicongviec.Table.Records.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "CongViec.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
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
                            Export export = new Export();
                            export.ToPDF(GGC_hienthicongviec, save.FileName);

                            MessageBox.Show("Successful", "Info");
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

            foreach (Record record in GGC_hienthicongviec.Table.Records)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = record.GetValue("Mã nhân viên");
                dtRow[1] = record.GetValue("Họ và tên");
                dtRow[2] = record.GetValue("Nội dung");
                dtRow[3] = record.GetValue("Mã căn hộ");
                dtRow[4] = record.GetValue("Thời hạn");
                dtRow[5] = record.GetValue("Ngày hoàn thành");
                dtRow[6] = record.GetValue("Trạng thái");
                dtRow[7] = record.GetValue("Ghi chú");

                dataTable.Rows.Add(dtRow);
            }
            Export export = new Export();
            export.ToExcel(dataTable, "Cong_viec", "CÔNG VIỆC CHUNG");
        }

        private void BTN_in_Click(object sender, EventArgs e)
        {
            //Create the Grid as printing document
            GridPrintDocumentAdv gpd = new GridPrintDocumentAdv(GGC_hienthicongviec.TableControl);
            PrintDialog pd = new PrintDialog();
            //Scale all columns to fit within a page
            gpd.ScaleColumnsToFitPage = true;
            pd.Document = gpd;
            //Print the contents of the Grid
            gpd.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*Bitmap bitmap = new Bitmap(DGV_hienthicongviec.Width, DGV_hienthicongviec.Height);
            DGV_hienthicongviec.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, DGV_hienthicongviec.Width, DGV_hienthicongviec.Height));
            
            e.Graphics.DrawImage(bitmap, 0, 0);*/
        }
    }
}
