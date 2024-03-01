using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.PrintTest
{
    class InformationPrint : TestPDFDecorator
    {
        public InformationPrint(TestPDFGenerate testPDFGenerate) : base(testPDFGenerate)
        {

        }
        public override void generate(Document pdfDoc)
        {
            Font conentfont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL);
            pdfDoc.Add(new Paragraph("") { SpacingBefore = 50});
            pdfDoc.Add(createParagrap("Họ và tên:"+" .............................................................................."+" Số báo danh: ...........................................", conentfont));
            pdfDoc.Add(createParagrap("Lớp học: ................................................................................. " + "Ngày thi: ..................................................", conentfont));
            base.generate(pdfDoc);
        }
        private Paragraph createParagrap(string content,Font font)
        {
            return new Paragraph(content, font)
            {
                SpacingBefore = 10
            };
        }
    }
}
