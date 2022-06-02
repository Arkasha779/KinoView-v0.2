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

namespace KinoView
{
    /// <summary>
    /// Логика взаимодействия для SbR.xaml
    /// </summary>
    public partial class SbR : Window
    {
        public SbR()
        {
            InitializeComponent();
        }

        private void i10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F8 win3 = new F8();
            win3.Show();
            Close();

        }

        private void i20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F16 win3 = new F16();
            win3.Show();
            Close();

        }

        private void i30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F2 win3 = new F2();
            win3.Show();
            Close();

        }

        private void i40_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F16 win3 = new F16();
            win3.Show();
            Close();

        }

        private void i50_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F16 win3 = new F16();
            win3.Show();
            Close();

        }

        private void i60_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            F16 win3 = new F16();
            win3.Show();
            Close();

        }

        private void b70_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win0 = new MainWindow();
            win0.Show();
            Close();

        }
    }
}
