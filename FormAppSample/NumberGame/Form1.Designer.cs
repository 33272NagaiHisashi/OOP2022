
namespace NumberGame {
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
			this.btInsert = new System.Windows.Forms.Button();
			this.tbNum = new System.Windows.Forms.TextBox();
			this.lbRW = new System.Windows.Forms.Label();
			this.lbHint = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(248, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(299, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "1～50の中から";
			// 
			// btInsert
			// 
			this.btInsert.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btInsert.Location = new System.Drawing.Point(456, 191);
			this.btInsert.Name = "btInsert";
			this.btInsert.Size = new System.Drawing.Size(174, 95);
			this.btInsert.TabIndex = 1;
			this.btInsert.Text = "入力";
			this.btInsert.UseVisualStyleBackColor = true;
			this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
			// 
			// tbNum
			// 
			this.tbNum.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbNum.Location = new System.Drawing.Point(200, 191);
			this.tbNum.Multiline = true;
			this.tbNum.Name = "tbNum";
			this.tbNum.Size = new System.Drawing.Size(166, 95);
			this.tbNum.TabIndex = 2;
			// 
			// lbRW
			// 
			this.lbRW.AutoSize = true;
			this.lbRW.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lbRW.Location = new System.Drawing.Point(366, 341);
			this.lbRW.Name = "lbRW";
			this.lbRW.Size = new System.Drawing.Size(0, 37);
			this.lbRW.TabIndex = 4;
			// 
			// lbHint
			// 
			this.lbHint.AutoSize = true;
			this.lbHint.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lbHint.Location = new System.Drawing.Point(318, 384);
			this.lbHint.Name = "lbHint";
			this.lbHint.Size = new System.Drawing.Size(0, 21);
			this.lbHint.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(322, 71);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(56, 48);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "0";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lbRW);
			this.Controls.Add(this.tbNum);
			this.Controls.Add(this.btInsert);
			this.Controls.Add(this.lbHint);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btInsert;
		private System.Windows.Forms.TextBox tbNum;
		private System.Windows.Forms.Label lbRW;
		private System.Windows.Forms.Label lbHint;
		private System.Windows.Forms.TextBox textBox1;
	}
}

