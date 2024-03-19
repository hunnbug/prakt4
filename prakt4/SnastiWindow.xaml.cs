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
    /// Логика взаимодействия для SnastiWindow.xaml
    /// </summary>
    public partial class SnastiWindow : Window
    {
        MainWindow main                     = new MainWindow();
        public SnastiWindow()
        {
            InitializeComponent();

            DG.ItemsSource                  = main.snasti.GetData();
            Filter.ItemsSource              = main.snasti.GetData();
            Filter.DisplayMemberPath        = "Cvet";
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource                  = main.snasti.GetDataBy(Search.Text);
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filter.SelectedItem != null)
            {
                var colour                  = (string)(Filter.SelectedItem as DataRowView).Row[2];
                DG.ItemsSource              = main.snasti.GetColours(colour);
            }
        }

        private void Btn_Click2(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource                  = main.snasti.GetData();
        }
    }
}
