﻿namespace KitapFiyatHesaplamaUygulamasi
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(92, 128);
			label1.Name = "label1";
			label1.Size = new Size(83, 20);
			label1.TabIndex = 0;
			label1.Text = "Kitap Adet:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(129, 187);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 1;
			label2.Text = "Tutar:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = SystemColors.ButtonHighlight;
			label3.Location = new Point(181, 187);
			label3.Name = "label3";
			label3.Size = new Size(44, 20);
			label3.TabIndex = 2;
			label3.Text = "00 TL";
			// 
			// button1
			// 
			button1.Location = new Point(129, 245);
			button1.Name = "button1";
			button1.Size = new Size(74, 29);
			button1.TabIndex = 4;
			button1.Text = "Hesapla";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(181, 128);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(44, 27);
			textBox1.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(352, 450);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Tutar Hesaplama";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private TextBox textBox1;
	}
}
