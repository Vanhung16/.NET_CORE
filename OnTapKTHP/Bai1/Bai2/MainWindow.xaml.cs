using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Bai2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NhanvienDBContext db = new NhanvienDBContext();

        public object PropertiesInfo { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            var query = from nv in db.Nhanviens
                        where nv.Songaycong >= 25
                        orderby nv.Songaycong ascending
                        select new
                        {
                            nv.MaNv,
                            nv.MaPhong,
                            nv.Luong,
                            nv.Hoten,
                            nv.Songaycong,
                            Thuong = nv.Luong * (nv.Songaycong >= 27 ? 0.1 : 0),
                        };
            dgnhanvien.ItemsSource = query.ToList();
        }
        public void hienthiPhongBan()
        {
            var query = from pb in db.PhongBans
                        select pb;
            cboMaPhong.ItemsSource = query.ToList();
            cboMaPhong.DisplayMemberPath = "TenPhong";
            cboMaPhong.SelectedValuePath = "MaPhong";
            cboMaPhong.SelectedIndex = 0;
        }
        public bool checkData()
        {
            bool check = true;
            string Hoten = txtHoten.Text;
            string Manv = txtManv.Text;
            string Songaycong = txtSongaycong.Text;
            string Luong = txtLuong.Text;

            if (!Regex.IsMatch(Hoten, "^[a-zA-Z ]+$"))
            {
                check = false;
                errHoten.Content = "Họ tên phải nhập bằng xâu ký tự";
            }
            else
            {
                errHoten.Content = "";
            }
            if (!Regex.IsMatch(Manv, "^\\d{1,}$"))
            {
                check = false;
                errManv.Content = "Mã nhân viên phải là số";
            }
            else
            {
                errManv.Content = "";
            }
            if (!Regex.IsMatch(Songaycong, "^\\d{1,}$"))
            {
                check = false;
                errSongaycong.Content = "Số ngày công phải nhập bằng số";
            }
            else
            {
                if (int.Parse(Songaycong) < 20 || int.Parse(Songaycong) > 30)
                {
                    check = false;
                    errSongaycong.Content = "Số ngày công thuộc đoạn [20,30]";
                }
                else
                {
                    errSongaycong.Content = "";
                }
            }
            if (!Regex.IsMatch(Luong, "^\\d{1,}$"))
            {
                check = false;
                errLuong.Content = "Luong phải nhập bằng số";
            }
            else
            {
                int luong = int.Parse(Luong);
                if (luong < 3000 || luong > 9000)
                {
                    check = false;
                    errLuong.Content = "Lương thuộc đoạn [3000,9000]";
                }
                else
                {
                    errLuong.Content = "";
                }
            }
            return check;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checkData())
            {
                try
                {
                    Nhanvien nv = new Nhanvien();
                    nv.Hoten = txtHoten.Text.ToString();
                    nv.Luong = int.Parse(txtLuong.Text.ToString());
                    nv.MaNv = int.Parse(txtManv.Text.ToString());
                    nv.MaPhong = int.Parse(cboMaPhong.SelectedValue.ToString());
                    nv.Songaycong = int.Parse(txtSongaycong.Text.ToString());
                    db.Nhanviens.Add(nv);
                    db.SaveChanges();
                    hienthi();
                    Clear();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi khi thêm: " + x.Message);
                    db.ChangeTracker.Clear();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienthi();
            hienthiPhongBan();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int manv = int.Parse(txtManv.Text);
            var nvSua = db.Nhanviens.SingleOrDefault(nv => nv.MaNv == manv);
            if (checkData())
            {
                try
                {
                    nvSua.Hoten = txtHoten.Text.ToString();
                    nvSua.Luong = int.Parse(txtLuong.Text);
                    nvSua.MaPhong = int.Parse(cboMaPhong.SelectedValue.ToString());
                    nvSua.Songaycong = int.Parse(txtSongaycong.Text);

                    db.SaveChanges();
                    hienthi();
                    Clear();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi khi sửa " + x.Message);
                    db.ChangeTracker.Clear();
                }
            }
        }
        public void Clear()
        {
            txtHoten.Text = "";
            txtManv.Text = "";
            txtLuong.Text = "";
            txtSongaycong.Text = "";
            txtManv.Focus();
            cboMaPhong.SelectedIndex = 0;
        }

        private void SelectedChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Object obj = dgnhanvien.SelectedItem;
            if (obj != null)
            {
                Type t = obj.GetType();
                PropertyInfo[] p = t.GetProperties();
                string manv = p[0].GetValue(obj).ToString();
                string maphong = p[1].GetValue(obj).ToString();
                string luong = p[2].GetValue(obj).ToString();
                string hoten = p[3].GetValue(obj).ToString();
                string songaycong = p[4].GetValue(obj).ToString();

                txtHoten.Text = hoten;
                txtLuong.Text = luong;
                txtManv.Text = manv;
                txtSongaycong.Text = songaycong;
                cboMaPhong.SelectedValue = int.Parse(maphong);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            int manv = int.Parse(txtManv.Text);
            try
            {
                var nvXoa = db.Nhanviens.SingleOrDefault(nv => nv.MaNv == manv);
                db.Nhanviens.Remove(nvXoa);
                db.SaveChanges();
                hienthi();
                Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Có lỗi khi xóa " + x.Message);
                db.ChangeTracker.Clear();
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 obj = new Window1();
            obj.Show();
        }
    }
}
