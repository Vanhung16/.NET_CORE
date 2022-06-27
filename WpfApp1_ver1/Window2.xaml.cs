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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Employee emp { get; set; }
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // txtName.IsReadOnly = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            txtID.IsEnabled = false;
            txtName.IsEnabled = false;
            txtSalary.IsEnabled = false;
            rdNam.IsEnabled = false;
            rdNu.IsEnabled = false;
            cboxAnh.IsEnabled = false;
            cboxTrung.IsEnabled = false;
            txtID.Text = emp.eid;
            txtName.Text = emp.name;
            txtSalary.Text = emp.salary.ToString();
            if (emp.gender == "Nam")
            {
                rdNam.IsChecked = true;
            }
            else
            {
                rdNu.IsChecked = true;
            }
        }
    }
}
