using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Report
{
    //trang trí thống kê kết quả thi
    class TestResultStatisticsReport : ReportDecorator
    {
        private DataTable dataTable;
        public TestResultStatisticsReport(ReportGenerate reportGenerate, DataTable dataTable):base(reportGenerate)
        {
            this.dataTable = dataTable;
        }
        public override void generate(Document pdfDoc)
        {
            //lấy ra giá trị lớn nhất trong row
            double maxValue = dataTable.Rows.Cast<DataRow>()
                .Max(t => double.Parse(t[3].ToString()));
            // tìm row có giá trị lớn nhất
            DataRow maxRow = dataTable.Rows.Cast<DataRow>()
                 .Where(t => double.Parse(t[3].ToString()) == maxValue)
                 .First();
            //lấy ra giá trị bé nhất trong row
            double minValue = dataTable.Rows.Cast<DataRow>()
                .Min(t => double.Parse(t[3].ToString()));
            // tìm row có giá trị bé nhất
            DataRow minRow = dataTable.Rows.Cast<DataRow>()
                 .Where(t => double.Parse(t[3].ToString()) == minValue)
                 .First();

            Font titlefont = new Font(bf, 14, Font.BOLD);
            Paragraph titlecontent = new Paragraph("Thống kê kết quả", titlefont)
            {
                SpacingAfter = 5
            };
            pdfDoc.Add(titlecontent);

            //tạo ra một bảng dữ liệu với 3 cột
            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.WidthPercentage = 70;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; //chiều ngang cho nằm bên trái

            //chuẩn bị bộ font
            Font boldFont = new Font(bf, 13, Font.BOLD);
            Font contentFont = new Font(bf, 13, Font.NORMAL);
            //thêm thông tin tiêu đề bảng
            pdfTable.AddCell(createMyPdfCell("", boldFont));
            pdfTable.AddCell(createMyPdfCell("Điểm", boldFont));
            pdfTable.AddCell(createMyPdfCell("Tên tài khoản", boldFont));
            //thêm thông tin điểm số cao nhất
            pdfTable.AddCell(createMyPdfCell("Điểm cao nhất", boldFont));
            pdfTable.AddCell(createMyPdfCell(maxRow[4].ToString(), contentFont));
            pdfTable.AddCell(createMyPdfCell(maxRow[0].ToString(), contentFont));
            //thêm thông tin điểm số thấp nhất
            pdfTable.AddCell(createMyPdfCell("Điểm thấp nhất", boldFont));
            pdfTable.AddCell(createMyPdfCell(minRow[4].ToString(), contentFont));
            pdfTable.AddCell(createMyPdfCell(minRow[0].ToString(), contentFont));

            pdfTable.SpacingAfter = 10;
            pdfDoc.Add(pdfTable);


            base.generate(pdfDoc);
        }
    }
}
