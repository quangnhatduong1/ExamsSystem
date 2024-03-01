using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyObjects.Report
{
    class DataTableReport : ReportGenerate
    {
        private DataTable dataTable;
        public DataTableReport(DataTable dataTable)
        {
            this.dataTable = dataTable;
        }
        
        public override void generate(Document pdfDoc)
        {
            
            pdfDoc.NewPage();
            Font headerfont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
            Paragraph header = new Paragraph("Bảng dữ liệu học sinh tham gia thi", headerfont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 20,
                SpacingAfter = 20

            };

            pdfDoc.Add(header);
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count+1);

            pdfTable.DefaultCell.Padding = 5;

            pdfTable.WidthPercentage = 100;
            
            
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            Font font = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);
            PdfPCell cellstt = new PdfPCell(new Phrase("STT",font))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_CENTER,
                Padding = 5
            };
            pdfTable.AddCell(cellstt);
            foreach (DataColumn column in dataTable.Columns)
            {
                Phrase para = new Phrase(column.ColumnName, font);

                PdfPCell cell = new PdfPCell(para) {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_CENTER,
                    Padding = 5
                };
                
               
                pdfTable.AddCell(cell);
            }

            int i = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                
                object[] cells = row.ItemArray;
               
                pdfTable.AddCell(new PdfPCell(new Phrase(i.ToString())) {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    VerticalAlignment = Element.ALIGN_CENTER,
                    Padding = 5
                });
                for(int index = 0; index< cells.Length; index++)
                {
                    string content = cells[index].ToString();
                    if (index == 2) //vị trí thời gian thì cast dữ liệu lại theo định dạng 
                    {
                        content = convertDateDBToString(content);
                    }
                   
                    Phrase pharseContent = new Phrase(content)
                    {

                    };
                    PdfPCell cellContent = new PdfPCell(pharseContent)
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        VerticalAlignment = Element.ALIGN_CENTER,
                        Padding = 5
                    };
                    pdfTable.AddCell(cellContent);
                }
                
                i += 1;
               
            }
          
            pdfDoc.Add(pdfTable);

        }

       

        
    }
}
