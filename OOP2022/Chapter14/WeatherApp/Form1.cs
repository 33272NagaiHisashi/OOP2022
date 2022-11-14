using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btAcquisition_Click(object sender, EventArgs e) {
			var wc = new WebClient() {
				Encoding = Encoding.UTF8
			};
			var downloadString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");

			var json = JsonConvert.DeserializeObject<Class1[]>(downloadString);

			tbWeatherInfo.Text = json[0].publishingOffice;
		}
	}
}
