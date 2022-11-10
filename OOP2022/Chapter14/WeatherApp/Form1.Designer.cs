
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
			this.cbRegion = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// tbWeatherInfo
			// 
			this.tbWeatherInfo.Location = new System.Drawing.Point(12, 74);
			this.tbWeatherInfo.Multiline = true;
			this.tbWeatherInfo.Name = "tbWeatherInfo";
			this.tbWeatherInfo.Size = new System.Drawing.Size(532, 263);
			this.tbWeatherInfo.TabIndex = 0;
			// 
			// btAcquisition
			// 
			this.btAcquisition.Location = new System.Drawing.Point(13, 13);
			this.btAcquisition.Name = "btAcquisition";
			this.btAcquisition.Size = new System.Drawing.Size(110, 55);
			this.btAcquisition.TabIndex = 1;
			this.btAcquisition.Text = "取得";
			this.btAcquisition.UseVisualStyleBackColor = true;
			this.btAcquisition.Click += new System.EventHandler(this.btAcquisition_Click);
			// 
			// cbRegion
			// 
			this.cbRegion.FormattingEnabled = true;
			this.cbRegion.Location = new System.Drawing.Point(129, 48);
			this.cbRegion.Name = "cbRegion";
			this.cbRegion.Size = new System.Drawing.Size(92, 20);
			this.cbRegion.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(129, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "地域";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(237, 48);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(105, 20);
			this.comboBox2.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 422);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbRegion);
			this.Controls.Add(this.btAcquisition);
			this.Controls.Add(this.tbWeatherInfo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbWeatherInfo;
		private System.Windows.Forms.Button btAcquisition;
		private System.Windows.Forms.ComboBox cbRegion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox2;
	}
}

