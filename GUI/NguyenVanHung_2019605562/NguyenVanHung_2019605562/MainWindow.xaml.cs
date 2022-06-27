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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NguyenVanHung_2019605562
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<CongNhan> list = new ObservableCollection<CongNhan>();
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            list.Add(new CongNhan("Hung","Nam",29,30));
            list.Add(new CongNhan("Hoang","Nam",29,30));
            list.Add(new CongNhan("Ha","Nu",29,30));
            lbdata.ItemsSource = list;
        }
        public void clear()
        {
            txtHoTen.Text = "";
            radNam.IsChecked = true;
            txtSoNgayCong.Text = "";
            txtLuong.Text = "";
        }
        public void view(CongNhan x)
        {
            txtHoTen.Text = x.name;
            txtLuong.Text = x.salary.ToString();
            txtSoNgayCong.Text = x.numberDate.ToString();
            if(x.gender == "Nam")
            {
                radNam.IsChecked = true;
            }
            else
            {
                radNu.IsChecked = true;
            }
        }

        private void addElement(object sender, RoutedEventArgs e)
        {
                string error = "";
            try
            {
                string hoten = txtHoTen.Text;
                string gioitinh = "Nam";
                if (radNu.IsChecked == true)
                {
                    gioitinh = radNu.Content.ToString();
                }
                int luong = int.Parse(txtLuong.Text);
                int date = int.Parse(txtSoNgayCong.Text);


                if (date <= 0 || date > 30)
                    error += "Số ngày công phải thuộc khoảng [1,30]";


                if (error == "")
                {
                    CongNhan congNhan = new CongNhan(hoten, gioitinh, date, luong);
                    list.Add(congNhan);
                    dgdata.ItemsSource = list;
                    lbdata.Items.Add(congNhan.ToString());
                    clear();
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("no no no "+ error);
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void deleteElement(object sender, RoutedEventArgs e)
        {
            try
            {
                CongNhan cn = (CongNhan)dgdata.SelectedItem;
                MessageBox.Show(cn.name + cn.gender);
                list.Remove(cn);
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
            
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CongNhan em = (CongNhan)dgdata.SelectedItems[0];

                details view = new details();
                view.emp = em;
                view.ShowDialog();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void update(object sender, RoutedEventArgs e)
        {
          
                int index = lbdata.SelectedIndex;
                //string gender = "Nam";
                //if (radNu.IsChecked == true)
                //{
                //    gender = "Nu";
                //}
                //CongNhan congnhanItem = new CongNhan(txtHoTen.Text, gender, int.Parse(txtSoNgayCong.Text), int.Parse(txtLuong.Text));

                //view(congnhanItem);
                lbdata.Items.RemoveAt(index);
                //lbdata.Items.Insert(index, congnhanItem);
           



        }
    }
}
