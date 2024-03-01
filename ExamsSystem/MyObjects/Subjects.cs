using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    //môn học
    public class Subjects
    {
        public Subjects(string subjectId, string subjectName)
        {
            SubjectID = subjectId;
            SubjectName = subjectName;
        }
        public string SubjectID
        {
            get;set;
        }
        public string SubjectName
        {
            get;set;
        }
        public Subjects clone()
        {
            return (Subjects)this.MemberwiseClone();
        }
    }
}
