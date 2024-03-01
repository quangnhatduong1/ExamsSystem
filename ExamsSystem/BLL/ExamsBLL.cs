using ExamsSystem.DAL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.StrategyPattern.CastObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.BLL
{
    class ExamsBLL
    {
        private ExamsDAL examsDAL;
        private MyCastObject myCastObject;
        private CastObjectFactory getCast;
        public ExamsBLL()
        {
            examsDAL = new ExamsDAL();
            getCast = new CastObjectFactory();
            myCastObject = new MyCastObject();
            myCastObject.setCDRStrategy(getCast.getCastObject("Exams"));
        }
        //chèn một đề thi
        public int insertExam(string username, int subjectid, int checkout, int dotime)
        {
            return examsDAL.insertExam(username, subjectid, checkout, dotime);
        }
        //chèn một đề thi và nhận về id của chính nó
        public int insertExamAndGetIt(string username, int subjectid, int checkout, int dotime)
        {
            DataRow dataRow = examsDAL.insertExamAndGetIt(username, subjectid, checkout, dotime);
            int examid = int.Parse(dataRow[0].ToString());
            return examid;
        }
        //lấy danh sách đề thi
        public DataTable getExamsList(string field_subject, string field_username)
        {
            return examsDAL.getExamsList(field_subject,field_username);
        }
        //lấy danh sách đề thi đã được duyệt
        public DataTable getCheckedExamsList(int examid)
        {
            return examsDAL.getCheckedExamsList(examid);
        }
        //lấy một đề thi
        public Exams getExam(int id)
        {
            DataRow dataRow = examsDAL.getExam(id);
            return (Exams)myCastObject.CastDataRowToObject(dataRow);
        }
        //chèn một câu hỏi vào đề thi
        public int insertQuestionToExam(int examid, int questionid)
        {
            return examsDAL.insertQuestionToExam(examid, questionid);
        }
        //update một câu hỏi vào đề thi (thay thế vị trí đã có thành một id câu hỏi khác)
        public int updateQuestionToExam(int examid, int oldquestionid, int newquestionid)
        {
            return examsDAL.updateQuestionToExam(examid, oldquestionid, newquestionid);
        }
        //xóa một câu hỏi ra khỏi đề thi (xóa liên kết trong bảng exams_questions)
        public int deleteQuestionToExam(int examid, int questionid)
        {
            return examsDAL.deleteQuestionToExam(examid, questionid);
        }
        //update thời gian làm bài của đề thi
        public int updateExamDotime(int examid, int dotime)
        {
            return examsDAL.updateExamDotime(examid, dotime);
        }
        //update trạng thái duyệt của đề thi
        public int updateExamCheckout(int examid, int checkout)
        {
            if (checkout == 0) //nếu người dùng bỏ duyệt thì phải kiểm tra xem đề thi
                               // này đã được thi chưa ? nếu rồi thì không thể bỏ duyệt
            {
                //lấy số lần xuất hiện của examid trong bảng tests để kiểm tra xem
                //exam này được áp dụng hay chưa ?
                int countExist = getExamsCountInTests(examid);
                if(countExist > 0) //nếu lớn hơn không thì đã được áp dụng do đó bắn ra lỗi
                {
                    throw new Exception("Đề thi này đã được áp dụng nên không thể xóa được");
                }
            }
            return examsDAL.updateExamCheckout(examid, checkout);
        }
        //hàm xóa đề thi
        public int deleteExam(int examid)
        {
            //không cần kiểm tra nhiều
            //bởi vì nếu đề thi được áp dụng thì nút xóa cũng bị ẩn không thể xóa được

            //xóa toàn bộ câu hỏi trong bảng exams_questions
            int deleteQuestions = examsDAL.deleteAllExamQuestions(examid);
            //xóa đề thi
            return examsDAL.deleteExam(examid);
        }
        //hàm trả về một row chứa số lần xuất hiện của examid trong bảng test
        // để kiểm tra xem exam đã được áp dụng hay chưa ? (tức là đã được đem vào tổ chức thi chưa)
        public int getExamsCountInTests(int examid)
        {
            
            DataRow dataRow=  examsDAL.getExamsCountInTests(examid);
            //lấy ra số lần xuất hiện
            int count = int.Parse(dataRow[0].ToString());
            return count;
        }
    }
}
