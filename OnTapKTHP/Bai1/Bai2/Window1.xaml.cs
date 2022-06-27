using Bai2.Models;
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
using System.Windows.Shapes;

namespace Bai2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        NhanvienDBContext db = new NhanvienDBContext();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from nv in db.Nhanviens
                        join pb in db.PhongBans
                        on nv.MaPhong equals pb.MaPhong
                        select new
                        {
                            pb.MaPhong,
                            pb.TenPhong,
                            nv.Hoten,
                            nv.Luong
                        };
            dgWindow1.ItemsSource = query.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
