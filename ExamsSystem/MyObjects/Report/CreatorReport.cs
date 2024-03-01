using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Report
{
    class CreatorReport : ReportDecorator
    {
        private Accounts account;
        
        public CreatorReport(ReportGenerate reportGenerate, Accounts account):base(reportGenerate)
        {
            this.account = account;
        }
        //trang trí thêm thông tin người tạo
        public override void generate(Document pdfDoc)
        {
            Font titlefont = new Font(bf, 14, Font.BOLD);
            Paragraph titlecontent = new Paragraph("Thông tin người tạo", titlefont)
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
            //thêm thông tin tên tài khoản
            pdfTable.AddCell(createMyPdfCell("Tên tài khoản", boldFont));
            pdfTable.AddCell(createMyPdfCell(account.Username, contentFont));
            //thêm thông tin họ và tên
            pdfTable.AddCell(createMyPdfCell("Họ và tên", boldFont));
            pdfTable.AddCell(createMyPdfCell(!string.IsNullOrWhiteSpace(account.Fullname) ? account.Fullname : "Chưa cập nhật", contentFont));
            //thêm thông tin chức vụ
            pdfTable.AddCell(createMyPdfCell("Chức vụ", boldFont));
            pdfTable.AddCell(createMyPdfCell(roleNameToPosition(account.Rolename), contentFont));
            //thêm thông tin địa chỉ email
            pdfTable.AddCell(createMyPdfCell("Địa chỉ email", boldFont));
            pdfTable.AddCell(createMyPdfCell(!string.IsNullOrWhiteSpace(account.Email) ? account.Email : "Chưa cập nhật", contentFont));
            //thêm thông tin số điện thoại
            pdfTable.AddCell(createMyPdfCell("Số điện thoại", boldFont));
            pdfTable.AddCell(createMyPdfCell(!string.IsNullOrWhiteSpace(account.Phonenumber) ? account.Phonenumber : "Chưa cập nhật", contentFont));
            

            pdfTable.SpacingAfter = 10;
            pdfDoc.Add(pdfTable);
            base.generate(pdfDoc);
        }
        //chuyển đổi quyền thành chức vụ cụ thể
        public string roleNameToPosition(string rolename)
        {
            if (rolename == "AM")
            {
                return "Quản trị hệ thống";
            }
            else if (rolename == "GV")
            {
                return "Giáo viên";
            }
            else
            {
                return "Phòng học vụ";
            }
        }

    }
}
