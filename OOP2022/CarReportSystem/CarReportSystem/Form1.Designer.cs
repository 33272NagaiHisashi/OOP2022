
namespace CarReportSystem {
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
			System.Windows.Forms.MenuStrip menuStrip1;
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.cbAuther = new System.Windows.Forms.ComboBox();
			this.rbToyota = new System.Windows.Forms.RadioButton();
			this.rbNissan = new System.Windows.Forms.RadioButton();
			this.rbHonda = new System.Windows.Forms.RadioButton();
			this.rbSubaru = new System.Windows.Forms.RadioButton();
			this.rbForeignCar = new System.Windows.Forms.RadioButton();
			this.rbOthers = new System.Windows.Forms.RadioButton();
			this.cbCarName = new System.Windows.Forms.ComboBox();
			this.tbReport = new System.Windows.Forms.TextBox();
			this.dgvCarReport = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.infosys202232DataSet = new CarReportSystem.infosys202232DataSet();
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btOpenPicture = new System.Windows.Forms.Button();
			this.btDeletePicture = new System.Windows.Forms.Button();
			this.btAddReport = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.tableAdapterManager = new CarReportSystem.infosys202232DataSetTableAdapters.TableAdapterManager();
			this.carReportDBTableAdapter = new CarReportSystem.infosys202232DataSetTableAdapters.CarReportDBTableAdapter();
			this.btSearch = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btClearSearch = new System.Windows.Forms.Button();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.infosys202232DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 1);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(751, 24);
			menuStrip1.TabIndex = 29;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.UseWaitCursor = true;
			// 
			// ファイルToolStripMenuItem
			// 
			this.ファイルToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.tsmiUpdate,
            this.保存ToolStripMenuItem,
            this.接続ToolStripMenuItem,
            this.toolStripSeparator1,
            this.色設定ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
			this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
			this.ファイルToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
			this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.ファイルToolStripMenuItem.Tag = "";
			this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// 開くToolStripMenuItem
			// 
			this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
			this.開くToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.開くToolStripMenuItem.Text = "開く...";
			this.開くToolStripMenuItem.Click += new System.EventHandler(this.btOpenReport_Click);
			// 
			// tsmiUpdate
			// 
			this.tsmiUpdate.Name = "tsmiUpdate";
			this.tsmiUpdate.Size = new System.Drawing.Size(129, 22);
			this.tsmiUpdate.Text = "更新";
			this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
			// 
			// 保存ToolStripMenuItem
			// 
			this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
			this.保存ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.保存ToolStripMenuItem.Text = "保存...";
			this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btSaveReport_Click);
			// 
			// 接続ToolStripMenuItem
			// 
			this.接続ToolStripMenuItem.Name = "接続ToolStripMenuItem";
			this.接続ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.接続ToolStripMenuItem.Text = "接続";
			this.接続ToolStripMenuItem.Click += new System.EventHandler(this.接続ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
			// 
			// 色設定ToolStripMenuItem
			// 
			this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
			this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.色設定ToolStripMenuItem.Text = "色の設定...";
			this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.ColorSetting_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
			// 
			// 終了ToolStripMenuItem
			// 
			this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
			this.終了ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.終了ToolStripMenuItem.Text = "終了";
			this.終了ToolStripMenuItem.Click += new System.EventHandler(this.btExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "日付：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "記録者：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "メーカー：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "車名";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "レポート：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 393);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "記事一覧：";
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(109, 31);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(328, 19);
			this.dtpDate.TabIndex = 6;
			// 
			// cbAuther
			// 
			this.cbAuther.FormattingEnabled = true;
			this.cbAuther.Location = new System.Drawing.Point(109, 74);
			this.cbAuther.Name = "cbAuther";
			this.cbAuther.Size = new System.Drawing.Size(328, 20);
			this.cbAuther.TabIndex = 7;
			// 
			// rbToyota
			// 
			this.rbToyota.AutoSize = true;
			this.rbToyota.Checked = true;
			this.rbToyota.Location = new System.Drawing.Point(109, 117);
			this.rbToyota.Name = "rbToyota";
			this.rbToyota.Size = new System.Drawing.Size(47, 16);
			this.rbToyota.TabIndex = 8;
			this.rbToyota.TabStop = true;
			this.rbToyota.Text = "トヨタ";
			this.rbToyota.UseVisualStyleBackColor = true;
			// 
			// rbNissan
			// 
			this.rbNissan.AutoSize = true;
			this.rbNissan.Location = new System.Drawing.Point(162, 117);
			this.rbNissan.Name = "rbNissan";
			this.rbNissan.Size = new System.Drawing.Size(47, 16);
			this.rbNissan.TabIndex = 9;
			this.rbNissan.Text = "日産";
			this.rbNissan.UseVisualStyleBackColor = true;
			// 
			// rbHonda
			// 
			this.rbHonda.AutoSize = true;
			this.rbHonda.Location = new System.Drawing.Point(215, 117);
			this.rbHonda.Name = "rbHonda";
			this.rbHonda.Size = new System.Drawing.Size(51, 16);
			this.rbHonda.TabIndex = 10;
			this.rbHonda.Text = "ホンダ";
			this.rbHonda.UseVisualStyleBackColor = true;
			// 
			// rbSubaru
			// 
			this.rbSubaru.AutoSize = true;
			this.rbSubaru.Location = new System.Drawing.Point(272, 117);
			this.rbSubaru.Name = "rbSubaru";
			this.rbSubaru.Size = new System.Drawing.Size(52, 16);
			this.rbSubaru.TabIndex = 11;
			this.rbSubaru.Text = "スバル";
			this.rbSubaru.UseVisualStyleBackColor = true;
			// 
			// rbForeignCar
			// 
			this.rbForeignCar.AutoSize = true;
			this.rbForeignCar.Location = new System.Drawing.Point(330, 117);
			this.rbForeignCar.Name = "rbForeignCar";
			this.rbForeignCar.Size = new System.Drawing.Size(47, 16);
			this.rbForeignCar.TabIndex = 12;
			this.rbForeignCar.Text = "車外";
			this.rbForeignCar.UseVisualStyleBackColor = true;
			// 
			// rbOthers
			// 
			this.rbOthers.AutoSize = true;
			this.rbOthers.Location = new System.Drawing.Point(383, 117);
			this.rbOthers.Name = "rbOthers";
			this.rbOthers.Size = new System.Drawing.Size(54, 16);
			this.rbOthers.TabIndex = 13;
			this.rbOthers.Text = "その他";
			this.rbOthers.UseVisualStyleBackColor = true;
			// 
			// cbCarName
			// 
			this.cbCarName.FormattingEnabled = true;
			this.cbCarName.Location = new System.Drawing.Point(109, 162);
			this.cbCarName.Name = "cbCarName";
			this.cbCarName.Size = new System.Drawing.Size(328, 20);
			this.cbCarName.TabIndex = 14;
			// 
			// tbReport
			// 
			this.tbReport.Location = new System.Drawing.Point(109, 224);
			this.tbReport.Multiline = true;
			this.tbReport.Name = "tbReport";
			this.tbReport.Size = new System.Drawing.Size(328, 147);
			this.tbReport.TabIndex = 15;
			// 
			// dgvCarReport
			// 
			this.dgvCarReport.AllowUserToAddRows = false;
			this.dgvCarReport.AllowUserToDeleteRows = false;
			this.dgvCarReport.AllowUserToResizeColumns = false;
			this.dgvCarReport.AllowUserToResizeRows = false;
			this.dgvCarReport.AutoGenerateColumns = false;
			this.dgvCarReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCarReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
			this.dgvCarReport.DataSource = this.carReportDBBindingSource;
			this.dgvCarReport.Location = new System.Drawing.Point(109, 392);
			this.dgvCarReport.MultiSelect = false;
			this.dgvCarReport.Name = "dgvCarReport";
			this.dgvCarReport.ReadOnly = true;
			this.dgvCarReport.RowTemplate.Height = 21;
			this.dgvCarReport.Size = new System.Drawing.Size(588, 212);
			this.dgvCarReport.TabIndex = 16;
			this.dgvCarReport.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCarReport_DataError);
			this.dgvCarReport.Click += new System.EventHandler(this.dgvCarReport_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// authorDataGridViewTextBoxColumn
			// 
			this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
			this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
			this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
			this.authorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// makerDataGridViewTextBoxColumn
			// 
			this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
			this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
			this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
			this.makerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// carNameDataGridViewTextBoxColumn
			// 
			this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
			this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
			this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
			this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// reportDataGridViewTextBoxColumn
			// 
			this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
			this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
			this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
			this.reportDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// imageDataGridViewImageColumn
			// 
			this.imageDataGridViewImageColumn.DataPropertyName = "Image";
			this.imageDataGridViewImageColumn.HeaderText = "Image";
			this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
			this.imageDataGridViewImageColumn.ReadOnly = true;
			// 
			// carReportDBBindingSource
			// 
			this.carReportDBBindingSource.DataMember = "CarReportDB";
			this.carReportDBBindingSource.DataSource = this.infosys202232DataSet;
			// 
			// infosys202232DataSet
			// 
			this.infosys202232DataSet.DataSetName = "infosys202232DataSet";
			this.infosys202232DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(622, 612);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "終了";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.btExit_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(470, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 12);
			this.label7.TabIndex = 20;
			this.label7.Text = "画像：";
			// 
			// btOpenPicture
			// 
			this.btOpenPicture.Location = new System.Drawing.Point(511, 38);
			this.btOpenPicture.Name = "btOpenPicture";
			this.btOpenPicture.Size = new System.Drawing.Size(57, 23);
			this.btOpenPicture.TabIndex = 21;
			this.btOpenPicture.Text = "開く";
			this.btOpenPicture.UseVisualStyleBackColor = true;
			this.btOpenPicture.Click += new System.EventHandler(this.btOpenPicture_Click);
			// 
			// btDeletePicture
			// 
			this.btDeletePicture.Location = new System.Drawing.Point(574, 38);
			this.btDeletePicture.Name = "btDeletePicture";
			this.btDeletePicture.Size = new System.Drawing.Size(57, 23);
			this.btDeletePicture.TabIndex = 22;
			this.btDeletePicture.Text = "削除";
			this.btDeletePicture.UseVisualStyleBackColor = true;
			this.btDeletePicture.Click += new System.EventHandler(this.btDeletePicture_Click);
			// 
			// btAddReport
			// 
			this.btAddReport.Location = new System.Drawing.Point(448, 348);
			this.btAddReport.Name = "btAddReport";
			this.btAddReport.Size = new System.Drawing.Size(57, 23);
			this.btAddReport.TabIndex = 23;
			this.btAddReport.Text = "追加";
			this.btAddReport.UseVisualStyleBackColor = true;
			this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(640, 348);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(57, 23);
			this.btDelete.TabIndex = 25;
			this.btDelete.Text = "削除";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// pbPicture
			// 
			this.pbPicture.BackColor = System.Drawing.Color.LightGray;
			this.pbPicture.Location = new System.Drawing.Point(472, 74);
			this.pbPicture.Name = "pbPicture";
			this.pbPicture.Size = new System.Drawing.Size(225, 267);
			this.pbPicture.TabIndex = 26;
			this.pbPicture.TabStop = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(637, 38);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 23);
			this.button1.TabIndex = 28;
			this.button1.Text = "★";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ColorSetting_Click);
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(514, 348);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(57, 23);
			this.btUpdate.TabIndex = 30;
			this.btUpdate.Text = "更新";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(577, 348);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(57, 23);
			this.btClear.TabIndex = 31;
			this.btClear.Text = "クリア";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
			this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202232DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// carReportDBTableAdapter
			// 
			this.carReportDBTableAdapter.ClearBeforeFill = true;
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(23, 612);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(75, 23);
			this.btSearch.TabIndex = 32;
			this.btSearch.Text = "検索";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(109, 612);
			this.tbSearch.Multiline = true;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(190, 23);
			this.tbSearch.TabIndex = 33;
			// 
			// btClearSearch
			// 
			this.btClearSearch.Location = new System.Drawing.Point(305, 612);
			this.btClearSearch.Name = "btClearSearch";
			this.btClearSearch.Size = new System.Drawing.Size(75, 23);
			this.btClearSearch.TabIndex = 34;
			this.btClearSearch.Text = "検索クリア";
			this.btClearSearch.UseVisualStyleBackColor = true;
			this.btClearSearch.Click += new System.EventHandler(this.btClearSearch_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(751, 647);
			this.Controls.Add(this.btClearSearch);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.btSearch);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pbPicture);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btAddReport);
			this.Controls.Add(this.btDeletePicture);
			this.Controls.Add(this.btOpenPicture);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dgvCarReport);
			this.Controls.Add(this.tbReport);
			this.Controls.Add(this.cbCarName);
			this.Controls.Add(this.rbOthers);
			this.Controls.Add(this.rbForeignCar);
			this.Controls.Add(this.rbSubaru);
			this.Controls.Add(this.rbHonda);
			this.Controls.Add(this.rbNissan);
			this.Controls.Add(this.rbToyota);
			this.Controls.Add(this.cbAuther);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(menuStrip1);
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.infosys202232DataSet)).EndInit();
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.ComboBox cbAuther;
		private System.Windows.Forms.RadioButton rbToyota;
		private System.Windows.Forms.RadioButton rbNissan;
		private System.Windows.Forms.RadioButton rbHonda;
		private System.Windows.Forms.RadioButton rbSubaru;
		private System.Windows.Forms.RadioButton rbForeignCar;
		private System.Windows.Forms.RadioButton rbOthers;
		private System.Windows.Forms.ComboBox cbCarName;
		private System.Windows.Forms.TextBox tbReport;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btOpenPicture;
		private System.Windows.Forms.Button btDeletePicture;
		private System.Windows.Forms.Button btAddReport;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.DataGridView dgvCarReport;
		private infosys202232DataSet infosys202232DataSet;
		private infosys202232DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private infosys202232DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
		private System.Windows.Forms.BindingSource carReportDBBindingSource;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 接続ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btClearSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
	}
}

