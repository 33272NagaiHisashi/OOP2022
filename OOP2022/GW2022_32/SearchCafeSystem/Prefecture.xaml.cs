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

namespace SearchCafeSystem {
	/// <summary>
	/// Window1.xaml の相互作用ロジック
	/// </summary>
	public partial class Prefecture : Window {
		List<string> checkedListBox = new List<string>();
		public Prefecture() {
			InitializeComponent();
		}

		private void tbAcquisition_Click(object sender, RoutedEventArgs e) {
			if (cbHokkaido.IsChecked == true) {
				checkedListBox.Add(cbHokkaido.Content.ToString());
			}
			if(cbAomori.IsChecked == true) {
				checkedListBox.Add(cbAomori.Content.ToString());
			}
			if (cbIwate.IsChecked == true) {
				checkedListBox.Add(cbIwate.Content.ToString());
			}
			if (cbAkita.IsChecked == true) {
				checkedListBox.Add(cbAkita.Content.ToString());
			}
			if (cbMiyagi.IsChecked == true) {
				checkedListBox.Add(cbMiyagi.Content.ToString());
			}
			if (cbYamagata.IsChecked == true) {
				checkedListBox.Add(cbYamagata.Content.ToString());
			}
			if (cbFukushima.IsChecked == true) {
				checkedListBox.Add(cbFukushima.Content.ToString());
			}
			if (cbIbaraki.IsChecked == true) {
				checkedListBox.Add(cbIbaraki.Content.ToString());
			}
			if (cbTochigi.IsChecked == true) {
				checkedListBox.Add(cbTochigi.Content.ToString());
			}
			if (cbGunma.IsChecked == true) {
				checkedListBox.Add(cbGunma.Content.ToString());
			}
			if (cbSaitama.IsChecked == true) {
				checkedListBox.Add(cbSaitama.Content.ToString());
			}
			if (cbChiba.IsChecked == true) {
				checkedListBox.Add(cbChiba.Content.ToString());
			}
			if (cbKyoto.IsChecked == true) {
				checkedListBox.Add(cbKyoto.Content.ToString());
			}
			if (cbKanagawa.IsChecked == true) {
				checkedListBox.Add(cbKanagawa.Content.ToString());
			}
			if (cbNiigata.IsChecked == true) {
				checkedListBox.Add(cbNiigata.Content.ToString());
			}
			if (cbToyama.IsChecked == true) {
				checkedListBox.Add(cbToyama.Content.ToString());
			}
			if (cbIshikawa.IsChecked == true) {
				checkedListBox.Add(cbIshikawa.Content.ToString());
			}
			if (cbFukui.IsChecked == true) {
				checkedListBox.Add(cbFukui.Content.ToString());
			}
			if (cbYamanashi.IsChecked == true) {
				checkedListBox.Add(cbYamanashi.Content.ToString());
			}
			if (cbNagano.IsChecked == true) {
				checkedListBox.Add(cbNagano.Content.ToString());
			}
			if (cbGifu.IsChecked == true) {
				checkedListBox.Add(cbGifu.Content.ToString());
			}
			if (cbShizuoka.IsChecked == true) {
				checkedListBox.Add(cbShizuoka.Content.ToString());
			}
			if (cbAichi.IsChecked == true) {
				checkedListBox.Add(cbAichi.Content.ToString());
			}
			if (cbShiga.IsChecked == true) {
				checkedListBox.Add(cbShiga.Content.ToString());
			}
			if (cbMie.IsChecked == true) {
				checkedListBox.Add(cbMie.Content.ToString());
			}
			if (cbKyoto.IsChecked == true) {
				checkedListBox.Add(cbKyoto.Content.ToString());
			}
			if (cbOsaka.IsChecked == true) {
				checkedListBox.Add(cbOsaka.Content.ToString());
			}
			if (cbNara.IsChecked == true) {
				checkedListBox.Add(cbNara.Content.ToString());
			}
			if (cbWakayama.IsChecked == true) {
				checkedListBox.Add(cbWakayama.Content.ToString());
			}
			if (cbHyogo.IsChecked == true) {
				checkedListBox.Add(cbHyogo.Content.ToString());
			}
			if (cbTottori.IsChecked == true) {
				checkedListBox.Add(cbTottori.Content.ToString());
			}
			if (cbShimane.IsChecked == true) {
				checkedListBox.Add(cbShimane.Content.ToString());
			}
			if (cbOkayama.IsChecked == true) {
				checkedListBox.Add(cbOkayama.Content.ToString());
			}
			if (cbHiroshima.IsChecked == true) {
				checkedListBox.Add(cbHiroshima.Content.ToString());
			}
			if (cbYamaguchi.IsChecked == true) {
				checkedListBox.Add(cbYamaguchi.Content.ToString());
			}
			if (cbTokushima.IsChecked == true) {
				checkedListBox.Add(cbTokushima.Content.ToString());
			}
			if (cbKagawa.IsChecked == true) {
				checkedListBox.Add(cbKagawa.Content.ToString());
			}
			if (cbEhime.IsChecked == true) {
				checkedListBox.Add(cbEhime.Content.ToString());
			}
			if (cbKochi.IsChecked == true) {
				checkedListBox.Add(cbKochi.Content.ToString());
			}
			if (cbFukuoka.IsChecked == true) {
				checkedListBox.Add(cbFukuoka.Content.ToString());
			}
			if (cbSaga.IsChecked == true) {
				checkedListBox.Add(cbSaga.Content.ToString());
			}
			if (cbNagasaki.IsChecked == true) {
				checkedListBox.Add(cbNagasaki.Content.ToString());
			}
			if (cbOita.IsChecked == true) {
				checkedListBox.Add(cbOita.Content.ToString());
			}
			if (cbKumamoto.IsChecked == true) {
				checkedListBox.Add(cbKumamoto.Content.ToString());
			}
			if (cbMiyasaki.IsChecked == true) {
				checkedListBox.Add(cbMiyasaki.Content.ToString());
			}
			if (cbKagoshima.IsChecked == true) {
				checkedListBox.Add(cbKagoshima.Content.ToString());
			}
			if (cbOkinawa.IsChecked == true) {
				checkedListBox.Add(cbOkinawa.Content.ToString());
			}
			Results results = new Results();
			results.Show();
			this.Close();
		}

		private void btClose_Click(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
		}
	}
}
