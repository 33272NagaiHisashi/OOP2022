﻿
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
			this.btOpenReport = new System.Windows.Forms.Button();
			this.btSaveReport = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btOpenPicture = new System.Windows.Forms.Button();
			this.btDeletePicture = new System.Windows.Forms.Button();
			this.btAddReport = new System.Windows.Forms.Button();
			this.btFixRecord = new System.Windows.Forms.Button();
			this.btDeleteRecord = new System.Windows.Forms.Button();
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "日付：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "記録者：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "メーカー：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "車名";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 227);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "レポート：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 392);
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
			this.rbToyota.Location = new System.Drawing.Point(109, 116);
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
			this.rbNissan.Location = new System.Drawing.Point(162, 116);
			this.rbNissan.Name = "rbNissan";
			this.rbNissan.Size = new System.Drawing.Size(47, 16);
			this.rbNissan.TabIndex = 9;
			this.rbNissan.TabStop = true;
			this.rbNissan.Text = "日産";
			this.rbNissan.UseVisualStyleBackColor = true;
			// 
			// rbHonda
			// 
			this.rbHonda.AutoSize = true;
			this.rbHonda.Location = new System.Drawing.Point(215, 116);
			this.rbHonda.Name = "rbHonda";
			this.rbHonda.Size = new System.Drawing.Size(51, 16);
			this.rbHonda.TabIndex = 10;
			this.rbHonda.TabStop = true;
			this.rbHonda.Text = "ホンダ";
			this.rbHonda.UseVisualStyleBackColor = true;
			// 
			// rbSubaru
			// 
			this.rbSubaru.AutoSize = true;
			this.rbSubaru.Location = new System.Drawing.Point(272, 116);
			this.rbSubaru.Name = "rbSubaru";
			this.rbSubaru.Size = new System.Drawing.Size(52, 16);
			this.rbSubaru.TabIndex = 11;
			this.rbSubaru.TabStop = true;
			this.rbSubaru.Text = "スバル";
			this.rbSubaru.UseVisualStyleBackColor = true;
			// 
			// rbForeignCar
			// 
			this.rbForeignCar.AutoSize = true;
			this.rbForeignCar.Location = new System.Drawing.Point(330, 116);
			this.rbForeignCar.Name = "rbForeignCar";
			this.rbForeignCar.Size = new System.Drawing.Size(47, 16);
			this.rbForeignCar.TabIndex = 12;
			this.rbForeignCar.TabStop = true;
			this.rbForeignCar.Text = "車外";
			this.rbForeignCar.UseVisualStyleBackColor = true;
			// 
			// rbOthers
			// 
			this.rbOthers.AutoSize = true;
			this.rbOthers.Location = new System.Drawing.Point(383, 116);
			this.rbOthers.Name = "rbOthers";
			this.rbOthers.Size = new System.Drawing.Size(54, 16);
			this.rbOthers.TabIndex = 13;
			this.rbOthers.TabStop = true;
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
			this.dgvCarReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCarReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarReport.Location = new System.Drawing.Point(109, 392);
			this.dgvCarReport.MultiSelect = false;
			this.dgvCarReport.Name = "dgvCarReport";
			this.dgvCarReport.ReadOnly = true;
			this.dgvCarReport.RowTemplate.Height = 21;
			this.dgvCarReport.Size = new System.Drawing.Size(588, 212);
			this.dgvCarReport.TabIndex = 16;
			this.dgvCarReport.Click += new System.EventHandler(this.dgvCarReport_Click);
			// 
			// btOpenReport
			// 
			this.btOpenReport.Location = new System.Drawing.Point(41, 429);
			this.btOpenReport.Name = "btOpenReport";
			this.btOpenReport.Size = new System.Drawing.Size(57, 23);
			this.btOpenReport.TabIndex = 17;
			this.btOpenReport.Text = "開く...";
			this.btOpenReport.UseVisualStyleBackColor = true;
			this.btOpenReport.Click += new System.EventHandler(this.btOpenReport_Click);
			// 
			// btSaveReport
			// 
			this.btSaveReport.Location = new System.Drawing.Point(41, 476);
			this.btSaveReport.Name = "btSaveReport";
			this.btSaveReport.Size = new System.Drawing.Size(57, 23);
			this.btSaveReport.TabIndex = 18;
			this.btSaveReport.Text = "保存...";
			this.btSaveReport.UseVisualStyleBackColor = true;
			this.btSaveReport.Click += new System.EventHandler(this.btSaveReport_Click);
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
			this.label7.Location = new System.Drawing.Point(470, 43);
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
			this.btAddReport.Location = new System.Drawing.Point(472, 348);
			this.btAddReport.Name = "btAddReport";
			this.btAddReport.Size = new System.Drawing.Size(57, 23);
			this.btAddReport.TabIndex = 23;
			this.btAddReport.Text = "追加";
			this.btAddReport.UseVisualStyleBackColor = true;
			this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
			// 
			// btFixRecord
			// 
			this.btFixRecord.Location = new System.Drawing.Point(560, 348);
			this.btFixRecord.Name = "btFixRecord";
			this.btFixRecord.Size = new System.Drawing.Size(57, 23);
			this.btFixRecord.TabIndex = 24;
			this.btFixRecord.Text = "修正";
			this.btFixRecord.UseVisualStyleBackColor = true;
			this.btFixRecord.Click += new System.EventHandler(this.btFixRecord_Click);
			// 
			// btDeleteRecord
			// 
			this.btDeleteRecord.Location = new System.Drawing.Point(640, 348);
			this.btDeleteRecord.Name = "btDeleteRecord";
			this.btDeleteRecord.Size = new System.Drawing.Size(57, 23);
			this.btDeleteRecord.TabIndex = 25;
			this.btDeleteRecord.Text = "削除";
			this.btDeleteRecord.UseVisualStyleBackColor = true;
			this.btDeleteRecord.Click += new System.EventHandler(this.btDeleteRecord_Click);
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
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 23);
			this.button1.TabIndex = 28;
			this.button1.Text = "★";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ColorSetting_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(79, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.UseWaitCursor = true;
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
			// 開くToolStripMenuItem
			// 
			this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
			this.開くToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.開くToolStripMenuItem.Text = "開く...";
			this.開くToolStripMenuItem.Click += new System.EventHandler(this.btOpenReport_Click);
			// 
			// 保存ToolStripMenuItem
			// 
			this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
			this.保存ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.保存ToolStripMenuItem.Text = "保存...";
			this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btSaveReport_Click);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(751, 647);
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
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.Button btOpenReport;
		private System.Windows.Forms.Button btSaveReport;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btOpenPicture;
		private System.Windows.Forms.Button btDeletePicture;
		private System.Windows.Forms.Button btAddReport;
		private System.Windows.Forms.Button btFixRecord;
		private System.Windows.Forms.Button btDeleteRecord;
		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.DataGridView dgvCarReport;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
	}
}

