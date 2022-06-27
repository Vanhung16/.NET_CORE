using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ValidDemo.xaml
    /// </summary>
    public partial class ValidDemo : Window
    {
        ObservableCollection<Employee> liem;
        public ValidDemo()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            liem = new ObservableCollection<Employee>();
            liem = new ObservableCollection<Employee>();
            liem.Add(new Employee("1", "Huong", "Nu", 1000, "Anh"));
            liem.Add(new Employee("2", "Long", "Nam", 1400, "Anh"));
            liem.Add(new Employee("3", "Hai", "Nu", 1800, "Trung"));
            dtaList.ItemsSource = liem;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string sID, sName, sSalary, sGender, sLanguage;
            string error = "";
            sID = txtID.Text;
            sName = txtName.Text;
            sSalary = txtSalary.Text;
            sLanguage = "";
            if (rdNam.IsChecked == true)
            {
                sGender = "Nam";
            }
            else
            {
                sGender = "Nu";
            }

            if (cboxAnh.IsChecked == true)
            {
                sLanguage = "Tieng Anh";
            }

            if (cboxTrung.IsChecked == true)
            {
                sLanguage += "Tieng Trung";
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                error += "\nBan phai nhap ID";
            }
            if(string.IsNullOrEmpty(txtName.Text))
            {
                error += "\nBan phai nhap ten";
            }
            if(!Regex.IsMatch(txtSalary.Text, @"\d+"))
            {
                error += "\nBan phai nhap vao so";
            }
            else
            {
                int a = int.Parse(txtSalary.Text);
                if(a < 1000 || a > 2000)
                {
                    error += "\nBan phai nhap luong khoang 1000 - 2000";
                }
            }
            if(sLanguage == "")
            {
                error += "\nBan phai chon mot ngon ngu";
            }
            if(error != "")
            {
                //   MessageBox.Show(error);

                lblMsg.Content = error;
            }
            else
            {
                lblMsg.Content = "";
                Employee Emp = new Employee();
                Emp.eid = sID;
                Emp.name = sName;
                Emp.gender = sGender;
                Emp.salary = int.Parse(sSalary);
                Emp.language = sLanguage;
                liem.Add(Emp);
                dtaList.ItemsSource = liem;
            }

        }

        

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Detail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee em = (Employee)dtaList.SelectedItems[0];
                Window2 obj = new Window2();
                obj.emp = em;
                obj.ShowDialog();
            }
            catch (Exception e2)
            {
              //  MessageBox.Show("Co loi: " + e2.Message);

              lblMsg.Content="Có lỗi xảy ra: "+e2.Message;

            }

           
        }

        
    }
}

