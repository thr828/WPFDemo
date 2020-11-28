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

namespace ControlLibrary
{
    /// <summary>
    /// 用户控件选择的项目时，用户控件库
    /// </summary>
    public partial class SalaryCalculator : UserControl
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox.Text))
            {
                MessageBox.Show("基本工资不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("岗位工资不能为空！");
                return;
            }

            this.textBox2.Text = (int.Parse(this.textBox.Text) + int.Parse(this.textBox1.Text)).ToString();
        }
    }
}
