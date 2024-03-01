using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    class TestsCDRStrategy : CDRStrategy
    {
       
        public object castDataRow(DataRow dataRow)

        {
            ExamsBLL examsBLL = new ExamsBLL();
            if (dataRow == null) { return null; }
            string id = dataRow[0].ToString();
            int examid = int.Parse(dataRow[1].ToString());
            string timedb = dataRow[2].ToString();
            //chuyển định dạng thời gian trong db thành dd/MM/yyyy HH:mm:ss
            string datestart = convertDateDBToString(timedb);
            int openstate = int.Parse(dataRow[3].ToString());
            //dựa vào examid lấy ra một đối tượng Exams
            Exams exam = examsBLL.getExam(examid);
            Console.WriteLine(datestart);
            return new Tests(id, exam, datestart, openstate);
        }
        private string convertDateDBToString(string timedb)
        {
            DateTime dateTime = DateTime.ParseExact(timedb, "M/d/yyyy h:mm:ss tt", null);
            string time_dateopen_exact = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            return time_dateopen_exact;
        }
    }
}
