namespace Argentum
{
	partial class MainForm
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
			this.NaButton = new System.Windows.Forms.Button();
			this.RawProteinButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NaButton
			// 
			this.NaButton.Location = new System.Drawing.Point(12, 12);
			this.NaButton.Name = "NaButton";
			this.NaButton.Size = new System.Drawing.Size(190, 40);
			this.NaButton.TabIndex = 0;
			this.NaButton.Text = "Na";
			this.NaButton.UseVisualStyleBackColor = true;
			this.NaButton.Click += new System.EventHandler(this.NaButton_Click);
			// 
			// RawProteinButton
			// 
			this.RawProteinButton.Location = new System.Drawing.Point(12, 58);
			this.RawProteinButton.Name = "RawProteinButton";
			this.RawProteinButton.Size = new System.Drawing.Size(190, 40);
			this.RawProteinButton.TabIndex = 1;
			this.RawProteinButton.Text = "Сырой протеин";
			this.RawProteinButton.UseVisualStyleBackColor = true;
			this.RawProteinButton.Click += new System.EventHandler(this.RawProteinButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 421);
			this.Controls.Add(this.RawProteinButton);
			this.Controls.Add(this.NaButton);
			this.MinimumSize = new System.Drawing.Size(230, 221);
			this.Name = "MainForm";
			this.Text = "Argentum v0.1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NaButton;
		private System.Windows.Forms.Button RawProteinButton;
	}
}

