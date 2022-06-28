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
		public Form1() {
			InitializeComponent();
		}

		private void btRss_Click(object sender, EventArgs e) {

			using (var wc = new WebClient()) {
				
				ClearPage();
			
				var stream = wc.OpenRead(cbRss.Text);

				var xdoc = XDocument.Load(stream);
				var xNews = xdoc.Root.Descendants("item").Select(x => x.Element("title"));

				var tilteList = new List<string>();
				var linkList = new List<string>();

				foreach (var data in xNews) {
					lbRss.Items.Add(data.Value);
				}
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
			wbRss.Refresh();
		}

		private void lbRss_SelectedIndexChanged(object sender, EventArgs e) {
			var index = lbRss.SelectedIndex;
		}
	}
}
