using Microsoft.Win32;
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

namespace SimpleMvvmDemo.Client
{
    /// <summary>
    /// MvvMWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MvvMWindow : Window
    {
        public MvvMWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.slider3.Value = this.slider1.Value + this.slider2.Value;
        }
    }
}
