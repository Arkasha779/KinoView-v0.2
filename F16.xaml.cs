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
    /// Логика взаимодействия для F16.xaml
    /// </summary>
    public partial class F16 : Window
    {
        public F16()
        {
            InitializeComponent();
        }

        private void b9_Click_1(object sender, RoutedEventArgs e)
        {
            SbR win3 = new SbR();
            win3.Show();
            Close();
        }
    }
}
