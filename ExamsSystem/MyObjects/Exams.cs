using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    public class Exams
    {
        public string Id // mã bài thi
        {
            get; set;
        }
        public string Username // người tạo
        {
            get; set;
        }
        public Subjects Subject // môn học
        {
            get;set;
        }
        public int Checkout // trạng thái kiểm duyệt
        {
            get;set;
        }
        public int Dotime // thời gian làm bài
        {
            get;set;
        }
        public int Questionscount //số lượng câu hỏi
        {
            get;set;
        }
        public List<Questions> Questions // danh sách câu hỏi
        {
            get;set;
        }

        public Exams(string id, string username, Subjects subject, int checkout, int dotime, List<Questions> questions)
        {
            Id = id;
            Username = username;
            Subject = subject;
            Checkout = checkout;
            Dotime = dotime;
            Questionscount = questions.Count;
            Questions = questions;

        }


        public Exams Clone() //clone một bài thi với một số thuộc tính thay đổi khác với ban đầu (id và người sở hữu)
        {
            Exams newExams = (Exams) this.MemberwiseClone();
            newExams.Id = null;
            newExams.Username = null;
            newExams.Checkout = 0;
            newExams.Subject = newExams.Subject.clone();
            List<Questions> questlist = new List<Questions>();
            foreach(Questions question in newExams.Questions)
            {
                questlist.Add(question);
            }
            newExams.Questions = questlist;
            return newExams;
        }
        public void addQuestion(Questions question)
        {
            Questions.Add(question);
            Questionscount = Questions.Count;
        }
        public void deleteQuestion(int index)
        {
            Questions.RemoveAt(index);
            Questionscount = Questions.Count;
        }

    }
}
