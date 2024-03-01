using ExamsSystem.MyForms;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class ShowExamManagerCommand : EAQCommand
    {
        private Form form;
        private List<MyQuestionObserver> observerList;
        private Exams exam;
        public ShowExamManagerCommand(Form form, List<MyQuestionObserver> observerList, Exams exam)
        {
            this.form = form;
            this.observerList = observerList;
            this.exam = exam;
        }
        public void execute()
        {
            QuestionManagerForm questionManagerForm = (QuestionManagerForm) FormFactory.getInstance().getForm("QuestionManager",exam);
            //gắn observer
            foreach(MyQuestionObserver ob in observerList)
            {
                questionManagerForm.setObserver(ob);
            }
            //ẩn form hiển tại
            form.Hide();
            //hiển thị
            questionManagerForm.ShowDialog();
            form.Close();
        }
    }
}
