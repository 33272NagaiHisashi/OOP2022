using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker2 {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		List<MyColor> stockMyColors = new List<MyColor>();
		public MainWindow() {
			InitializeComponent();
			DataContext = GetColorList();
		}
		private MyColor[] GetColorList() {
			return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
				.Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			setColor();
		}
		private void Slider_ValueChanged(Object sender, RoutedPropertyChangedEventArgs<double> e) {
			setColor();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
			var color = mycolor.Color;
			var name = mycolor.Name;

			SolidColorBrush scb = new SolidColorBrush(color);
			lColor.Background = scb;

			tbRed.Text = Convert.ToString(color.R, 10);
			tbGreen.Text = Convert.ToString(color.G, 10);
			tbBlue.Text = Convert.ToString(color.B, 10);
			setColor();
		}

		private void setColor() {
			var R = byte.Parse(tbRed.Text);
			var G = byte.Parse(tbGreen.Text);
			var B = byte.Parse(tbBlue.Text);

			SolidColorBrush scb = new SolidColorBrush(Color.FromRgb(R, G, B));
			lColor.Background = scb;
		}

		private void btStock_Click(object sender, RoutedEventArgs e) {

			MyColor myColor = new MyColor {
				Color = Color.FromRgb(byte.Parse(tbRed.Text), byte.Parse(tbGreen.Text), byte.Parse(tbBlue.Text))
			};
			var colorName = ((IEnumerable<MyColor>)DataContext).Where(c => c.Color.R == Color.FromRgb(byte.Parse(tbRed.Text), byte.Parse(tbGreen.Text), byte.Parse(tbBlue.Text)).R &&
																		  c.Color.G == Color.FromRgb(byte.Parse(tbRed.Text), byte.Parse(tbGreen.Text), byte.Parse(tbBlue.Text)).G &&
																		  c.Color.B == Color.FromRgb(byte.Parse(tbRed.Text), byte.Parse(tbGreen.Text), byte.Parse(tbBlue.Text)).B).FirstOrDefault();
			stockList.Items.Insert(0, $"R :{myColor.Color.R.ToString()} G :{myColor.Color.G.ToString()} B :{myColor.Color.B.ToString()}");
			//stockList.Items.Insert(0, $"R :{tbRed.Text} G :{tbGreen.Text} B :{tbBlue.Text}");
		}

		private void btDelete_Click(object sender, RoutedEventArgs e) {
			if (stockList.SelectedIndex == -1) return;
			int sel = stockList.SelectedIndex;
			stockList.Items.RemoveAt(sel);
		}

		private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			var index = stockList.SelectedIndex;

			/*tbRed.Text = stockMyColors[index].Color.R.ToString();
			tbGreen.Text = stockMyColors[index].Color.G.ToString();
			tbBlue.Text = stockMyColors[index].Color.B.ToString();*/

			sRed.Value = stockMyColors[index].Color.R;
			sGreen.Value = stockMyColors[index].Color.G;
			sBlue.Value = stockMyColors[index].Color.B;

			setColor();
		}
		/// <summary>
		/// 色と色名を保持するクラス
		/// </summary>
		public class MyColor {
			public Color Color { get; set; }
			public string Name { get; set; }
		}
	}
}

