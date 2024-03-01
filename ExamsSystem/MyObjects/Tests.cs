using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    public class Tests
    {
        public String Id { get; set; } //id bài thi
        public Exams Exam { get; set; } // đề thi
        public String Datestart { get; set; }//ngày mở
        public int Openstate { get; set; }
        public string Submittime { get; set; } // thời gian nộp bài
        public string Startdotime { get; set; } // thời gian bắt đầu làm bài
        public Tests(String id, Exams exam, string datestart, int openstate)
        {
            Id = id;
            Exam = exam;
            Datestart = datestart;
            Openstate = openstate;
        }
    }
}
