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

namespace prakt4NowWithEF
{
    public partial class MainWindow : Window
    {
        public RibolovnieSnasti2Entities en = new RibolovnieSnasti2Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sn = new SnastiWindow(); sn.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var skladi = new SkladiWindow(); skladi.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var sotrudniki = new SotrudnikiWindow(); sotrudniki.Show();
        }
    }
}
