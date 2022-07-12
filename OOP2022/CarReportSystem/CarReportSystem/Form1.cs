using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
	public partial class Form1 : Form {
		BindingList<CarReport> listCarReport = new BindingList<CarReport>();
		public Form1() {
			InitializeComponent();
			dgvCarReport.DataSource = listCarReport;
		}

		private void btOpenPicture_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				pbPicture.Image = Image.FromFile(openFileDialog.FileName);
			}
		}

		private void btAddReport_Click(object sender, EventArgs e) {
			CarReport carReport = new CarReport {
				Date = dtpDate.Value,
				Auther = cbAuther.Text,
				Maker = GetMakerGroups(),
				CarName = cbCarName.Text,
				Report = tbReport.Text,
				Picture = pbPicture.Image,
			};
			listCarReport.Add(carReport);
			dgvCarReport.Rows[dgvCarReport.RowCount - 1].Selected = true;
		}
		private List<CarReport.MakerGroup> GetMakerGroups() {
			var listMaker = new List<CarReport.MakerGroup>();
			if (rbToyota.Checked) {
				listMaker.Add(CarReport.MakerGroup.トヨタ);
			}
			if (rbNissan.Checked) {
				listMaker.Add(CarReport.MakerGroup.日産);
			}
			if (rbHonda.Checked) {
				listMaker.Add(CarReport.MakerGroup.ホンダ);
			}
			if (rbSubaru.Checked) {
				listMaker.Add(CarReport.MakerGroup.スバル);
			}
			if (rbForeignCar.Checked) {
				listMaker.Add(CarReport.MakerGroup.外国車);
			}
			if (rbOthers.Checked) {
				listMaker.Add(CarReport.MakerGroup.その他);
			}
			return listMaker;
		}
	}
}
