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

namespace Laba16
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AboutOpen(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new About());
        }

        private void options(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Options());
        }

        private void task_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Splitter());
        }
    }
}
