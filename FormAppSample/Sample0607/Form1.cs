using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
	public partial class Form1 : Form {

		Random rand = new Random();
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e) {
			var min = int.Parse(tbMin.Text);
			var max = int.Parse(tbMax.Text);
			tbRandom.Text = rand.Next((int)min,(int)max + 1).ToString();
		}
	}
}
