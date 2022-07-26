﻿using System;
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

namespace ColorChecker {
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
			var stColor = GetMyColor(byte.Parse(tbRed.Text), byte.Parse(tbGreen.Text), byte.Parse(tbBlue.Text));
			stockList.Items.Insert(0,stColor.Name ?? $"R :{stColor.Color.R} G :{stColor.Color.G} B :{stColor.Color.B}");
			stockMyColors.Insert(0, stColor);
		}

		private void btDelete_Click(object sender, RoutedEventArgs e) {
			if (stockList.SelectedIndex == -1) return;
			var index = stockList.SelectedIndex;
			stockList.Items.RemoveAt(index);
			stockMyColors.RemoveAt(index);
		}

		private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			if (stockList.SelectedIndex == -1) return;
			var index = stockList.SelectedIndex;

			tbRed.Text = stockMyColors[index].Color.R.ToString();
			tbGreen.Text = stockMyColors[index].Color.G.ToString();
			tbBlue.Text = stockMyColors[index].Color.B.ToString();
			
			/*sRed.Value = stockMyColors[index].Color.R;
			sGreen.Value = stockMyColors[index].Color.G;
			sBlue.Value = stockMyColors[index].Color.B;*/

			setColor();
		}

		private MyColor GetMyColor(byte R, byte G, byte B) {
			return new MyColor {
				Color = Color.FromRgb(R, G, B),
				Name = ((IEnumerable<MyColor>)DataContext).Where(c => c.Color.R == R &&
																	  c.Color.G == G &&
																	  c.Color.B == B)
														　.Select(c => c.Name).FirstOrDefault()
		};

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

