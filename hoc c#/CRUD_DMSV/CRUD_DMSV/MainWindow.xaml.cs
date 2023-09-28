using CRUD_DMSV.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CRUD_DMSV.DBClass;
using System.Data;

namespace CRUD_DMSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SinhVien sv = new SinhVien();//khai báo toàn cục
        public MainWindow()
        {
            InitializeComponent();
            loadthongtin();

        }
        // hàm để lấy giá trị từ các điểu khiển trên form gán vào class nhân viên
        private void khoitaosinhvien()
        {   
            if(txtMa.Text !="")
                sv.ma = txtMa.Text;
            if (txtTen.Text != "")
                sv.ten = txtTen.Text;
            if (dtNgaySinh.Text != "")
                sv.ngaySinh = Convert.ToDateTime(dtNgaySinh.Text.Trim()).Date;
            if (txtQueQuan.Text != "")
                sv.queQuan = txtQueQuan.Text;
            if (txtNoiO.Text != "")
                sv.noiO = txtNoiO.Text;
            if (txtLop.Text != "")
                sv.lop = txtLop.Text;
            if (txtKhoa.Text != "")
                sv.khoa = txtKhoa.Text;
        }
        private void loadthongtin()
        {
           dtSinhVien.ItemsSource = sv.LayThongTinSinhVien().DefaultView;
        }

        private void dtNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)// sự lụa chọn thay đổi của datagrid
        {
            if(dtSinhVien.SelectedIndex.ToString() != null)// nếu Dtgrid có dòng được chọn
            {
                DataRowView drv = (DataRowView)dtSinhVien.SelectedItem;
                if (drv != null)
                {
                    txtMa.Text = drv["MA_SV"].ToString();
                    txtTen.Text = drv["TEN_SV"].ToString();
                    dtNgaySinh.Text = drv["Ngay_sinh"].ToString();
                    txtQueQuan.Text = drv["Que_quan"].ToString();
                    txtNoiO.Text = drv["Noi_o"].ToString();
                    txtLop.Text = drv["Lop"].ToString();
                    txtKhoa.Text = drv["Khoa"].ToString();
                }
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            khoitaosinhvien();
            sv.themsinhvien(sv);
            loadthongtin();

        }

    
        


        private void btnXoa_Click_1(object sender, RoutedEventArgs e)
        {
             if(txtMa.Text != "")// kiểm tra xem mã nhân viên có dữ liệu chưa 
                        sv.xoasinhvien(txtMa.Text);
                        loadthongtin();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            khoitaosinhvien();
            sv.suanhanvien(sv);
            loadthongtin();
        }
    }
}
