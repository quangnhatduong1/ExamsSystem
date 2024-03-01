using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    public class ExamsCDRStrategy : CDRStrategy
    {
        public object castDataRow(DataRow dataRow)
        {
            QuestionsBLL questionsBLL = new QuestionsBLL();
            MyCastObject myCastObject = new MyCastObject();
            myCastObject.setCDRStrategy(new QuestionsCDRStrategy());
            //id bài exam
            string id = dataRow[0].ToString();
            //tên chủ sở hữu
            string username = dataRow[1].ToString();
            //mã môn học
            string subjectid = dataRow[2].ToString();
            //tên môn học
            string subjectname = dataRow[3].ToString();
            //tình trạng
            int checkout = int.Parse(dataRow[4].ToString());
            //thời gian làm bài
            int dotime = int.Parse(dataRow[5].ToString());

            //chuẩn bị dữ liệu môn học
            Subjects subject = new Subjects(subjectid, subjectname);

            //lấy danh sách câu hỏi dựa theo id của đề thi
            List<Questions> questions = new List<Questions>();
            DataTable dataGet = questionsBLL.getQuestionsListByExamsId(int.Parse(id));
            foreach(DataRow data in dataGet.Rows)
            {
                //cast dataRow thành một Questions object
                questions.Add((Questions)myCastObject.CastDataRowToObject(data));
            }

            //tạo một đối tượng Exam
            Exams exam = new Exams(id, username, subject, checkout, dotime, questions);
            return exam;
        }
    }
}
