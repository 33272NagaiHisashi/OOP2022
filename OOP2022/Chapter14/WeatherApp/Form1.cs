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
            foreach (var obj in kvp) {
                if (obj.Key.Equals(tbSearch.Text)) {
                    var downloadString = wc.DownloadString($"{url}{obj.Value}.json");
                    var json = JsonConvert.DeserializeObject<Class1[]>(downloadString);
                    for (var i = 0; i < json[1].timeSeries[0].areas.Count(); i++) {
                        cbArea.Items.Add(json[1].timeSeries[0].areas[i].area.name);
                    }
                    var downloadT = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{obj.Value}.json");
                    var jsonT = JsonConvert.DeserializeObject<Area6>(downloadT);
                    tbWeatherInfo.Text = jsonT.text;
                    /*var downloadW = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_week/{obj.Value}.json");
                    var jsonW = JsonConvert.DeserializeObject<Area6>(downloadW);
                    tbWeatherInfoW.Text = jsonW.text;*/
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
                    for (var i = 0; i < json[0].timeSeries[0].areas[0].area.name.Count(); i++) {
                        if (cbArea.Text.Equals(json[0].timeSeries[0].areas[i].area.name)) {
                            var turl = $"{iurl}{json[0].timeSeries[0].areas[i].weatherCodes[0]}.png";
                            var tstream = wc.OpenRead(turl);
                            var tbitmap = new Bitmap(tstream);
                            tstream.Close();
                            pbToday.Image = tbitmap;
                            var tourl = $"{iurl}{json[0].timeSeries[0].areas[i].weatherCodes[1]}.png";
                            var tostream = wc.OpenRead(tourl);
                            var tobitmap = new Bitmap(tostream);
                            tostream.Close();
                            pbTomorrow.Image = tobitmap;
                            var aiurl = $"{iurl}{json[0].timeSeries[0].areas[i].weatherCodes[2]}.png";
                            var astream = wc.OpenRead(aiurl);
                            var abitmap = new Bitmap(astream);
                            astream.Close();
                            pbAsatte.Image = abitmap;

                            tbTodayMaxT.Text = json[0].timeSeries[0].areas[2].area[i].
                        }
                    }
                }
            }
        }
            /*void classifyWeatherCode(uint16_t weather_code) {
                switch (weather_code) {
                    //--------Clear（晴れ）-----------------
                    case 100:
                    case 123:
                    case 124:
                    case 130:
                    case 131:
                        Serial.println("晴れ");
                        break;

                    //--------晴れ時々（一時）曇り----------------
                    case 101:
                    case 132:
                        Serial.println("晴れ時々曇り");
                        break;

                    //--------晴れ時々（一時）雨----------------
                    case 102:
                    case 103:
                    case 106:
                    case 107:
                    case 108:
                    case 120:
                    case 121:
                    case 140:
                        Serial.println("晴れ時々雨");
                        break;

                    //--------晴れ時々（一時）雪----------------
                    case 104:
                    case 105:
                    case 160:
                    case 170:
                        Serial.println("晴れ時々雪");
                        break;

                    //--------晴れ後曇り----------------
                    case 110:
                    case 111:
                        Serial.println("晴れ後曇り");
                        break;

                    //--------晴れ後雨----------------
                    case 112:
                    case 113:
                    case 114:
                    case 118:
                    case 119:
                    case 122:
                    case 125:
                    case 126:
                    case 127:
                    case 128:
                        Serial.println("晴れ後雨");
                        break;

                    //--------晴れ後雪----------------
                    case 115:
                    case 116:
                    case 117:
                    case 181:
                        Serial.println("晴れ後雪");
                        break;

                    //--------曇り-----------------
                    case 200:
                    case 209:
                    case 231:
                        Serial.println("曇り");
                        break;

                    //--------曇り時々晴れ-----------------
                    case 201:
                    case 223:
                        Serial.println("曇り時々晴れ");
                        break;

                    //--------曇り時々雨-----------------
                    case 202:
                    case 203:
                    case 206:
                    case 207:
                    case 208:
                    case 220:
                    case 221:
                    case 240:
                        Serial.println("曇り時々雨");
                        break;

                    //--------曇り一時雪-----------------
                    case 204:
                    case 205:
                    case 250:
                    case 260:
                    case 270:
                        Serial.println("曇り一時雪");
                        break;

                    //--------曇り後晴れ-----------------
                    case 210:
                    case 211:
                        Serial.println("曇り後晴れ");
                        break;

                    //--------曇り後雨-----------------
                    case 212:
                    case 213:
                    case 214:
                    case 218:
                    case 219:
                    case 222:
                    case 224:
                    case 225:
                    case 226:
                        Serial.println("曇り後雨");
                        break;

                    //--------曇り後雪-----------------
                    case 215:
                    case 216:
                    case 217:
                    case 228:
                    case 229:
                    case 230:
                    case 281:
                        Serial.println("曇り後雪");
                        break;

                    //--------雨-----------------
                    case 300:
                    case 304:
                    case 306:
                    case 328:
                    case 329:
                    case 350:
                        Serial.println("雨");
                        break;

                    //--------雨時々晴れ-----------------
                    case 301:
                        Serial.println("雨時々晴れ");
                        break;

                    //--------雨時々曇り-----------------
                    case 302:
                        Serial.println("雨時々曇り");
                        break;

                    //--------雨時々雪-----------------
                    case 303:
                    case 309:
                    case 322:
                        Serial.println("雨時々雪");
                        break;

                    //--------暴風雨-----------------
                    case 308:
                        Serial.println("暴風雨");
                        break;

                    //--------雨後晴れ-----------------
                    case 311:
                    case 316:
                    case 320:
                    case 323:
                    case 324:
                    case 325:
                        Serial.println("雨後晴れ");
                        break;

                    //--------雨後曇り-----------------
                    case 313:
                    case 317:
                    case 321:
                        Serial.println("雨後曇り");
                        break;

                    //--------雨後雪-----------------
                    case 314:
                    case 315:
                    case 326:
                    case 327:
                        Serial.println("雨後雪");
                        break;

                    //--------雪-----------------
                    case 340:
                    case 400:
                    case 405:
                    case 425:
                    case 426:
                    case 427:
                    case 450:
                        Serial.println("雪");
                        break;

                    //--------雪時々晴れ-----------------
                    case 401:
                        Serial.println("雪時々晴れ");
                        break;

                    //--------雪時々曇り-----------------
                    case 402:
                        Serial.println("雪時々曇り");
                        break;

                    //--------雪時々雨-----------------
                    case 403:
                    case 409:
                        Serial.println("雪時々雨");
                        break;

                    //--------暴風雪-----------------
                    case 406:
                    case 407:
                        Serial.println("暴風雪");
                        break;

                    //--------雪後晴れ-----------------
                    case 361:
                    case 411:
                    case 420:
                        Serial.println("雪後晴れ");
                        break;

                    //--------雪後曇り-----------------
                    case 371:
                    case 413:
                    case 421:
                        Serial.println("雪後曇り");
                        break;

                    //--------雪後雨-----------------
                    case 414:
                    case 422:
                    case 423:
                        Serial.println("雪後雨");
                        break;

                    default:
                        break;
                }*/
    }
}
