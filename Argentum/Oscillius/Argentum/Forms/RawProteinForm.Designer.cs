namespace Argentum.Oscillius.Argentum.Forms
{
	partial class RawProteinForm
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
			this.InputGroupBox = new System.Windows.Forms.GroupBox();
			this.TubeAndSampleMassLabel = new System.Windows.Forms.Label();
			this.TubeAndSampleMassTextBox = new System.Windows.Forms.TextBox();
			this.RawProteinToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.TubeAndRemainsMassLabel = new System.Windows.Forms.Label();
			this.TubeAndRemainsMassTextBox = new System.Windows.Forms.TextBox();
			this.TitrantVolumeLabel = new System.Windows.Forms.Label();
			this.TitrantVolumeTextBox = new System.Windows.Forms.TextBox();
			this.TitrantCorrectionLabel = new System.Windows.Forms.Label();
			this.TitrantCorrectionTextBox = new System.Windows.Forms.TextBox();
			this.TitrantControlVolumeLabel = new System.Windows.Forms.Label();
			this.TitrantControlVolumeTextBox = new System.Windows.Forms.TextBox();
			this.InputGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputGroupBox
			// 
			this.InputGroupBox.Controls.Add(this.TitrantControlVolumeTextBox);
			this.InputGroupBox.Controls.Add(this.TitrantControlVolumeLabel);
			this.InputGroupBox.Controls.Add(this.TitrantCorrectionTextBox);
			this.InputGroupBox.Controls.Add(this.TitrantCorrectionLabel);
			this.InputGroupBox.Controls.Add(this.TitrantVolumeTextBox);
			this.InputGroupBox.Controls.Add(this.TitrantVolumeLabel);
			this.InputGroupBox.Controls.Add(this.TubeAndRemainsMassTextBox);
			this.InputGroupBox.Controls.Add(this.TubeAndRemainsMassLabel);
			this.InputGroupBox.Controls.Add(this.TubeAndSampleMassTextBox);
			this.InputGroupBox.Controls.Add(this.TubeAndSampleMassLabel);
			this.InputGroupBox.Location = new System.Drawing.Point(12, 12);
			this.InputGroupBox.Name = "InputGroupBox";
			this.InputGroupBox.Size = new System.Drawing.Size(186, 263);
			this.InputGroupBox.TabIndex = 2;
			this.InputGroupBox.TabStop = false;
			this.InputGroupBox.Text = "Входные параметры";
			// 
			// TubeAndSampleMassLabel
			// 
			this.TubeAndSampleMassLabel.AutoSize = true;
			this.TubeAndSampleMassLabel.Location = new System.Drawing.Point(6, 22);
			this.TubeAndSampleMassLabel.Name = "TubeAndSampleMassLabel";
			this.TubeAndSampleMassLabel.Size = new System.Drawing.Size(172, 26);
			this.TubeAndSampleMassLabel.TabIndex = 1;
			this.TubeAndSampleMassLabel.Text = "Масса малой пробирки с грубой\r\nнавеской пробы, г";
			// 
			// TubeAndSampleMassTextBox
			// 
			this.TubeAndSampleMassTextBox.Location = new System.Drawing.Point(6, 51);
			this.TubeAndSampleMassTextBox.Name = "TubeAndSampleMassTextBox";
			this.TubeAndSampleMassTextBox.Size = new System.Drawing.Size(172, 20);
			this.TubeAndSampleMassTextBox.TabIndex = 2;
			this.RawProteinToolTip.SetToolTip(this.TubeAndSampleMassTextBox, "До погружения в колбу Кьельдаля.");
			// 
			// RawProteinToolTip
			// 
			this.RawProteinToolTip.AutomaticDelay = 5;
			this.RawProteinToolTip.AutoPopDelay = 30000;
			this.RawProteinToolTip.InitialDelay = 5;
			this.RawProteinToolTip.ReshowDelay = 5;
			this.RawProteinToolTip.UseFading = false;
			// 
			// TubeAndRemainsMassLabel
			// 
			this.TubeAndRemainsMassLabel.AutoSize = true;
			this.TubeAndRemainsMassLabel.Location = new System.Drawing.Point(6, 74);
			this.TubeAndRemainsMassLabel.Name = "TubeAndRemainsMassLabel";
			this.TubeAndRemainsMassLabel.Size = new System.Drawing.Size(126, 26);
			this.TubeAndRemainsMassLabel.TabIndex = 3;
			this.TubeAndRemainsMassLabel.Text = "Масса малой пробирки\r\nс остатком пробы, г";
			// 
			// TubeAndRemainsMassTextBox
			// 
			this.TubeAndRemainsMassTextBox.Location = new System.Drawing.Point(6, 103);
			this.TubeAndRemainsMassTextBox.Name = "TubeAndRemainsMassTextBox";
			this.TubeAndRemainsMassTextBox.Size = new System.Drawing.Size(172, 20);
			this.TubeAndRemainsMassTextBox.TabIndex = 4;
			this.RawProteinToolTip.SetToolTip(this.TubeAndRemainsMassTextBox, "После погружения в колбу Кьельдаля.");
			// 
			// TitrantVolumeLabel
			// 
			this.TitrantVolumeLabel.AutoSize = true;
			this.TitrantVolumeLabel.Location = new System.Drawing.Point(6, 126);
			this.TitrantVolumeLabel.Name = "TitrantVolumeLabel";
			this.TitrantVolumeLabel.Size = new System.Drawing.Size(110, 13);
			this.TitrantVolumeLabel.TabIndex = 5;
			this.TitrantVolumeLabel.Text = "Объем титранта, мл";
			// 
			// TitrantVolumeTextBox
			// 
			this.TitrantVolumeTextBox.Location = new System.Drawing.Point(6, 142);
			this.TitrantVolumeTextBox.Name = "TitrantVolumeTextBox";
			this.TitrantVolumeTextBox.Size = new System.Drawing.Size(172, 20);
			this.TitrantVolumeTextBox.TabIndex = 6;
			this.RawProteinToolTip.SetToolTip(this.TitrantVolumeTextBox, "Объем раствора серной кислоты,\r\nпошедший на титрование.");
			// 
			// TitrantCorrectionLabel
			// 
			this.TitrantCorrectionLabel.AutoSize = true;
			this.TitrantCorrectionLabel.Location = new System.Drawing.Point(6, 165);
			this.TitrantCorrectionLabel.Name = "TitrantCorrectionLabel";
			this.TitrantCorrectionLabel.Size = new System.Drawing.Size(163, 13);
			this.TitrantCorrectionLabel.TabIndex = 7;
			this.TitrantCorrectionLabel.Text = "Поправка для серной кислоты";
			// 
			// TitrantCorrectionTextBox
			// 
			this.TitrantCorrectionTextBox.Location = new System.Drawing.Point(6, 181);
			this.TitrantCorrectionTextBox.Name = "TitrantCorrectionTextBox";
			this.TitrantCorrectionTextBox.Size = new System.Drawing.Size(172, 20);
			this.TitrantCorrectionTextBox.TabIndex = 8;
			this.RawProteinToolTip.SetToolTip(this.TitrantCorrectionTextBox, "Поправочный коэффициент для раствора серной кислоты,\r\nс помощью которого производ" +
        "илось титрование.");
			// 
			// TitrantControlVolumeLabel
			// 
			this.TitrantControlVolumeLabel.AutoSize = true;
			this.TitrantControlVolumeLabel.Location = new System.Drawing.Point(6, 204);
			this.TitrantControlVolumeLabel.Name = "TitrantControlVolumeLabel";
			this.TitrantControlVolumeLabel.Size = new System.Drawing.Size(169, 26);
			this.TitrantControlVolumeLabel.TabIndex = 9;
			this.TitrantControlVolumeLabel.Text = "Объем титранта в контрольном\r\nопыте, мл";
			// 
			// TitrantControlVolumeTextBox
			// 
			this.TitrantControlVolumeTextBox.Location = new System.Drawing.Point(6, 233);
			this.TitrantControlVolumeTextBox.Name = "TitrantControlVolumeTextBox";
			this.TitrantControlVolumeTextBox.Size = new System.Drawing.Size(172, 20);
			this.TitrantControlVolumeTextBox.TabIndex = 10;
			this.RawProteinToolTip.SetToolTip(this.TitrantControlVolumeTextBox, "Объем раствора серной кислоты, пошедший\r\nна титрование в контрольном опыте.");
			// 
			// RawProteinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 284);
			this.Controls.Add(this.InputGroupBox);
			this.Name = "RawProteinForm";
			this.Text = "Сырой протеин";
			this.InputGroupBox.ResumeLayout(false);
			this.InputGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox InputGroupBox;
		private System.Windows.Forms.Label TubeAndSampleMassLabel;
		private System.Windows.Forms.TextBox TubeAndSampleMassTextBox;
		private System.Windows.Forms.ToolTip RawProteinToolTip;
		private System.Windows.Forms.Label TubeAndRemainsMassLabel;
		private System.Windows.Forms.TextBox TubeAndRemainsMassTextBox;
		private System.Windows.Forms.TextBox TitrantVolumeTextBox;
		private System.Windows.Forms.Label TitrantVolumeLabel;
		private System.Windows.Forms.TextBox TitrantControlVolumeTextBox;
		private System.Windows.Forms.Label TitrantControlVolumeLabel;
		private System.Windows.Forms.TextBox TitrantCorrectionTextBox;
		private System.Windows.Forms.Label TitrantCorrectionLabel;
	}
}