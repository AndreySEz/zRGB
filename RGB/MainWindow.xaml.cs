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

namespace RGB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] colors = { "черный", "белый", "красный", "зеленый", "бирюзовый", "синий", "фиолетовый", "желтый", "коричневый", "оранжевый", "лиловый", "серый" };
            list.ItemsSource = colors;
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list.SelectedIndex == 0)
            {
                color.Content = "000000".ToString();
            }
            if (list.SelectedIndex == 1)
            {
                color.Content = "FFFFFF".ToString();
            }
            if (list.SelectedIndex == 2)
            {
                color.Content = "FF0000".ToString();
            }
            if (list.SelectedIndex == 3)
            {
                color.Content = "00FF00".ToString();
            }
            if (list.SelectedIndex == 4)
            {
                color.Content = "00FFFF".ToString();
            }
            if (list.SelectedIndex == 5)
            {
                color.Content = "0000FF".ToString();
            }
            if (list.SelectedIndex == 6)
            {
                color.Content = "FF00FF".ToString();
            }
            if (list.SelectedIndex == 7)
            {
                color.Content = "FFFF00".ToString();
            }
            if (list.SelectedIndex == 8)
            {
                color.Content = "996633".ToString();
            }
            if (list.SelectedIndex == 9)
            {
                color.Content = "FF8000".ToString();
            }
            if (list.SelectedIndex == 10)
            {
                color.Content = "8000FF".ToString();
            }
            if (list.SelectedIndex == 11)
            {
                color.Content = "А0А0А0".ToString();
            }
        }
    }
}
