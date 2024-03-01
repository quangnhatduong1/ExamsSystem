using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Report
{
    public abstract class ReportGenerate
    {
        protected BaseFont bf;
        public ReportGenerate()
        {
            //tạo ra đường dẫn đến font chữ tiếng việt
            string path = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources/myfont/vuArial.ttf");
            //tạo font chữ
            this.bf = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        }
        protected string convertDateDBToString(string timedb)
        {
            DateTime dateTime = DateTime.ParseExact(timedb, "M/d/yyyy h:mm:ss tt", null);
            string time_dateopen_exact = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            return time_dateopen_exact;
        }
        public abstract void generate(Document pdfDoc);
    }
}
