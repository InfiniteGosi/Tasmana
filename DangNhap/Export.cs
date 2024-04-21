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
using Syncfusion.XlsIO;

namespace DangNhap
{
    internal class Export
    {
        public void ToExcel(DataTable dataTable, string sheetName, string title, int loai)
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
            if (loai == 0) { 
                // Create title
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "N1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Create column name

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã công việc";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã nhân viên";

                cl2.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Họ";

                cl3.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tên";

                cl4.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Mã nhóm";

                cl5.ColumnWidth = 50;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Mã bộ phận";
                cl6.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Nội dung";

                cl7.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                cl8.Value2 = "Mã căn hộ";

                cl8.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

                cl9.Value2 = "Ngày giao";

                cl9.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

                cl10.Value2 = "Ngày cập nhật";

                cl10.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

                cl11.Value2 = "Thời hạn";

                cl11.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

                cl12.Value2 = "Ngày hoàn thành";

                cl12.ColumnWidth = 20;
                Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");

                cl13.Value2 = "Trạng thái";

                cl13.ColumnWidth = 20;
                Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("N3", "N3");

                cl14.Value2 = "Ghi chú";

                cl14.ColumnWidth = 20;
                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "N3");
                rowHead.Font.Bold = true;
                // Draw border

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Setting background color

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            else if (loai == 1)
            {
                // Create title
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "L1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Create column name

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã công việc";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã nhóm";

                cl2.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Mã trưởng nhóm";

                cl3.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Mã bộ phận";

                cl4.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Nội dung";

                cl5.ColumnWidth = 50;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Mã căn hộ";

                cl6.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Ngày giao";

                cl7.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                cl8.Value2 = "Ngày cập nhật";

                cl8.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

                cl9.Value2 = "Thời hạn";

                cl9.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

                cl10.Value2 = "Ngày hoàn thành";

                cl10.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

                cl11.Value2 = "Trạng thái";

                cl11.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

                cl12.Value2 = "Ghi chú";

                cl12.ColumnWidth = 20;
                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "L3");
                rowHead.Font.Bold = true;
                // Draw border

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Setting background color

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            else
            {
                // Create title
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "K1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Create column name

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã công việc";

                cl1.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Mã bộ phận";

                cl2.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Mã quản lý";

                cl3.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Nội dung";

                cl4.ColumnWidth = 50;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Mã căn hộ";

                cl5.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Ngày giao";

                cl6.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Ngày cập nhật";

                cl7.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                cl8.Value2 = "Thời hạn";

                cl8.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

                cl9.Value2 = "Ngày hoàn thành";

                cl9.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

                cl10.Value2 = "Trạng thái";

                cl10.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

                cl11.Value2 = "Ghi chú";

                cl11.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");
                rowHead.Font.Bold = true;
                // Draw border

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Setting background color

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }

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


        public void ToPDF(DataTable dataTable, String path)
        {
            // Tạo một tệp PDF mới
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

            // Mở tài liệu để bắt đầu viết dữ liệu vào
            document.Open();

            // Tạo một bảng PDF với số cột bằng với số cột trong DataTable
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

            // Thêm tiêu đề cho từng cột
            foreach (DataColumn column in dataTable.Columns)
            {
                pdfTable.AddCell(new Phrase(column.ColumnName));
            }

            // Thêm dữ liệu từ DataTable vào bảng PDF
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (object item in row.ItemArray)
                {
                    pdfTable.AddCell(new Phrase(item.ToString()));
                }
            }

            // Thêm bảng vào tài liệu
            document.Add(pdfTable);

            // Đóng tài liệu sau khi đã hoàn thành việc ghi dữ liệu
            document.Close();

        }

        public void ToExcelNV(DataTable dataTable, string sheetName, string title)
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");

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

            cl2.Value2 = "Họ";

            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Tên";

            cl3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Mã bộ phận";

            cl4.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Tổng công việc";

            cl5.ColumnWidth = 50;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Hoàn thành";

            cl6.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Đang thực hiện";

            cl7.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Chưa bắt đầu";

            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Trễ hạn";

            cl9.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");

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

        public void ToExcelCH(DataTable dataTable, string sheetName, string title)
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Create column name

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã căn hộ";

            cl1.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Diện tích";

            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Vị trí tầng";

            cl3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Số lượng phòng ngủ";

            cl4.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số lượng toilet";

            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Số lượng thẻ thang máy";

            cl6.ColumnWidth = 40;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Mức phí quản lý hàng tháng";

            cl7.ColumnWidth = 40;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Lịch sử giao dịch";

            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Tình trạng giao dịch hiện tại";

            cl9.ColumnWidth = 50;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "Mã cư dân";

            cl10.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");

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
    }
}