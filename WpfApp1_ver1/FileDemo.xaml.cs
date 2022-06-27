using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for FileDemo.xaml
    /// </summary>
    public partial class FileDemo : Window
    {
        public FileDemo()
        {
            InitializeComponent();
        }

        private void cboFonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = cboFont.SelectedValue.ToString();
            txtContent.FontFamily = new FontFamily(fontName);
            txtContent.FontSize = 20;
        }

        private void SetColor_IndexChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            string colorStr = cboColor.SelectedColor.Value.ToString();
            var bc = new BrushConverter();
            txtContent.Foreground = (Brush)bc.ConvertFrom(colorStr);
        }

        private void btnDong_Click(object sender, RoutedEventArgs e)
        {
            txtContent.Clear();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            string lines = txtContent.Text;
            File.WriteAllTextAsync(saveFile.FileName, lines);
        }

        private void btnOpenFIle_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            var fileName = openFile.FileName;
            string text = File.ReadAllText(fileName);
            txtContent.Text = text;
        }
    }
}
