﻿using System;
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
	public partial class Results : Window {
		public Results() {
			InitializeComponent();
		}

		private void tbMenu_Click(object sender, RoutedEventArgs e) {
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
		}

		private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {

		}
	}
}
