using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp9._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<String> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            addDatatoList();
            foreach (string item in list)
            {
                lbx_trai.Items.Add(item);
            }
        }

        public void addDatatoList()
        {
            list.Add("Công nghệ thực tại ảo");
            list.Add("Đảm bảo chất lượng phần mềm");
            list.Add("Giải thuật di truyền và ứng dụng");
            list.Add("Hệ chuyên gia");
            list.Add("Lập trình căn bản");
            list.Add("Lập trình hướng đối tượng");
            list.Add("Lập trình mạng");
            list.Add("Lập trình trên window");
            list.Add("Một số phương pháp tính toán phần mềm");
            list.Add("Nhập môn tin học");
            list.Add("Phân tích thiết kế hệ thống");
            list.Add("Phân tích và thống ke số liệu");
            list.Add("Thiết kế cơ sở dữ liệu");
            list.Add("Thiết kế trang web");
            list.Add("Tin văn phòng");
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            lbx_phai.Items.Add(lbx_trai.SelectedItem);
            lbx_trai.Items.Remove(lbx_trai.SelectedItem);
        }

        private void btn_add_all(object sender, RoutedEventArgs e)
        {
            //foreach (string item in list)
            //{
            //    lbx_phai.Items.Add(item);
            //}
            for (int i = 0; i < lbx_trai.Items.Count; i++)
            {
                lbx_phai.Items.Add(lbx_trai.Items[i]);
            }
        }

        private void btn_remove(object sender, RoutedEventArgs e)
        {
            lbx_phai.Items.Remove(lbx_phai.SelectedItem);
        }

        private void btn_removeAll(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lbx_phai.Items.Count; i++)
            {
                lbx_phai.Items.RemoveAt(i);
            }
        }
    }
}
