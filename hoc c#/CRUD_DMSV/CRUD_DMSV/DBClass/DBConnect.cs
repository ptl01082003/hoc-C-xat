using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRUD_DMSV.DBClass
{
    class DBConnect
    {
        static string chuoiketnoi = @"Server = DESKTOP-FRJB18B\SQLEXPRESS;" +
            "Initial Catalog = DMSV ; Integrated Security = True;User Id=sa ; Password=123;";

        public object SQLCONNECTION { get; private set; }

      public   DataTable ketquadangnhap(string taikhoan, string matkhau)
        {
            DataTable dt = new DataTable();
            try
            {
                
                SqlConnection connection = new SqlConnection(chuoiketnoi); // mở kết nối trong chuỗi kết nối ở dòng 13
                connection.Open();// mở keets nối 
                string sql = "SELECT * FROM DMUSER WHERE TENDANGNHAP = '" + taikhoan + "' AND MATKHAU = '" + matkhau + "'";

                SqlCommand command = new SqlCommand(sql, connection);// thực hiện câu lệnh với chuỗi kết nối ở trên 
                SqlDataReader dataReader = command.ExecuteReader();// đọc dữ liệu lên Reader
                dt.Load(dataReader); // gán dữ liệu vào datatable
                connection.Close(); //đóng kết nối để tránh tốn tài nguyên 

                return dt;
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại ");
                return dt;
            }

            //Hàm để lấy dieux liệu tuef câu lệnh Sql = "Select" để lấy thông tin lên 
           
        }

  
        public DataTable Sql_Select(string sql_query)
        {
            DataTable dt = new DataTable();
            //mở kết nối 
            SqlConnection sql_conn = new SqlConnection(chuoiketnoi);
            if(sql_conn.State == ConnectionState.Closed)
            sql_conn.Open();
            SqlCommand sql_cmd = new SqlCommand(sql_query, sql_conn);
            SqlDataReader sql_dr = sql_cmd.ExecuteReader();
            dt.Load(sql_dr);
            //đóng kết nối 
            sql_conn.Close();
            return dt;
        }
        public void Sql_Insert_Delete_Update(string sql_query)
        {
            SqlConnection sql_conn = new SqlConnection(chuoiketnoi);
            if (sql_conn.State == ConnectionState.Closed)
                sql_conn.Open();
            try
            {
                ///thực hiện câu lệnh sql
                SqlCommand sql_cmd = new SqlCommand(sql_query, sql_conn);
                int sql_status = sql_cmd.ExecuteNonQuery();
                //đóng kết nối 
                sql_conn.Close();
            }
            catch
            {
                MessageBox.Show("Thao tác bị lỗi");
            }

        }

    }
     
}
