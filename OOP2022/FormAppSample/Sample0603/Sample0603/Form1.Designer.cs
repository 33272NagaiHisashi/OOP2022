
namespace Sample0603 {
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
			this.btPush = new System.Windows.Forms.Button();
			this.tbSuu1 = new System.Windows.Forms.TextBox();
			this.tbAns = new System.Windows.Forms.TextBox();
			this.tbSuu2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nud1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.nud2 = new System.Windows.Forms.NumericUpDown();
			this.nudAns = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAns)).BeginInit();
			this.SuspendLayout();
			// 
			// btPush
			// 
			this.btPush.BackColor = System.Drawing.Color.Red;
			this.btPush.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btPush.Location = new System.Drawing.Point(437, 91);
			this.btPush.Name = "btPush";
			this.btPush.Size = new System.Drawing.Size(172, 55);
			this.btPush.TabIndex = 0;
			this.btPush.Text = "計算";
			this.btPush.UseVisualStyleBackColor = false;
			this.btPush.Click += new System.EventHandler(this.btPush_Click);
			// 
			// tbSuu1
			// 
			this.tbSuu1.Location = new System.Drawing.Point(12, 12);
			this.tbSuu1.Multiline = true;
			this.tbSuu1.Name = "tbSuu1";
			this.tbSuu1.Size = new System.Drawing.Size(134, 60);
			this.tbSuu1.TabIndex = 1;
			
			// 
			// tbAns
			// 
			this.tbAns.Location = new System.Drawing.Point(407, 12);
			this.tbAns.Multiline = true;
			this.tbAns.Name = "tbAns";
			this.tbAns.Size = new System.Drawing.Size(202, 60);
			this.tbAns.TabIndex = 1;
			// 
			// tbSuu2
			// 
			this.tbSuu2.Location = new System.Drawing.Point(189, 12);
			this.tbSuu2.Multiline = true;
			this.tbSuu2.Name = "tbSuu2";
			this.tbSuu2.Size = new System.Drawing.Size(132, 60);
			this.tbSuu2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(152, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 33);
			this.label1.TabIndex = 2;
			this.label1.Text = "+";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(354, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "=";
			// 
			// nud1
			// 
			this.nud1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nud1.Location = new System.Drawing.Point(12, 153);
			this.nud1.Name = "nud1";
			this.nud1.Size = new System.Drawing.Size(134, 39);
			this.nud1.TabIndex = 4;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.numericUpDown2.Location = new System.Drawing.Point(189, 153);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 39);
			this.numericUpDown2.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button1.Location = new System.Drawing.Point(437, 91);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(172, 55);
			this.button1.TabIndex = 0;
			this.button1.Text = "計算";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.btPush_Click);
			// 
			// nud2
			// 
			this.nud2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nud2.Location = new System.Drawing.Point(189, 153);
			this.nud2.Name = "nud2";
			this.nud2.Size = new System.Drawing.Size(132, 39);
			this.nud2.TabIndex = 4;
			// 
			// nudAns
			// 
			this.nudAns.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.nudAns.Location = new System.Drawing.Point(407, 152);
			this.nudAns.Name = "nudAns";
			this.nudAns.Size = new System.Drawing.Size(202, 39);
			this.nudAns.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(152, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "+";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(354, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "=";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 253);
			this.Controls.Add(this.nudAns);
			this.Controls.Add(this.nud2);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.nud1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbAns);
			this.Controls.Add(this.tbSuu2);
			this.Controls.Add(this.tbSuu1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btPush);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAns)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btPush;
		private System.Windows.Forms.TextBox tbSuu1;
		private System.Windows.Forms.TextBox tbAns;
		private System.Windows.Forms.TextBox tbSuu2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nud1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown nud2;
		private System.Windows.Forms.NumericUpDown nudAns;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

