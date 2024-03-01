using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyData
{
    public class DataProvider
    {
        //thiết kế cấu trúc Singleton -- vì cấu trúc này sử dụng biến biến tĩnh static (khởi tạo một lần và nó sẽ lưu mãi) nên ta đỡ mất công khởi tạo
        //cũng như tránh trường hợp bị lỗi
        //cách sử dụng bên ngoài: gọi DataProvider.Instance. các phương thức trong hàm ví dụ: DataProvider.Instance.ExecuteQuery(a,b)
        //lúc này phương thức tĩnh Instance được gọi, khởi tạo instance kiểu Provider nếu nó null và trả về instance, do đó mới sử dụng được các phương thức trong đây
        //vậy lợi ích là bên ngoài ta không cần phải khởi tạo biến DataProvider vì trong đây đã khởi tạo và gán cho biến tĩnh instance và biến nãy sẽ lưu đến khi thoát chương trình
        private static DataProvider instance; //tạo một biến static kiểu DataProvider
        private DataProvider() { }
        public static DataProvider Instance()
        {
            if(instance == null){
                instance = new DataProvider();
            }
            return instance;
        }
        

        private string connectionName = @"Data Source=.;Initial Catalog=exammanager;Integrated Security=True";
        public DataTable ExecuteQuery(string querystring, object[] parameter = null)
        {
            DataTable dataTable = new DataTable(); //vì dữ liệu sẽ trả về ở dạng dataset(datatable) nên ta phải tạo kiểu DataTable để chứa
            //sử dụng using để giải phóng bộ nhớ, tránh lỗi
            using (SqlConnection conn = new SqlConnection(connectionName))
            {
                conn.Open(); // mở kết nối -- nhớ đóng khi truy vấn xong
                SqlCommand command = new SqlCommand(querystring, conn); //Thực hiện câu truy vấn
                if (parameter != null) //custom lại phần này -- cho phép ta truyền tham số một cách linh hoạt -- xem trong link tường nhà fb của microsoft
                {
                    string[] arrPara = querystring.Split(' '); //câu truy vấn để cho nó linh hoạt nó sẽ có dạng giá trị = @giatri nói chung là chỗ nào mà ta muốn thêm giá trị để truy vấn cứ đặt là @tengiatri
                    //khi đó ta chỉ cần xác định chỗ nào @giatri thì ta sẽ thay bằng giá trị trong mảng parameter
                    // do đó ta sài Split cắt chuỗi query thành một mảng phân biệt bởi dấu khoảng trắng, và ta cho chạy vòng lặp foreach 
                    //cái mảng chuỗi ta thu được từ việc cắt để tìm những chỗ nào có @ thì thêm giá trị trong mảng parameter vào chỗ đó
                    int i = 0;
                    foreach (string val in arrPara) //duyệt mảng chuỗi query vừa cắt được
                    {
                        if (val.Contains('@')) //nếu chỗ nào có @ thì chỗ đó là giá trị cần thêm
                        {
                            command.Parameters.AddWithValue(val, parameter[i]); //thêm giá trị vào chỗ có @
                            i++; //tăng i để đến giá trị cho lần khác
                        }
                    }


                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);//lấy dữ liệu từ câu truy vấn
                sqlDataAdapter.Fill(dataTable);//truyền dữ liệu trả về cho dataTable
                conn.Close(); //đóng kết nối khi truy vấn xong
            }
            return dataTable;
        }
        public int ExecuteNonQuery(string querystring, object[] parameter = null) //hàm này dành cho việc update, delete, insert
                                                                                  //chỉ trả về số dòng thành công
        {
            int data = 0; //chứa dữ liệu số dòng được thực hiện db thành công
            //sử dụng using để giải phóng bộ nhớ, tránh lỗi
            using (SqlConnection conn = new SqlConnection(connectionName))
            {
                conn.Open(); // mở kết nối -- nhớ đóng khi truy vấn xong
                SqlCommand command = new SqlCommand(querystring, conn);
                if (parameter != null) //custom lại phần này -- cho phép ta truyền tham số một cách linh hoạt -- xem trong link tường nhà fb của microsoft
                {
                    string[] arrPara = querystring.Split(' '); //câu truy vấn để cho nó linh hoạt nó sẽ có dạng giá trị = @giatri nói chung là chỗ nào mà ta muốn thêm giá trị để truy vấn cứ đặt là @tengiatri
                    //khi đó ta chỉ cần xác định chỗ nào @giatri thì ta sẽ thay bằng giá trị trong mảng parameter
                    // do đó ta sài Split cắt chuỗi query thành một mảng phân biệt bởi dấu khoảng trắng, và ta cho chạy vòng lặp foreach 
                    //cái mảng chuỗi ta thu được từ việc cắt để tìm những chỗ nào có @ thì thêm giá trị trong mảng parameter vào chỗ đó
                    int i = 0;
                    foreach (string val in arrPara) //duyệt mảng chuỗi query vừa cắt được
                    {
                        if (val.Contains('@')) //nếu chỗ nào có @ thì chỗ đó là giá trị cần thêm
                        {
                            command.Parameters.AddWithValue(val, parameter[i]); //thêm giá trị vào chỗ có @
                            i++; //tăng i để đến giá trị cho lần khác
                        }
                    }


                }

                data = command.ExecuteNonQuery(); //thực hiện truy vấn và trả về số dòng thành công
                conn.Close(); //đóng kết nối khi truy vấn xong
            }
            return data;
        }

        //phương thức này thực hiện truy vấn lấy dữ liệu nhưng chỉ lấy dòng đầu tiên
        public object ExecuteScalar(string querystring, object[] parameter = null)
        {
            object data = 0; //chứa 1 dòng dữ liệu lấy được
            //sử dụng using để giải phóng bộ nhớ, tránh lỗi
            using (SqlConnection conn = new SqlConnection(connectionName))
            {
                conn.Open(); // mở kết nối -- nhớ đóng khi truy vấn xong
                SqlCommand command = new SqlCommand(querystring, conn);
                if (parameter != null) //custom lại phần này -- cho phép ta truyền tham số một cách linh hoạt -- xem trong link tường nhà fb của microsoft
                {
                    string[] arrPara = querystring.Split(' '); //câu truy vấn để cho nó linh hoạt nó sẽ có dạng giá trị = @giatri nói chung là chỗ nào mà ta muốn thêm giá trị để truy vấn cứ đặt là @tengiatri
                    //khi đó ta chỉ cần xác định chỗ nào @giatri thì ta sẽ thay bằng giá trị trong mảng parameter
                    // do đó ta sài Split cắt chuỗi query thành một mảng phân biệt bởi dấu khoảng trắng, và ta cho chạy vòng lặp foreach 
                    //cái mảng chuỗi ta thu được từ việc cắt để tìm những chỗ nào có @ thì thêm giá trị trong mảng parameter vào chỗ đó
                    int i = 0;
                    foreach (string val in arrPara) //duyệt mảng chuỗi query vừa cắt được
                    {
                        if (val.Contains('@')) //nếu chỗ nào có @ thì chỗ đó là giá trị cần thêm
                        {
                            command.Parameters.AddWithValue(val, parameter[i]); //thêm giá trị vào chỗ có @
                            i++; //tăng i để đến giá trị cho lần khác
                        }
                    }


                }

                data = command.ExecuteScalar(); //thực hiện truy vấn và trả về 1 cột dữ liệu của 1 dòng đầu tiên
                
                Console.WriteLine(data.ToString());
                conn.Close(); //đóng kết nối khi truy vấn xong
            }
            return data;
        }
    }
}
