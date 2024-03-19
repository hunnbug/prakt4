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
    /// Логика взаимодействия для SotrudnikiWindow.xaml
    /// </summary>
    public partial class SotrudnikiWindow : Window
    {
        MainWindow main                         = new MainWindow();
        public SotrudnikiWindow()
        {
            InitializeComponent();

            DG.ItemsSource                      = main.sotrudniki.GetData();
            Filter.ItemsSource                  = main.sotrudniki.GetData();
            Filter.DisplayMemberPath            = "SotrudnikSurname";
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource                      = main.sotrudniki.GetDataBy(Search.Text);
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filter.SelectedItem != null)
            {
                var surname                     = (string)(Filter.SelectedItem as DataRowView).Row[2];
                DG.ItemsSource                  = main.sotrudniki.GetSotrudnik(surname);
            }
        }

        private void Btn_Click2(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource                      = main.sotrudniki.GetData();
        }
    }
}
