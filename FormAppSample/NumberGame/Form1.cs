using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
	public partial class Form1 : Form {

		private Random rd = new Random();
		private int rdNum;

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			getRandom();
			this.Text = rdNum.ToString();
		}

		private void btInsert_Click(object sender, EventArgs e) {
			if (int.Parse(tbNum.Text) == rdNum) {
				lbRW.Text = "成功！";
				lbHint.Text = "";
			}
			if (int.Parse(tbNum.Text) > rdNum) {
				lbRW.Text = "失敗";
				lbHint.Text = tbNum.Text + "　より小さい値です";
			}
			if (int.Parse(tbNum.Text) < rdNum) {
				lbRW.Text = "失敗";
				lbHint.Text = tbNum.Text + "　より大きい値です";
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			getRandom();
			this.Text = rdNum.ToString();
		}
		private void getRandom() {
			var max = int.Parse(textBox1.Text);
			rdNum = rd.Next(1, (int)max + 1);
		}
	}
}
