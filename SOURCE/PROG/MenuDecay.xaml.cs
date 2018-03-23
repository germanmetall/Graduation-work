using System;
using System.Collections.Generic;
using System.Text;
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
	/// Логика взаимодействия для MenuIso.xaml
	/// </summary>
	public partial class MenuDecay : Window
	{
		public MenuDecay()
		{
			this.InitializeComponent();
			
			// Вставьте ниже код, необходимый для создания объекта.
		}

		private void Label_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            Decay form = new Decay();
			form.Show();
		}

		private void Label_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			BDecay form = new BDecay();
			form.Show();
		}

		private void Label_MouseDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			//GDecay form = new GDecay();
			//form.Show();
		}
	}
}