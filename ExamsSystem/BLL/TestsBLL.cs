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
    class TestsBLL
    {
        private TestsDAL testsDAL;
        private MyCastObject myCastObject;
        private CastObjectFactory getCast;
        public TestsBLL()
        {
            this.testsDAL = new TestsDAL();
            getCast = new CastObjectFactory();
            

        }
        //thêm một test
        public int insertTest(int examid, string datestart, int openstate)
        {
           
            return testsDAL.insertTest(examid, datestart, openstate);
        }
        //lấy danh sách bài tests
        public DataTable getTestsList(string field_subject, int field_openstate)
        {
            return testsDAL.getTestsList(field_subject,field_openstate);
        }
        //lấy một bài test dựa vào id
        public Tests getTest(int id)
        {
            myCastObject = new MyCastObject();
            myCastObject.setCDRStrategy(getCast.getCastObject("Tests"));
            DataRow dataRow = testsDAL.getTest(id);
            return (Tests) myCastObject.CastDataRowToObject(dataRow);
        }
        //lấy giá trị count testid từ bảng students_tests để kiểm tra xem bài thi có được áp dụng (được làm hay chưa)
        public int getCountStudentsTest(int testid)
        {
            DataRow dataRow = testsDAL.getCountStudentsTest(testid);
            //nếu null nghĩa là chưa có ai làm return 0
            if (dataRow == null) { return 0; }
            // hàng này chỉ có 1 cột là giá trị count mình cần tìm
            int countest = int.Parse(dataRow[0].ToString());
            return countest;
        }
        //cập nhật một bài thi
        public int updateTest(int examid, string datestart, int openstate, int testid)
        {
            return testsDAL.updateTest(examid, datestart, openstate, testid);
        }
        //xóa một bài test
        public int deleteTest(int testid)
        {
            return testsDAL.deleteTest(testid);
        }
       
    }
}
