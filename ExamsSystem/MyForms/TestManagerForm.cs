using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.PrintTest;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer;
using ExamsSystem.Patterns.Observer.Test;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyForms
{
    public partial class TestManagerForm : Form, MyTestObserver
    {
        private TestsBLL testsBLL;
        private int selectedIndex = -1;
        public TestManagerForm()
        {
            InitializeComponent();
            testsBLL = new TestsBLL();
            cb_openstate.SelectedIndex = 0;
            cb_subjects.SelectedIndex = 0;
            lockForm();
        }
        private void lockForm()
        {
            btn_test_detail.Enabled = false;
            btn_test_print.Enabled = false;
        }
        private void unclockForm()
        {
            btn_test_detail.Enabled = true;
            btn_test_print.Enabled = true;
        }
        private void clearForm()
        {
            txt_examid.Text = null;
            txt_testid.Text = null;
            txt_subject.Text = null;
            txt_time_open.Text = null;
            txt_openstate.Text = null;
        }
        private void TestManagerForm_Load(object sender, EventArgs e)
        {
            //hiển thị danh sách tests
            showTestsList("",-1);
        }
        //hàm hiển thị danh sách các bài test có trong hệ thống
        private void showTestsList(string field_subject, int field_openstate)
        {
            data_tests_list.DataSource = testsBLL.getTestsList(field_subject,field_openstate);
        }
        //khi nhấn nút tạo bài thi
        private void btn_create_test_Click(object sender, EventArgs e)
        {
            //hienr thi form tạo bài thi
            Form form = FormFactory.getInstance().getForm("CreateTest");
            CreateTestForm createTestForm = (CreateTestForm)form;
            createTestForm.setObserver(this);
            createTestForm.ShowDialog();
        }

       
        private void data_tests_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                showTestToView(e.RowIndex);
                selectedIndex = e.RowIndex;
                unclockForm();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                clearForm();
                lockForm();
                selectedIndex = -1;
            }
            
        }
        //hiển thị bài test lên view
        private void showTestToView(int index)
        {
            DataGridViewRow rowSelected = data_tests_list.Rows[index];
            //lấy id bài test
            int testid = int.Parse(rowSelected.Cells[0].Value.ToString());

            //lấy bài test trong csdl
            Tests test = testsBLL.getTest(testid);
            //hiển thị lên view
            txt_testid.Text = test.Id;
            txt_examid.Text = test.Exam.Id;
            txt_subject.Text = test.Exam.Subject.SubjectName;
            txt_time_open.Text = test.Datestart;
            txt_openstate.Text = test.Openstate == 0 ? "Chưa mở" : "Mở";
            //mở khóa nút details
            btn_test_detail.Enabled = true;

        }
        //hàm convert một giá trị datetime trong db thành giá trị chuỗi datetime theo định dạng dd/MM/yyyy HH:mm:ss
        private string convertDateDBToString(string timedb)
        {
            DateTime dateTime = DateTime.ParseExact(timedb, "M/dd/yyyy h:mm:ss tt", null);
            string time_dateopen_exact = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            return time_dateopen_exact;
        }

        private void btn_test_detail_Click(object sender, EventArgs e)
        {
            string testid = txt_testid.Text.ToString();
            Form form = FormFactory.getInstance().getForm("TestDetails", testid);
            TestDetailsForm testDetailsForm = (TestDetailsForm)form;
            testDetailsForm.setObserver(this);
            testDetailsForm.ShowDialog();
        }

        public void refreshUI(Tests test, int option)
        {
           
            if (option == 0) //nhận phản hồi từ việc thêm
            {
                showTestsList("", -1);
                clearForm();
                lockForm();
                clearSearch();
            }
            else if(option == 1) // nhận phải hồi từ việc sửa
            {
                //lấy ra test id của row hiện tại
                string testid = (txt_testid.Text.ToString());
                //show lên view test mới vừa cập nhật
                showTestToView(selectedIndex);
                //làm mới search(bao gồm list)
                clearSearch();
                //tìm kiếm row tương ứng với testid để nhấn vào
                DataGridViewRow rowToSelected = data_tests_list.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value.ToString().Equals(testid))
                    .First();
                //bỏ chọn row đầu tiên
                data_tests_list.Rows[0].Selected = false;
                rowToSelected.Selected = true;
                
            }
            else if(option == 2) // nhận phản hồi từ việc xóa
            {
                showTestsList("", -1);
                clearForm();
                lockForm();
                clearSearch();
            }
        }
        private void clearSearch()
        {
            cb_subjects.SelectedIndex = 0;
            cb_openstate.SelectedIndex = 0;
            showTestsList("", -1);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string field_subject = "";
            if(cb_subjects.SelectedIndex > 0)
            {
                field_subject = cb_subjects.SelectedItem.ToString();
            }
            int field_openstate = -1;
            if(cb_openstate.SelectedIndex > 0)
            {
                field_openstate = cb_openstate.SelectedIndex - 1; //-1 để đúng về giá trị openstate
            }
            showTestsList(field_subject, field_openstate);
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowSelected = data_tests_list.Rows[selectedIndex];
            //lấy id bài test
            int testid = int.Parse(rowSelected.Cells[0].Value.ToString());

            //lấy bài test trong csdl
            Tests test = testsBLL.getTest(testid);
            if (test.Exam.Questions.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "OutputTest.pdf";
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
                                Document pdfDoc = new Document(PageSize.A4, 40f, 40f, 20f, 10f);

                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();
                                TestPDFGenerate testPDFGenerate = new ExamDataPrint(test.Exam);
                                testPDFGenerate = new InformationPrint(testPDFGenerate);
                                testPDFGenerate = new TitlePrint(testPDFGenerate, test);
                                testPDFGenerate.generate(pdfDoc);

                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("In bài thi thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có câu hỏi để in", "Thông báo");
            }
        }

        private void TestManagerForm_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
