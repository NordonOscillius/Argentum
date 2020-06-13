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
			this.E1Label = new System.Windows.Forms.Label();
			this.E2Label = new System.Windows.Forms.Label();
			this.E3Label = new System.Windows.Forms.Label();
			this.E2TextBox = new System.Windows.Forms.TextBox();
			this.E3TextBox = new System.Windows.Forms.TextBox();
			this.InputGroupBox = new System.Windows.Forms.GroupBox();
			this.MassLabel = new System.Windows.Forms.Label();
			this.MassTextBox = new System.Windows.Forms.TextBox();
			this.OutputGroupBox = new System.Windows.Forms.GroupBox();
			this.ExponentTextBox = new System.Windows.Forms.TextBox();
			this.ExponentLabel = new System.Windows.Forms.Label();
			this.SteepnessTextBox = new System.Windows.Forms.TextBox();
			this.SteepnessLabel = new System.Windows.Forms.Label();
			this.DeltaELabel = new System.Windows.Forms.Label();
			this.DeltaETextBox = new System.Windows.Forms.TextBox();
			this.SodiumToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SodiumFractionLabel = new System.Windows.Forms.Label();
			this.SodiumFractionTextBox = new System.Windows.Forms.TextBox();
			this.InputGroupBox.SuspendLayout();
			this.OutputGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// E1TextBox
			// 
			this.E1TextBox.Location = new System.Drawing.Point(9, 77);
			this.E1TextBox.Name = "E1TextBox";
			this.E1TextBox.Size = new System.Drawing.Size(114, 20);
			this.E1TextBox.TabIndex = 3;
			this.SodiumToolTip.SetToolTip(this.E1TextBox, "Значение потенциала E1, полученное при первом измерении:\r\n• 5 мл суспензии;\r\n• 0," +
        "5 мл NaCl (0,05 моль/л);\r\n• 5 мл буферного раствора с pH = 12,45;\r\n• 39,5 мл дис" +
        "тиллированной воды.");
			this.E1TextBox.TextChanged += new System.EventHandler(this.E1TextBox_TextChanged);
			this.E1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBox_KeyPress);
			// 
			// E1Label
			// 
			this.E1Label.AutoSize = true;
			this.E1Label.Location = new System.Drawing.Point(6, 61);
			this.E1Label.Name = "E1Label";
			this.E1Label.Size = new System.Drawing.Size(41, 13);
			this.E1Label.TabIndex = 2;
			this.E1Label.Text = "E1, мВ";
			// 
			// E2Label
			// 
			this.E2Label.AutoSize = true;
			this.E2Label.Location = new System.Drawing.Point(6, 100);
			this.E2Label.Name = "E2Label";
			this.E2Label.Size = new System.Drawing.Size(41, 13);
			this.E2Label.TabIndex = 4;
			this.E2Label.Text = "E2, мВ";
			// 
			// E3Label
			// 
			this.E3Label.AutoSize = true;
			this.E3Label.Location = new System.Drawing.Point(6, 139);
			this.E3Label.Name = "E3Label";
			this.E3Label.Size = new System.Drawing.Size(41, 13);
			this.E3Label.TabIndex = 6;
			this.E3Label.Text = "E3, мВ";
			// 
			// E2TextBox
			// 
			this.E2TextBox.Location = new System.Drawing.Point(9, 116);
			this.E2TextBox.Name = "E2TextBox";
			this.E2TextBox.Size = new System.Drawing.Size(114, 20);
			this.E2TextBox.TabIndex = 5;
			this.SodiumToolTip.SetToolTip(this.E2TextBox, "Значение потенциала E2, полученное при втором измерении\r\n(в стакане с 50 мл суспе" +
        "нзии).");
			this.E2TextBox.TextChanged += new System.EventHandler(this.E2TextBox_TextChanged);
			this.E2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBox_KeyPress);
			// 
			// E3TextBox
			// 
			this.E3TextBox.Location = new System.Drawing.Point(9, 155);
			this.E3TextBox.Name = "E3TextBox";
			this.E3TextBox.Size = new System.Drawing.Size(114, 20);
			this.E3TextBox.TabIndex = 7;
			this.SodiumToolTip.SetToolTip(this.E3TextBox, "Значение потенциала E3, полученное при третьем измерении:\r\n• 50 мл суспензии;\r\n• " +
        "0,5 мл NaCl (0,5 моль/л).");
			this.E3TextBox.TextChanged += new System.EventHandler(this.E3TextBox_TextChanged);
			this.E3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericTextBox_KeyPress);
			// 
			// InputGroupBox
			// 
			this.InputGroupBox.Controls.Add(this.MassLabel);
			this.InputGroupBox.Controls.Add(this.MassTextBox);
			this.InputGroupBox.Controls.Add(this.E1Label);
			this.InputGroupBox.Controls.Add(this.E3TextBox);
			this.InputGroupBox.Controls.Add(this.E3Label);
			this.InputGroupBox.Controls.Add(this.E1TextBox);
			this.InputGroupBox.Controls.Add(this.E2Label);
			this.InputGroupBox.Controls.Add(this.E2TextBox);
			this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
			this.InputGroupBox.Name = "InputGroupBox";
			this.InputGroupBox.Size = new System.Drawing.Size(129, 184);
			this.InputGroupBox.TabIndex = 1;
			this.InputGroupBox.TabStop = false;
			this.InputGroupBox.Text = "Входные параметры";
			// 
			// MassLabel
			// 
			this.MassLabel.AutoSize = true;
			this.MassLabel.Location = new System.Drawing.Point(6, 22);
			this.MassLabel.Name = "MassLabel";
			this.MassLabel.Size = new System.Drawing.Size(96, 13);
			this.MassLabel.TabIndex = 0;
			this.MassLabel.Text = "Масса навески, г";
			// 
			// MassTextBox
			// 
			this.MassTextBox.Location = new System.Drawing.Point(6, 38);
			this.MassTextBox.Name = "MassTextBox";
			this.MassTextBox.Size = new System.Drawing.Size(114, 20);
			this.MassTextBox.TabIndex = 1;
			this.MassTextBox.TextChanged += new System.EventHandler(this.MassTextBox_TextChanged);
			this.MassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericNonNegativeTextBox_KeyPress);
			// 
			// OutputGroupBox
			// 
			this.OutputGroupBox.Controls.Add(this.SodiumFractionTextBox);
			this.OutputGroupBox.Controls.Add(this.SodiumFractionLabel);
			this.OutputGroupBox.Controls.Add(this.ExponentTextBox);
			this.OutputGroupBox.Controls.Add(this.ExponentLabel);
			this.OutputGroupBox.Controls.Add(this.SteepnessTextBox);
			this.OutputGroupBox.Controls.Add(this.SteepnessLabel);
			this.OutputGroupBox.Controls.Add(this.DeltaELabel);
			this.OutputGroupBox.Controls.Add(this.DeltaETextBox);
			this.OutputGroupBox.Location = new System.Drawing.Point(157, 12);
			this.OutputGroupBox.Name = "OutputGroupBox";
			this.OutputGroupBox.Size = new System.Drawing.Size(257, 184);
			this.OutputGroupBox.TabIndex = 2;
			this.OutputGroupBox.TabStop = false;
			this.OutputGroupBox.Text = "Рассчитанные значения";
			// 
			// ExponentTextBox
			// 
			this.ExponentTextBox.Location = new System.Drawing.Point(6, 116);
			this.ExponentTextBox.Name = "ExponentTextBox";
			this.ExponentTextBox.ReadOnly = true;
			this.ExponentTextBox.Size = new System.Drawing.Size(114, 20);
			this.ExponentTextBox.TabIndex = 4;
			this.ExponentTextBox.TabStop = false;
			this.SodiumToolTip.SetToolTip(this.ExponentTextBox, "Отношение дельты потенциала к крутизне электродной функции.");
			// 
			// ExponentLabel
			// 
			this.ExponentLabel.AutoSize = true;
			this.ExponentLabel.Location = new System.Drawing.Point(6, 100);
			this.ExponentLabel.Name = "ExponentLabel";
			this.ExponentLabel.Size = new System.Drawing.Size(39, 13);
			this.ExponentLabel.TabIndex = 3;
			this.ExponentLabel.Text = "ΔE / S";
			// 
			// SteepnessTextBox
			// 
			this.SteepnessTextBox.Location = new System.Drawing.Point(6, 77);
			this.SteepnessTextBox.Name = "SteepnessTextBox";
			this.SteepnessTextBox.ReadOnly = true;
			this.SteepnessTextBox.Size = new System.Drawing.Size(114, 20);
			this.SteepnessTextBox.TabIndex = 2;
			this.SteepnessTextBox.TabStop = false;
			this.SodiumToolTip.SetToolTip(this.SteepnessTextBox, "Крутизна электродной функции S = E3 - E1.");
			// 
			// SteepnessLabel
			// 
			this.SteepnessLabel.AutoSize = true;
			this.SteepnessLabel.Location = new System.Drawing.Point(6, 61);
			this.SteepnessLabel.Name = "SteepnessLabel";
			this.SteepnessLabel.Size = new System.Drawing.Size(35, 13);
			this.SteepnessLabel.TabIndex = 1;
			this.SteepnessLabel.Text = "S, мВ";
			// 
			// DeltaELabel
			// 
			this.DeltaELabel.AutoSize = true;
			this.DeltaELabel.Location = new System.Drawing.Point(6, 22);
			this.DeltaELabel.Name = "DeltaELabel";
			this.DeltaELabel.Size = new System.Drawing.Size(42, 13);
			this.DeltaELabel.TabIndex = 0;
			this.DeltaELabel.Text = "ΔE, мВ";
			// 
			// DeltaETextBox
			// 
			this.DeltaETextBox.Location = new System.Drawing.Point(6, 38);
			this.DeltaETextBox.Name = "DeltaETextBox";
			this.DeltaETextBox.ReadOnly = true;
			this.DeltaETextBox.Size = new System.Drawing.Size(114, 20);
			this.DeltaETextBox.TabIndex = 0;
			this.DeltaETextBox.TabStop = false;
			this.SodiumToolTip.SetToolTip(this.DeltaETextBox, "Изменение потенциала ΔE = E3 - E2.");
			// 
			// SodiumToolTip
			// 
			this.SodiumToolTip.AutomaticDelay = 5;
			this.SodiumToolTip.AutoPopDelay = 30000;
			this.SodiumToolTip.InitialDelay = 5;
			this.SodiumToolTip.ReshowDelay = 5;
			this.SodiumToolTip.UseFading = false;
			// 
			// SodiumFractionLabel
			// 
			this.SodiumFractionLabel.AutoSize = true;
			this.SodiumFractionLabel.Location = new System.Drawing.Point(6, 139);
			this.SodiumFractionLabel.Name = "SodiumFractionLabel";
			this.SodiumFractionLabel.Size = new System.Drawing.Size(122, 13);
			this.SodiumFractionLabel.TabIndex = 5;
			this.SodiumFractionLabel.Text = "Содержание натрия, %";
			// 
			// SodiumFractionTextBox
			// 
			this.SodiumFractionTextBox.Location = new System.Drawing.Point(6, 155);
			this.SodiumFractionTextBox.Name = "SodiumFractionTextBox";
			this.SodiumFractionTextBox.ReadOnly = true;
			this.SodiumFractionTextBox.Size = new System.Drawing.Size(114, 20);
			this.SodiumFractionTextBox.TabIndex = 6;
			this.SodiumFractionTextBox.TabStop = false;
			this.SodiumToolTip.SetToolTip(this.SodiumFractionTextBox, "Искомое содержание натрия в пробе.");
			// 
			// SodiumForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 204);
			this.Controls.Add(this.OutputGroupBox);
			this.Controls.Add(this.InputGroupBox);
			this.Name = "SodiumForm";
			this.Text = "Натрий";
			this.Load += new System.EventHandler(this.SodiumForm_Load);
			this.InputGroupBox.ResumeLayout(false);
			this.InputGroupBox.PerformLayout();
			this.OutputGroupBox.ResumeLayout(false);
			this.OutputGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox E1TextBox;
		private System.Windows.Forms.Label E1Label;
		private System.Windows.Forms.Label E2Label;
		private System.Windows.Forms.Label E3Label;
		private System.Windows.Forms.TextBox E2TextBox;
		private System.Windows.Forms.TextBox E3TextBox;
		private System.Windows.Forms.GroupBox InputGroupBox;
		private System.Windows.Forms.GroupBox OutputGroupBox;
		private System.Windows.Forms.ToolTip SodiumToolTip;
		private System.Windows.Forms.Label DeltaELabel;
		private System.Windows.Forms.TextBox DeltaETextBox;
		private System.Windows.Forms.Label MassLabel;
		private System.Windows.Forms.TextBox MassTextBox;
		private System.Windows.Forms.TextBox SteepnessTextBox;
		private System.Windows.Forms.Label SteepnessLabel;
		private System.Windows.Forms.TextBox ExponentTextBox;
		private System.Windows.Forms.Label ExponentLabel;
		private System.Windows.Forms.TextBox SodiumFractionTextBox;
		private System.Windows.Forms.Label SodiumFractionLabel;
	}
}