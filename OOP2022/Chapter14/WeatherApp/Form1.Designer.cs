
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbPublishingOffice = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbWeatherInfo
			// 
			this.tbWeatherInfo.Location = new System.Drawing.Point(13, 281);
			this.tbWeatherInfo.Multiline = true;
			this.tbWeatherInfo.Name = "tbWeatherInfo";
			this.tbWeatherInfo.Size = new System.Drawing.Size(544, 117);
			this.tbWeatherInfo.TabIndex = 0;
			// 
			// btAcquisition
			// 
			this.btAcquisition.Location = new System.Drawing.Point(447, 220);
			this.btAcquisition.Name = "btAcquisition";
			this.btAcquisition.Size = new System.Drawing.Size(110, 55);
			this.btAcquisition.TabIndex = 1;
			this.btAcquisition.Text = "取得";
			this.btAcquisition.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "地方気象台";
			// 
			// tbPublishingOffice
			// 
			this.tbPublishingOffice.Location = new System.Drawing.Point(12, 24);
			this.tbPublishingOffice.Name = "tbPublishingOffice";
			this.tbPublishingOffice.Size = new System.Drawing.Size(100, 19);
			this.tbPublishingOffice.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 422);
			this.Controls.Add(this.tbPublishingOffice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btAcquisition);
			this.Controls.Add(this.tbWeatherInfo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbWeatherInfo;
		private System.Windows.Forms.Button btAcquisition;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPublishingOffice;
	}
}

