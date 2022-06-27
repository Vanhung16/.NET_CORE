using Bai1.models;
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

namespace Bai1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> cboDiachi1 = new List<String>() { "Hà Nội", "Hải Phòng", "Quảng Ninh" };
        List<String> cboLophoc1 = new List<String>() { "Công nghệ thông tin", "Hệ thống thông tin", "Khoa học máy tính" };
        truonghocdb2Context db = new truonghocdb2Context();
        public MainWindow()
        {
            InitializeComponent();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            xoathongbao();
            hienthiDataGrid();
            hienthiLopHoc();
            cboDiachi.ItemsSource = cboDiachi1;
            cboDiachi.SelectedIndex = 0;
        }

        private void hienthiDataGrid()
        {
            var query = from sv in db.Sinhviens select sv;
            dgDanhsach.ItemsSource = query.ToList();
        }
        private void hienthiLopHoc()
        {
            var query = from lh in db.Lophocs select lh;
            cboLop.ItemsSource = query.ToList();
            cboLop.DisplayMemberPath = "Tenlop";
            cboLop.SelectedValuePath = "Malop";
            cboLop.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void xoathongbao()
        {
            errMasv.Content = "";
            errHoten.Content = "";
            errDiem.Content = "";
        }
        private bool checkData()
        {
            bool check = true;
            string masv = txtMasv.Text;
            string hoten = txtHoten.Text;
            string diem = txtDiem.Text;
            if (!Regex.IsMatch(masv, "^\\d{1,}$"))
            {
                check = false;
                errMasv.Content = "Mã sinh viên phải là số";
            }
            else
            {
                errMasv.Content = "";
            }
            if (!Regex.IsMatch(hoten, "^[a-zA-Z ]+$"))
            {
                check = false;
                errHoten.Content = "Họ tên phải nhập bằng chữ";
            }
            else
            {
                errHoten.Content = "";
            }
            if (!Regex.IsMatch(diem, "^\\d{1,}$"))
            {
                check = false;
                errDiem.Content = "Điểm phải là số";
            }
            else
            {
                float d = float.Parse(diem);
                if (d < 0 || d > 10)
                {
                    check = false;
                    errDiem.Content = "Điểm thuộc đoạn [0,10]";
                }
                else
                {
                    errDiem.Content = "";
                }
            }
            return check;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            bool check = checkData();
            if (check)
            {
                try
                {
                    Sinhvien sv = new Sinhvien(int.Parse(txtMasv.Text), txtHoten.Text, cboDiachi.Text,
                        byte.Parse(txtDiem.Text), int.Parse(cboLop.SelectedValue.ToString()));
                    db.Sinhviens.Add(sv);
                    db.SaveChanges();
                    hienthiDataGrid();
                    clear();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi khi thêm: " + x.Message);
                    db.ChangeTracker.Clear();
                }
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var svXoa = db.Sinhviens.SingleOrDefault(sv => sv.Masv == int.Parse(txtMasv.Text));
                db.Sinhviens.Remove(svXoa);
                db.SaveChanges();
                hienthiDataGrid();
                clear();
            }
            catch (Exception x)
            {
                MessageBox.Show("Có lỗi khi xóa: " + x.Message);
                db.ChangeTracker.Clear();

            }
        }
        private void clear()
        {
            txtDiem.Text = "";
            txtHoten.Text = "";
            txtMasv.Text = "";
            cboDiachi.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
            txtMasv.Focus();
        }

        private void XoaDong_Click(object sender, RoutedEventArgs e)
        {
            object obj = dgDanhsach.SelectedItem;
            if (obj != null)
            {
                try
                {
                    Type t = obj.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    int masv = int.Parse(p[0].GetValue(dgDanhsach.SelectedItem).ToString());
                    var svXoa = db.Sinhviens.SingleOrDefault(sv => sv.Masv == masv);
                    db.Sinhviens.Remove(svXoa);
                    db.SaveChanges();
                    hienthiDataGrid();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Bạn phải chọn 1 hàng trong bảng");
                }
            }
        }

        private void SelectedChanged_Click(object sender, SelectedCellsChangedEventArgs e)
        {
            object obj = dgDanhsach.SelectedItem;
            if (obj != null)
            {
                try
                {
                    int indexDiachi = -1;
                    Type t = dgDanhsach.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    string masv = p[0].GetValue(dgDanhsach.SelectedItem).ToString();
                    string hoten = p[1].GetValue(dgDanhsach.SelectedItem).ToString();
                    string diachi = p[2].GetValue(dgDanhsach.SelectedItem).ToString();
                    string diem = p[3].GetValue(dgDanhsach.SelectedItem).ToString();
                    string maLop = p[4].GetValue(dgDanhsach.SelectedItem).ToString();
                    txtMasv.Text = masv;
                    txtHoten.Text = hoten;
                    txtDiem.Text = diem;

                    for (int i = 0; i < cboDiachi1.Count; i++)
                    {
                        if(cboDiachi1[i].ToUpper() == diachi.ToUpper())
                        {
                            indexDiachi = i;
                        }
                    }
                    if (indexDiachi != -1)
                    {
                        cboDiachi.SelectedIndex = indexDiachi;
                    }
                    cboLop.SelectedValue = maLop;


                }
                catch (Exception x)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + x.Message);
                    db.ChangeTracker.Clear();
                }
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var svSua = db.Sinhviens.SingleOrDefault(sv => sv.Masv == int.Parse(txtMasv.Text));
                if(svSua != null)
                {
                    if (checkData())
                    {
                        svSua.Hoten = txtHoten.Text;
                        svSua.Malop = int.Parse(cboLop.SelectedValue.ToString());
                        svSua.Diem = byte.Parse(txtDiem.Text);
                        svSua.Diachi = cboDiachi.Text;
                        db.SaveChanges();
                        hienthiDataGrid();
                        clear();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("có lỗi khi sửa: "+x.Message);
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 obj = new Window1();
            obj.ShowDialog();
        }
    }
}
