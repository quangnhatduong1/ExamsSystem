using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.PrintTest
{
    public class TestPDFDecorator : TestPDFGenerate
    {
        private TestPDFGenerate testPDFGenerate;
        public TestPDFDecorator(TestPDFGenerate testPDFGenerate)
        {
            this.testPDFGenerate = testPDFGenerate;
        }

        public override void generate(Document pdfDoc)
        {
            testPDFGenerate.generate(pdfDoc);
        }
    }
}
