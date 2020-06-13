namespace Argentum.Oscillius.Argentum.Forms
{
	partial class SodiumForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			this.E1TextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.E2TextBox = new System.Windows.Forms.TextBox();
			this.E3TextBox = new System.Windows.Forms.TextBox();
			this.InputGroupBox = new System.Windows.Forms.GroupBox();
			this.OutputGroupBox = new System.Windows.Forms.GroupBox();
			this.SodiumToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.InputGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// E1TextBox
			// 
			this.E1TextBox.Location = new System.Drawing.Point(9, 38);
			this.E1TextBox.Name = "E1TextBox";
			this.E1TextBox.Size = new System.Drawing.Size(114, 20);
			this.E1TextBox.TabIndex = 1;
			this.SodiumToolTip.SetToolTip(this.E1TextBox, "Значение потенциала E1, полученное при первом измерении:\r\n• 5 мл суспензии;\r\n• 0," +
        "5 мл NaCl (0,05 моль/л);\r\n• 5 мл буферного раствора с pH = 12,43;\r\n• 39,5 мл дис" +
        "тиллированной воды.");
			this.E1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBox_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "E1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "E2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "E3";
			// 
			// E2TextBox
			// 
			this.E2TextBox.Location = new System.Drawing.Point(9, 77);
			this.E2TextBox.Name = "E2TextBox";
			this.E2TextBox.Size = new System.Drawing.Size(114, 20);
			this.E2TextBox.TabIndex = 4;
			this.SodiumToolTip.SetToolTip(this.E2TextBox, "Значение потенциала E2, полученное при втором измерении\r\n(в стакане с 50 мл суспе" +
        "нзии).");
			this.E2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBox_KeyPress);
			// 
			// E3TextBox
			// 
			this.E3TextBox.Location = new System.Drawing.Point(9, 116);
			this.E3TextBox.Name = "E3TextBox";
			this.E3TextBox.Size = new System.Drawing.Size(114, 20);
			this.E3TextBox.TabIndex = 5;
			this.SodiumToolTip.SetToolTip(this.E3TextBox, "Значение потенциала E3, полученное при третьем измерении:\r\n• 50 мл суспензии;\r\n• " +
        "0,5 мл NaCl (0,5 моль/л).");
			this.E3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBox_KeyPress);
			// 
			// InputGroupBox
			// 
			this.InputGroupBox.Controls.Add(this.label1);
			this.InputGroupBox.Controls.Add(this.E3TextBox);
			this.InputGroupBox.Controls.Add(this.label3);
			this.InputGroupBox.Controls.Add(this.E1TextBox);
			this.InputGroupBox.Controls.Add(this.label2);
			this.InputGroupBox.Controls.Add(this.E2TextBox);
			this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
			this.InputGroupBox.Name = "InputGroupBox";
			this.InputGroupBox.Size = new System.Drawing.Size(129, 158);
			this.InputGroupBox.TabIndex = 1;
			this.InputGroupBox.TabStop = false;
			this.InputGroupBox.Text = "Входные параметры";
			// 
			// OutputGroupBox
			// 
			this.OutputGroupBox.Location = new System.Drawing.Point(157, 12);
			this.OutputGroupBox.Name = "OutputGroupBox";
			this.OutputGroupBox.Size = new System.Drawing.Size(257, 155);
			this.OutputGroupBox.TabIndex = 2;
			this.OutputGroupBox.TabStop = false;
			this.OutputGroupBox.Text = "Рассчитанные значения";
			// 
			// SodiumToolTip
			// 
			this.SodiumToolTip.AutomaticDelay = 5;
			this.SodiumToolTip.AutoPopDelay = 30000;
			this.SodiumToolTip.InitialDelay = 5;
			this.SodiumToolTip.ReshowDelay = 5;
			this.SodiumToolTip.UseAnimation = false;
			this.SodiumToolTip.UseFading = false;
			// 
			// SodiumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 179);
			this.Controls.Add(this.OutputGroupBox);
			this.Controls.Add(this.InputGroupBox);
			this.Name = "SodiumForm";
			this.Text = "Натрий";
			this.InputGroupBox.ResumeLayout(false);
			this.InputGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox E1TextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox E2TextBox;
		private System.Windows.Forms.TextBox E3TextBox;
		private System.Windows.Forms.GroupBox InputGroupBox;
		private System.Windows.Forms.GroupBox OutputGroupBox;
		private System.Windows.Forms.ToolTip SodiumToolTip;
	}
}