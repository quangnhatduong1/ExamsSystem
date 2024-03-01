using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
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
    public partial class TestDetailsForm : Form
    {
        private TestsBLL testsBLL;
        private Tests test;
        private ExamsBLL examsBLL;
        private List<MyTestObserver> observerList;
        public TestDetailsForm()
        {
            InitializeComponent();
            

        }
        public TestDetailsForm(object ob)
        {
            InitializeComponent();
            testsBLL = new TestsBLL();
            examsBLL = new ExamsBLL();
            observerList = new List<MyTestObserver>();
            int testid = int.Parse((string)ob);
            test = testsBLL.getTest(testid);
            
        }
        private void TestDetailsForm_Load(object sender, EventArgs e)
        {
            showCheckedExamsList("-1");
            setDefaultValue();
            lockForm();
            //kiểm tra xem bài thi này đã được áp dụng (đã được làm) chưa để khóa một số thành phần
            int countest = testsBLL.getCountStudentsTest(int.Parse(test.Id));
            if(countest > 0) //nghĩa là đã được áp dụng
            {
                checkbox_tested.Checked = true;
                //khóa nút lưu và xóa
                btn_save_test.Enabled = false;
                btn_delete_test.Enabled = false;
            }
            //load danh sách các học sinh đã thi bài thi này (có kèm kết quả)
            showStudentsTestsList();
        }
        //hiển thị danh sách đề thi đã được duyệt
        private void showCheckedExamsList(string examid)
        {
            int id = 0;
            try
            {
                id = int.Parse(examid);
            }
            catch(Exception err)
            {
                id = 0;
            }
            data_exams_list.DataSource = examsBLL.getCheckedExamsList(id);
        }
        //thiết lập giá trị mặc định (giá trị lúc mới load form)
        public void setDefaultValue()
        {
            DateTime testDateTime = DateTime.ParseExact(test.Datestart, "dd/MM/yyyy HH:mm:ss", null);
            DateTime currentDateTime = DateTime.Now;
            if(testDateTime > currentDateTime)
            {
                time_datestart.MinDate = currentDateTime;
            }
            else
            {
                time_datestart.MinDate = testDateTime;
            }
            showTestToView();
            //Nhấn chọn row exam bên bảng dữ liệu
            DataGridViewRow dataRow = data_exams_list.Rows.Cast<DataGridViewRow>()
                 .Where(t => t.Cells[0].Value.ToString().Equals(test.Exam.Id))
                 .First();
            data_exams_list.Rows[0].Selected = false;
            dataRow.Selected = true;
        }
        //khóa một số thành phần trên form
        private void lockForm()
        {
            btn_exam_details.Enabled = false;
          
            
        }
        //hàm unlock một số thành phần trên form
        private void unlockForm()
        {
            //mở khóa nút xem chi tiết
            btn_exam_details.Enabled = true;
           
            
        }
        private void clearForm()
        {
            setDefaultValue();
        }
        //hiển thị nội dung của đối tượng test lên view
        public void showTestToView()
        {
            //mã đề thi
            txt_testid.Text = test.Id;
            //thời gian mở
            time_datestart.Value = DateTime.ParseExact(test.Datestart, "dd/MM/yyyy HH:mm:ss", null);
            //trạng thái mở
            cb_openstate.SelectedIndex = test.Openstate;
            //hiển thị phần exam
            showExamToView(test.Exam);


        }
        //hiển thị nội dung của đối tượng exam lên view
        private void showExamToView(Exams exam)
        {
            try
            {
                

                //hiển thị thông tin exam lên view
                //id exam
                txt_examid.Text = exam.Id;
                //số câu hỏi
                txt_questionscount.Text = exam.Questions.Count.ToString();
                //tên môn học
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
            catch (Exception err)
            {
                setDefaultValue();
                btn_exam_details.Enabled = false;
            }
        }
        //hàm show thông tin đề thi qua bên form thêm bài thi
        private void showExamToView(int examid)
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

        private void btn_exam_details_Click(object sender, EventArgs e)
        {
            int examid = int.Parse(txt_examid.Text.ToString());
            Form form = FormFactory.getInstance().getForm("ExamDetails", examid);
            form.ShowDialog();
        }

        private void btn_clear_test_Click(object sender, EventArgs e)
        {
            setDefaultValue();
        }
        //khi nhấn nút lưu
        private void btn_save_test_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn cập nhật lại thông tin của bài thi này", "Thông báo");
            if(dialogResult == DialogResult.Yes) // nếu xác nhận thì tiến hành lưu
            {
                int examid = int.Parse(txt_examid.Text.ToString());
                string datestart = time_datestart.Value.ToString("MM/dd/yyyy HH:mm:ss");
                int openstate = cb_openstate.SelectedIndex;
                //gọi hàm thực hiện việc test
                updateTest(examid, datestart, openstate);
                //đóng form
                this.Close();

            }
        }
        //hàm tiến hành cập nhật test
        private void updateTest(int examid, string datestart, int openstate)
        {
            try
            {
                int testid = int.Parse(test.Id);
                int resultUpdate = testsBLL.updateTest(examid, datestart, openstate, testid);
                if(resultUpdate > 0)
                {
                    createMessageBox("Cập nhật lại bài thi thành công", "Thông báo");
                    //cập nhật lại giá trị test
                    test = testsBLL.getTest(testid);
                    //cập nhật lên bên phía chờ
                    changeData(test, 1); //1 là thông báo cập nhật một test
                }
                else
                {
                    createMessageBox("Cập nhật lại bài thi thất bại, vui lòng thử lại", "Thông báo");
                }
            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
        }
        public void setObserver(MyTestObserver myob)
        {
            observerList.Add(myob);
        }
        public void changeData(Tests test, int option)
        {
            foreach (MyTestObserver ob in observerList)
            {
                ob.refreshUI(test, option); //option: 1:sửa, 2: xóa
            }
        }
        private DialogResult createMessageBoxYesNo(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, title, button);
        }

        private void btn_delete_test_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn xóa bài thi này không ?", "Thông báo");
            if (dialogResult == DialogResult.Yes)
            {
                int testid = int.Parse(txt_testid.Text.ToString());
                //gọi hàm thực hiện xóa
                deleteTest(testid);
            }
        }
        private void deleteTest(int testid)
        {
            try {
                int resultDelete = testsBLL.deleteTest(testid);
                if(resultDelete > 0)
                {
                    //gọi hàm thay đổi dữ liệu phía nhận
                    changeData(null, 2); //2 là thông báo xóa dữ liệu
                    DialogResult dialogResult = createMessageBox("Xóa bài thi thành công", "Thông báo");
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
        }

        //hàm upload danh sách các học sinh đã tham gia bài thi này (có kèm kết quả)
        public void showStudentsTestsList()
        {
            StudentsTestsBLL studentsTestsBLL = new StudentsTestsBLL();
            data_students_tests.DataSource = studentsTestsBLL.getStudentsByTestsId(int.Parse(test.Id));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(cb_search.SelectedIndex >= 0)
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
