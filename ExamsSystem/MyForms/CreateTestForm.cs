using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer;
using ExamsSystem.Patterns.Observer.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyForms
{
    public partial class CreateTestForm : Form
    {
        private ExamsBLL examsBLL;
        private TestsBLL testsBLL;
        private List<MyTestObserver> observerList;
        public CreateTestForm()
        {
            InitializeComponent();
            examsBLL = new ExamsBLL();
            testsBLL = new TestsBLL();
            observerList = new List<MyTestObserver>();
            clearForm();
            setDefaultValue();
            lockForm();
        }
        //hàm clearForm
        private void clearForm()
        {
            
            
            txt_examid.Text = null;
            txt_subjectname.Text = null;
            txt_questionscount.Text = "0";
            
        }
        //khóa một số thành phần trên form
        private void lockForm()
        {
            btn_exam_details.Enabled = false;
            btn_create_test.Enabled = false;
        }
        //hàm unlock một số thành phần trên form
        private void unlockForm()
        {
            //mở khóa nút xem chi tiết
            btn_exam_details.Enabled = true;
            //mở khóa nút thêm
            btn_create_test.Enabled = true;
        }
        //hàm gắn một số dữ liệu mặc định lên form
        private void setDefaultValue()
        {
            //gắn trạng thái chưa mở
            cb_openstate.SelectedIndex = 1;
            //gắn giá trị thời gian bé nhất là hiện tại
            time_datestart.MinDate = DateTime.Now;
            //gắn câu hỏi là 0
            txt_questionscount.Text = "0";
        }
        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            //hiển thị danh sách đề thi đã được duyệt
            showCheckedExamsList("-1");
        }
        //hiển thị danh sách đề thi đã được duyệt
        private void showCheckedExamsList(string examid)
        {
            int id = 0;
            try
            {
                id = int.Parse(examid);
            }
            catch (Exception err)
            {
                id = 0;
            }
            data_exams_list.DataSource = examsBLL.getCheckedExamsList(id);
        }
        //khi nhấn vào nút xác nhận để tạo test
        private void btn_create_test_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy ra thông tin examid
                int examid = int.Parse(txt_examid.Text.ToString());
                //lấy ra thông tin datestart (đảo ngược lại ngày tháng thành tháng ngày để thêm vào csdl)
                string datestart = time_datestart.Value.ToString("MM/dd/yyyy HH:mm:ss");
                //mặc định là chưa mở (vì mới tạo)
                int openstate = 0;
                //gọi câu lệnh thêm
                int resultTest = testsBLL.insertTest(examid, datestart, openstate);
                if(resultTest > 0)
                {
                    //gọi hàm observer
                    newTestData();
                    DialogResult dialogResult =  createMessageBox("Tạo bài test thành công", "Thông báo");
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                else
                {
                    createMessageBox("Tạo bài test thất bại, vui lòng thử lại", "Thông báo");
                }

            }
            catch (Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }

        }

        //khi nhấn vào row trong bảng đề thi
        private void data_exams_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //xác định row được nhấn
                DataGridViewRow rowSelected = data_exams_list.Rows[e.RowIndex];
                //lấy được id đề thi
                int examid = int.Parse(rowSelected.Cells[0].Value.ToString());
                //gọi hàm show exam lên
                showExamToView(examid);
                //gọi hàm unlock một số thành phần trên form
                unlockForm();
                
            }
            catch(Exception err)
            {
                clearForm();
                lockForm();
            }
        }
        //hàm show thông tin đề thi qua bên form thêm bài thi
        private void  showExamToView(int examid)
        {
            try
            {
                //lấy exam từ csdl
                Exams exam = examsBLL.getExam(examid);

                //hiển thị thông tin exam lên view

                txt_examid.Text = exam.Id;
                txt_questionscount.Text = exam.Questions.Count.ToString();
                txt_subjectname.Text = exam.Subject.SubjectName;
                
            }
            catch (Exception e)
            {
                createMessageBox(e.Message, "Thông báo");
            }
        }
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }

        private void btn_clear_test_Click(object sender, EventArgs e)
        {
            clearForm();
            lockForm();
            setDefaultValue();
        }
        public void setObserver(MyTestObserver myob)
        {
            observerList.Add(myob);
        }
        public void newTestData()
        {
            foreach (MyTestObserver ob in observerList)
            {
                ob.refreshUI(null,0); // 0 là báo cho bên chờ là mới thêm một test mới
            }
        }

        //gọi hàm xem chi tiết một đề thi
        private void btn_exam_details_Click(object sender, EventArgs e)
        {
            int examid = int.Parse(txt_examid.Text.ToString());
            Form form = FormFactory.getInstance().getForm("ExamDetails",examid);
            form.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cb_search.SelectedIndex >= 0)
            {
                if (string.IsNullOrEmpty(txt_search.Text.ToString()))
                {
                    showCheckedExamsList("-1");
                }
                else
                {
                    showCheckedExamsList(txt_search.Text.ToString());
                }

            }
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            cb_search.SelectedIndex = -1;
            txt_search.Text = null;
            showCheckedExamsList("-1");
        }
    }
}
