
namespace WeatherApp {
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
			this.tbWeatherInfo = new System.Windows.Forms.TextBox();
			this.btAcquisition = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pbTomorrow = new System.Windows.Forms.PictureBox();
			this.pbAsatte = new System.Windows.Forms.PictureBox();
			this.pbToday = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbTodayMaxT = new System.Windows.Forms.TextBox();
			this.tbTodayMinT = new System.Windows.Forms.TextBox();
			this.tbTomorrowMaxT = new System.Windows.Forms.TextBox();
			this.tbTomorrowMinT = new System.Windows.Forms.TextBox();
			this.tbAssateMaxT = new System.Windows.Forms.TextBox();
			this.tbAssateMinT = new System.Windows.Forms.TextBox();
			this.cbArea = new System.Windows.Forms.ComboBox();
			this.labe1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAsatte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
			this.SuspendLayout();
			// 
			// tbWeatherInfo
			// 
			this.tbWeatherInfo.Location = new System.Drawing.Point(16, 281);
			this.tbWeatherInfo.Multiline = true;
			this.tbWeatherInfo.Name = "tbWeatherInfo";
			this.tbWeatherInfo.ReadOnly = true;
			this.tbWeatherInfo.Size = new System.Drawing.Size(632, 163);
			this.tbWeatherInfo.TabIndex = 0;
			// 
			// btAcquisition
			// 
			this.btAcquisition.Location = new System.Drawing.Point(138, 36);
			this.btAcquisition.Name = "btAcquisition";
			this.btAcquisition.Size = new System.Drawing.Size(128, 24);
			this.btAcquisition.TabIndex = 1;
			this.btAcquisition.Text = "検索";
			this.btAcquisition.UseVisualStyleBackColor = true;
			this.btAcquisition.Click += new System.EventHandler(this.btAcquisition_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "都道府県";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(14, 36);
			this.tbSearch.Multiline = true;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(116, 20);
			this.tbSearch.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(331, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "今日";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(462, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "明日";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(573, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "明後日";
			// 
			// pbTomorrow
			// 
			this.pbTomorrow.Location = new System.Drawing.Point(428, 78);
			this.pbTomorrow.Name = "pbTomorrow";
			this.pbTomorrow.Size = new System.Drawing.Size(93, 54);
			this.pbTomorrow.TabIndex = 14;
			this.pbTomorrow.TabStop = false;
			// 
			// pbAsatte
			// 
			this.pbAsatte.Location = new System.Drawing.Point(555, 78);
			this.pbAsatte.Name = "pbAsatte";
			this.pbAsatte.Size = new System.Drawing.Size(93, 54);
			this.pbAsatte.TabIndex = 15;
			this.pbAsatte.TabStop = false;
			// 
			// pbToday
			// 
			this.pbToday.Location = new System.Drawing.Point(299, 78);
			this.pbToday.Name = "pbToday";
			this.pbToday.Size = new System.Drawing.Size(93, 54);
			this.pbToday.TabIndex = 16;
			this.pbToday.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(217, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 25);
			this.label7.TabIndex = 17;
			this.label7.Text = "最高気温";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(217, 234);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 25);
			this.label8.TabIndex = 18;
			this.label8.Text = "最低気温";
			// 
			// tbTodayMaxT
			// 
			this.tbTodayMaxT.Location = new System.Drawing.Point(299, 179);
			this.tbTodayMaxT.Name = "tbTodayMaxT";
			this.tbTodayMaxT.ReadOnly = true;
			this.tbTodayMaxT.Size = new System.Drawing.Size(93, 20);
			this.tbTodayMaxT.TabIndex = 19;
			// 
			// tbTodayMinT
			// 
			this.tbTodayMinT.Location = new System.Drawing.Point(299, 234);
			this.tbTodayMinT.Name = "tbTodayMinT";
			this.tbTodayMinT.ReadOnly = true;
			this.tbTodayMinT.Size = new System.Drawing.Size(93, 20);
			this.tbTodayMinT.TabIndex = 20;
			// 
			// tbTomorrowMaxT
			// 
			this.tbTomorrowMaxT.Location = new System.Drawing.Point(428, 179);
			this.tbTomorrowMaxT.Name = "tbTomorrowMaxT";
			this.tbTomorrowMaxT.ReadOnly = true;
			this.tbTomorrowMaxT.Size = new System.Drawing.Size(93, 20);
			this.tbTomorrowMaxT.TabIndex = 21;
			// 
			// tbTomorrowMinT
			// 
			this.tbTomorrowMinT.Location = new System.Drawing.Point(428, 234);
			this.tbTomorrowMinT.Name = "tbTomorrowMinT";
			this.tbTomorrowMinT.ReadOnly = true;
			this.tbTomorrowMinT.Size = new System.Drawing.Size(93, 20);
			this.tbTomorrowMinT.TabIndex = 22;
			// 
			// tbAssateMaxT
			// 
			this.tbAssateMaxT.Location = new System.Drawing.Point(555, 183);
			this.tbAssateMaxT.Name = "tbAssateMaxT";
			this.tbAssateMaxT.ReadOnly = true;
			this.tbAssateMaxT.Size = new System.Drawing.Size(93, 20);
			this.tbAssateMaxT.TabIndex = 23;
			// 
			// tbAssateMinT
			// 
			this.tbAssateMinT.Location = new System.Drawing.Point(555, 234);
			this.tbAssateMinT.Name = "tbAssateMinT";
			this.tbAssateMinT.ReadOnly = true;
			this.tbAssateMinT.Size = new System.Drawing.Size(94, 20);
			this.tbAssateMinT.TabIndex = 24;
			// 
			// cbArea
			// 
			this.cbArea.FormattingEnabled = true;
			this.cbArea.Location = new System.Drawing.Point(15, 89);
			this.cbArea.Name = "cbArea";
			this.cbArea.Size = new System.Drawing.Size(115, 21);
			this.cbArea.TabIndex = 25;
			this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
			// 
			// labe1
			// 
			this.labe1.AutoSize = true;
			this.labe1.Location = new System.Drawing.Point(13, 73);
			this.labe1.Name = "labe1";
			this.labe1.Size = new System.Drawing.Size(35, 13);
			this.labe1.TabIndex = 26;
			this.labe1.Text = "エリア";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 457);
			this.Controls.Add(this.labe1);
			this.Controls.Add(this.cbArea);
			this.Controls.Add(this.tbAssateMinT);
			this.Controls.Add(this.tbAssateMaxT);
			this.Controls.Add(this.tbTomorrowMinT);
			this.Controls.Add(this.tbTomorrowMaxT);
			this.Controls.Add(this.tbTodayMinT);
			this.Controls.Add(this.tbTodayMaxT);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pbToday);
			this.Controls.Add(this.pbAsatte);
			this.Controls.Add(this.pbTomorrow);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btAcquisition);
			this.Controls.Add(this.tbWeatherInfo);
			this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAsatte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbWeatherInfo;
		private System.Windows.Forms.Button btAcquisition;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pbTomorrow;
		private System.Windows.Forms.PictureBox pbAsatte;
		private System.Windows.Forms.PictureBox pbToday;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbTodayMaxT;
		private System.Windows.Forms.TextBox tbTodayMinT;
		private System.Windows.Forms.TextBox tbTomorrowMaxT;
		private System.Windows.Forms.TextBox tbTomorrowMinT;
		private System.Windows.Forms.TextBox tbAssateMaxT;
		private System.Windows.Forms.TextBox tbAssateMinT;
		private System.Windows.Forms.ComboBox cbArea;
		private System.Windows.Forms.Label labe1;
	}
}

