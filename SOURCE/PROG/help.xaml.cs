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
    /// Логика взаимодействия для help.xaml
    /// </summary>
    public partial class help : Window
    {
        public help(bool a)
        {
            InitializeComponent();
            a1 = a;
        }
        bool a1;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (a1)
            {
                label.Content = "β-Розпад";
                label.Background = new SolidColorBrush(Colors.LightBlue);
                l1.Text = "У цій частині виконується розрахунок розпаду за формулою: E1(p, n) -> E2(p+1,n-1)+β⁻";
                l2.Text = "У цій частині моделюється незалежний від введених значень β-розпад елементу Be(4p, 5n), під час якого з нього вилітає β⁻-частинка(нейтрон перетворюється на протон, вилітає електрон) і утворюється ізотоп B(5p, 4n)";
            }
        }
    }
}
