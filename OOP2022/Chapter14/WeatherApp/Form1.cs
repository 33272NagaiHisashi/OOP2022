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
		string iurl = "https://www.jma.go.jp/bosai/forecast/img/";
		RegionReader regionReader = new RegionReader("areacode.csv");
		WebClient wc = new WebClient();
		public Form1() {
			InitializeComponent();
		}

        private void btAcquisition_Click(object sender, EventArgs e) {
            wc.Encoding = Encoding.UTF8;
            var kvp = regionReader.keyValuePairs();
            cbArea.Items.Clear();
            cbArea.Text = null;
            pbToday.Image = null;
            pbTomorrow.Image = null;
            pbAsatte.Image = null;
            tbTodayMaxT.Text = null;
            tbTodayMinT.Text = null;
            tbTomorrowMaxT.Text = null;
            tbTomorrowMinT.Text = null;
            tbAssateMaxT.Text = null;
            tbAssateMinT.Text = null;
            foreach (var obj in kvp) {
                if (obj.Key.Equals(tbSearch.Text)) {
                    var downloadString = wc.DownloadString($"{url}{obj.Value}.json");
                    var json = JsonConvert.DeserializeObject<Class1[]>(downloadString);
                    for (var i = 0; i < json[0].timeSeries[2].areas.Count(); i++) {
                        cbArea.Items.Add(json[0].timeSeries[2].areas[i].area.name);
                    }
                    var downloadT = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{obj.Value}.json");
                    var jsonT = JsonConvert.DeserializeObject<Area6>(downloadT);
                    tbWeatherInfo.Text = jsonT.text;
                }
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e) {
            wc.Encoding = Encoding.UTF8;
            var kvp = regionReader.keyValuePairs();
            foreach (var obj in kvp) {
                if (obj.Key.Equals(tbSearch.Text)) {
                    var downloadString = wc.DownloadString($"{url}{obj.Value}.json");
                    var json = JsonConvert.DeserializeObject<Class1[]>(downloadString);
                    for (var i = 0; i < json[0].timeSeries[0].areas.Count(); i++) {
                        if (cbArea.SelectedIndex == i) {
                            var turl = $"{iurl}{classifyWeatherCode(json[0].timeSeries[0].areas[i].weatherCodes[0])}.png";
                            var tstream = wc.OpenRead(turl);
                            var tbitmap = new Bitmap(tstream);
                            tstream.Close();
                            pbToday.Image = tbitmap;
                            tbTodayMaxT.Text = Math.Ceiling(double.Parse(json[1].tempAverage.areas[i].max)).ToString();
                            tbTodayMinT.Text = Math.Ceiling(double.Parse(json[1].tempAverage.areas[i].min)).ToString();
                            var tourl = $"{iurl}{classifyWeatherCode(json[0].timeSeries[0].areas[i].weatherCodes[1])}.png";
                            var tostream = wc.OpenRead(tourl);
                            var tobitmap = new Bitmap(tostream);
                            tostream.Close();
                            pbTomorrow.Image = tobitmap;
                            tbTomorrowMaxT.Text = json[1].timeSeries[1].areas[i].tempsMax[1];
                            tbTomorrowMinT.Text = json[1].timeSeries[1].areas[i].tempsMin[1];
                            var aiurl = $"{iurl}{classifyWeatherCode(json[0].timeSeries[0].areas[i].weatherCodes[2])}.png";
                            var astream = wc.OpenRead(aiurl);
                            var abitmap = new Bitmap(astream);
                            astream.Close();
                            pbAsatte.Image = abitmap;
                            tbAssateMaxT.Text = json[1].timeSeries[1].areas[i].tempsMax[2];
                            tbAssateMinT.Text = json[1].timeSeries[1].areas[i].tempsMin[2];
                        }
                    }
                }
            }
        }
        string classifyWeatherCode(string str) {
            switch (str) {
                case "100":
                case "123":
                case "124":
                case "130":
                case "131":
                    str = "100";
                    break;
                case "101":
                case "132":
                    str = "101";
                    break;
                case "102":
                case "103":
                case "106":
                case "107":
                case "108":
                case "120":
                case "121":
                case "122":
                case "140":
                    str = "102";
                    break;
                case "104":
                case "105":
                case "160":
                case "170":
                    str = "104";
                    break;
                case "110":
                case "111":
                    str = "110";
                    break;
                case "112":
                case "113":
                case "114":
                case "118":
                case "119":
                case "125":
                case "126":
                case "127":
                case "128":
                    str = "112";
                    break;
                case "115":
                case "116":
                case "117":
                case "181":
                    str = "115";
                    break;
                case "200":
                case "209":
                case "231":
                    str = "200";
                    break;
                case "201":
                case "223":
                    str = "201";
                    break;
                case "202":
                case "203":
                case "206":
                case "207":
                case "208":
                case "220":
                case "221":
                case "240":
                    str = "202";
                    break;
                case "204":
                case "205":
                case "250":
                case "260":
                case "270":
                    str = "204";
                    break;
                case "210":
                case "211":
                    str = "210";
                    break;
                case "212":
                case "213":
                case "214":
                case "218":
                case "219":
                case "222":
                case "224":
                case "225":
                case "226":
                    str = "212";
                    break;
                case "215":
                case "216":
                case "217":
                case "228":
                case "229":
                case "230":
                case "281":
                    str = "215";
                    break;
                case "300":
                case "304":
                case "328":
                case "329":
                case "350":
                    str = "300";
                    break;
                case "301":
                    str = "301";
                    break;
                case "302":
                    str = "302";
                    break;
                case "303":
                case "309":
                case "322":
                    str = "303";
                    break;
                case "308":
                    str = "308";
                    break;
                case "311":
                case "316":
                case "320":
                case "323":
                case "324":
                case "325":
                    str = "311";
                    break;
                case "313":
                case "317":
                case "321":
                    str = "313";
                    break;
                case "314":
                case "315":
                case "326":
                case "327":
                    str = "314";
                    break;
                case "340":
                case "400":
                case "405":
                case "425":
                case "426":
                case "427":
                case "450":
                    str = "400";
                    break;
                case "401":
                    str = "401";
                    break;
                case "402":
                    str = "402";
                    break;
                case "403":
                case "409":
                    str = "403";
                    break;
                case "406":
                case "407":
                    str = "406";
                    break;
                case "361":
                case "411":
                case "420":
                    str = "411";
                    break;
                case "371":
                case "413":
                case "421":
                    str = "413";
                    break;
                case "414":
                case "422":
                    str = "414";
                    break;
            }
            return str;
        }
    }
}
