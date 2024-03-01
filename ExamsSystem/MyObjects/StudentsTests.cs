using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    class StudentsTests
    {
        public StudentsTests(string username, string testid, string startdotime, string submittime, int rightanswercount, double score)
        {
            Username = username;
            Testid = testid;
            Startdotime = startdotime;
            Submittime = submittime;
            Rightanswercount = rightanswercount;
            Score = score;
        }

        public string Username { get; set; }
        public string Testid { get; set; }
        public string Startdotime { get; set; }
        public string Submittime { get; set; }
        public int Rightanswercount { get; set; }
        public double Score { get; set; }
    }
}
