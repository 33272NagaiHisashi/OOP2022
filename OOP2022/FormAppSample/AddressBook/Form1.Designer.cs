
namespace AddressBook {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvPersons = new System.Windows.Forms.DataGridView();
			this.tbName = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbMailAddress = new System.Windows.Forms.TextBox();
			this.cbFamily = new System.Windows.Forms.CheckBox();
			this.cbFriend = new System.Windows.Forms.CheckBox();
			this.cbWork = new System.Windows.Forms.CheckBox();
			this.cbOther = new System.Windows.Forms.CheckBox();
			this.btAddPerson = new System.Windows.Forms.Button();
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.btPictureOpen = new System.Windows.Forms.Button();
			this.btPictureClear = new System.Windows.Forms.Button();
			this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.cbCompany = new System.Windows.Forms.ComboBox();
			this.btSave = new System.Windows.Forms.Button();
			this.btOpen = new System.Windows.Forms.Button();
			this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpRegistration = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.rbHome = new System.Windows.Forms.RadioButton();
			this.rbMobile = new System.Windows.Forms.RadioButton();
			this.tbTelNumber = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(120, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "名前";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(30, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 27);
			this.label2.TabIndex = 0;
			this.label2.Text = "メールアドレス";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(120, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 27);
			this.label3.TabIndex = 0;
			this.label3.Text = "住所";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(120, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 27);
			this.label4.TabIndex = 0;
			this.label4.Text = "会社";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(89, 268);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 27);
			this.label5.TabIndex = 0;
			this.label5.Text = "グループ";
			// 
			// dgvPersons
			// 
			this.dgvPersons.AllowUserToAddRows = false;
			this.dgvPersons.AllowUserToDeleteRows = false;
			this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPersons.Location = new System.Drawing.Point(94, 394);
			this.dgvPersons.MultiSelect = false;
			this.dgvPersons.Name = "dgvPersons";
			this.dgvPersons.RowHeadersVisible = false;
			this.dgvPersons.RowTemplate.Height = 21;
			this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPersons.Size = new System.Drawing.Size(710, 150);
			this.dgvPersons.TabIndex = 1;
			this.dgvPersons.Click += new System.EventHandler(this.dgvPersons_Click);
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbName.Location = new System.Drawing.Point(213, 25);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(390, 31);
			this.tbName.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox2.Location = new System.Drawing.Point(213, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(390, 31);
			this.textBox2.TabIndex = 2;
			// 
			// tbAddress
			// 
			this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbAddress.Location = new System.Drawing.Point(213, 121);
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(390, 72);
			this.tbAddress.TabIndex = 2;
			// 
			// tbMailAddress
			// 
			this.tbMailAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbMailAddress.Location = new System.Drawing.Point(213, 79);
			this.tbMailAddress.Name = "tbMailAddress";
			this.tbMailAddress.Size = new System.Drawing.Size(390, 31);
			this.tbMailAddress.TabIndex = 2;
			// 
			// cbFamily
			// 
			this.cbFamily.AutoSize = true;
			this.cbFamily.Cursor = System.Windows.Forms.Cursors.Default;
			this.cbFamily.Location = new System.Drawing.Point(223, 278);
			this.cbFamily.Name = "cbFamily";
			this.cbFamily.Size = new System.Drawing.Size(48, 16);
			this.cbFamily.TabIndex = 3;
			this.cbFamily.Text = "家族";
			this.cbFamily.UseVisualStyleBackColor = true;
			// 
			// cbFriend
			// 
			this.cbFriend.AutoSize = true;
			this.cbFriend.Location = new System.Drawing.Point(306, 278);
			this.cbFriend.Name = "cbFriend";
			this.cbFriend.Size = new System.Drawing.Size(48, 16);
			this.cbFriend.TabIndex = 3;
			this.cbFriend.Text = "友人";
			this.cbFriend.UseVisualStyleBackColor = true;
			// 
			// cbWork
			// 
			this.cbWork.AutoSize = true;
			this.cbWork.Location = new System.Drawing.Point(397, 278);
			this.cbWork.Name = "cbWork";
			this.cbWork.Size = new System.Drawing.Size(48, 16);
			this.cbWork.TabIndex = 3;
			this.cbWork.Text = "仕事";
			this.cbWork.UseVisualStyleBackColor = true;
			// 
			// cbOther
			// 
			this.cbOther.AutoSize = true;
			this.cbOther.Location = new System.Drawing.Point(483, 278);
			this.cbOther.Name = "cbOther";
			this.cbOther.Size = new System.Drawing.Size(55, 16);
			this.cbOther.TabIndex = 3;
			this.cbOther.Text = "その他";
			this.cbOther.UseVisualStyleBackColor = true;
			// 
			// btAddPerson
			// 
			this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btAddPerson.Location = new System.Drawing.Point(555, 260);
			this.btAddPerson.Name = "btAddPerson";
			this.btAddPerson.Size = new System.Drawing.Size(68, 41);
			this.btAddPerson.TabIndex = 4;
			this.btAddPerson.Text = "追加";
			this.btAddPerson.UseVisualStyleBackColor = true;
			this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
			// 
			// pbPicture
			// 
			this.pbPicture.Location = new System.Drawing.Point(655, 25);
			this.pbPicture.Name = "pbPicture";
			this.pbPicture.Size = new System.Drawing.Size(149, 168);
			this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPicture.TabIndex = 5;
			this.pbPicture.TabStop = false;
			// 
			// btPictureOpen
			// 
			this.btPictureOpen.Location = new System.Drawing.Point(655, 199);
			this.btPictureOpen.Name = "btPictureOpen";
			this.btPictureOpen.Size = new System.Drawing.Size(71, 23);
			this.btPictureOpen.TabIndex = 6;
			this.btPictureOpen.Text = "開く...";
			this.btPictureOpen.UseVisualStyleBackColor = true;
			this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
			// 
			// btPictureClear
			// 
			this.btPictureClear.Location = new System.Drawing.Point(732, 199);
			this.btPictureClear.Name = "btPictureClear";
			this.btPictureClear.Size = new System.Drawing.Size(72, 23);
			this.btPictureClear.TabIndex = 6;
			this.btPictureClear.Text = "クリア";
			this.btPictureClear.UseVisualStyleBackColor = true;
			this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
			// 
			// ofdFileOpenDialog
			// 
			this.ofdFileOpenDialog.FileName = "openFileDialog1";
			// 
			// btUpdate
			// 
			this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btUpdate.Location = new System.Drawing.Point(655, 253);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(71, 41);
			this.btUpdate.TabIndex = 4;
			this.btUpdate.Text = "更新";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btDelete
			// 
			this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDelete.Location = new System.Drawing.Point(732, 253);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(72, 41);
			this.btDelete.TabIndex = 4;
			this.btDelete.Text = "削除";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// cbCompany
			// 
			this.cbCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbCompany.FormattingEnabled = true;
			this.cbCompany.Location = new System.Drawing.Point(213, 215);
			this.cbCompany.Name = "cbCompany";
			this.cbCompany.Size = new System.Drawing.Size(390, 32);
			this.cbCompany.TabIndex = 7;
			// 
			// btSave
			// 
			this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btSave.Location = new System.Drawing.Point(12, 503);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(74, 41);
			this.btSave.TabIndex = 4;
			this.btSave.Text = "保存...";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btOpen
			// 
			this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btOpen.Location = new System.Drawing.Point(12, 456);
			this.btOpen.Name = "btOpen";
			this.btOpen.Size = new System.Drawing.Size(74, 41);
			this.btOpen.TabIndex = 4;
			this.btOpen.Text = "開く...";
			this.btOpen.UseVisualStyleBackColor = true;
			this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(499, 563);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "登録日：";
			// 
			// dtpRegistration
			// 
			this.dtpRegistration.Location = new System.Drawing.Point(569, 560);
			this.dtpRegistration.Name = "dtpRegistration";
			this.dtpRegistration.Size = new System.Drawing.Size(200, 19);
			this.dtpRegistration.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(66, 314);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 27);
			this.label7.TabIndex = 0;
			this.label7.Text = "電話番号";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(221, 360);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 8;
			this.label8.Text = "種別";
			// 
			// rbHome
			// 
			this.rbHome.AutoSize = true;
			this.rbHome.Checked = true;
			this.rbHome.Location = new System.Drawing.Point(262, 358);
			this.rbHome.Name = "rbHome";
			this.rbHome.Size = new System.Drawing.Size(47, 16);
			this.rbHome.TabIndex = 10;
			this.rbHome.TabStop = true;
			this.rbHome.Text = "自宅";
			this.rbHome.UseVisualStyleBackColor = true;
			// 
			// rbMobile
			// 
			this.rbMobile.AutoSize = true;
			this.rbMobile.Location = new System.Drawing.Point(324, 358);
			this.rbMobile.Name = "rbMobile";
			this.rbMobile.Size = new System.Drawing.Size(47, 16);
			this.rbMobile.TabIndex = 10;
			this.rbMobile.Text = "携帯";
			this.rbMobile.UseVisualStyleBackColor = true;
			// 
			// tbTelNumber
			// 
			this.tbTelNumber.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbTelNumber.Location = new System.Drawing.Point(213, 314);
			this.tbTelNumber.Name = "tbTelNumber";
			this.tbTelNumber.Size = new System.Drawing.Size(390, 31);
			this.tbTelNumber.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 590);
			this.Controls.Add(this.rbMobile);
			this.Controls.Add(this.rbHome);
			this.Controls.Add(this.dtpRegistration);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbCompany);
			this.Controls.Add(this.btPictureClear);
			this.Controls.Add(this.btPictureOpen);
			this.Controls.Add(this.pbPicture);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btOpen);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btAddPerson);
			this.Controls.Add(this.cbOther);
			this.Controls.Add(this.cbWork);
			this.Controls.Add(this.cbFriend);
			this.Controls.Add(this.cbFamily);
			this.Controls.Add(this.tbTelNumber);
			this.Controls.Add(this.tbMailAddress);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.dgvPersons);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvPersons;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbMailAddress;
		private System.Windows.Forms.CheckBox cbFamily;
		private System.Windows.Forms.CheckBox cbFriend;
		private System.Windows.Forms.CheckBox cbWork;
		private System.Windows.Forms.CheckBox cbOther;
		private System.Windows.Forms.Button btAddPerson;
		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.Button btPictureOpen;
		private System.Windows.Forms.Button btPictureClear;
		private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.ComboBox cbCompany;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btOpen;
		private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpRegistration;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton rbHome;
		private System.Windows.Forms.RadioButton rbMobile;
		private System.Windows.Forms.TextBox tbTelNumber;
	}
}

