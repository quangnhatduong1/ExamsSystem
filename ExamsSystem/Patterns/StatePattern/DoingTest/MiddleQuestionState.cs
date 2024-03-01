using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.DoingTest
{
    //trạng thái khi nằm ở các câu hỏi ở giữa
    class MiddleQuestionState : DoTestState
    {
        public MiddleQuestionState(DoTestContext doTestContext) : base(doTestContext)
        {

        }
        public override void clickCell(int cellIndex)
        {
            doTestContext.jumpToQuestion(cellIndex);
            //nếu nhảy đến câu hỏi cuối thì chuyển sang trạng thái câu hỏi cuối
            if (cellIndex == doTestContext.getCountQuestions() - 1)
            {
                doTestContext.changeState(new LastQuestionState(doTestContext));
            }
            //nếu nhảy đến câu hỏi đầu tiên thì chuyển sang trạng thái câu hỏi đầu tiên
            else if(cellIndex == 0)
            {
                doTestContext.changeState(new FirstQuestionState(doTestContext));
            }
        }
        public override void clickNext()
        {
            doTestContext.nextQuestion();
            //nếu next đến câu hỏi cuối thì chuyển sang trạng thái câu hỏi cuối
            if(doTestContext.getCurrentIndex() == doTestContext.getCountQuestions() - 1)
            {
                doTestContext.changeState(new LastQuestionState(doTestContext));
            }
        }
        public override void clickPrevious()
        {
            doTestContext.previousQuestion();
            //nếu previous đến câu hỏi đầu tiên thì chuyển sang câu hỏi đầu tiên
            if (doTestContext.getCurrentIndex() == 0)
            {
                doTestContext.changeState(new FirstQuestionState(doTestContext));
            }
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
