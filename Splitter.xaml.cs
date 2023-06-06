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
    /// Логика взаимодействия для Splitter.xaml
    /// </summary>
    public partial class Splitter : Page
    {
        public Splitter()
        {
            InitializeComponent();
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            try
            {
                if (box.Text == "")
                {
                    throw new Exception("Field is empty!");
                }
                string txt = box.Text;
                string[] words = txt.Split(' ');
                foreach (string word in words)
                {
                    WordWindow window = new WordWindow(word);
                    window.Show();
                }
                box.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
