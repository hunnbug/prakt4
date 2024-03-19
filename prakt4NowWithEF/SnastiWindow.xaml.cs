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

namespace prakt4NowWithEF
{
    /// <summary>
    /// Логика взаимодействия для SnastiWindow.xaml
    /// </summary>
    public partial class SnastiWindow : Window
    {
        private MainWindow main = new MainWindow();
        public SnastiWindow()
        {
            InitializeComponent();

            DG.ItemsSource = main.en.Snasti.ToList();
            Filter.ItemsSource = main.en.Snasti.ToList();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = main.en.Snasti.ToList().Where(item => item.SnastName.Contains(Search.Text));
        }

        private void Filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filter.SelectedItem != null)
            {
                var selected = Filter.SelectedItem as Snasti;
                DG.ItemsSource = main.en.Snasti.ToList().Where(item => item == selected);
            }
        }

        private void Btn_Click2(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = main.en.Snasti.ToList();
        }
    }
}
