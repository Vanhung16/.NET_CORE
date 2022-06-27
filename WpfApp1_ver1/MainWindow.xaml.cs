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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double kq = 0;
                if (radCong.IsChecked == true)
                {
                    kq = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);

                }
                else if (radTru.IsChecked == true)
                {
                    kq = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);


                }
                else if (radNhan.IsChecked == true)
                {
                    kq = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);


                }
                else
                    kq = double.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);

                // MessageBox.Show("KQ=" + kq, "THONG BAO");
                lblMsg.Content = "KQ: " + kq;
            }
            catch (Exception e1)
            {

                lblMsg.Content = "Nhap sai du lieu " + e1.Message;
              //  lblMsg.Foreground = Color.
            }
          

        }

        private void btnDong_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDong_Click2(object sender, RoutedEventArgs e)
        {

        }
    }
}
