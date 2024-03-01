using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    //trạng thái đang làm bài
    class DoingTestState : TestState
    {
        private Tests test;
        private Timer aTimer;
        private DoTestObserver ob;
        private TimeSpan timecount;
        public DoingTestState(Tests test)
        {
            this.test = test;
            aTimer = new Timer();
        }
        public override void action(DoTestObserver ob)
        {
            
            this.ob = ob;
           
            //lấy ra thời gian làm bài (số phút)
            double totalMinutes = test.Exam.Dotime;
            //chuyển về lại timeSpan để đếm
            timecount = TimeSpan.FromMinutes(totalMinutes); // từ phút chuyển thành TimeSpan dựa theo phút (nếu hơn 59 phút tự đồng chuyển sang định dạng giờ )
            
            //hiển thị lên view lần đầu
            ob.refreshUI($"Bạn còn {timecount.ToString()} để làm bài", 0);
            aTimer.Enabled = false; //đóng trước
            aTimer = new Timer();// tạo mới
            aTimer.Interval = 1000; // ngắt quãng 1s (đếm lùi mỗi 1s)
            aTimer.Tick += new EventHandler(countDownDoTest); //thiết lập sự kiện khi bắt đầu đếm thời gian
            aTimer.Start();//bắt đầu đếm lùi

        }
        //hàm đếm ngược thời gian làm bài và up về giao diện
        private void countDownDoTest(object sender, EventArgs e)
        {
            
            double tmptimecount = timecount.TotalSeconds - 1; /* lấy thời gian trong TimeSpan ra đổi thành giây và trừ đi 1 */
            timecount = TimeSpan.FromSeconds(tmptimecount); /* chuyển nó lại dạng TimeSpan dựa theo số giây */
            //tiếp tục cập nhật giao diện người dùng
            ob.refreshUI($"Bạn còn {timecount.ToString()} để làm bài", 0);
            if (tmptimecount == 0) /* nếu đếm lùi đến 0 thì ngưng đếm */
            {
                aTimer.Stop();
                //tiếp tục chuyển người dùng sang trạng thái hoàn thành
                ob.refreshUI(null, 4); //option 4: là không có dữ liệu trả xuống

            }
        }
    }
}
