using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    //trạng thái khi lần đầu người dùng mở vào trang làm bài thi
    class DefaultTestState : TestState
    {
        public DefaultTestState()
        {

        }
        public override void action(DoTestObserver doTestObserver)
        {
            doTestObserver.refreshUI("Vui lòng nhập mã bài thi để tiến hành làm bài", 0);//option: 0 nghĩa là truyền một chuỗi
        }
    }
}
