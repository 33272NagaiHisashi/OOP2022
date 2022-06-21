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

namespace AddressBook {
	public partial class Form1 : Form {

		BindingList<Person> listPerson = new BindingList<Person>();
		public Form1() {
			InitializeComponent();
			dgvPersons.DataSource = listPerson;
		}

		private void btPictureOpen_Click(object sender, EventArgs e) {
			if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
				pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
			}
		}

		private void btAddPerson_Click(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(tbName.Text)) {
				MessageBox.Show("氏名が入力されていません");
				return;
			}
			Person newPerson = new Person {
				Name = tbName.Text,
				MailAddress = tbMailAddress.Text,
				Address = tbAddress.Text,
				Company = cbCompany.Text,
				Picture = pbPicture.Image,
				listGroup = GetCheckBoxGroup(),
			};
			listPerson.Add(newPerson);
			dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

			EnableCheck();

			setCbCompany(cbCompany.Text);
		}

		private void setCbCompany(string company) {
			if (!cbCompany.Items.Contains(company)) {
				cbCompany.Items.Add(company);
			}
		}

		private void btUpdate_Click(object sender, EventArgs e) {
			if (dgvPersons.CurrentRow == null) return;

			listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
			listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
			listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
			listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
			listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
			dgvPersons.
			Refresh();
		}

		private void btDelete_Click(object sender, EventArgs e) {
			if (dgvPersons.CurrentRow == null) return;

			EnableCheck();

			listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
			dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

		}

		private void EnableCheck() {
			btDelete.Enabled = listPerson.Count() > 0 ? true : false;
			btUpdate.Enabled = listPerson.Count() > 0 ? true : false;
		}

		//チェックボックスにセットされている値をリストとして取り出す
		private List<Person.GroupType> GetCheckBoxGroup() {
			var listGroup = new List<Person.GroupType>();
			if (cbFamily.Checked == true) {
				listGroup.Add(Person.GroupType.家族);
			}
			if (cbFriend.Checked == true) {
				listGroup.Add(Person.GroupType.友人);
			}
			if (cbWork.Checked == true) {
				listGroup.Add(Person.GroupType.仕事);
			}
			if (cbOther.Checked == true) {
				listGroup.Add(Person.GroupType.その他);
			}
			return listGroup;
		}

		private void btPictureClear_Click(object sender, EventArgs e) {
			pbPicture.Image = null;
		}

		private void dgvPersons_Click(object sender, EventArgs e) {
			if (dgvPersons.CurrentRow == null) return;

			int index = dgvPersons.CurrentRow.Index;

			tbName.Text = listPerson[index].Name;
			tbMailAddress.Text = listPerson[index].MailAddress;
			tbAddress.Text = listPerson[index].Address;
			cbCompany.Text = listPerson[index].Company;
			pbPicture.Image = listPerson[index].Picture;

			groupCheckBoxAllClear();

			foreach (var group in listPerson[index].listGroup) {
				switch (group) {
					case Person.GroupType.家族:
						cbFamily.Checked = true;
						break;
					case Person.GroupType.友人:
						cbFriend.Checked = true;
						break;
					case Person.GroupType.仕事:
						cbWork.Checked = true;
						break;
					case Person.GroupType.その他:
						cbOther.Checked = true;
						break;
				}
			}
		}

		private void groupCheckBoxAllClear() {
			cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
		}

		private void Form1_Load(object sender, EventArgs e) {
			EnableCheck();
		}

		private void btSave_Click(object sender, EventArgs e) {
			if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
				try {
					var bf = new BinaryFormatter();
					using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
						bf.Serialize(fs, listPerson);
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btOpen_Click(object sender, EventArgs e) {
			if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
				try {
					var bf = new BinaryFormatter();
					using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open)) {
						listPerson = (BindingList<Person>)bf.Deserialize(fs);
						dgvPersons.DataSource = null;
						dgvPersons.DataSource = listPerson;
					}
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
				foreach(var item in listPerson.Select(p => p.Company)) {
					setCbCompany(item); //存在する会社を登録
				}
			}
			EnableCheck();
		}
	}
}
