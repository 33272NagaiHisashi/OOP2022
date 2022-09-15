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
			DataRow newRow = infosys202232DataSet.CarReportDB.NewRow();
			newRow[1] = dtpDate.Value;
			newRow[2] = cbAuther.Text;
			newRow[3] = GetRadioButton();
			newRow[4] = cbCarName.Text;
			newRow[5] = tbReport.Text;
			newRow[6] = ImageToByteArray(pbPicture.Image);
			//データセットへ新しいレコードを追加
			infosys202232DataSet.CarReportDB.Rows.Add(newRow);
			//データベース更新
			this.carReportDBTableAdapter.Update(this.infosys202232DataSet.CarReportDB);
		}

		private string GetRadioButton() {
			if (rbToyota.Checked) {
				return "トヨタ";
			}
			if (rbNissan.Checked) {
				return "日産";
			}
			if (rbHonda.Checked) {
				return "ホンダ";
			}
			if (rbSubaru.Checked) {
				return "スバル";
			}
			if (rbForeignCar.Checked) {
				return "外国車";
			}
			return "その他";
		}

		private void dgvCarReport_Click(object sender, EventArgs e) {
			
			dtpDate.Value = DateTime.Parse(dgvCarReport.CurrentRow.Cells[1].Value.ToString());
			cbAuther.Text = dgvCarReport.CurrentRow.Cells[2].Value.ToString();
			setMarkerRadioSet(dgvCarReport.CurrentRow.Cells[3].Value.ToString());
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
			dgvCarReport.CurrentRow.Cells[3].Value = GetRadioButton();
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

		private void btSearch_Click(object sender, EventArgs e) {
			carReportDBTableAdapter.FillBy(infosys202232DataSet.CarReportDB, tbSearch.Text);
		}

		private void btClearSearch_Click(object sender, EventArgs e) {
			tbSearch.Clear();
			carReportDBTableAdapter.FillBy(infosys202232DataSet.CarReportDB, "");
		}
		
		private void setMarkerRadioSet(string Marker) {
			switch (Marker) {
				case "トヨタ":
					rbToyota.Checked = true;
					break;
				case "日産":
					rbNissan.Checked = true;
					break;
				case "ホンダ":
					rbHonda.Checked = true;
					break;
				case "スバル":
					rbSubaru.Checked = true;
					break;
				case "外国車":
					rbForeignCar.Checked = true;
					break;
				case "その他":
					rbOthers.Checked = true;
					break;
			}
		}

		private void btDelete_Click(object sender, EventArgs e) {
			carReportDBBindingSource.RemoveAt(dgvCarReport.CurrentRow.Index);
			this.tableAdapterManager.UpdateAll(this.infosys202232DataSet);
		}
	}
}
