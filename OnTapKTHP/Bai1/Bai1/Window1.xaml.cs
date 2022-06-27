using Bai1.models;
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

namespace Bai1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        truonghocdb2Context db = new truonghocdb2Context();
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from sv in db.Sinhviens
                        join lop in db.Lophocs
                        on sv.Malop equals lop.Malop
                        where sv.Malop == 3
                        where sv.Diem > 5
                        select new
                        {
                            sv.Masv,
                            sv.Hoten,
                            sv.Diachi,
                            sv.Diem,
                            lop.Malop,
                            lop.Tenlop
                        };
            dgWindow2.ItemsSource = query.ToList();
        }
    }
}
