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
    /// Логика взаимодействия для BDecay.xaml
    /// </summary>
    public partial class BDecay : Window
    {
        public BDecay()
        {
            InitializeComponent();
        }
        int min, max, lastmin, lastmax;
        XmlDocument el = new XmlDocument();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool a = false, b = false;
            //  ПЕРЕВІРКИ
            if (cmb.SelectedIndex != -1)
            {
                for (int i = 0; i < n.Text.Length; i++) if (!Char.IsDigit(n.Text[i])) n.Text = "1";
                if (int.Parse(n.Text) < 1) n.Text = "1";
                el.Load("elements.xml");
                XmlElement nodes = el.DocumentElement;
                foreach (XmlNode node in nodes)
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 3)) a = true;
                        if (a && childnode.Name == "МінімальнаКількістьНейтронів")
                        {
                            lastmin = int.Parse(childnode.InnerText);
                            a = false;
                        }
                        if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 3)) b = true;
                        if (b && childnode.Name == "МаксимальнаКількістьНейтронів")
                        {
                            lastmax = int.Parse(childnode.InnerText);
                            b = false;
                        }
                    }
                }
                if (cmb.SelectedIndex == 116)
                {
                    if (int.Parse(n.Text) > 177)
                    {
                        n.Text = "177";
                        MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - максимальна кількість необхідних нейтронів для існування нижча за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else if (int.Parse(n.Text) < 177)
                    {
                        n.Text = "177";
                        MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - мінімальна кількість необхідних нейтронів для існування вища за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    eq.Text = "Ts(117p;"+int.Parse(n.Text)+"n) -> Og(118p;" + (int.Parse(n.Text) - 1) + "n) + β⁻";
                }
                else if (int.Parse(n.Text) < lastmin + 1)
                {
                    n.Text = (lastmin + 1).ToString();
                    MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - мінімальна кількість необхідних нейтронів для існування вища за отриману", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    eq.Text = (cmb.Items[cmb.SelectedIndex]).ToString() + "(" + (cmb.SelectedIndex + 1).ToString() + "p;" + (int.Parse(n.Text)) + "n) -> " + (cmb.Items[cmb.SelectedIndex + 1]).ToString() + "(" + (cmb.SelectedIndex + 2).ToString() + "p;" + (int.Parse(n.Text) - 1) + "n) + β⁻";
                }
                else if (int.Parse(n.Text) > max)
                {
                    n.Text = max.ToString();
                    MessageBox.Show("Цей елемент чи ізотоп не може розпадатися - максимальна кількість необхідних нейтронів для існування нижча за введену", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
                    eq.Text = (cmb.Items[cmb.SelectedIndex]).ToString() + "(" + (cmb.SelectedIndex + 1).ToString() + "p;" + (int.Parse(n.Text)) + "n) -> " + (cmb.Items[cmb.SelectedIndex + 1]).ToString() + "(" + (cmb.SelectedIndex + 2).ToString() + "p;" + (int.Parse(n.Text) - 1) + "n) + β⁻";
                }
                else eq.Text = (cmb.Items[cmb.SelectedIndex]).ToString() + "(" + (cmb.SelectedIndex + 1).ToString() + "p;" + (int.Parse(n.Text)) + "n) -> " + (cmb.Items[cmb.SelectedIndex + 1]).ToString() + "(" + (cmb.SelectedIndex + 2).ToString() + "p;" + (int.Parse(n.Text) - 1) + "n) + β⁻";
            }
            else MessageBox.Show("Ви повинні обрати початковий елемент(ізотоп)!", "Увага!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            bool b = true;
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == 117) b = false;
                    if (b && childnode.Name == "УмовнеПозначенняЕлемента") cmb.Items.Add(childnode.InnerText);
                }
            }
        }

        private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool a = false, b = false;
            p.Text = (cmb.SelectedIndex+1).ToString();
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 2)) a = true;
                    if (a && childnode.Name == "МінімальнаКількістьНейтронів")
                    {
                        min = int.Parse(childnode.InnerText);
                        a = false;
                    }
                    if (childnode.Name == "ПорядковийНомер" && int.Parse(childnode.InnerText) == (cmb.SelectedIndex + 2)) b = true;
                    if (b && childnode.Name == "МаксимальнаКількістьНейтронів")
                    {
                        max = int.Parse(childnode.InnerText);
                        b = false;
                    }
                }
            }
            n.Text = min.ToString();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            help form = new help(true);
            form.ShowDialog();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                help form = new help(true);
                form.ShowDialog();
            }
        }
    }
}
