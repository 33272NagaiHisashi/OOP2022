using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
	public partial class Form1 : Form {
		BindingList<CarReport> listCarReport = new BindingList<CarReport>();
		int mode;
		public Form1() {
			InitializeComponent();
			dgvCarReport.DataSource = listCarReport;
		}

		private void btOpenPicture_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				pbPicture.Image = Image.FromFile(openFileDialog.FileName);
			}
		}

		private void btDeletePicture_Click(object sender, EventArgs e) {
			pbPicture.Image = null;
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

		private void btFixRecord_Click(object sender, EventArgs e) {
			if (dgvCarReport.CurrentRow == null) return;

			listCarReport[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
			listCarReport[dgvCarReport.CurrentRow.Index].Auther = cbAuther.Text;
			listCarReport[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
			listCarReport[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
			listCarReport[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;

			dgvCarReport.Refresh();
		}

		private void btDeleteRecord_Click(object sender, EventArgs e) { 
			if (dgvCarReport.CurrentRow == null) return;
			int index = dgvCarReport.CurrentRow.Index;
			listCarReport.RemoveAt(index);

		}

		private void dgvCarReport_Click(object sender, EventArgs e) {
			if (dgvCarReport.CurrentRow == null) return;

			int index = dgvCarReport.CurrentRow.Index;

			dtpDate.Value = listCarReport[index].Date;
			cbAuther.Text = listCarReport[index].Auther;
			cbCarName.Text = listCarReport[index].CarName;
			tbReport.Text = listCarReport[index].Report;
			pbPicture.Image = listCarReport[index].Picture;
		}

		private void btExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void btOpenReport_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					var bf = new BinaryFormatter();
					using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open)) {
						listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
						dgvCarReport.DataSource = null;
						dgvCarReport.DataSource = listCarReport;
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
				foreach (var item in listCarReport.Select(p => p.Auther)) {
					setAuther(item); //存在する会社を登録
				}
				foreach (var item in listCarReport.Select(p => p.CarName)) {
					setCarName(item); //存在する会社を登録
				}
			}
		}

		private void setCarName(string item) {
			if (!cbCarName.Items.Contains(item)) {
				cbCarName.Items.Add(item);
			}
		}

		private void setAuther(string item) {
			if (!cbAuther.Items.Contains(item)) {
				cbAuther.Items.Add(item);
			}
		}

		private void btSaveReport_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					var bf = new BinaryFormatter();
					using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Create)) {
						bf.Serialize(fs, listCarReport);
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void ColorSetting_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			pbPicture.SizeMode = (PictureBoxSizeMode)mode;
		}
	}
}
