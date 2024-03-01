using ExamsSystem.BLL;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer.DoTest;
using ExamsSystem.Patterns.StatePattern.Test;
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
    public partial class TestDoForm : Form, DoTestObserver
    {
        private TestsBLL testsBLL;
        private TestsContext testsContext;
        public TestDoForm()
        {
            InitializeComponent();
            testsBLL = new TestsBLL();
            testsContext = new TestsContext(this);
        }

        

        //khi nhấn nút xác nhận
       
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //khi nhấn nút xác nhận thì tiến hành set valid state để kiểm tra mã bài thi có tồn tại hay không
            //lấy ra mã bài thi
            string testidstr = (txt_testid.Text.ToString());
            if (string.IsNullOrWhiteSpace(testidstr))
            {
                testsContext.setState(new DefaultTestState());
            }
            else
            {
                int testid = int.Parse(testidstr);
                testsContext.setState(new CheckingTestState(testid,testsBLL));
            }
            testsContext.actionState();
        }
        public void refreshUI(object data, int option)
        {
            if (option == 0) //nghĩa là nhận được một chuỗi
            {
                string message = (string)data;
                lb_message.Text = message;
            }
            else if (option == 1) //nghĩa là nhận được một đối tượng thuộc nhánh state
            {
                testsContext.setState((TestState)data);
                testsContext.actionState();
            }
            else if (option == 2) //nghĩa là nhận được yêu cầu mở một form và đóng form hiện tại
            {
                Form form = (Form)data;
                
                
                if (form is FinishedDoTestForm)
                {
                    FinishedDoTestForm finishedDoTestForm = (FinishedDoTestForm)data;
                    this.Hide();
                    finishedDoTestForm.ShowDialog();
                    this.Close();
                }
                else
                {

                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
               
            }
        }
        // khi mới load form
        private void TestDoForm_Load(object sender, EventArgs e)
        {
            //set state là default và thực hiện chức năng
            testsContext.setState(new DefaultTestState());
            testsContext.actionState();
        }

        
        private void checkFloatInputTextBox(object sender, KeyPressEventArgs e)//kiểm tra để chỉ cho phép textbox nhập số float
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
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
