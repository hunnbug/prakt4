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
using prakt4.DSTableAdapters;

namespace prakt4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SnastiTableAdapter snasti            = new SnastiTableAdapter();
        public SotrudnikiTableAdapter sotrudniki    = new SotrudnikiTableAdapter();
        public SkladTableAdapter skladi             = new SkladTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sn                                  = new SnastiWindow(); sn.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var skladi                               = new SkladiWindow(); skladi.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var sotrudniki                          = new SotrudnikiWindow(); sotrudniki.Show();
        }
    }
}
