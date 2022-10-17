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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Button bt = (Button)sender;
			Random rnd = new Random();
			var num = rnd.Next(1) + 1;
			if ((object)num == bt.Content) {
				MessageBox.Show("正解！");
			} else {
				MessageBox.Show("はずれ");
			}
		}
	}
}
