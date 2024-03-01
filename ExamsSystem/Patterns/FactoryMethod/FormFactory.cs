using ExamsSystem.MyForms;
using ExamsSystem.MyForms.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.FactoryMethod
{
    class FormFactory
    {
        private static FormFactory instance;
        public static FormFactory getInstance()
        {
            if (instance == null)
            {
                instance = new FormFactory();
            }
            return instance;
        }
        //trả về form không có thiết lập dữ liệu
        public Form getForm(string formName)
        {
            switch (formName)
            {
                case "Login":
                    return new LoginForm();
                    break;
                case "Home":
                    return new HomeForm();
                    break;
                case "AccountManager":
                    return new AccountManagerForm();
                    break;
                case "Register":
                    return new RegisterForm();
                    break;
                case "PasswordChange":
                    return new PasswordChangeForm();
                    break;
                case "ExamManager":
                    return new ExamManagerForm();
                    break;
                case "CreateExam":
                    return new CreateExamForm();
                    break;
                case "CreateQuestion":
                    return new CreateQuestionForm();
                case "CreateTest":
                    return new CreateTestForm();
                case "TestManager":
                    return new TestManagerForm();
                case "TestDo":
                    return new TestDoForm();
                case "TestsResult":
                    return new TestsResultForm();
                case "QuestionManager":
                    return new QuestionManagerForm();
                case "ReportManager":
                    return new ReportManagerForm();
                case "TestResultReport":
                    return new TestResultReportForm();
                default:
                    return null;
            }
        }
        //trả về form có thiết lập dữ liệu
        public Form getForm(string formName, object data)
        {
            switch (formName)
            {
                
                case "AccountDetails":
                    return new AccountDetailsForm(data);
                    break;
                case "ExamDetails":
                    return new ExamDetailsForm(data);
                    break;
                case "CreateQuestion":
                    return new CreateQuestionForm(data);
                case "TestDetails":
                    return new TestDetailsForm(data);
                case "TestDoing":
                    return new TestDoingForm(data);
                case "FinishedDoTest":
                    return new FinishedDoTestForm(data);
                case "QuestionDetails":
                    return new QuestionDetailsForm(data);
                case "QuestionManager":
                    return new QuestionManagerForm(data);
                case "ReviewDataTabe":
                    return new ReviewDataTabeForm(data);
                default:
                    return null;
            }
        }
    }
}
