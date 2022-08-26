using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
	public class Settings {

		public int MainFormColor { get; set; }
		private static Settings settings;
		private Settings() { }
		public static Settings getInstance() {
			if (settings == null) {
				settings = new Settings();
			}
			return settings;
		}
	}
}
