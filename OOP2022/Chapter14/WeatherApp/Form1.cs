using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
		string url = "https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json";
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			var wc = new WebClient();
			wc.Encoding = Encoding.UTF8;
			var downloadString = wc.DownloadString(url);
			var json = JsonConvert.DeserializeObject<Class1[]>(downloadString);
			tbPublishingOffice.Text = json[0].publishingOffice;
		}
	}
}
