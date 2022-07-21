
namespace Sample0607 {
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
			this.btRandom = new System.Windows.Forms.Button();
			this.tbRandom = new System.Windows.Forms.TextBox();
			this.tbMin = new System.Windows.Forms.TextBox();
			this.tbMax = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btRandom
			// 
			this.btRandom.Location = new System.Drawing.Point(464, 253);
			this.btRandom.Name = "btRandom";
			this.btRandom.Size = new System.Drawing.Size(200, 69);
			this.btRandom.TabIndex = 0;
			this.btRandom.Text = "乱数";
			this.btRandom.UseVisualStyleBackColor = true;
			this.btRandom.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// tbRandom
			// 
			this.tbRandom.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbRandom.Location = new System.Drawing.Point(109, 218);
			this.tbRandom.Multiline = true;
			this.tbRandom.Name = "tbRandom";
			this.tbRandom.Size = new System.Drawing.Size(234, 114);
			this.tbRandom.TabIndex = 1;
			// 
			// tbMin
			// 
			this.tbMin.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbMin.Location = new System.Drawing.Point(441, 30);
			this.tbMin.Multiline = true;
			this.tbMin.Name = "tbMin";
			this.tbMin.Size = new System.Drawing.Size(242, 62);
			this.tbMin.TabIndex = 1;
			// 
			// tbMax
			// 
			this.tbMax.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbMax.Location = new System.Drawing.Point(441, 125);
			this.tbMax.Multiline = true;
			this.tbMax.Name = "tbMax";
			this.tbMax.Size = new System.Drawing.Size(242, 63);
			this.tbMax.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(179, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "最小値";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(179, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 37);
			this.label2.TabIndex = 2;
			this.label2.Text = "最大値";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(800, 344);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbMax);
			this.Controls.Add(this.tbMin);
			this.Controls.Add(this.tbRandom);
			this.Controls.Add(this.btRandom);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btRandom;
		private System.Windows.Forms.TextBox tbRandom;
		private System.Windows.Forms.TextBox tbMin;
		private System.Windows.Forms.TextBox tbMax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

