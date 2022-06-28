
namespace RssReader {
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
			this.btRss = new System.Windows.Forms.Button();
			this.lbRss = new System.Windows.Forms.ListBox();
			this.wbRss = new System.Windows.Forms.WebBrowser();
			this.cbRss = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btRss
			// 
			this.btRss.Location = new System.Drawing.Point(713, 9);
			this.btRss.Name = "btRss";
			this.btRss.Size = new System.Drawing.Size(75, 23);
			this.btRss.TabIndex = 0;
			this.btRss.Text = "取得";
			this.btRss.UseVisualStyleBackColor = true;
			this.btRss.Click += new System.EventHandler(this.btRss_Click);
			// 
			// lbRss
			// 
			this.lbRss.FormattingEnabled = true;
			this.lbRss.ItemHeight = 12;
			this.lbRss.Location = new System.Drawing.Point(12, 35);
			this.lbRss.Name = "lbRss";
			this.lbRss.Size = new System.Drawing.Size(185, 400);
			this.lbRss.TabIndex = 2;
			this.lbRss.SelectedIndexChanged += new System.EventHandler(this.lbRss_SelectedIndexChanged);
			// 
			// wbRss
			// 
			this.wbRss.Location = new System.Drawing.Point(203, 35);
			this.wbRss.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbRss.Name = "wbRss";
			this.wbRss.Size = new System.Drawing.Size(585, 402);
			this.wbRss.TabIndex = 3;
			// 
			// cbRss
			// 
			this.cbRss.FormattingEnabled = true;
			this.cbRss.Location = new System.Drawing.Point(13, 9);
			this.cbRss.Name = "cbRss";
			this.cbRss.Size = new System.Drawing.Size(694, 20);
			this.cbRss.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbRss);
			this.Controls.Add(this.wbRss);
			this.Controls.Add(this.lbRss);
			this.Controls.Add(this.btRss);
			this.Name = "Form1";
			this.Text = "RssReader";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btRss;
		private System.Windows.Forms.ListBox lbRss;
		private System.Windows.Forms.WebBrowser wbRss;
		private System.Windows.Forms.ComboBox cbRss;
	}
}

