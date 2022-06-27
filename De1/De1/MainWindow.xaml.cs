using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace De1
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

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            string sName = "", sType, sBirth = "";
            double sMoney = 0, sHoaHong = 0;
            string err = "";
            if (txtName.Text != "")
                sName = txtName.Text;
            else
                err += "Vui lòng nhập tên nhân viên";

            ComboBoxItem typeItem = (ComboBoxItem)cboNV.SelectedItem;
            sType = typeItem.Content.ToString();
            DateTime? selectedDate = dateBirth.SelectedDate;
            if (selectedDate.HasValue)
            {
                sBirth = selectedDate.Value.ToString("dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                int year = int.Parse(selectedDate.Value.ToString("yyyy", System.Globalization.CultureInfo.InvariantCulture));
                DateTime aDateTime = DateTime.Now;
                int year_now = aDateTime.Year;
                if (year_now - year < 19 || year_now - year > 60)
                    err += "\nTuổi không thỏa mãn >= 19 và <= 60";
            }
            else
                err += "\nVui lòng nhập ngày sinh";

            if (txtMoney.Text == "")
                err += "\nVui lòng nhập doanh số";
            else
            {
                sMoney = double.Parse(txtMoney.Text);
                if (sMoney <= 0)
                    err += "\nDoanh số phải lớn hơn 0";
                else if (sMoney < 1000)
                    sHoaHong = 0;
                else if (sMoney <= 5000)
                    sHoaHong = sMoney * 0.05;
                else
                    sHoaHong = sMoney * 0.1;
            }     
            if (err == "")
            {
                blockErr.Text = "";
                string em = String.Format("{0} - {1} - {2} - {3} - {4}", sName, sType, sBirth, sMoney, sHoaHong);
                lbNV.Items.Add(em);
            }
            else
                blockErr.Text = err;
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChiTiet ct2 = new ChiTiet();
                String in4 = (String)lbNV.SelectedItem;
                string[] thongtin = in4.Split(" - ");
                string sName = thongtin[0], sType = thongtin[1], sDate = thongtin[2];
                double sMoney = double.Parse(thongtin[3]);
                Employee emp = new Employee(sName, sType, sDate, sMoney);
                ct2.employee = emp;
                ct2.ShowDialog();
            }
            catch (Exception ex)
            {
                blockErr.Text = "Có lỗi xảy ra " + ex;
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            cboNV.SelectedIndex = -1;
            dateBirth.SelectedDate = DateTime.Now;
            txtMoney.Text = "";
            txtName.Focus();
        }
    }
}
