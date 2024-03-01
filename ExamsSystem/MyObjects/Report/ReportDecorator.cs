using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Report
{
    class ReportDecorator : ReportGenerate
    {
        private ReportGenerate reportGenerate;
        public ReportDecorator(ReportGenerate reportGenerate)
        {
            this.reportGenerate = reportGenerate;
        }
        public override void generate(Document pdfDoc)
        {
            reportGenerate.generate(pdfDoc);
        }
        protected PdfPCell createMyPdfCell(string content, Font font)
        {

            PdfPCell cellContent = new PdfPCell(new Phrase(content, font))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                Padding = 3
            };
            return cellContent;
        }
    }
}
