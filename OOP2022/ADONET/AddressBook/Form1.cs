using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
			this.Validate();
			this.addressTableBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.infosys202232DataSet);

		}

		private void Form1_Load(object sender, EventArgs e) {
			// TODO: このコード行はデータを 'infosys202232DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

		}

		private void btConnect_Click(object sender, EventArgs e) {
			this.addressTableTableAdapter.Fill(this.infosys202232DataSet.AddressTable);
		}

		private void btUpdate_Click(object sender, EventArgs e) {
			dgvAddressTable.CurrentRow.Cells[1].Value = tbName.Text;
			dgvAddressTable.CurrentRow.Cells[2].Value = tbTel.Text;
			dgvAddressTable.CurrentRow.Cells[3].Value = tbMail.Text;
			dgvAddressTable.CurrentRow.Cells[4].Value = tbAddress.Text;
			dgvAddressTable.CurrentRow.Cells[5].Value = tbMemo.Text;
			//dgvAddressTable.CurrentRow.Cells[6].Value = pbImage.Image;
			dgvAddressTable.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
			this.Validate();
			this.addressTableBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.infosys202232DataSet);
		}

		private void dgvAddressTable_Click(object sender, EventArgs e) {
			if (dgvAddressTable.CurrentRow == null) {
				return;
			}
			
			tbName.Text = dgvAddressTable.CurrentRow.Cells[1].Value.ToString();
			tbTel.Text = dgvAddressTable.CurrentRow.Cells[2].Value.ToString();
			tbMail.Text = dgvAddressTable.CurrentRow.Cells[3].Value.ToString();
			tbAddress.Text = dgvAddressTable.CurrentRow.Cells[4].Value.ToString();
			tbMemo.Text = dgvAddressTable.CurrentRow.Cells[5].Value.ToString();
			if (!(dgvAddressTable.CurrentRow.Cells[6].Value is DBNull)) {
				pbImage.Image = ByteArrayToImage((byte[])dgvAddressTable.CurrentRow.Cells[6].Value);
			} else {
				pbImage.Image = null;
			}
			//pbImage.Image = (Image)dgvAddressTable.CurrentRow.Cells[6].Value;
			/*if (!DBNull.Value.Equals(dgvAddressTable.CurrentRow.Cells[6].Value)){
				pbImage.Image = ByteArrayToImage((byte[])dgvAddressTable.CurrentRow.Cells[6].Value);
			}*/
		}

		private void btOpenImage_Click(object sender, EventArgs e) {
			//ofdImage.Filter = "画像ファイル(*.jpg,*.png,*.bmp) | *.jpg,*.bmp";
			if (ofdImage.ShowDialog() == DialogResult.OK) {
				pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
			}
		}

		private void btDeleteImage_Click(object sender, EventArgs e) {
			pbImage.Image = null;
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

		private void dgvAddressTable_DataError(object sender, DataGridViewDataErrorEventArgs e) {

		}

		private void btSearch_Click(object sender, EventArgs e) {
			addressTableTableAdapter.FillByName(infosys202232DataSet.AddressTable, tbSearch.Text);
		}

		private void btAdd_Click(object sender, EventArgs e) {
			DataRow newRow = infosys202232DataSet.AddressTable.NewRow();
			newRow[1] = tbName.Text;
			newRow[2] = tbTel.Text;
			newRow[3] = tbMail.Text;
			newRow[4] = tbAddress.Text;
			newRow[5] = tbMemo.Text;
			newRow[6] = pbImage.Image;
			//データセットへ新しいレコードを追加
			infosys202232DataSet.AddressTable.Rows.Add(newRow);
			//データベース更新
			this.addressTableTableAdapter.Update(this.infosys202232DataSet.AddressTable);
		}

		private void btClear_Click(object sender, EventArgs e) {
			tbName.Clear();
			tbAddress.Clear();
			tbTel.Clear();
			tbMail.Clear();
			tbMemo.Clear();
			pbImage.Image = null;
		}

		private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {

		}

		private void btSearchClear_Click(object sender, EventArgs e) {
			tbSearch.Clear();
			addressTableTableAdapter.FillByName(infosys202232DataSet.AddressTable,"");
		}

		private void tsmiVersionInformation_Click(object sender, EventArgs e) {
			new Version().ShowDialog();
		}
	}
}
