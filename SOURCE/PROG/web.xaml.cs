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
    /// Логика взаимодействия для web.xaml
    /// </summary>
    public partial class web : Window
    {
        public web(int n)
        {
            InitializeComponent();
            this.n = n;
        }
        int n;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            switch (n) {
                case 1:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%92%D0%BE%D0%B4%D0%B5%D0%BD%D1%8C");
                    break;
                case 2:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%B5%D0%BB%D1%96%D0%B9");
                    break;
                case 3:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9B%D1%96%D1%82%D1%96%D0%B9");
                    break;
                case 4:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D0%B5%D1%80%D0%B8%D0%BB%D1%96%D0%B9");
                    break;
                case 5:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D0%BE%D1%80");
                    break;
                case 6:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%92%D1%83%D0%B3%D0%BB%D0%B5%D1%86%D1%8C");
                    break;
                case 7:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D0%B7%D0%BE%D1%82");
                    break;
                case 8:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9E%D0%BA%D1%81%D0%B8%D0%B3%D0%B5%D0%BD");
                    break;
                case 9:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A4%D1%82%D0%BE%D1%80");
                    break;
                case 10:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D0%B5%D0%BE%D0%BD");
                    break;
                case 11:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D0%B0%D1%82%D1%80%D1%96%D0%B9");
                    break;
                case 12:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D0%B0%D0%B3%D0%BD%D1%96%D0%B9");
                    break;
                case 13:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D0%BB%D1%8E%D0%BC%D1%96%D0%BD%D1%96%D0%B9");
                    break;
                case 14:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D1%80%D0%B5%D0%BC%D0%BD%D1%96%D0%B9");
                    break;
                case 15:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A4%D0%BE%D1%81%D1%84%D0%BE%D1%80");
                    break;
                case 16:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D1%96%D1%80%D0%BA%D0%B0");
                    break;
                case 17:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A5%D0%BB%D0%BE%D1%80");
                    break;
                case 18:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D1%80%D0%B3%D0%BE%D0%BD");
                    break;
                case 19:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D0%BB%D1%96%D0%B9");
                    break;
                case 20:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D0%BB%D1%8C%D1%86%D1%96%D0%B9");
                    break;
                case 21:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D0%BA%D0%B0%D0%BD%D0%B4%D1%96%D0%B9");
                    break;
                case 22:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B8%D1%82%D0%B0%D0%BD_(%D1%85%D1%96%D0%BC%D1%96%D1%87%D0%BD%D0%B8%D0%B9_%D0%B5%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)");
                    break;
                case 23:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%92%D0%B0%D0%BD%D0%B0%D0%B4%D1%96%D0%B9");
                    break;
                case 24:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A5%D1%80%D0%BE%D0%BC");
                    break;
                case 25:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D0%B0%D0%BD%D0%B3%D0%B0%D0%BD");
                    break;
                case 26:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%97%D0%B0%D0%BB%D1%96%D0%B7%D0%BE");
                    break;
                case 27:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D0%BE%D0%B1%D0%B0%D0%BB%D1%8C%D1%82");
                    break;
                case 28:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D1%96%D0%BA%D0%B5%D0%BB%D1%8C");
                    break;
                case 29:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D1%96%D0%B4%D1%8C");
                    break;
                case 30:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A6%D0%B8%D0%BD%D0%BA");
                    break;
                case 31:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%B0%D0%BB%D1%96%D0%B9");
                    break;
                case 32:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D1%96%D0%B9");
                    break;
                case 33:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D1%80%D1%81%D0%B5%D0%BD");
                    break;
                case 34:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D0%B5%D0%BB%D0%B5%D0%BD");
                    break;
                case 35:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D1%80%D0%BE%D0%BC");
                    break;
                case 36:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D1%80%D0%B8%D0%BF%D1%82%D0%BE%D0%BD");
                    break;
                case 37:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D1%83%D0%B1%D1%96%D0%B4%D1%96%D0%B9");
                    break;
                case 38:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D1%82%D1%80%D0%BE%D0%BD%D1%86%D1%96%D0%B9");
                    break;
                case 39:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%86%D1%82%D1%80%D1%96%D0%B9");
                    break;
                case 40:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A6%D0%B8%D1%80%D0%BA%D0%BE%D0%BD%D1%96%D0%B9");
                    break;
                case 41:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D1%96%D0%BE%D0%B1%D1%96%D0%B9");
                    break;
                case 42:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D0%BE%D0%BB%D1%96%D0%B1%D0%B4%D0%B5%D0%BD");
                    break;
                case 43:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B5%D1%85%D0%BD%D0%B5%D1%86%D1%96%D0%B9");
                    break;
                case 44:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D1%83%D1%82%D0%B5%D0%BD%D1%96%D0%B9");
                    break;
                case 45:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D0%BE%D0%B4%D1%96%D0%B9");
                    break;
                case 46:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D0%B0%D0%BB%D0%B0%D0%B4%D1%96%D0%B9");
                    break;
                case 47:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D1%80%D1%96%D0%B1%D0%BB%D0%BE");
                    break;
                case 48:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D0%B4%D0%BC%D1%96%D0%B9");
                    break;
                case 49:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%86%D0%BD%D0%B4%D1%96%D0%B9");
                    break;
                case 50:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D1%82%D0%B0%D0%BD%D1%83%D0%BC");
                    break;
                case 51:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D1%82%D0%B8%D0%B1%D1%96%D0%B9");
                    break;
                case 52:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BB%D1%83%D1%80");
                    break;
                case 53:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%99%D0%BE%D0%B4");
                    break;
                case 54:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D1%81%D0%B5%D0%BD%D0%BE%D0%BD");
                    break;
                case 55:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A6%D0%B5%D0%B7%D1%96%D0%B9");
                    break;
                case 56:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D0%B0%D1%80%D1%96%D0%B9");
                    break;
                case 57:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9B%D0%B0%D0%BD%D1%82%D0%B0%D0%BD");
                    break;
                case 58:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A6%D0%B5%D1%80%D1%96%D0%B9");
                    break;
                case 59:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D1%80%D0%B0%D0%B7%D0%B5%D0%BE%D0%B4%D0%B8%D0%BC");
                    break;
                case 60:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D0%B5%D0%BE%D0%B4%D0%B8%D0%BC");
                    break;
                case 61:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D0%BC%D0%B5%D1%82%D1%96%D0%B9");
                    break;
                case 62:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D0%B0%D0%BC%D0%B0%D1%80%D1%96%D0%B9");
                    break;
                case 63:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%84%D0%B2%D1%80%D0%BE%D0%BF%D1%96%D0%B9");
                    break;
                case 64:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%B0%D0%B4%D0%BE%D0%BB%D1%96%D0%BD%D1%96%D0%B9");
                    break;
                case 65:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B5%D1%80%D0%B1%D1%96%D0%B9");
                    break;
                case 66:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%94%D0%B8%D1%81%D0%BF%D1%80%D0%BE%D0%B7%D1%96%D0%B9");
                    break;
                case 67:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%BE%D0%BB%D1%8C%D0%BC%D1%96%D0%B9");
                    break;
                case 68:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%95%D1%80%D0%B1%D1%96%D0%B9");
                    break;
                case 69:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D1%83%D0%BB%D1%96%D0%B9");
                    break;
                case 70:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%86%D1%82%D0%B5%D1%80%D0%B1%D1%96%D0%B9");
                    break;
                case 71:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9B%D1%8E%D1%82%D0%B5%D1%86%D1%96%D0%B9");
                    break;
                case 72:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%B0%D1%84%D0%BD%D1%96%D0%B9");
                    break;
                case 73:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B0%D0%BD%D1%82%D0%B0%D0%BB_(%D1%85%D1%96%D0%BC%D1%96%D1%87%D0%BD%D0%B8%D0%B9_%D0%B5%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)");
                    break;
                case 74:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%92%D0%BE%D0%BB%D1%8C%D1%84%D1%80%D0%B0%D0%BC");
                    break;
                case 75:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D0%B5%D0%BD%D1%96%D0%B9");
                    break;
                case 76:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9E%D1%81%D0%BC%D1%96%D0%B9");
                    break;
                case 77:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%86%D1%80%D0%B8%D0%B4%D1%96%D0%B9");
                    break;
                case 78:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D0%BB%D0%B0%D1%82%D0%B8%D0%BD%D0%B0");
                    break;
                case 79:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%97%D0%BE%D0%BB%D0%BE%D1%82%D0%BE");
                    break;
                case 80:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D1%82%D1%83%D1%82%D1%8C");
                    break;
                case 81:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B0%D0%BB%D1%96%D0%B9");
                    break;
                case 82:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D0%B2%D0%B8%D0%BD%D0%B5%D1%86%D1%8C");
                    break;
                case 83:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D1%96%D1%81%D0%BC%D1%83%D1%82");
                    break;
                case 84:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D0%BE%D0%BB%D0%BE%D0%BD%D1%96%D0%B9");
                    break;
                case 85:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D1%81%D1%82%D0%B0%D1%82");
                    break;
                case 86:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D0%B0%D0%B4%D0%BE%D0%BD");
                    break;
                case 87:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A4%D1%80%D0%B0%D0%BD%D1%86%D1%96%D0%B9");
                    break;
                case 88:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D0%B0%D0%B4%D1%96%D0%B9");
                    break;
                case 89:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D0%BA%D1%82%D0%B8%D0%BD%D1%96%D0%B9");
                    break;
                case 90:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%BE%D1%80%D1%96%D0%B9");
                    break;
                case 91:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D1%82%D0%B0%D0%BA%D1%82%D0%B8%D0%BD%D1%96%D0%B9");
                    break;
                case 92:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A3%D1%80%D0%B0%D0%BD_(%D1%85%D1%96%D0%BC%D1%96%D1%87%D0%BD%D0%B8%D0%B9_%D0%B5%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82)");
                    break;
                case 93:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D0%B5%D0%BF%D1%82%D1%83%D0%BD%D1%96%D0%B9");
                    break;
                case 94:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9F%D0%BB%D1%83%D1%82%D0%BE%D0%BD%D1%96%D0%B9");
                    break;
                case 95:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D1%86%D1%96%D0%B9");
                    break;
                case 96:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D1%8E%D1%80%D1%96%D0%B9");
                    break;
                case 97:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D0%B5%D1%80%D0%BA%D0%BB%D1%96%D0%B9");
                    break;
                case 98:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D0%B0%D0%BB%D1%96%D1%84%D0%BE%D1%80%D0%BD%D1%96%D0%B9");
                    break;
                case 99:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%95%D0%B9%D0%BD%D1%88%D1%82%D0%B5%D0%B9%D0%BD%D1%96%D0%B9");
                    break;
                case 100:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A4%D0%B5%D1%80%D0%BC%D1%96%D0%B9");
                    break;
                case 101:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D0%B5%D0%BD%D0%B4%D0%B5%D0%BB%D0%B5%D0%B2%D1%96%D0%B9");
                    break;
                case 102:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D0%BE%D0%B1%D0%B5%D0%BB%D1%96%D0%B9");
                    break;
                case 103:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9B%D0%BE%D1%83%D1%80%D0%B5%D0%BD%D1%81%D1%96%D0%B9");
                    break;
                case 104:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D0%B5%D0%B7%D0%B5%D1%80%D1%84%D0%BE%D1%80%D0%B4%D1%96%D0%B9");
                    break;
                case 105:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%94%D1%83%D0%B1%D0%BD%D1%96%D0%B9");
                    break;
                case 106:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A1%D1%96%D0%B1%D0%BE%D1%80%D0%B3%D1%96%D0%B9");
                    break;
                case 107:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%91%D0%BE%D1%80%D1%96%D0%B9");
                    break;
                case 108:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%93%D0%B0%D1%81%D1%96%D0%B9");
                    break;
                case 109:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D0%B0%D0%B9%D1%82%D0%BD%D0%B5%D1%80%D1%96%D0%B9");
                    break;
                case 110:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%94%D0%B0%D1%80%D0%BC%D1%88%D1%82%D0%B0%D0%B4%D1%82%D1%96%D0%B9");
                    break;
                case 111:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A0%D0%B5%D0%BD%D1%82%D0%B3%D0%B5%D0%BD%D1%96%D0%B9");
                    break;
                case 112:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9A%D0%BE%D0%BF%D0%B5%D1%80%D0%BD%D0%B8%D1%86%D1%96%D0%B9");
                    break;
                case 113:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9D%D1%96%D1%85%D0%BE%D0%BD%D1%96%D0%B9");
                    break;
                case 114:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A4%D0%BB%D0%B5%D1%80%D0%BE%D0%B2%D1%96%D0%B9");
                    break;
                case 115:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9C%D0%BE%D1%81%D0%BA%D0%BE%D0%B2%D1%96%D0%B9");
                    break;
                case 116:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9B%D1%96%D0%B2%D0%B5%D1%80%D0%BC%D0%BE%D1%80%D1%96%D0%B9");
                    break;
                case 117:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%A2%D0%B5%D0%BD%D0%BD%D0%B5%D1%81%D1%81%D0%B8%D0%BD");
                    break;
                case 118:
                    wb.Source = new Uri("https://uk.wikipedia.org/wiki/%D0%9E%D0%B3%D0%B0%D0%BD%D0%B5%D1%81%D0%BE%D0%BD");
                    break;
                }
            
        }
    }
}
