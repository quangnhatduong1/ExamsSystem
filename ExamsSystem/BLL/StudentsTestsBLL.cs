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
    class StudentsTestsBLL

    {
        private StudentsTestsDAL studentsTestsDAL;
        private MyCastObject myCastObject;
        private CastObjectFactory getCast;
        public StudentsTestsBLL()
        {
            studentsTestsDAL = new StudentsTestsDAL();
            getCast = new CastObjectFactory();
            myCastObject = new MyCastObject();
            myCastObject.setCDRStrategy(getCast.getCastObject("StudentsTests"));
        }
        //lấy danh sách các học sinh thi một bài thi
        public DataTable getStudentsByTestsId(int testid)
        {
            return studentsTestsDAL.getStudentsByTestsId(testid);
        }
        //lưu thông tin thực hiện một bài thi
        public int saveDoTest(string username, int testid, string startdotime, string submittime, int rightanswercount, double score)
        {
            //chuyển thông tin thời gian về lại dạng MM/dd/yyyy HH:mm:ss để thêm vào csdl
            startdotime = DateTime.ParseExact(startdotime, "dd/MM/yyyy HH:mm:ss", null).ToString("MM/dd/yyyy HH:mm:ss");
            submittime = DateTime.ParseExact(submittime, "dd/MM/yyyy HH:mm:ss", null).ToString("MM/dd/yyyy HH:mm:ss");
            return studentsTestsDAL.saveDoTest(username, testid, startdotime, submittime, rightanswercount, score);
        }
        //lấy thông tin của một học sinh làm bài thi
        public StudentsTests getStudentTest(string username, int testid)
        {
            DataRow dataGet = studentsTestsDAL.getStudentTest(username, testid);
            if (dataGet == null) { return null; }
            return (StudentsTests)myCastObject.CastDataRowToObject(dataGet);
        }
        //lấy kết quả làm bài dựa theo giá trị tìm kiếm
        public DataTable getResultTestsBySearch(int field, string username, object valuesearch)
        {
            if(field == 0) //mặc định
            {
                //Không tìm kiếm theo giá trị nào => chỉ tìm theo username
                return studentsTestsDAL.getResultTest(username);
            }
            else if(field == 1) //theo mã bài thi
            {
                int testid = 0; // cho một giá trị 0 để lỗi thì tìm theo giá trị này
                try
                {
                    testid = int.Parse(valuesearch.ToString());
                }
                catch
                {
                    testid = 0;
                }
                return studentsTestsDAL.getReSultTestByTestid(username, testid);
            }
            else if(field == 2) // theo môn học
            {
                return studentsTestsDAL.getReSultTestBySubject(username, valuesearch.ToString());
            }
            return new DataTable();
        }
    }
}
