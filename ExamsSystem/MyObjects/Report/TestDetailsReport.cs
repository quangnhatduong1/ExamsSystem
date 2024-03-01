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
    class TestDetailsReport : ReportDecorator
    {
        private Tests test;
        private DataTable dataTable;
        public TestDetailsReport(ReportGenerate reportGenerate, Tests test, DataTable dataTable) : base(reportGenerate)
        {
            this.test = test;
            this.dataTable = dataTable;
        }
        //trang trí thông tin chi tiết bài thi
        public override void generate(Document pdfDoc)
        {
            Font titlefont = new Font(bf, 14, Font.BOLD);
            Paragraph titlecontent = new Paragraph("Thông tin bài thi", titlefont)
            {
                SpacingAfter = 5
            };
            pdfDoc.Add(titlecontent);
            //tạo ra một bảng dữ liệu với 2 cột
            PdfPTable pdfTable = new PdfPTable(2);
            pdfTable.WidthPercentage = 70;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; //chiều ngang cho nằm bên trái
            //chuẩn bị bộ font
            Font boldFont = new Font(bf, 13, Font.BOLD);
            Font contentFont = new Font(bf, 13, Font.NORMAL);
            //thêm thông tin mã đề thi vào bảng
            pdfTable.AddCell(createMyPdfCell("Mã bài thi", boldFont));
            pdfTable.AddCell(createMyPdfCell(test.Id, contentFont));
            //thêm thông tin môn học
            pdfTable.AddCell(createMyPdfCell("Môn học", boldFont));
            pdfTable.AddCell(createMyPdfCell(test.Exam.Subject.SubjectName, contentFont));
            //thêm thông tin thời gian mở bài
            pdfTable.AddCell(createMyPdfCell("Thời gian mở", boldFont));
            pdfTable.AddCell(createMyPdfCell(test.Datestart, contentFont));           
            //thêm thông tin số lượng người tham gia thi
            pdfTable.AddCell(createMyPdfCell("Số học sinh tham gia thi", boldFont));
            pdfTable.AddCell(createMyPdfCell(dataTable.Rows.Count.ToString(), contentFont));
            pdfTable.SpacingAfter = 10;
            pdfDoc.Add(pdfTable);
            base.generate(pdfDoc);
           
        }
    }
}
