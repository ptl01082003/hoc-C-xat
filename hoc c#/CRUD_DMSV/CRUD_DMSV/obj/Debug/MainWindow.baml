   M S B A M L   `   `   `  ����D  @CRUD_DMSV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRUD_DMSV	CRUD_DMSV  5   	       CRUD_DMSV.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CRUD_DMSV     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1000��6)   .��5	      � .+�5   
   �� $	��Mã��6   $
��Left=�6   $��	20,27,0,0q�68   $	��Top=�6K   $��37��6c   �� 5   
   $
��Tên��6   $
��Left=�6   $��
315,27,0,0q�69   $	��Top=�6M    J� RenderTransformOrigin$ 4.935,-3.831&�6e   �� 5   
   $��
Ngày sinh��6   $��607,27,312,0q�6$   $	��Top=�6:   $ -0.072,0.647&�6R   �� 5   
   $��Quê Quán ��6   $
��Left=�6$   $��
20,121,0,0q�6?   $	��Top=�6S   �� 5   
   $��Nơi ở��6   $
��Left=�6    $��315,121,0,0q�6;   $	��Top=�6P   �� 5   
   $��Lớp��6   $
��Left=�6   $��607,129,0,0q�69   $	��Top=�6N   �� 5   
   $
��Khoa��6   $
��Left=�6   $��
20,204,0,0q�6:   $	��Top=�6N   $ 0.247,0.725&�6f   �� 5   
   -   5         ��Name$ txtMa��5      $
��Left=�6!   $��23��6<   $��
103,27,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��178��6�   �� 5   
   -   5        $ 
txtQueQuan��5      $
��Left=�6&   $��23��6A   $��103,125,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��178��6�   �� 5   
   -   5        $ txtKhoa��5      $
��Left=�6#   $��23��6>   $��103,207,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��178��6�   �� 5   
   -   5        $ txtTen��5      $
��Left=�6"   $��23��6=   $��
389,27,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��178��6�   �� 5   
   -   5        $ txtNoiO��5      $
��Left=�6#   $��23��6>   $��389,125,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��178��6�   �� 5   
   -   5        $ txtLop��5      $
��Left=�6"   $��23��6=   $��726,129,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��178��6�   $ 3.839,-3.381&�6�   �� 5   
   -   5        $��btnThem��5       $��Thêm��6   $
��Left=�6/   $��
58,700,0,0q�6J   $	��Top=�6^   $��75��6v   6�   �� 5   
   -   5        $��btnXoa��5      $
��Xóa��6   $
��Left=�6-   $��562,700,0,0q�6H   $	��Top=�6]   $��75��6u   6�   �� 5   
   -	   5         ��Name$ btThoat��5      $��Thoát��6"   $
��Left=�62   $��885,700,0,0q�6M   $	��Top=�6b   $ 0.438,1.305&�6z   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ 
dtSinhVien��5      $
��Left=�6(   $	��341��6C   $��
34,291,0,0q�6P   $	��Top=�6d   $	��926��6|   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��
dtNgaySinh��5      $
��Left=�6'   $��
726,26,0,0q�6B   $	��Top=�6V   $	��178��6n   $��27��6z   �� 5    
   -   5        $ btnSua��5       $��Sửa��6   $
��Left=�6/   $��238,700,0,0q�6J   $	��Top=�6_   $��75��6w   $ 
0.893,0.55&�6�   5"      5#      