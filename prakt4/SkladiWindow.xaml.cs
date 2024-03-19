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
using System.Windows.Shapes;

namespace prakt4
{
    /// <summary>
    /// Логика взаимодействия для SkladiWindow.xaml
    /// </summary>
    public partial class SkladiWindow : Window
    {
        MainWindow main                         = new MainWindow();
        public SkladiWindow()
        {
            InitializeComponent();

            DG.ItemsSource                      = main.skladi.GetData();
            Filter.ItemsSource                  = main.skladi.GetData();
            Filter.DisplayMemberPath            = "Adres";
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource                      = main.skladi.GetDataBy(Search.Text);
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filter.SelectedItem != null)
            {
                var ad                          = (string)(Filter.SelectedItem as DataRowView).Row[2];
                DG.ItemsSource                  = main.skladi.GetByAdress(ad);
            }
        }

        private void Btn_Click2(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource                      = main.skladi.GetData();
        }
    }
}
