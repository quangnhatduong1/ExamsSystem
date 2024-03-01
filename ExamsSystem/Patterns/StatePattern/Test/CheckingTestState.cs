using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    //trạng thái kiểm tra bài thi
    class CheckingTestState : TestState
    {
        private int testid;
        private TestsBLL testsBLL;
        private StudentsTestsBLL studentsTestsBLL;
        public CheckingTestState(int testid, TestsBLL testsBLL) // nhận vào một mã testid để tiến hành kiểm tra
        {
            this.testid = testid;
            this.testsBLL = testsBLL;
            this.studentsTestsBLL = new StudentsTestsBLL();
        }
        public override void action(DoTestObserver ob)
        {
            //lấy ra một bài test
            Tests test = testsBLL.getTest(testid);
            if (test == null)
            {
                ob.refreshUI("Mã bài thi không tồn tại, vui lòng thử lại", 0); //option 0: là chuỗi
            }
            else
            {
                //nếu đã có tồn tại thì kiểm tra xem người dùng làm bài chưa ? nếu rồi thì chuyển sang trạng thái hoàn thành luôn
                StudentsTests studentsTests = studentsTestsBLL.getStudentTest(User.getInstance().getAccount().Username, testid);
                
                if(studentsTests != null) //nghĩa là đã có làm bài // chuyển sang trạng thái hoàn thành
                {
                    Console.WriteLine(studentsTests.Score);
                    ob.refreshUI(new FinishedTestState(studentsTests), 1);
                    return;
                }
                //nếu đã đóng chuyển sang trạng thái đóng
                if (test.Openstate == 0)
                {
                    ob.refreshUI(new ClosedTestState(), 1); //option 1: là một đối tượng thuộc nhánh state
                    return;
                }
             
                
                //kiểm tra thời gian
                // nếu thời gian người dùng muốn làm bé hơn thời gian mở bài thi
                //thì kiểm tra xem khoảng cách thời gian
                DateTime currentDatetime = DateTime.Now; // thời gian hiện tại
                string datestart = test.Datestart; //thời gian mở bài ở dạng chuỗi
                DateTime testDatetime = DateTime.ParseExact(datestart, "dd/MM/yyyy HH:mm:ss", null);//thời gian mở bài
                if(currentDatetime < testDatetime)
                {
                    
                    //thông báo là chưa đến giờ làm bài
                    ob.refreshUI(new AwayFromTestState(datestart), 1);
                    return;
                }
                //nếu đã và đang mở chuyển sang trạng thái bài thi hợp lệ
                ob.refreshUI(new ValidTestState(test), 1);
                return;
            }
        }
    }
}
