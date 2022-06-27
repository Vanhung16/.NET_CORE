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
using WpfApp3.Models;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        truonghocdbContext db = new truonghocdbContext();
        private void DisplayDatGrid()
        {
            //var query = from sv in db.Sinhviens select sv;
            var query = from sv in db.Sinhviens
                        join lh in db.Lophocs
                        on sv.Malop equals lh.Malop
                        select new
                        {
                            Masv = sv.Masv,
                            Hoten = sv.Hoten,
                            Diachi = sv.Diachi,
                            Dienthoai = sv.Dienthoai,
                            Malop = sv.Malop,
                            Tenlop = lh.Tenlop,
                            Anh = sv.Anh
                        };
            dgDanhsach.ItemsSource = query.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayDatGrid();
            var query = from lh in db.Lophocs select lh;
            cboMalop.ItemsSource = query.ToList();
            cboMalop.DisplayMemberPath = "Tenlop";
            cboMalop.SelectedValuePath = "Malop";
            cboMalop.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Sinhvien item = (Sinhvien)dgDanhsach.SelectedItem;
                object item = dgDanhsach.SelectedItem;
                if (item != null)
                {
                    txtMasv.Text = (dgDanhsach.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    int temp = int.Parse(txtMasv.Text);

                    var s = db.Sinhviens.SingleOrDefault(sv => sv.Masv == temp);
                    if (s != null)
                    {
                        MessageBoxResult msg = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (msg == MessageBoxResult.Yes)
                        {
                            db.Sinhviens.Remove(s);
                            db.SaveChanges();
                            DisplayDatGrid();
                        }
                    }
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("Co loi khi xoa: " + e1.Message);
            }
        }

        private void btnDong_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sinhvien x = new Sinhvien();
                x.Hoten = txtHoten.Text;
                x.Diachi = txtDiachi.Text;
                x.Dienthoai = txtDienThoai.Text;
                x.Anh = txtAnh.Text;
                x.Malop = Convert.ToInt32(cboMalop.SelectedValue);
                db.Sinhviens.Add(x);
                db.SaveChanges();
                DisplayDatGrid();
                ClearTextBox();
                txtHoten.Focus();
            }
            catch (Exception e3)
            {
                MessageBox.Show("có lỗi khi thêm sinh viên" + e3.Message);
            }
        }
        private void ClearTextBox()
        {
            txtHoten.Clear();
            txtDiachi.Clear();
            txtAnh.Clear();
            txtDienThoai.Clear();
            cboMalop.SelectedIndex = 0;

        }

        private void GetrowValue(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dgDanhsach.SelectedItem;
                if (item != null)
                {
                    txtMasv.Text = (dgDanhsach.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    txtHoten.Text = (dgDanhsach.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                    txtDiachi.Text = (dgDanhsach.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                    txtDienThoai.Text = (dgDanhsach.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;

                    if ((dgDanhsach.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text != "")
                    {
                        cboMalop.SelectedIndex = Convert.ToInt32((dgDanhsach.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text) - 1;
                    }
                    txtAnh.Text = (dgDanhsach.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                }
            }
            catch (Exception e2)
            {

                MessageBox.Show("Có lỗi khi chọn: " + e2.Message);
            }


        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var sv2 = db.Sinhviens.SingleOrDefault(sv => sv.Masv == int.Parse(txtMasv.Text));
            sv2.Hoten = txtHoten.Text;
            sv2.Diachi = txtDiachi.Text;
            sv2.Dienthoai = txtDienThoai.Text;
            sv2.Malop = Convert.ToInt32(cboMalop.SelectedValue);
            sv2.Anh = txtAnh.Text;
            db.SaveChanges();
            DisplayDatGrid();
        }
    }

}
