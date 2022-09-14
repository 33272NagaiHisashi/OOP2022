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
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
	public partial class Form1 : Form {
		Settings settings = Settings.getInstance();
		BindingList<CarReport> listCarReport = new BindingList<CarReport>();
		public Form1() {
			InitializeComponent();
			//dgvCarReport.DataSource = listCarReport;
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
			/*CarReport carReport = new CarReport {
				Date = dtpDate.Value,
				Auther = cbAuther.Text,
				Maker = GetMakerGroups(),
				CarName = cbCarName.Text,
				Report = tbReport.Text,
				Picture = pbPicture.Image,
			};
			listCarReport.Add(carReport);
			dgvCarReport.Rows[dgvCarReport.RowCount - 1].Selected = true;*/
			DataRow newRow = infosys202232DataSet.CarReportDB.NewRow();
			newRow[1] = dtpDate.Value;
			newRow[2] = cbAuther.Text;
			//newRow[3] = GetMakerGroups();
			newRow[4] = cbCarName.Text;
			newRow[5] = tbReport.Text;
			newRow[6] = ImageToByteArray(pbPicture.Image);
			//データセットへ新しいレコードを追加
			infosys202232DataSet.CarReportDB.Rows.Add(newRow);
			//データベース更新
			this.carReportDBTableAdapter.Update(this.infosys202232DataSet.CarReportDB);
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
			listCarReport[dgvCarReport.CurrentRow.Index].Maker = GetMakerGroups();

			dgvCarReport.Refresh();
		}

		private void btDeleteRecord_Click(object sender, EventArgs e) { 
			if (dgvCarReport.CurrentRow == null) return;
			int index = dgvCarReport.CurrentRow.Index;
			listCarReport.RemoveAt(index);

		}

		private void dgvCarReport_Click(object sender, EventArgs e) {
			/*if (dgvCarReport.CurrentRow == null) return;

			int index = dgvCarReport.CurrentRow.Index;

			dtpDate.Value = listCarReport[index].Date;
			cbAuther.Text = listCarReport[index].Auther;
			cbCarName.Text = listCarReport[index].CarName;
			tbReport.Text = listCarReport[index].Report;
			pbPicture.Image = listCarReport[index].Picture;*/
			
			dtpDate.Value = DateTime.Parse(dgvCarReport.CurrentRow.Cells[1].Value.ToString());
			cbAuther.Text = dgvCarReport.CurrentRow.Cells[2].Value.ToString();
			cbCarName.Text = dgvCarReport.CurrentRow.Cells[4].Value.ToString();
			tbReport.Text = dgvCarReport.CurrentRow.Cells[5].Value.ToString();
			if (!(dgvCarReport.CurrentRow.Cells[6].Value is DBNull)) {
				pbPicture.Image = ByteArrayToImage((byte[])dgvCarReport.CurrentRow.Cells[6].Value);
			} else {
				pbPicture.Image = null;
			}
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
					setAuther(item); 
				}
				foreach (var item in listCarReport.Select(p => p.CarName)) {
					setCarName(item);
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
			if (colorDialog.ShowDialog() == DialogResult.OK) {
				BackColor = colorDialog.Color;
				settings.MainFormColor = colorDialog.Color.ToArgb();
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			using (var color = XmlWriter.Create("settings.xml")) {
				var serializer = new XmlSerializer(settings.GetType());
				serializer.Serialize(color, settings);
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			try {
				using (var reader = XmlReader.Create("settings.xml")) {
					var serializer = new XmlSerializer(typeof(Settings));
					var setting = serializer.Deserialize(reader) as Settings;
					BackColor = Color.FromArgb(settings.MainFormColor);
				}
			} catch (Exception) {
			}
		}

		private void CarReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
			this.Validate();
			this.carReportDBBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.infosys202232DataSet);
		}

		private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
			this.carReportDBTableAdapter.Fill(this.infosys202232DataSet.CarReportDB);
		}

		private void dgvCarReport_DataError(object sender, DataGridViewDataErrorEventArgs e) {

		}

		// バイト配列をImageオブジェクトに変換
		public static Image ByteArrayToImage(byte[] b) {
			ImageConverter imgconv = new ImageConverter();
			Image img = (Image)imgconv.ConvertFrom(b);
			return img;
		}

		// Imageオブジェクトをバイト配列に変換
		public static byte[] ImageToByteArray(Image img) {
			ImageConverter imgconv = new ImageConverter();
			byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
			return b;
		}

		private void tsmiUpdate_Click(object sender, EventArgs e) {
			dgvCarReport.CurrentRow.Cells[1].Value = dtpDate.Value;
			dgvCarReport.CurrentRow.Cells[2].Value = cbAuther.Text;
			dgvCarReport.CurrentRow.Cells[3].Value = GetMakerGroups();
			dgvCarReport.CurrentRow.Cells[4].Value = cbCarName.Text;
			dgvCarReport.CurrentRow.Cells[5].Value = tbReport.Text;
			dgvCarReport.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);
			this.Validate();
			this.carReportDBBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.infosys202232DataSet);
		}

		private void btClear_Click(object sender, EventArgs e) {
			dtpDate.Value = DateTime.Now;
			cbAuther.Text = null;
			cbCarName.Text = null;
			tbReport.Clear();
			pbPicture.Image = null;
		}
	}
}
