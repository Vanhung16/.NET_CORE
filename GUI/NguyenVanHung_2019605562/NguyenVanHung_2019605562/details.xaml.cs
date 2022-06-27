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

namespace NguyenVanHung_2019605562
{
    /// <summary>
    /// Interaction logic for details.xaml
    /// </summary>
    public partial class details : Window
    {
        public CongNhan emp { get; set; }
        public details()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            txtHoTen.IsEnabled = false;
            txtLuong.IsEnabled = false;
            txtSoNgayCong.IsEnabled = false;
            radNam.IsEnabled = false;
            radNu.IsEnabled = false;

            txtHoTen.Text = emp.name;
            txtLuong.Text = emp.salary.ToString();
            txtSoNgayCong.Text = emp.numberDate.ToString();
            if(emp.gender == "Nam")
            {
                radNam.IsChecked = true;
            }
            else
            {
                radNu.IsChecked = true;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
