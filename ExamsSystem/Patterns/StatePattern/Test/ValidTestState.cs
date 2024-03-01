using ExamsSystem.MyForms;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    //trạng thái bài thi hợp lệ (tiến hành hiển thị form làm bài) và chuyển sang trạng thái đang làm
    class ValidTestState : TestState
    {
        private Tests test;
        public ValidTestState(Tests test)
        {
            this.test = test;
        }
        public override void action(DoTestObserver ob)
        {
            //gắn dữ liệu bài test và chuyển sang trạng thái đang làm bài
            Form form = FormFactory.getInstance().getForm("TestDoing",test);
            
            ob.refreshUI(form,2);
        }
    }
}
