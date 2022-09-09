
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
			this.components = new System.ComponentModel.Container();
			this.dgvAddressTable = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Image = new System.Windows.Forms.DataGridViewImageColumn();
			this.addressTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.infosys202232DataSet = new AddressBook.infosys202232DataSet();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbMemo = new System.Windows.Forms.TextBox();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btConnect = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.btOpenImage = new System.Windows.Forms.Button();
			this.btDeleteImage = new System.Windows.Forms.Button();
			this.ofdImage = new System.Windows.Forms.OpenFileDialog();
			this.sfdImage = new System.Windows.Forms.SaveFileDialog();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.btSearch = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.addressTableTableAdapter = new AddressBook.infosys202232DataSetTableAdapters.AddressTableTableAdapter();
			this.tableAdapterManager = new AddressBook.infosys202232DataSetTableAdapters.TableAdapterManager();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddressTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.infosys202232DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAddressTable
			// 
			this.dgvAddressTable.AllowUserToAddRows = false;
			this.dgvAddressTable.AllowUserToDeleteRows = false;
			this.dgvAddressTable.AllowUserToResizeColumns = false;
			this.dgvAddressTable.AllowUserToResizeRows = false;
			this.dgvAddressTable.AutoGenerateColumns = false;
			this.dgvAddressTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddressTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Image});
			this.dgvAddressTable.DataSource = this.addressTableBindingSource;
			this.dgvAddressTable.Location = new System.Drawing.Point(12, 390);
			this.dgvAddressTable.MultiSelect = false;
			this.dgvAddressTable.Name = "dgvAddressTable";
			this.dgvAddressTable.ReadOnly = true;
			this.dgvAddressTable.RowTemplate.Height = 21;
			this.dgvAddressTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAddressTable.Size = new System.Drawing.Size(743, 218);
			this.dgvAddressTable.TabIndex = 1;
			this.dgvAddressTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAddressTable_DataError);
			this.dgvAddressTable.Click += new System.EventHandler(this.dgvAddressTable_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Tel";
			this.dataGridViewTextBoxColumn3.HeaderText = "Tel";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Mail";
			this.dataGridViewTextBoxColumn4.HeaderText = "Mail";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn5.HeaderText = "Address";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Memo";
			this.dataGridViewTextBoxColumn6.HeaderText = "Memo";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// Image
			// 
			this.Image.DataPropertyName = "Image";
			this.Image.HeaderText = "Image";
			this.Image.Name = "Image";
			this.Image.ReadOnly = true;
			// 
			// addressTableBindingSource
			// 
			this.addressTableBindingSource.DataMember = "AddressTable";
			this.addressTableBindingSource.DataSource = this.infosys202232DataSet;
			// 
			// infosys202232DataSet
			// 
			this.infosys202232DataSet.DataSetName = "infosys202232DataSet";
			this.infosys202232DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(98, 40);
			this.tbName.Multiline = true;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(488, 24);
			this.tbName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(12, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tel";
			// 
			// tbTel
			// 
			this.tbTel.Location = new System.Drawing.Point(98, 81);
			this.tbTel.Multiline = true;
			this.tbTel.Name = "tbTel";
			this.tbTel.Size = new System.Drawing.Size(488, 24);
			this.tbTel.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(12, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mail";
			// 
			// tbMail
			// 
			this.tbMail.Location = new System.Drawing.Point(98, 120);
			this.tbMail.Multiline = true;
			this.tbMail.Name = "tbMail";
			this.tbMail.Size = new System.Drawing.Size(488, 25);
			this.tbMail.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(12, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 24);
			this.label4.TabIndex = 9;
			this.label4.Text = "Address";
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(98, 169);
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(488, 25);
			this.tbAddress.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(12, 222);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 24);
			this.label6.TabIndex = 13;
			this.label6.Text = "Memo";
			// 
			// tbMemo
			// 
			this.tbMemo.Location = new System.Drawing.Point(98, 222);
			this.tbMemo.Multiline = true;
			this.tbMemo.Name = "tbMemo";
			this.tbMemo.Size = new System.Drawing.Size(488, 92);
			this.tbMemo.TabIndex = 12;
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(604, 218);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(131, 43);
			this.btUpdate.TabIndex = 14;
			this.btUpdate.Text = "更新";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btConnect
			// 
			this.btConnect.Location = new System.Drawing.Point(604, 267);
			this.btConnect.Name = "btConnect";
			this.btConnect.Size = new System.Drawing.Size(131, 42);
			this.btConnect.TabIndex = 15;
			this.btConnect.Text = "接続";
			this.btConnect.UseVisualStyleBackColor = true;
			this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(604, 169);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(131, 43);
			this.btAdd.TabIndex = 16;
			this.btAdd.Text = "追加";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// btOpenImage
			// 
			this.btOpenImage.Location = new System.Drawing.Point(604, 13);
			this.btOpenImage.Name = "btOpenImage";
			this.btOpenImage.Size = new System.Drawing.Size(78, 23);
			this.btOpenImage.TabIndex = 18;
			this.btOpenImage.Text = "開く...";
			this.btOpenImage.UseVisualStyleBackColor = true;
			this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
			// 
			// btDeleteImage
			// 
			this.btDeleteImage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDeleteImage.Location = new System.Drawing.Point(699, 13);
			this.btDeleteImage.Name = "btDeleteImage";
			this.btDeleteImage.Size = new System.Drawing.Size(36, 23);
			this.btDeleteImage.TabIndex = 19;
			this.btDeleteImage.Text = "X";
			this.btDeleteImage.UseVisualStyleBackColor = true;
			this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
			// 
			// ofdImage
			// 
			this.ofdImage.FileName = "openFileDialog1";
			// 
			// pbImage
			// 
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImage.Location = new System.Drawing.Point(604, 42);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(131, 121);
			this.pbImage.TabIndex = 20;
			this.pbImage.TabStop = false;
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(12, 339);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(87, 31);
			this.btSearch.TabIndex = 21;
			this.btSearch.Text = "名前検索";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(105, 339);
			this.tbSearch.Multiline = true;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(187, 31);
			this.tbSearch.TabIndex = 22;
			// 
			// addressTableTableAdapter
			// 
			this.addressTableTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AddressTableTableAdapter = this.addressTableTableAdapter;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = AddressBook.infosys202232DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 621);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.btSearch);
			this.Controls.Add(this.pbImage);
			this.Controls.Add(this.btDeleteImage);
			this.Controls.Add(this.btOpenImage);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.btConnect);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbMemo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbMail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.dgvAddressTable);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAddressTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.infosys202232DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private infosys202232DataSet infosys202232DataSet;
		private System.Windows.Forms.BindingSource addressTableBindingSource;
		private infosys202232DataSetTableAdapters.AddressTableTableAdapter addressTableTableAdapter;
		private infosys202232DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView dgvAddressTable;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbMail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbMemo;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btConnect;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewImageColumn Image;
		private System.Windows.Forms.Button btOpenImage;
		private System.Windows.Forms.Button btDeleteImage;
		private System.Windows.Forms.OpenFileDialog ofdImage;
		private System.Windows.Forms.SaveFileDialog sfdImage;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.TextBox tbSearch;
	}
}

