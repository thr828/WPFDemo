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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleMvvmDemo.Client
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            double d1 = double.Parse(this.tb1.Text);
            double d2 = double.Parse(this.tb2.Text);
            double result = d1 + d2;
            this.tb3.Text = result.ToString();
            
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MvvMWindow mvvMWindow = new MvvMWindow();
            mvvMWindow.Show();
            this.Close();
        }


        private void BtnShowMVVM_OnClick(object sender, RoutedEventArgs e)
        {
           MVVM mmvMvvm=new MVVM();
           mmvMvvm.Show();
           this.Close();
        }
    }
}
