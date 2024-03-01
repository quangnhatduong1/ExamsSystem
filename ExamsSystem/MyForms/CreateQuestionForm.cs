using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.Command.ExamsAndQuestions;
using ExamsSystem.Patterns.Observer;
using ExamsSystem.Patterns.Observer.Question;
using ExamsSystem.Patterns.StrategyPattern.ValidForm;
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
    public partial class CreateQuestionForm : Form
    {
        private Exams exam; //giá trị này sẽ có khi người dùng tạo câu hỏi cho một đề thi cụ thể
        private List<MyQuestionObserver> observerList; //ob dành cho tạo câu hỏi 1 đề thi cụ thể
        private MyObserver myObserver; //ob dành cho việc tạo câu hỏi ở phần quản lý
        private QuestionsBLL questionBLL;
        private EAQRemote eAQRemote;
        //constructor này sẽ được chạy khi người dùng bấm tạo câu hỏi ở phần quản lý câu hỏi
        //mục đích là có thể tự chọn môn cho câu hỏi
        public CreateQuestionForm()
        {
            InitializeComponent();
            questionBLL = new QuestionsBLL();
            observerList = new List<MyQuestionObserver>();
            btn_question_manager.Hide();
            //kiểm tra quyền hạn dạy học để hiển thị khu vực dạy học
            checkStudying();
            
        }
        //nếu có thông tin đính kèm (cụ thể là một đối tượng Exam)
        //constructor này sẽ được chạy khi người dùng bấm tạo câu hỏi ở danh sách câu hỏi của một exam
        //lúc này môn học của câu hỏi sẽ được gán mặc định chứ người dùng không được tự phép chọn tự do nữa
        public CreateQuestionForm(object data)
        {
            InitializeComponent();
            questionBLL = new QuestionsBLL();
            observerList = new List<MyQuestionObserver>();
            exam = (Exams)data;
            setDefaultExamValue();

        }
        private void CreateQuestionForm_Load(object sender, EventArgs e)
        {
            //tạo đối tượng question handling để xử lý form thành câu hỏi và ngược lại
            QuestionHandling questionHandling = new QuestionHandling(rtxt_question_title, rtxt_answerA, rtxt_answerB, rtxt_answerC, rtxt_answerD, group_type, group_answers, group_subjects, exam);
            questionHandling.setObserver(myObserver);
            foreach(MyQuestionObserver myob in observerList)
            {
                questionHandling.setObserver(myob);
            }
            //thêm remote
            eAQRemote = new EAQRemote();
            //các index sau đây trong mảng sẽ làm một công việc cụ thể
            //0 : trống
            //1: show Question Manager
            //2: trống
            //3: clear question
            //4: paste question
            //5: create question
            //6: on button paste 
            //7: off button paste
            //8: on an item
            //9: off an item
            //10: execute copy text
            //11: execute paste text
            //12: execute cleartext
            //13: on item copy
            //14: on item paste
            //15: on item clear
            //16: off item copy
            //17: off item paste
            //18: off item clear
            //thêm command hiển thị form quản lý câu hỏi ở slot 1
            eAQRemote.setCommand(new ShowExamManagerCommand(this, observerList, exam),1);
            //thêm command làm mới câu hỏi ở slot 3
            eAQRemote.setCommand(new ClearQuestionCommand(questionHandling), 3);
            //thêm command dán câu hỏi ở slot 4
            eAQRemote.setCommand(new PasteQuestionCommand(questionHandling), 4);
            //thêm command tạo câu hỏi ở slot 5
            eAQRemote.setCommand(new CreateQuestionCommand(questionHandling),5);
            //thêm command on button paste ở slot 6
            eAQRemote.setCommand(new OnControlCommand(btn_paste_question), 6);
            //thêm command off button paste ở slot 7
            eAQRemote.setCommand(new OffControlCommand(btn_paste_question), 7);
            //thêm command on copy, paste, clear vào slot 13,14,15
            eAQRemote.setCommand(new OnItemMenuCommand(item_copy), 13);
            eAQRemote.setCommand(new OnItemMenuCommand(item_paste), 14);
            eAQRemote.setCommand(new OnItemMenuCommand(item_clear), 15);
            //thêm command off copy,paste,clear vào slot 16, 17, 18
            eAQRemote.setCommand(new OffItemCommand(item_copy), 16);
            eAQRemote.setCommand(new OffItemCommand(item_paste), 17);
            eAQRemote.setCommand(new OffItemCommand(item_clear), 18);
            //nếu người dùng không có bản copy nào thì ẩn đi nút paste
            if (User.getInstance().copiedQuestion == null)
            {
                //off
                eAQRemote.executeCommand(7);
            }
            else
            {
                //on
                eAQRemote.executeCommand(6);
            }
        }
        private void checkStudying()
        {
            Accounts account = User.getInstance().getAccount();
            string rolename = account.Rolename;
            if (rolename == "GV")
            {
                //kiểm tra để cập lại danh sách môn học
                List<Subjects> subjects = account.SubjectStudy;
                if (subjects == null || subjects.Count <= 0)
                {
                    foreach (Control control in group_subjects.Controls) { control.Hide(); }
                }
                else
                {
                    foreach (Control control in group_subjects.Controls)
                    {
                        Subjects subject = subjects.Find(t => t.SubjectID.ToString().Equals(control.Tag.ToString()));
                        if (subject == null)
                        {
                            control.Hide();
                        }
                    }
                    //tick cái đầu tiên
                    foreach (Control control in group_subjects.Controls)
                    {
                        RadioButton rd = (RadioButton)control;
                        rd.Checked = true;
                        break;
                    }

                }
            }
        }
        private void menu_item_click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            // Đoạn code có thể nhận biết được control nào sử dụng tripMenuContext
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // control đang sử dụng menu item
                    Control sourceControl = owner.SourceControl;
                    // thông qua tag của item biết được item được chọn sẽ làm công việc gì để gắn command
                    string tagItem = menuItem.Tag.ToString();
                    
                   
                    eAQRemote.executeCommand(int.Parse(tagItem));

                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        //gán giá trị mặc định dựa vào Exam (nếu có)
        private void setDefaultExamValue()
        {
            //lấy ra môn học của đề thi
            Subjects subject = exam.Subject;
            //gán vào radio button của group môn học tương ứng
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                //kiểm tra xem tag của môn nào bằng id của subject thì set checked
                if (rd.Tag.ToString().Equals(subject.SubjectID))
                {
                    rd.Checked = true;
                }
            }
            //khóa cái khu vực group_subject lại để người dùng không chọn được nữa
            group_subjects.Enabled = false;
        }
       
        
        
        public void setObserver(MyQuestionObserver myob)
        {
            observerList.Add(myob);
        }
        public void setObserver(MyObserver myob)
        {
            myObserver = myob;
        }
        private void deleteControlInAnswerForm()
        {
            List<Control> controlToDelete = new List<Control>();
            //xóa đi các nút cũ
            foreach (Control control in group_answers.Controls)
            {
                string namecontrol = control.Name;
                if (namecontrol.Equals("rd_answer_A") || namecontrol.Equals("rd_answer_B") || namecontrol.Equals("rd_answer_C") || namecontrol.Equals("rd_answer_D"))
                {
                    controlToDelete.Add(control);
                }
            }
            foreach (Control control in controlToDelete)
            {
                group_answers.Controls.Remove(control);
            }
        }

        //hàm thay đổi phần nút chọn câu trả lời
        private void updateAnswerQuestionBox(int typeQuestion)
        {
            deleteControlInAnswerForm();

            string[] answerTag = { "A", "B", "C", "D" };

            int sizeX = 57;
            int sizeY = 17;
            int pointX = 6;
            int pointY = 20;
            if (typeQuestion == 0)
            {
                rd_answer_single.Checked = true;
            }
            else
            {
                rd_answer_multiple.Checked = true;
            }
            foreach (string tag in answerTag)
            {
                Control answerControl = null;
                //nếu là dạng câu hỏi 1 câu trả lời thì tạo radio button
                if (typeQuestion == 0)
                {
                    answerControl = new RadioButton()
                    {
                        Width = sizeX,
                        Height = sizeY,
                        Location = new Point(pointX, pointY),
                        Tag = tag,
                        Text = $"{tag}.",
                        Name = $"rd_answer_{tag}"
                    };
                }
                //nếu là câu hỏi dạng nhiều câu trả lời thì tạo checkbox
                if (typeQuestion == 1)
                {
                    answerControl = new CheckBox()
                    {
                        Width = sizeX + 2,
                        Height = sizeY,
                        Location = new Point(pointX, pointY),
                        Tag = tag,
                        Text = $"{tag}.",
                        Name = $"rd_answer_{tag}"
                    };
                }
                
                pointY += 74;
                group_answers.Controls.Add(answerControl);
            }
        }
        //khi click vào radio button trong group type question thì thay đổi hình thức tạo câu hỏi
        // cụ thể là đổi từ dạng radio button -->checkbox ở khung nhập câu trả lời cho câu hỏi hoặc ngược lại
        public void change_type_question_radio_click(object sender, EventArgs e)
        {
            //lấy type câu hỏi mà người dùng chọn thông qua tag của radio button
            RadioButton typeRadio = (RadioButton)sender;
            int typeQuestion = int.Parse(typeRadio.Tag.ToString());
            //gọi hàm thay đổi nút chọn câu trả lời
            updateAnswerQuestionBox(typeQuestion);
        }
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }
        //khi nhấn bất kì button nào trong màn hình
        private void btn_question_click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            //lấy vị trí để thực hiện command thông qua tag
            int commandSlot = int.Parse(control.Tag.ToString());
            //thực hiện command tuognw ứng
            eAQRemote.executeCommand(commandSlot);
        }


        //sự kiện khi mở một context menu strip
        private void menu_interact_richtext_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip contextMenuStrip = sender as ContextMenuStrip;
            //lấy ra control mà đang mở context menu
            Control sourceControl = contextMenuStrip.SourceControl;
            //nếu không có text thì khóa nút copy và nút clear
            if (string.IsNullOrWhiteSpace(sourceControl.Text))
            {
                eAQRemote.executeCommand(16); //16: slot chứa off copy
                eAQRemote.executeCommand(18);//17: slot chứa off clear
            }
            else //ngược lại thì mở khóa
            {
                eAQRemote.executeCommand(13); //13: slot chứa on copy
                eAQRemote.executeCommand(15);//15: slot chứa on clear
            }
            //nếu người dùng không có copy text nào thì ẩn đi nút paste trên menu
            if (string.IsNullOrWhiteSpace(User.getInstance().copiedText))
            {
                eAQRemote.executeCommand(17); //17: slot chứa off paste
            }
            //ngược lại thì mở khóa
            else
            {
                eAQRemote.executeCommand(14);//14: slot chứa on paste
            }

            //gắn command tương ứng với control đang sử dụng context menu strip
            
            //gắn commmand copy text
            eAQRemote.setCommand(new CopyTextCommand(sourceControl), 10); // 10 là vị trí thực hiện copy text

            //gắn command paste text
            eAQRemote.setCommand(new PasteTextCommand(sourceControl), 11); // 11 là vị trí thực hiện paste text

            ///gắn command clear text
            eAQRemote.setCommand(new ClearTextCommand(sourceControl), 12); // 12 là vị trí thực hiện clear text

            
        }
    }
}
