using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
namespace DangNhap
{
    internal class Export
    {
        public void ToExcel(DataTable dataTable, string sheetName, string title)
        {
            // Create Excel object

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Create new Excel WorkBook
            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Create title
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Create column name

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ và tên";

            cl2.ColumnWidth = 50.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Nội dung";

            cl3.ColumnWidth = 50.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Mã căn hộ";

            cl4.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Thời hạn";

            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Ngày hoàn thành";

            cl6.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Trạng thái";

            cl7.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Ghi chú";

            cl8.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");

            rowHead.Font.Bold = true;
            // Draw border

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Setting background color

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Create array base on datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            // Transfer data from DataTable to object array

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // Setting field fills in data

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // the begin cell to fill with data

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // the end cell to fill with data

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Get the data fill area

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // Fill in the data in the established area

            range.Value2 = arr;

            // Draw border

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Center the table
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        public void ToPDF(GridGroupingControl ggc, String path)
        {
            // Tạo một đối tượng Document
            Document document = new Document(PageSize.LETTER, 10, 10, 42, 35);

            // Tạo một đối tượng PdfWriter để ghi dữ liệu vào file PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

            // Mở Document để bắt đầu viết dữ liệu
            document.Open();

            // Tạo một PdfPTable với số cột bằng với số cột trong GridGroupingControl
            PdfPTable table = new PdfPTable(ggc.TableDescriptor.Columns.Count);

            // Thêm tiêu đề cho bảng
            foreach (GridColumnDescriptor column in ggc.TableDescriptor.Columns)
            {
                table.AddCell(new Phrase(column.Name));
            }

            // Thiết lập số hàng đầu tiên là hàng tiêu đề
            table.HeaderRows = 1;

            // Duyệt qua từng bản ghi trong GridGroupingControl và thêm dữ liệu vào bảng
            foreach (Record record in ggc.Table.Records)
            {
                foreach (GridColumnDescriptor column in ggc.TableDescriptor.Columns)
                {
                    if (record.GetValue(column.MappingName) != null)
                    {
                        table.AddCell(new Phrase(record.GetValue(column.MappingName).ToString()));
                    }
                }
            }

            // Thêm bảng vào Document
            document.Add(table);

            // Đóng Document sau khi đã hoàn thành việc ghi dữ liệu
            document.Close();
        }
    }
}