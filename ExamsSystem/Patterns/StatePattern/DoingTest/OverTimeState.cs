using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StatePattern.DoingTest
{
    //hết giờ làm bài
    class OverTimeState : DoTestState
    {
        public OverTimeState(DoTestContext doTestContext) : base(doTestContext)
        {

        }
        public override void clickCell(int cellIndex)
        {
            
        }

        public override void clickNext()
        {
            
        }

        public override void clickPrevious()
        {
           
        }

        public override void clickSubmit()
        {
            
        }

        public override void showAlert()
        {
            //gọi hàm khóa hành động làm bài và đếm ngược thời gian tự động nộp bài
            doTestContext.lockActionDoTest();
        }
    }
}
