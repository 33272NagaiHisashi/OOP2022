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
			Person newPerson = new Person {
				Name = tbName.Text,
				MailAddress = tbMailAddress.Text,
				Address = tbAddress.Text,
				Company = tbCompany.Text,
				Picture = pbPicture.Image,
				listGroup = GetCheckBoxGroup(),
			};
			listPerson.Add(newPerson);
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
			/*foreach (DataGridViewRow dr in dgvPersons.SelectedRows) {
				tbName.Text = listPerson[dr.Index].Name;
				tbMailAddress.Text = listPerson[dr.Index].MailAddress;
				tbAddress.Text = listPerson[dr.Index].Address;
				tbCompany.Text = listPerson[dr.Index].Company;
				pbPicture.Image = listPerson[dr.Index].Picture;
			}*/
			int index = dgvPersons.CurrentRow.Index;
			tbName.Text = listPerson[index].Name;
			tbMailAddress.Text = listPerson[index].MailAddress;
			tbAddress.Text = listPerson[index].Address;
			tbCompany.Text = listPerson[index].Company;
			pbPicture.Image = listPerson[index].Picture;


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
	}
}
