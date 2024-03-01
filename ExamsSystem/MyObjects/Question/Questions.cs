using ExamsSystem.Patterns.Visitor.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Question
{
    public abstract class Questions 
    {
        public string Id //mã câu hỏi
        {
            get;set;
        }
        public string Title // tiêu đề câu hỏi (câu hỏi muốn hỏi)
        {
            get;set;
        }
        public List<string> Answers // danh sách câu trả lời
        {
            get;set;
        }
       
        public int TypeQuestion // loại câu hỏi (radio hoặc checkbox)
        {
            get;set;
        }
        public Subjects Subject // thuộc môn nào
        {
            get;set;
        }
        public bool Right //đúng hay sai ? giá trị này được thiết lập khi chấm điểm
        {
            get;set;
        }
        public string Username //chủ câu hỏi
        {
            get;set;
        }
        public Questions (string id, string title ,List<string> answers, int type, Subjects subject,string username)
        {
            Id = id;
            Title = title;
            Answers = answers;
            TypeQuestion = type;
            Subject = subject;
            Username = username;
        }
        abstract public void accept(QuestionsVisitor questionVisitor);
        //prototye
        abstract public Questions Clone();
    }
}
