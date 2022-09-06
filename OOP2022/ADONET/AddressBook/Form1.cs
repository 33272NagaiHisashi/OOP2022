﻿using System;
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
			tbName.Text = dgvAddressTable.CurrentRow.Cells[1].Value.ToString();
			tbTel.Text = dgvAddressTable.CurrentRow.Cells[2].Value.ToString();
			tbMail.Text = dgvAddressTable.CurrentRow.Cells[3].Value.ToString();
			tbAddress.Text = dgvAddressTable.CurrentRow.Cells[4].Value.ToString();
			tbMemo.Text = dgvAddressTable.CurrentRow.Cells[5].Value.ToString();
		}

		private void btOpenImage_Click(object sender, EventArgs e) {
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
	}
}