
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.PrintTest
{
    public abstract class TestPDFGenerate
    {
        protected BaseFont bf;
        public TestPDFGenerate()
        {
            //tạo ra đường dẫn đến font chữ tiếng việt
            string path = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources/myfont/vuArial.ttf");
            //tạo font chữ
            this.bf = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        }
        public abstract void generate(Document pdfDoc);
        
    }
}
