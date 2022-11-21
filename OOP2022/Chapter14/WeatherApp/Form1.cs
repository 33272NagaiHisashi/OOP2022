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
		string url = "https://www.jma.go.jp/bosai/forecast/data/forecast/";
		RegionReader regionReader = new RegionReader("areacode.csv");
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			/*var kvp = regionReader.keyValuePairs();
			foreach(var obj in kvp) {
				cbState.Items.Add(obj.Key);
			}*/
		}

		private void btAcquisition_Click(object sender, EventArgs e) {
			var wc = new WebClient();
			wc.Encoding = Encoding.UTF8;
			var kvp = regionReader.keyValuePairs();
			foreach(var obj in kvp) {
				if (obj.Key.Equals(tbSearch.Text)) {
					var downloadString = wc.DownloadString($"{url}{obj.Value}.json");
					var json = JsonConvert.DeserializeObject<Class1[]>(downloadString);
					tbPublishingOffice.Text = json[0].publishingOffice;
					for (var i = 0; i < json[0].timeSeries[0].areas.Count(); i++) {
						cbArea.Items.Add(json[0].timeSeries[0].areas[i].area.name);
					}
				}
			}
		}

		private void cbArea_SelectedIndexChanged(object sender, EventArgs e) {

		}
	}
}
