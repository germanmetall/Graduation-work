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
    /// Логика взаимодействия для Lant.xaml
    /// </summary>
    public partial class Lant : Window
    {
        public Lant()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            El form = new El(57, "Лантан");
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            El form = new El(58, "Цезій");
            form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            El form = new El(59, "Празеодим");
            form.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            El form = new El(60, "Ніодім");
            form.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            El form = new El(61, "Прометій");
            form.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            El form = new El(62, "Самарій");
            form.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            El form = new El(63, "Європій");
            form.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            El form = new El(64, "Гадоліній");
            form.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            El form = new El(65, "Тербій");
            form.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            El form = new El(66, "Диспрозій");
            form.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            El form = new El(67, "Гольмій");
            form.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            El form = new El(68, "Ербій");
            form.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            El form = new El(69, "Тулій");
            form.Show();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            El form = new El(70, "Ітербій");
            form.Show();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            El form = new El(71, "Лютецій");
            form.Show();
        }
    }
}
