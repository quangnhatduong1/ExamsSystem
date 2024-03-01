using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.DoingTest
{
    //trạng thái khi ở câu hỏi đầu tiên
    class FirstQuestionState : DoTestState
    {
        public FirstQuestionState(DoTestContext doTestContext) : base(doTestContext)
        {

        }
        public override void clickCell(int cellIndex)
        {
            doTestContext.jumpToQuestion(cellIndex);
            //nếu đến câu hỏi đầu tiên thì chuyển sang trạng thái câu hỏi đầu tiên
            if(cellIndex == 0)
            {
                doTestContext.changeState(new FirstQuestionState(doTestContext));
            }
            //nếu đến câu hỏi cuối thì chuyển sang trang thái đang ở câu hỏi cuối
            else if(cellIndex == doTestContext.getCountQuestions() - 1)
            {
                doTestContext.changeState(new LastQuestionState(doTestContext));
            }
            //ngược lại thì chuyển sang middle
            else
            {
                doTestContext.changeState(new MiddleQuestionState(doTestContext));
            }
        }
        public override void clickNext()
        {
            doTestContext.nextQuestion();
            //chuyển sang trạng thái middle
            doTestContext.changeState(new MiddleQuestionState(doTestContext));
        }
        //trạng thái ở câu hỏi đầu thì không cho previous
        public override void clickPrevious()
        {
           
        }
        public override void clickSubmit()
        {
            doTestContext.submitTestConfirm();
        }
        public override void showAlert()
        {
            
        }
    }
}
