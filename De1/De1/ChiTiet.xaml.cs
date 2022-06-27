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

namespace De1
{
    /// <summary>
    /// Interaction logic for ChiTiet.xaml
    /// </summary>
    public partial class ChiTiet : Window
    {
        public Employee employee {get; set;}
        public ChiTiet()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtName.IsEnabled = false;
            cboNV.IsEnabled = false;
            dateBirth.IsEnabled = false;
            txtMoney.IsEnabled = false;
            txtName.Text = employee.name;
            int index = -1;
            foreach(ComboBoxItem cb in cboNV.Items)
            {
                index++;
                if (cb.Content.ToString() == employee.typeNV)
                    break;
            }
            cboNV.SelectedIndex = index;
            dateBirth.SelectedDate = DateTime.ParseExact(employee.birthday, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            txtMoney.Text = employee.money.ToString();
        }
    }
}
