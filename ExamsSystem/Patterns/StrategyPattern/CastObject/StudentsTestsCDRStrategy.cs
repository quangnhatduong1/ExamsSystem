using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    class StudentsTestsCDRStrategy : CDRStrategy
    {
        public object castDataRow(DataRow dataRow)
        {
            string username = dataRow[0].ToString();
            string testid = dataRow[1].ToString();
            string startdotime = dataRow[2].ToString();
            Console.WriteLine("a: " + startdotime);
            Console.WriteLine("b: " + dataRow[3].ToString());
            //đổi lại thành dạng chuẩn
            startdotime = convertDateDBToString(startdotime);
            string submittime = dataRow[3].ToString();
            submittime = convertDateDBToString(submittime);
            Console.WriteLine("a: " + startdotime);
            Console.WriteLine("b: " + dataRow[3].ToString());
            int rightanswercount = int.Parse(dataRow[4].ToString());
            double score = double.Parse(dataRow[5].ToString());

            return new StudentsTests(username, testid, startdotime, submittime, rightanswercount, score);

        }
        private string convertDateDBToString(string timedb)
        {
            DateTime dateTime = DateTime.ParseExact(timedb, "M/d/yyyy h:mm:ss tt", null);
            string time_dateopen_exact = dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            return time_dateopen_exact;
        }
    }
}
