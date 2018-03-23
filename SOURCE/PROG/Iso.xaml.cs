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
using System.Data;
using System.IO;
using System.Xml;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace KVAL
{
    /// <summary>
    /// Логика взаимодействия для Iso.xaml
    /// </summary>
    public partial class Iso : Window
    {
        public Iso(int name)
        {
            InitializeComponent();
            this.name = name;
        }
        int name;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int count = 1, j = 0;
            string a="",b="",c="",d="",e1="",f="";
            XmlDocument el = new XmlDocument();
            el.Load("elements.xml");
            XmlElement nodes = el.DocumentElement;
            DataTable dt = new DataTable();
            DataRow row0 = dt.NewRow(), row1 = dt.NewRow(), row2 = dt.NewRow(), row3 = dt.NewRow(), row4 = dt.NewRow(), row5 = dt.NewRow();
            foreach (XmlNode node in nodes)
            {
                if (count == name)
                {
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        foreach (XmlNode onemore in childnode.ChildNodes)
                        {
                            if (j > 7 && j < 14)
                            {
                                DataColumn column = new DataColumn(onemore.Name);
                                dt.Columns.Add(column);
                            }
                            if (j > 7 && j < 32)
                            {
                                if ((j-8)%6 == 0)
                                {
                                    row0 = dt.NewRow();
                                    row0[onemore.Name] = onemore.InnerText;
                                    a = onemore.Name;
                                }
                                else if ((j-8)%6 == 1)
                                {
                                    row1 = dt.NewRow();
                                    row1[onemore.Name] = onemore.InnerText;
                                    b = onemore.Name;
                                }
                                else if ((j-8)%6 == 2)
                                {
                                    row2 = dt.NewRow();
                                    row2[onemore.Name] = onemore.InnerText;
                                    c = onemore.Name;
                                }
                                else if ((j-8)%6 == 3)
                                {
                                    row3 = dt.NewRow();
                                    row3[onemore.Name] = onemore.InnerText;
                                    d = onemore.Name;
                                }
                                else if ((j-8)%6 == 4)
                                {
                                    row4 = dt.NewRow();
                                    row4[onemore.Name] = onemore.InnerText;
                                    e1 = onemore.Name;
                                }
                                else if ((j-8)%6 == 5)
                                {
                                    row5 = dt.NewRow();
                                    row5[onemore.Name] = onemore.InnerText;
                                    f = onemore.Name;
                                    dt.Rows.Add(new Object[] { row0[a].ToString(), row1[b].ToString(), row2[c].ToString(), row3[d].ToString(), row4[e1].ToString(), row5[f].ToString()});
                                }
                            }
                            j++;
                        }
                    }
                }
                count++;
            }
            //MessageBox.Show(dt.Columns.Count.ToString());
            dg.ItemsSource = dt.DefaultView;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ElSv form = new ElSv(name);
            form.Show();
            this.Close();
        }
    }
}
