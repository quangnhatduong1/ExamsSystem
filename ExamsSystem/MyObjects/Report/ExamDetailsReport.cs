using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Report
{
    //trang trí thêm nội dung chi tiết của đề thi thuộc bài thi
    class ExamDetailsReport : ReportDecorator
    {
        private Exams exam;
        public ExamDetailsReport(ReportGenerate reportGenerate, Exams exam):base(reportGenerate)
        {
            this.exam = exam;
        }
        //trang trí thêm thông tin chi tiết đề thi
        public override void generate(Document pdfDoc)
        {
            Font titlefont = new Font(bf, 14, Font.BOLD);
            Paragraph titlecontent = new Paragraph("Thông tin đề thi", titlefont) { 
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
            pdfTable.AddCell(createMyPdfCell("Mã đề thi",boldFont));
            pdfTable.AddCell(createMyPdfCell(exam.Id,contentFont));
            //thêm thông tin môn học
            pdfTable.AddCell(createMyPdfCell("Môn học", boldFont));
            pdfTable.AddCell(createMyPdfCell(exam.Subject.SubjectName, contentFont));
            //thêm thông tin thời gian làm bài
            pdfTable.AddCell(createMyPdfCell("Thời gian làm bài", boldFont));
            pdfTable.AddCell(createMyPdfCell(exam.Dotime.ToString() + " phút", contentFont));
            //thêm thông tin số lượng câu hỏi
            pdfTable.AddCell(createMyPdfCell("Số lượng câu hỏi", boldFont));
            pdfTable.AddCell(createMyPdfCell(exam.Questionscount.ToString() + " câu", contentFont));
            //thêm tên tài khoản người tạo
            pdfTable.AddCell(createMyPdfCell("Người tạo", boldFont));
            pdfTable.AddCell(createMyPdfCell(exam.Username, contentFont));
         
            pdfTable.SpacingAfter = 10;
            pdfDoc.Add(pdfTable);
            base.generate(pdfDoc);
        }
        
    }
  
}
