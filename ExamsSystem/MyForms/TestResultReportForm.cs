using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Report;
using ExamsSystem.Patterns.FactoryMethod;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyForms
{
    public partial class TestResultReportForm : Form
    {
        private TestsBLL testsBLL;
        private int selectedIndex = -1;

        public TestResultReportForm()
        {
            InitializeComponent();
            cb_openstate.SelectedIndex = 0;
            cb_subjects.SelectedIndex = 0;
           
            testsBLL = new TestsBLL();
          
        }
        private void showTestsList(string field_subject, int field_openstate)
        {
            data_tests_list.DataSource = testsBLL.getTestsList(field_subject, field_openstate);
        }
        private void TestResultReportForm_Load(object sender, EventArgs e)
        {
            btn_create_report.Enabled = false;
            group_report_options.Enabled = false;
            showTestsList("", -1);
        }
        private void data_tests_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if(e.RowIndex < 0 || e.RowIndex >= data_tests_list.Rows.Count -1)
                {
                    throw new Exception("over index");
                }
                btn_create_report.Enabled = true;
                group_report_options.Enabled = true;
                btn_review_data.Enabled = true;
                selectedIndex = e.RowIndex;
            }
            catch(Exception err)
            {
                btn_create_report.Enabled = false;
                group_report_options.Enabled = false;
                btn_review_data.Enabled = false;
                selectedIndex = -1;
                checkbox_creator.Checked = false;
                checkbox_exam_details.Checked = false;
                checkbox_statictics.Checked = false;
                
            }
        }
        //tiến hành lập báo cáo
        private void btn_create_report_Click(object sender, EventArgs e)
        {
            //lấy ra row được chọn
            DataGridViewRow dataGridViewRow = data_tests_list.Rows[selectedIndex];
            //lấy ra test id
            int testid = int.Parse(dataGridViewRow.Cells[0].Value.ToString());
            //lấy ra bài test
            Tests test = testsBLL.getTest(testid);

            StudentsTestsBLL studentsTestsBLL = new StudentsTestsBLL();
            
           
            DataTable dataTable = studentsTestsBLL.getStudentsByTestsId(testid);
          



            if (dataTable.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi file vào khu vực được chọn, vui lòng thử lại" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 50f, 50f, 20f, 10f);
                                
                                PdfWriter.GetInstance(pdfDoc, stream);
                                
                                pdfDoc.Open();
                                //tạo ra đường dẫn đến font chữ tiếng việt
                                string path = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Resources/myfont/vuArial.ttf");
                                //tạo font chữ
                                BaseFont bf = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                                
                                Font font = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                                Paragraph header = new Paragraph("Báo cáo kết quả bài thi", font)
                                {
                                    Alignment = Element.ALIGN_CENTER,
                                    SpacingBefore = 20,
                                    
                                    
                                };
                                
                                pdfDoc.Add(header);
                                Font subFont = new Font(bf, 14, iTextSharp.text.Font.NORMAL);
                                Paragraph subhead = new Paragraph($"Ngày lập: {DateTime.Now.ToString("dd/MM/yyyy")}", subFont)
                                {
                                    Alignment = Element.ALIGN_CENTER,
                                    SpacingBefore = 5,
                                    SpacingAfter = 20 //giống như margin
                                };
                                pdfDoc.Add(subhead);

                                //tạo ra một đối tượng tạo report với bảng dữ liệu (mặc định)
                                ReportGenerate reportGenerate = new DataTableReport(dataTable);
                                // thêm thông tin thông kế bài thi (nếu có)
                                if(checkbox_statictics .Checked)
                                {
                                    reportGenerate = new TestResultStatisticsReport(reportGenerate, dataTable);
                                }
                                //thêm thông tin người tạo (nếu có)
                                if (checkbox_creator.Checked)
                                {
                                    
                                    reportGenerate = new CreatorReport(reportGenerate, User.getInstance().getAccount());
                                }
                                //thêm thông tin chi tiết đề thi (nếu có)
                                if (checkbox_exam_details.Checked)
                                {
                                    reportGenerate = new ExamDetailsReport(reportGenerate, test.Exam);
                                }
                                //thêm thông tin bài thi (mặc định)
                                reportGenerate = new TestDetailsReport(reportGenerate, test, dataTable);
                                //khởi tạo
                                reportGenerate.generate(pdfDoc);

                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string field_subject = "";
            if (cb_subjects.SelectedIndex > 0)
            {
                field_subject = cb_subjects.SelectedItem.ToString();
            }
            int field_openstate = -1;
            if (cb_openstate.SelectedIndex > 0)
            {
                field_openstate = cb_openstate.SelectedIndex - 1; //-1 để đúng về giá trị openstate
            }
            showTestsList(field_subject, field_openstate);
        }
        private void clearForm()
        {
            cb_openstate.SelectedIndex = 0;
           
            cb_subjects.SelectedIndex = 0;
            btn_create_report.Enabled = false;
            group_report_options.Enabled = false;
            showTestsList("", -1);
            foreach(Control control in group_report_options.Controls)
            {
                if(control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    cb.Checked = false;
                }
            }
        }
        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        //hiển thị bảng dữ liệu để xem trước bảng dữ liệu
        private void btn_review_data_Click(object sender, EventArgs e)
        {
            //lấy ra row được chọn
            DataGridViewRow dataGridViewRow = data_tests_list.Rows[selectedIndex];
            //lấy ra test id
            int testid = int.Parse(dataGridViewRow.Cells[0].Value.ToString());
            StudentsTestsBLL studentsTestsBLL = new StudentsTestsBLL();
            DataTable dataTable = studentsTestsBLL.getStudentsByTestsId(testid);
            Form form = FormFactory.getInstance().getForm("ReviewDataTabe",dataTable);
            form.ShowDialog();

        }

        private void TestResultReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToHomeForm();
        }
        private void goToHomeForm()
        {
            // tạo một HomeForm
            Form homeForm = FormFactory.getInstance().getForm("Home");
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }
        //hàm chỉnh lại một datatable


    }
}
