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
			this.SuspendLayout();
			// 
			// NaButton
			// 
			this.NaButton.Location = new System.Drawing.Point(12, 12);
			this.NaButton.Name = "NaButton";
			this.NaButton.Size = new System.Drawing.Size(173, 40);
			this.NaButton.TabIndex = 0;
			this.NaButton.Text = "Na";
			this.NaButton.UseVisualStyleBackColor = true;
			this.NaButton.Click += new System.EventHandler(this.NaButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 421);
			this.Controls.Add(this.NaButton);
			this.Name = "MainForm";
			this.Text = "Argentum";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button NaButton;
	}
}

