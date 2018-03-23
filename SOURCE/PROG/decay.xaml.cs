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
using System.Xml;

namespace KVAL
{
    /// <summary>
    /// Логика взаимодействия для Decay.xaml
    /// </summary>
    public partial class Decay : Window
    {
        public Decay()
        {
            InitializeComponent();
        }
        int min, max, lastmin, lastmax;
        XmlDocument el = new XmlDocument();
        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            bool b = false;
            //  ЗАПОВНЕННЯ КОМБОБОКСУ (НАЗВАМИ ЕЛЕМЕНТІВ)
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) > 1) b = true;
                    if (b && childnode.Name == "УмовнеПозначенняЕлемента") cmb.Items.Add(childnode.InnerText);
                }
            }
        }

        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool a = false, b = false;
            p.Text = (cmb.SelectedIndex + 3).ToString();
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            //  ЗАВАНТАЖЕННЯ ІНФОРМАЦІЇ ПРО МІН ТА МАХ КІЛЬКІСТЬ НЕЙТРОНІВ
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 3)) a = true;
                    if (a && childnode.Name == "МінімальнаКількістьНейтронів")
                    {
                        min = int.Parse(childnode.InnerText);
                        a = false;
                    }
                    if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 3)) b = true;
                    if (b && childnode.Name == "МаксимальнаКількістьНейтронів")
                    {
                        max = int.Parse(childnode.InnerText);
                        b = false;
                    }
                }
            }
            if (min < 2) n.Text = "2";
            else n.Text = min.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool a = false, b = false;
            //  ПЕРЕВІРКА ЗНАЧЕНЬ
            if (cmb.SelectedIndex != -1)
            {
                for (int i = 0; i < n.Text.Length; i++) if (!Char.IsDigit(n.Text[i])) n.Text = "2";
                if (int.Parse(n.Text) < 2) n.Text = "2";//  КІЛЬКІСТЬ НЕЙТРОНІВ - НЕ МЕНШЕ ДВУХ
                el.Load("elements.xml");
                XmlElement nodes = el.DocumentElement;
                foreach (XmlNode node in nodes)
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 1)) a = true;
                        if (a && childnode.Name == "МінімальнаКількістьНейтронів")
                        {
                            lastmin = int.Parse(childnode.InnerText);
                            a = false;
                        }
                        if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 1)) b = true;
                        if (b && childnode.Name == "МаксимальнаКількістьНейтронів")
                        {
                            lastmax = int.Parse(childnode.InnerText);
                            b = false;
                        }
                    }
                }
                //  ЯКЩО ОБРАНО ЕЛЕМЕНТ Н
                if (cmb.SelectedIndex == 0)
                {
                    if (int.Parse(n.Text) > 8)
                    {
                        n.Text = "8";
                        MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - максимальна кількість необхідних нейтронів для існування нижча за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    eq.Text = "Li(3p;"+(int.Parse(n.Text))+"n) -> H(1p;" + (int.Parse(n.Text) - 2) + "n) + α(₂⁴)";
                    
                }
                //  ЯКЩО ОБРАНО ЕЛЕМЕНТ Не
                else if (cmb.SelectedIndex == 1)
                {
                    if (int.Parse(n.Text) > 10)
                    {
                        n.Text = "10";
                        MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - максимальна кількість необхідних нейтронів для існування нижча за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    if (cmb.SelectedIndex == 1) eq.Text = "Be(4p;" + (int.Parse(n.Text)) + "n) -> He(2p;" + (int.Parse(n.Text) - 2) + "n) + α(₂⁴)";
                }
                //  ЯКЩО КІЛЬКІСТЬ ІЗОТОПІВ МЕНША ЗА МОЖЛИВУ
                else if (int.Parse(n.Text) < lastmin + 2)
                {
                    n.Text = (lastmin + 2).ToString();
                    MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - мінімальна кількість необхідних нейтронів для існування вища за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    eq.Text = (cmb.Items[cmb.SelectedIndex]).ToString() + "(" + (cmb.SelectedIndex + 3).ToString() + "p;" + int.Parse(n.Text) + "n) -> " + (cmb.Items[cmb.SelectedIndex - 2]).ToString() + "(" + (cmb.SelectedIndex + 1).ToString() + "p;" + (int.Parse(n.Text) - 2) + "n) + α(₂⁴)";
                }
                //  ЯКЩО КІЛЬКІСТЬ ІЗОТОПІВ БІЛЬША ЗА МОЖЛИВУ
                else if (int.Parse(n.Text) > lastmax + 2)
                {
                    n.Text = (lastmax + 2).ToString();
                    MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - максимальна кількість необхідних нейтронів для існування нижча за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    eq.Text = (cmb.Items[cmb.SelectedIndex]).ToString() + "(" + (cmb.SelectedIndex + 3).ToString() + "p;" + int.Parse(n.Text) + "n) -> " + (cmb.Items[cmb.SelectedIndex - 2]).ToString() + "(" + (cmb.SelectedIndex + 1).ToString() + "p;" + (int.Parse(n.Text) - 2) + "n) + α(₂⁴)";
                }
                    // ЯКЩО ВСЕ НОРМАЛЬНО
                else eq.Text = (cmb.Items[cmb.SelectedIndex]).ToString() + "(" + (cmb.SelectedIndex + 3).ToString() + "p;" + int.Parse(n.Text) + "n) -> " + (cmb.Items[cmb.SelectedIndex - 2]).ToString() + "(" + (cmb.SelectedIndex + 1).ToString() + "p;" + (int.Parse(n.Text) - 2) + "n) + α(₂⁴)";
            }
            else MessageBox.Show("Ви повинні обрати початковий елемент(ізотоп)!", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            help form = new help(false);
            form.ShowDialog();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                help form = new help(false);
                form.ShowDialog();
            }
        }
    }
}
