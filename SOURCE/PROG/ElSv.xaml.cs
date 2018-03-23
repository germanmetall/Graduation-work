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
using System.Windows.Navigation;
using System.Xml;

namespace KVAL
{
    /// <summary>
    /// Логика взаимодействия для ElSv.xaml
    /// </summary>
    public partial class ElSv : Window
    {
        public ElSv(int name)
        {
            InitializeComponent();
            this.name = name;
        }
        int name;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int c = 1, j = 0;
            XmlDocument el = new XmlDocument();
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            foreach (XmlNode node in nodes)
            {
                if (c == name)
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        if(j<8)
                        {
                            string text = childnode.InnerText;
                            string name1 = childnode.Name;
                            if (j == 0)
                            {
                                lbl1.Content = name1;
                                lbl9.Content = text;
                            }
                            else if (j == 1)
                            {
                                lbl2.Content = name1;
                                lbl10.Content = text;
                            }
                            else if (j == 2)
                            {
                                lbl3.Content = name1;
                                lbl11.Content = text;
                            }
                            else if (j == 3)
                            {
                                lbl4.Content = name1;
                                lbl12.Content = text;
                            }
                            else if (j == 4)
                            {
                                lbl5.Content = name1;
                                lbl13.Content = text;
                            }
                            else if (j == 5)
                            {
                                lbl6.Content = name1;
                                lbl14.Content = text;
                            }
                            else if (j == 6)
                            {
                                lbl7.Content = name1;
                                lbl15.Content = text;
                            }
                            else if (j == 7)
                            {
                                lbl8.Content = name1;
                                lbl16.Content = text;
                            }
                        }
                        j++;
                    }
                }
                c++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Iso form = new Iso(name);
            form.Show();
            this.Close();
        }
		private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Decay form = new Decay();
            form.Show();
            this.Close();
        }
    }
}
