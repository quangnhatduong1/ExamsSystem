using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.DoingTest
{
    //trạng thái khi ở câu hỏi cuối cùng
    class LastQuestionState : DoTestState
    {
        public LastQuestionState(DoTestContext doTestContext): base(doTestContext)
        {

        }
        public override void clickCell(int cellIndex)
        {
            doTestContext.jumpToQuestion(cellIndex);
            //nếu đến câu hỏi đầu tiên thì chuyển sang trạng thái câu hỏi đầu tiên
            if (cellIndex == 0)
            {
                doTestContext.changeState(new FirstQuestionState(doTestContext));
            }
            //nếu đến câu hỏi cuối thì chuyển sang trang thái đang ở câu hỏi cuối
            else if (cellIndex == doTestContext.getCountQuestions() - 1)
            {
                doTestContext.changeState(new LastQuestionState(doTestContext));
            }
            //ngược lại thì chuyển sang middle
            else
            {
                doTestContext.changeState(new MiddleQuestionState(doTestContext));
            }
        }
        //ở câu hỏi cuối cùng nếu click lần nữa thì hiển thị thông báo nộp bài
        public override void clickNext()
        {
            //hiển thị thông báo nộp bài
            DialogResult dialogResult = createMessageBoxYesNo("Đã đến câu hỏi cuối cùng, bạn có muốn nộp bài không ?", "Thông báo");
            if(dialogResult == DialogResult.Yes)
            {
                doTestContext.submitTest();
            }
        }
        public override void clickPrevious()
        {
            doTestContext.previousQuestion();
            //chuyển sang trạng thái middle
            doTestContext.changeState(new MiddleQuestionState(doTestContext));
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
