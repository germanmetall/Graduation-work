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
using System.Data;

namespace KVAL
{
    /// <summary>
    /// Логика взаимодействия для El.xaml
    /// </summary>
    public partial class El : Window
    {
        public El(int a, string nm)
        {
            InitializeComponent();
            this.a = a;
            this.nm = nm;
        }
        int a,b,c;
        string nm;
        double c1, c2;
        bool isc1=false, isc2=false;
        int q = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title += " "+nm;
            c = a;
            XmlDocument el = new XmlDocument();
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            b = a;
            //  ЗАВАНТАЖЕННЯ ІНФОРМАЦІЇ З БАЗИ ДАНИХ, ЗАПОВНЕННЯ ЗНАЧЕНЬ ФІЗИЧНИХ ХАРАКТЕРИСТИК
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.Name == "УмовнеПозначенняЕлемента") a--;
                    if (a == 0 && childnode.Name != "Ізотопи")
                    {
                        if (q==0) el1a.Content = childnode.InnerText;
                        else if (q==1) el2a.Content = childnode.InnerText;
                        else if (q==2) el3a.Content = childnode.InnerText;
                        else if (q==3) el4a.Content = childnode.InnerText;
                        else if (q==4) el5a.Content = childnode.InnerText;
                        else if (q==5) el6a.Content = childnode.InnerText;
                        else if (q==6) el7a.Content = childnode.InnerText + " г/см^3";
                        else if (q==7) 
                        {
                            el8a.Content = childnode.InnerText + " °C";
                            if (!String.Equals(el8a.Content.ToString(), "- °C"))
                            {
                                c1 = double.Parse(childnode.InnerText);
                                isc1 = true;
                            }
                        }
                        else if (q==8)
                        {
                            el9a.Content = childnode.InnerText + " °C";
                            if (!String.Equals(el9a.Content.ToString(), "- °C"))
                            {
                                c2 = double.Parse(childnode.InnerText);
                                isc2 = true;
                            }
                        }
                        else if (q == 9) el0a.Content = childnode.InnerText;
                        q++;
                    }
                }
            }
            wb.Content += " " + el1a.Content.ToString();
            tabl.Content += el1a.Content.ToString();
            bool again = true;
            int i = 2;
            DataTable dt = new DataTable();
            //  ЗАПОВНЕННЯ ТАБЛИЦІ (ІЗОТОПІВ)
            foreach (XmlNode node in nodes)
            {
                foreach (XmlNode childnode in node.ChildNodes)
                {
                    if (childnode.Name == "УмовнеПозначенняЕлемента") b--;
                    if (b==0)
                    {
                        foreach (XmlNode onemore1 in childnode.ChildNodes)
                        {
                            if (onemore1.Name == "УмовнеПозначенняЕлементу")
                            {
                                again = false;
                                dt.Rows.Add(new Object[] { childnode.ChildNodes[0].InnerText, childnode.ChildNodes[1].InnerText, childnode.ChildNodes[2].InnerText});
                            }
                            if (childnode.Name == "Ізотопи" && again)
                            {
                                DataColumn column;
                                switch (i)
                                {
                                    case 2:
                                        column = new DataColumn("Позначення ізотопу");
                                        dt.Columns.Add(column);
                                        break;
                                    case 1:
                                        column = new DataColumn("Кількість протонів");
                                        dt.Columns.Add(column);
                                        break;
                                    case 0:
                                        column = new DataColumn("Кількість нейтронів");
                                        dt.Columns.Add(column);
                                        break;
                                }
                                i--;
                            }
                        }
                    }
                }
            }
            if (dt.Rows.Count==0)
            {
                tabl.Content = "Стабільних ізотопів немає!";
                dg.Opacity = 0;
            }
            dg.ItemsSource = dt.DefaultView;
        }

        //  ЗМІНЕННЯ ТЕМПЕРАТУРИ З ГРАДУСІВ ЦЕЛЬСІЮ ДО КЕЛЬВИНА ТА НАВПАКИ
        private void el8a_Click(object sender, RoutedEventArgs e)
        {
            if (!String.Equals(el8a.Content.ToString(), "- °C"))
            {
                if (isc1)
                {
                    el8a.Content = (c1 + 273 + " K").ToString();
                    isc1 = false;
                }
                else
                {
                    el8a.Content = (c1 + " °C").ToString();
                    isc1 = true;
                }
            }
        }

        //  ЗМІНЕННЯ ТЕМПЕРАТУРИ З ГРАДУСІВ ЦЕЛЬСІЮ ДО КЕЛЬВИНА ТА НАВПАКИ
        private void el9a_Click(object sender, RoutedEventArgs e)
        {
            if (!String.Equals(el9a.Content.ToString(), "- °C"))
            {
                if (isc2)
                {
                    el9a.Content = (c2 + 273 + " K").ToString();
                    isc2 = false;
                }
                else
                {
                    el9a.Content = (c2 + " °C").ToString();
                    isc2 = true;
                }
            }
        }

        private void web_Click(object sender, RoutedEventArgs e)
        {
            web form = new web(c);
            form.ShowDialog();
        }
    }
}
