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
    /// Логика взаимодействия для Options.xaml
    /// </summary>
    public partial class Options : Page
    {
        public Options()
        {
            InitializeComponent();
        }

        private void color_checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;

            switch(pressed.Content.ToString())
            {
                case "Белый": lbl.Foreground = Brushes.White; break;
                case "Красный": lbl.Foreground = Brushes.Red; break;
                case "Голубой": lbl.Foreground = Brushes.Blue; break;
                case "Зеленый": lbl.Foreground = Brushes.Green; break;
            }
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            title.Content = box.Text;
            box.Text = "";
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
    }
}
