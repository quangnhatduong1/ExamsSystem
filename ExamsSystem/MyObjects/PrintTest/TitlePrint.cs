using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.PrintTest
{
    
    public class TitlePrint : TestPDFDecorator
    {
        private Tests test;
        public TitlePrint(TestPDFGenerate testPDFGenerate, Tests test) : base(testPDFGenerate)
        {
            this.test = test;
        }
        public override void generate(Document pdfDoc)
        {
            Font headerfont = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);
            Font conentfont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL);
            PdfPTable table = new PdfPTable(2);
            table.AddCell(createCellWithOutBorder("Trung tâm luyện thi môn học khối xã hội", headerfont));
            table.AddCell(createCellWithOutBorder("Bài thi đánh giá năng lực học sinh của trung tâm", headerfont));
            table.AddCell(createCellWithOutBorder($"Môn thi: {test.Exam.Subject.SubjectName}", conentfont));
            table.AddCell(createCellWithOutBorder($"Thời gian làm bài: {test.Exam.Dotime} phút", conentfont));
            table.AddCell(createCellWithOutBorder("", conentfont));
            table.AddCell(createCellWithOutBorder($"Mã bài thi: {test.Id}", conentfont));
            pdfDoc.Add(table);
            base.generate(pdfDoc);
        }
        private PdfPCell createCellWithOutBorder(string content, Font font)
        {
            Paragraph para = new Paragraph(content, font) { 
                
            };
            return new PdfPCell(para) { 
                Border= 0,
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingLeft = 10,
                PaddingRight = 10,
                PaddingTop = 5
            };
        }
        private PdfPCell createCellWithBorder(string content, Font font)
        {
            Paragraph para = new Paragraph(content, font)
            {
               
            };
            return new PdfPCell(para)
            {
                
                HorizontalAlignment = Element.ALIGN_CENTER,
                PaddingLeft = 10,
                PaddingRight = 10,
                PaddingTop = 5
            };
        }


    }
}
