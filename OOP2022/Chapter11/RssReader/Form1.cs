using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
	public partial class Form1 : Form {

		/*List<string> titleList = new List<string>();
		List<string> linkList = new List<string>();*/
		IEnumerable<string> xLink, xTitle;

		public Form1() {
			InitializeComponent();
		}

		private void btRss_Click(object sender, EventArgs e) {

			using (var wc = new WebClient()) {
				ClearPage();
			
				var stream = wc.OpenRead(cbRss.Text);
				var xdoc = XDocument.Load(stream);
				xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
				xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

				foreach (var data in xTitle) {
					lbRss.Items.Add(data);
				}
				/*foreach(var link in xLink) {
					linkList.Add(link.Value);
				}*/
				setCbRss(cbRss.Text);
			}
		}

		private void setCbRss(String site) {
			if (!cbRss.Items.Contains(site)) {
				cbRss.Items.Add(site);
			}
		}

		private void ClearPage() {
			lbRss.Items.Clear();
		}

		private void lbRss_SelectedIndexChanged(object sender, EventArgs e) {
			var index = lbRss.SelectedIndex;
			//wbRss.Navigate(linkList[index]);
			var url = xLink.ElementAt(index);
			wvBrowser.Source = new Uri(url);
		}

		private void Form1_Load(object sender, EventArgs e) {
			//wbRss.ScriptErrorsSuppressed = true;
			buttonEnableCheck();
		}

		private void btBack_Click(object sender, EventArgs e) {
			wvBrowser.GoBack();
		}

		private void btForward_Click(object sender, EventArgs e) {
			wvBrowser.GoForward();
		}

		private void wvBrowser_DOMContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e) {
			buttonEnableCheck();
		}

		private void buttonEnableCheck() {
			btBack.Enabled = wvBrowser.CanGoBack;
			btForward.Enabled = wvBrowser.CanGoForward;
		}
	}
}
