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

		Random rnd = new Random();
		private int num;

		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Button bt = (Button)sender;
			if (num == int.Parse(bt.Content.ToString())) {
				bt.Background = Brushes.Green;
				infoDisp.Text = "正解！";
			}
			if (num > int.Parse(bt.Content.ToString())) {
				bt.Background = Brushes.Red;
				infoDisp.Text = int.Parse(bt.Content.ToString()) + " より大きい";
			}
			if (num < int.Parse(bt.Content.ToString())) {
				bt.Background = Brushes.Red;
				infoDisp.Text = int.Parse(bt.Content.ToString()) + " より小さい";
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			infoDisp.Text = "ゲームスタート";
			num = rnd.Next(25) + 1;
			this.Title = num.ToString();
		}
	}
}
