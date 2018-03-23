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

namespace KVAL
{
    /// <summary>
    /// Логика взаимодействия для Act.xaml
    /// </summary>
    public partial class Act : Window
    {
        public Act()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            El form = new El(90, "Тамій");
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            El form = new El(91, "Паладій");
            form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            El form = new El(92, "Уран");
            form.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            El form = new El(93, "Нептуній");
            form.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            El form = new El(94, "Плутон");
            form.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            El form = new El(95, "Америцій");
            form.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            El form = new El(96, "Кюрій");
            form.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            El form = new El(97, "Берклій");
            form.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            El form = new El(98, "Каліфорній");
            form.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            El form = new El(99, "Ейнштейній");
            form.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            El form = new El(100, "Фермій");
            form.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            El form = new El(101, "Менделевій");
            form.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            El form = new El(102, "Нобелій");
            form.Show();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            El form = new El(103, "Лоуренцій");
            form.Show();
        }
    }
}
