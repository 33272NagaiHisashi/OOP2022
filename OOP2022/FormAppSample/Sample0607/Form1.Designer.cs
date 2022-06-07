
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
			this.tbNum1 = new System.Windows.Forms.TextBox();
			this.tbNum2 = new System.Windows.Forms.TextBox();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbRemainder = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nudRemainder = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nudTotal = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.nudNum2 = new System.Windows.Forms.NumericUpDown();
			this.nudNum1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudRemainder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNum2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNum1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbNum1
			// 
			this.tbNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbNum1.Location = new System.Drawing.Point(27, 24);
			this.tbNum1.Multiline = true;
			this.tbNum1.Name = "tbNum1";
			this.tbNum1.Size = new System.Drawing.Size(100, 90);
			this.tbNum1.TabIndex = 0;
			// 
			// tbNum2
			// 
			this.tbNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbNum2.Location = new System.Drawing.Point(193, 24);
			this.tbNum2.Multiline = true;
			this.tbNum2.Name = "tbNum2";
			this.tbNum2.Size = new System.Drawing.Size(100, 90);
			this.tbNum2.TabIndex = 0;
			// 
			// tbTotal
			// 
			this.tbTotal.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbTotal.Location = new System.Drawing.Point(341, 24);
			this.tbTotal.Multiline = true;
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(100, 90);
			this.tbTotal.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(133, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "÷";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(299, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "=";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(447, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "あまり";
			// 
			// tbRemainder
			// 
			this.tbRemainder.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbRemainder.Location = new System.Drawing.Point(551, 24);
			this.tbRemainder.Multiline = true;
			this.tbRemainder.Name = "tbRemainder";
			this.tbRemainder.Size = new System.Drawing.Size(100, 90);
			this.tbRemainder.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button1.Location = new System.Drawing.Point(688, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 90);
			this.button1.TabIndex = 2;
			this.button1.Text = "計算";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(299, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 37);
			this.label6.TabIndex = 1;
			this.label6.Text = "=";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(299, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 37);
			this.label8.TabIndex = 1;
			this.label8.Text = "=";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.Location = new System.Drawing.Point(447, 53);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 37);
			this.label10.TabIndex = 1;
			this.label10.Text = "あまり";
			// 
			// nudRemainder
			// 
			this.nudRemainder.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nudRemainder.Location = new System.Drawing.Point(636, 224);
			this.nudRemainder.Name = "nudRemainder";
			this.nudRemainder.Size = new System.Drawing.Size(120, 44);
			this.nudRemainder.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label11.Location = new System.Drawing.Point(523, 230);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 37);
			this.label11.TabIndex = 1;
			this.label11.Text = "あまり";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label9.Location = new System.Drawing.Point(334, 231);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 37);
			this.label9.TabIndex = 1;
			this.label9.Text = "=";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(133, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 37);
			this.label4.TabIndex = 1;
			this.label4.Text = "÷";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(133, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 37);
			this.label5.TabIndex = 1;
			this.label5.Text = "÷";
			// 
			// nudTotal
			// 
			this.nudTotal.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nudTotal.Location = new System.Drawing.Point(376, 226);
			this.nudTotal.Name = "nudTotal";
			this.nudTotal.Size = new System.Drawing.Size(120, 44);
			this.nudTotal.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(133, 233);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 37);
			this.label7.TabIndex = 1;
			this.label7.Text = "÷";
			// 
			// nudNum2
			// 
			this.nudNum2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nudNum2.Location = new System.Drawing.Point(193, 228);
			this.nudNum2.Name = "nudNum2";
			this.nudNum2.Size = new System.Drawing.Size(120, 44);
			this.nudNum2.TabIndex = 3;
			// 
			// nudNum1
			// 
			this.nudNum1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nudNum1.Location = new System.Drawing.Point(27, 229);
			this.nudNum1.Name = "nudNum1";
			this.nudNum1.Size = new System.Drawing.Size(100, 44);
			this.nudNum1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(800, 396);
			this.Controls.Add(this.nudRemainder);
			this.Controls.Add(this.nudTotal);
			this.Controls.Add(this.nudNum2);
			this.Controls.Add(this.nudNum1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbRemainder);
			this.Controls.Add(this.tbTotal);
			this.Controls.Add(this.tbNum2);
			this.Controls.Add(this.tbNum1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nudRemainder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNum2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNum1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbNum1;
		private System.Windows.Forms.TextBox tbNum2;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbRemainder;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown nudRemainder;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudTotal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudNum2;
		private System.Windows.Forms.NumericUpDown nudNum1;
	}
}

