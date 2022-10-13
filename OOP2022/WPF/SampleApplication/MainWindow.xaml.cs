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

namespace SampleApplication {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			MessageBox.Show("ボタンが押された！");
		}

		private void cb_Checked(object sender, RoutedEventArgs e) {
			checkBoxTextBlock.Text = "チェック済";
		}

		private void cb_Unchecked(object sender, RoutedEventArgs e) {
			checkBoxTextBlock.Text = "未チェック";
		}

		private void rbRed_Checked(object sender, RoutedEventArgs e) {
			tbColor.Text = "赤";
		}

		private void rbYellow_Checked(object sender, RoutedEventArgs e) {
			tbColor.Text = "黄";
		}

		private void rbBlue_Checked(object sender, RoutedEventArgs e) {
			tbColor.Text = "青";
		}

		private void cbSeason_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			tblockSeason.Text = (string)((ComboBoxItem)cbSeason.SelectedItem).Content;
		}
	}
}
