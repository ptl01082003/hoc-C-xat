using CRUD_DMSV.DBClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRUD_DMSV.model
{
   public class SinhVien
    {
                // khai báo các thuộc tính 
        public string ma { get ; set; }
        public string ten { get; set; }
        public DateTime ngaySinh { get; set; }
        public string queQuan { get; set; }
        public string noiO { get; set; }
        public string lop { get; set; }
        public string khoa { get; set; }

        //khai báo các phương thức 
        DBConnect dBConnect = new DBConnect(); // biến toán cục cho lớp nhân viên được lấy từ lớp dbconmect
        public DataTable LayThongTinSinhVien()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Sinh_Vien";
            dt = dBConnect.Sql_Select(sql);
    
            return dt;//SỬ DỤNG  dt để quản lý để đưa lên CBB, DataGrid
        }
        //Viết hàm để có thể thêm, xóa , sửa  sinhVien
        public void themsinhvien(SinhVien sv)
        { 
            //Khai bảo lớp đối tượng Data Access Object 
            //GỌi hàm và viết câu lệnh Xóa dữ liệu
            try
            {
                string sqlformat = " SET DATEFORMAT DMY ";
                dBConnect.Sql_Insert_Delete_Update(sqlformat);
              string sql = sqlformat + " INSERT INTO Sinh_Vien (MA_SV, TEN_SV, Ngay_sinh, Que_quan, Noi_o, Lop,Khoa)" + 
                    " VALUES ('" + sv.ma + "',N'" + sv.ten + "','" + sv.ngaySinh + "',N'" + sv.queQuan + "'," +
                    "N'" + sv.noiO + "','" + sv.lop + "',N'" + sv.khoa + "')  ";
                dBConnect.Sql_Insert_Delete_Update(sql);

            }
            catch
            {
                MessageBox.Show("Thao tác bị lỗi");
            }
        }
        public void suanhanvien(SinhVien sv)
        {
            //Khai bảo lớp đối tượng Data Access Object
            // GỌi hàm và viết câu lệnh Xóa dữ liệu
            try
            {
                string sqlformat = " SET DATEFORMAT DMY ";
                dBConnect.Sql_Insert_Delete_Update(sqlformat);
                string sql = sqlformat + " UPDATE  Sinh_Vien SET TEN_SV = N'" + sv.ten + "'," + "Ngay_sinh = '" + sv.ngaySinh + "'," + "Que_quan = N'" + sv.queQuan + "'," + "Noi_o = N'" + sv.noiO + "'" +
                    "," + "Lop = '" + sv.lop + "'," + "Khoa = N'" + sv.khoa + "' WHERE MA_SV = '" + sv.ma + "'";
                dBConnect.Sql_Insert_Delete_Update(sql);

            }
            catch
            {
                MessageBox.Show("Thao tác bị lỗi");
            }
        }
        public void xoasinhvien(string masv)
        {
            //Khai bảo lớp đối tượng Data Access Object 
            //GỌi hàm và viết câu lệnh Xóa dữ liệu
            try
            {
                string sql = "DELETE FROM Sinh_Vien WHERE MA_SV ='" + masv + "'";
                dBConnect.Sql_Insert_Delete_Update(sql);
            }
            catch
            {
                MessageBox.Show("xóa bị lỗi");
            }
        }

    }
}
