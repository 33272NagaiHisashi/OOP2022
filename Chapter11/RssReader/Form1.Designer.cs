
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
			this.cbRss = new System.Windows.Forms.ComboBox();
			this.btBack = new System.Windows.Forms.Button();
			this.btForward = new System.Windows.Forms.Button();
			this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
			((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
			this.SuspendLayout();
			// 
			// btRss
			// 
			this.btRss.Location = new System.Drawing.Point(1220, 6);
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
			this.lbRss.Size = new System.Drawing.Size(185, 616);
			this.lbRss.TabIndex = 2;
			this.lbRss.SelectedIndexChanged += new System.EventHandler(this.lbRss_SelectedIndexChanged);
			// 
			// cbRss
			// 
			this.cbRss.FormattingEnabled = true;
			this.cbRss.Location = new System.Drawing.Point(13, 9);
			this.cbRss.Name = "cbRss";
			this.cbRss.Size = new System.Drawing.Size(1201, 20);
			this.cbRss.TabIndex = 4;
			// 
			// btBack
			// 
			this.btBack.Location = new System.Drawing.Point(1333, 6);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(40, 23);
			this.btBack.TabIndex = 0;
			this.btBack.Text = "←";
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// btForward
			// 
			this.btForward.Location = new System.Drawing.Point(1379, 6);
			this.btForward.Name = "btForward";
			this.btForward.Size = new System.Drawing.Size(40, 23);
			this.btForward.TabIndex = 0;
			this.btForward.Text = "→";
			this.btForward.UseVisualStyleBackColor = true;
			this.btForward.Click += new System.EventHandler(this.btForward_Click);
			// 
			// wvBrowser
			// 
			this.wvBrowser.Location = new System.Drawing.Point(203, 35);
			this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.wvBrowser.Name = "wvBrowser";
			this.wvBrowser.Size = new System.Drawing.Size(1217, 616);
			this.wvBrowser.TabIndex = 5;
			this.wvBrowser.DOMContentLoaded += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs>(this.wvBrowser_DOMContentLoaded);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1432, 656);
			this.Controls.Add(this.wvBrowser);
			this.Controls.Add(this.cbRss);
			this.Controls.Add(this.lbRss);
			this.Controls.Add(this.btForward);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.btRss);
			this.Name = "Form1";
			this.Text = "RssReader";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btRss;
		private System.Windows.Forms.ListBox lbRss;
		private System.Windows.Forms.ComboBox cbRss;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Button btForward;
		private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
	}
}

