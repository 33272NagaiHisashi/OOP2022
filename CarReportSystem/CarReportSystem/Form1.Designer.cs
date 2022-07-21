
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
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.btDeleteRecord = new System.Windows.Forms.Button();
			this.btFixRecord = new System.Windows.Forms.Button();
			this.btAddReport = new System.Windows.Forms.Button();
			this.btDeletePicture = new System.Windows.Forms.Button();
			this.btOpenPicture = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.btSaveReport = new System.Windows.Forms.Button();
			this.btOpenReport = new System.Windows.Forms.Button();
			this.dgvCarReport = new System.Windows.Forms.DataGridView();
			this.tbReport = new System.Windows.Forms.TextBox();
			this.cbCarName = new System.Windows.Forms.ComboBox();
			this.rbOthers = new System.Windows.Forms.RadioButton();
			this.rbForeignCar = new System.Windows.Forms.RadioButton();
			this.rbSubaru = new System.Windows.Forms.RadioButton();
			this.rbHonda = new System.Windows.Forms.RadioButton();
			this.rbNissan = new System.Windows.Forms.RadioButton();
			this.rbToyota = new System.Windows.Forms.RadioButton();
			this.cbAuther = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// 終了ToolStripMenuItem
			// 
			this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
			this.終了ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.終了ToolStripMenuItem.Text = "終了";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
			// 
			// 色設定ToolStripMenuItem
			// 
			this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
			this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.色設定ToolStripMenuItem.Text = "色の設定...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
			// 
			// 保存ToolStripMenuItem
			// 
			this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
			this.保存ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.保存ToolStripMenuItem.Text = "保存...";
			// 
			// 開くToolStripMenuItem
			// 
			this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
			this.開くToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.開くToolStripMenuItem.Text = "開く...";
			// 
			// ファイルToolStripMenuItem
			// 
			this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.色設定ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem});
			this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
			this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.ファイルToolStripMenuItem.Tag = "";
			this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(637, -54);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 23);
			this.button1.TabIndex = 57;
			this.button1.Text = "★";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// pbPicture
			// 
			this.pbPicture.BackColor = System.Drawing.Color.White;
			this.pbPicture.Location = new System.Drawing.Point(472, -18);
			this.pbPicture.Name = "pbPicture";
			this.pbPicture.Size = new System.Drawing.Size(225, 267);
			this.pbPicture.TabIndex = 55;
			this.pbPicture.TabStop = false;
			this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
			// 
			// btDeleteRecord
			// 
			this.btDeleteRecord.Location = new System.Drawing.Point(640, 256);
			this.btDeleteRecord.Name = "btDeleteRecord";
			this.btDeleteRecord.Size = new System.Drawing.Size(57, 23);
			this.btDeleteRecord.TabIndex = 54;
			this.btDeleteRecord.Text = "削除";
			this.btDeleteRecord.UseVisualStyleBackColor = true;
			// 
			// btFixRecord
			// 
			this.btFixRecord.Location = new System.Drawing.Point(560, 256);
			this.btFixRecord.Name = "btFixRecord";
			this.btFixRecord.Size = new System.Drawing.Size(57, 23);
			this.btFixRecord.TabIndex = 53;
			this.btFixRecord.Text = "修正";
			this.btFixRecord.UseVisualStyleBackColor = true;
			// 
			// btAddReport
			// 
			this.btAddReport.Location = new System.Drawing.Point(472, 256);
			this.btAddReport.Name = "btAddReport";
			this.btAddReport.Size = new System.Drawing.Size(57, 23);
			this.btAddReport.TabIndex = 52;
			this.btAddReport.Text = "追加";
			this.btAddReport.UseVisualStyleBackColor = true;
			// 
			// btDeletePicture
			// 
			this.btDeletePicture.Location = new System.Drawing.Point(574, -54);
			this.btDeletePicture.Name = "btDeletePicture";
			this.btDeletePicture.Size = new System.Drawing.Size(57, 23);
			this.btDeletePicture.TabIndex = 51;
			this.btDeletePicture.Text = "削除";
			this.btDeletePicture.UseVisualStyleBackColor = true;
			// 
			// btOpenPicture
			// 
			this.btOpenPicture.Location = new System.Drawing.Point(511, -54);
			this.btOpenPicture.Name = "btOpenPicture";
			this.btOpenPicture.Size = new System.Drawing.Size(57, 23);
			this.btOpenPicture.TabIndex = 50;
			this.btOpenPicture.Text = "開く";
			this.btOpenPicture.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(470, -49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 12);
			this.label7.TabIndex = 49;
			this.label7.Text = "画像：";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(622, 520);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 48;
			this.button3.Text = "終了";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btSaveReport
			// 
			this.btSaveReport.Location = new System.Drawing.Point(41, 384);
			this.btSaveReport.Name = "btSaveReport";
			this.btSaveReport.Size = new System.Drawing.Size(57, 23);
			this.btSaveReport.TabIndex = 47;
			this.btSaveReport.Text = "保存...";
			this.btSaveReport.UseVisualStyleBackColor = true;
			// 
			// btOpenReport
			// 
			this.btOpenReport.Location = new System.Drawing.Point(41, 337);
			this.btOpenReport.Name = "btOpenReport";
			this.btOpenReport.Size = new System.Drawing.Size(57, 23);
			this.btOpenReport.TabIndex = 46;
			this.btOpenReport.Text = "開く...";
			this.btOpenReport.UseVisualStyleBackColor = true;
			// 
			// dgvCarReport
			// 
			this.dgvCarReport.AllowUserToAddRows = false;
			this.dgvCarReport.AllowUserToDeleteRows = false;
			this.dgvCarReport.AllowUserToResizeColumns = false;
			this.dgvCarReport.AllowUserToResizeRows = false;
			this.dgvCarReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCarReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarReport.Location = new System.Drawing.Point(109, 300);
			this.dgvCarReport.MultiSelect = false;
			this.dgvCarReport.Name = "dgvCarReport";
			this.dgvCarReport.ReadOnly = true;
			this.dgvCarReport.RowTemplate.Height = 21;
			this.dgvCarReport.Size = new System.Drawing.Size(588, 212);
			this.dgvCarReport.TabIndex = 45;
			// 
			// tbReport
			// 
			this.tbReport.Location = new System.Drawing.Point(109, 132);
			this.tbReport.Multiline = true;
			this.tbReport.Name = "tbReport";
			this.tbReport.Size = new System.Drawing.Size(328, 147);
			this.tbReport.TabIndex = 44;
			// 
			// cbCarName
			// 
			this.cbCarName.FormattingEnabled = true;
			this.cbCarName.Location = new System.Drawing.Point(109, 70);
			this.cbCarName.Name = "cbCarName";
			this.cbCarName.Size = new System.Drawing.Size(328, 20);
			this.cbCarName.TabIndex = 43;
			// 
			// rbOthers
			// 
			this.rbOthers.AutoSize = true;
			this.rbOthers.Location = new System.Drawing.Point(383, 24);
			this.rbOthers.Name = "rbOthers";
			this.rbOthers.Size = new System.Drawing.Size(54, 16);
			this.rbOthers.TabIndex = 42;
			this.rbOthers.TabStop = true;
			this.rbOthers.Text = "その他";
			this.rbOthers.UseVisualStyleBackColor = true;
			// 
			// rbForeignCar
			// 
			this.rbForeignCar.AutoSize = true;
			this.rbForeignCar.Location = new System.Drawing.Point(330, 24);
			this.rbForeignCar.Name = "rbForeignCar";
			this.rbForeignCar.Size = new System.Drawing.Size(47, 16);
			this.rbForeignCar.TabIndex = 41;
			this.rbForeignCar.TabStop = true;
			this.rbForeignCar.Text = "車外";
			this.rbForeignCar.UseVisualStyleBackColor = true;
			// 
			// rbSubaru
			// 
			this.rbSubaru.AutoSize = true;
			this.rbSubaru.Location = new System.Drawing.Point(272, 24);
			this.rbSubaru.Name = "rbSubaru";
			this.rbSubaru.Size = new System.Drawing.Size(52, 16);
			this.rbSubaru.TabIndex = 40;
			this.rbSubaru.TabStop = true;
			this.rbSubaru.Text = "スバル";
			this.rbSubaru.UseVisualStyleBackColor = true;
			// 
			// rbHonda
			// 
			this.rbHonda.AutoSize = true;
			this.rbHonda.Location = new System.Drawing.Point(215, 24);
			this.rbHonda.Name = "rbHonda";
			this.rbHonda.Size = new System.Drawing.Size(51, 16);
			this.rbHonda.TabIndex = 39;
			this.rbHonda.TabStop = true;
			this.rbHonda.Text = "ホンダ";
			this.rbHonda.UseVisualStyleBackColor = true;
			// 
			// rbNissan
			// 
			this.rbNissan.AutoSize = true;
			this.rbNissan.Location = new System.Drawing.Point(162, 24);
			this.rbNissan.Name = "rbNissan";
			this.rbNissan.Size = new System.Drawing.Size(47, 16);
			this.rbNissan.TabIndex = 38;
			this.rbNissan.TabStop = true;
			this.rbNissan.Text = "日産";
			this.rbNissan.UseVisualStyleBackColor = true;
			// 
			// rbToyota
			// 
			this.rbToyota.AutoSize = true;
			this.rbToyota.Location = new System.Drawing.Point(109, 24);
			this.rbToyota.Name = "rbToyota";
			this.rbToyota.Size = new System.Drawing.Size(47, 16);
			this.rbToyota.TabIndex = 37;
			this.rbToyota.TabStop = true;
			this.rbToyota.Text = "トヨタ";
			this.rbToyota.UseVisualStyleBackColor = true;
			// 
			// cbAuther
			// 
			this.cbAuther.FormattingEnabled = true;
			this.cbAuther.Location = new System.Drawing.Point(109, -18);
			this.cbAuther.Name = "cbAuther";
			this.cbAuther.Size = new System.Drawing.Size(328, 20);
			this.cbAuther.TabIndex = 36;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(109, -61);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(328, 19);
			this.dtpDate.TabIndex = 35;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 12);
			this.label6.TabIndex = 34;
			this.label6.Text = "記事一覧：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 12);
			this.label5.TabIndex = 33;
			this.label5.Text = "レポート：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 32;
			this.label4.Text = "車名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 12);
			this.label3.TabIndex = 31;
			this.label3.Text = "メーカー：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, -18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 30;
			this.label2.Text = "記録者：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, -61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 29;
			this.label1.Text = "日付：";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 56;
			this.menuStrip.Text = "menuStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 534);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pbPicture);
			this.Controls.Add(this.btDeleteRecord);
			this.Controls.Add(this.btFixRecord);
			this.Controls.Add(this.btAddReport);
			this.Controls.Add(this.btDeletePicture);
			this.Controls.Add(this.btOpenPicture);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btSaveReport);
			this.Controls.Add(this.btOpenReport);
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
			this.Controls.Add(this.menuStrip);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.Button btDeleteRecord;
		private System.Windows.Forms.Button btFixRecord;
		private System.Windows.Forms.Button btAddReport;
		private System.Windows.Forms.Button btDeletePicture;
		private System.Windows.Forms.Button btOpenPicture;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btSaveReport;
		private System.Windows.Forms.Button btOpenReport;
		private System.Windows.Forms.DataGridView dgvCarReport;
		private System.Windows.Forms.TextBox tbReport;
		private System.Windows.Forms.ComboBox cbCarName;
		private System.Windows.Forms.RadioButton rbOthers;
		private System.Windows.Forms.RadioButton rbForeignCar;
		private System.Windows.Forms.RadioButton rbSubaru;
		private System.Windows.Forms.RadioButton rbHonda;
		private System.Windows.Forms.RadioButton rbNissan;
		private System.Windows.Forms.RadioButton rbToyota;
		private System.Windows.Forms.ComboBox cbAuther;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip;
	}
}

