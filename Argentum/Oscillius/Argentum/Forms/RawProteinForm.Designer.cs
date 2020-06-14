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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawProteinForm));
			this.InputGroupBox = new System.Windows.Forms.GroupBox();
			this.TitrantCorrectionResetBtn = new System.Windows.Forms.Button();
			this.LoadDefaultsBtnsImageList = new System.Windows.Forms.ImageList(this.components);
			this.TitrantCorrectionDeleteBtn = new System.Windows.Forms.Button();
			this.DeleteDefaultsBtnsImageList = new System.Windows.Forms.ImageList(this.components);
			this.TitrantCorrectionSaveBtn = new System.Windows.Forms.Button();
			this.SaveDefaultsBtnsImageList = new System.Windows.Forms.ImageList(this.components);
			this.TitrantControlVolumeDeleteBtn = new System.Windows.Forms.Button();
			this.TitrantControlVolumeResetBtn = new System.Windows.Forms.Button();
			this.TitrantControlVolumeSaveBtn = new System.Windows.Forms.Button();
			this.TitrantControlVolumeTextBox = new System.Windows.Forms.TextBox();
			this.TitrantControlVolumeLabel = new System.Windows.Forms.Label();
			this.TitrantCorrectionTextBox = new System.Windows.Forms.TextBox();
			this.TitrantCorrectionLabel = new System.Windows.Forms.Label();
			this.TitrantVolumeTextBox = new System.Windows.Forms.TextBox();
			this.TitrantVolumeLabel = new System.Windows.Forms.Label();
			this.TubeAndRemainsMassTextBox = new System.Windows.Forms.TextBox();
			this.TubeAndRemainsMassLabel = new System.Windows.Forms.Label();
			this.TubeAndSampleMassTextBox = new System.Windows.Forms.TextBox();
			this.TubeAndSampleMassLabel = new System.Windows.Forms.Label();
			this.RawProteinToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.EnableSaveDefaultsCheckBox = new System.Windows.Forms.CheckBox();
			this.EnableLoadDefaultsCheckBox = new System.Windows.Forms.CheckBox();
			this.EnableDeleteDefaultsCheckBox = new System.Windows.Forms.CheckBox();
			this.SampleMassTextBox = new System.Windows.Forms.TextBox();
			this.OutputGroupBox = new System.Windows.Forms.GroupBox();
			this.RawProteinFractureTextBox = new System.Windows.Forms.TextBox();
			this.RawProteinFractureLabel = new System.Windows.Forms.Label();
			this.NitrogenFractureTextBox = new System.Windows.Forms.TextBox();
			this.NitrogenFractionLabel = new System.Windows.Forms.Label();
			this.SampleMassLabel = new System.Windows.Forms.Label();
			this.InputGroupBox.SuspendLayout();
			this.OutputGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputGroupBox
			// 
			this.InputGroupBox.Controls.Add(this.TitrantCorrectionResetBtn);
			this.InputGroupBox.Controls.Add(this.TitrantCorrectionDeleteBtn);
			this.InputGroupBox.Controls.Add(this.TitrantCorrectionSaveBtn);
			this.InputGroupBox.Controls.Add(this.TitrantControlVolumeDeleteBtn);
			this.InputGroupBox.Controls.Add(this.TitrantControlVolumeResetBtn);
			this.InputGroupBox.Controls.Add(this.TitrantControlVolumeSaveBtn);
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
			this.InputGroupBox.Size = new System.Drawing.Size(194, 264);
			this.InputGroupBox.TabIndex = 2;
			this.InputGroupBox.TabStop = false;
			this.InputGroupBox.Text = "Входные параметры";
			// 
			// TitrantCorrectionResetBtn
			// 
			this.TitrantCorrectionResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TitrantCorrectionResetBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitrantCorrectionResetBtn.ImageIndex = 0;
			this.TitrantCorrectionResetBtn.ImageList = this.LoadDefaultsBtnsImageList;
			this.TitrantCorrectionResetBtn.Location = new System.Drawing.Point(165, 178);
			this.TitrantCorrectionResetBtn.Name = "TitrantCorrectionResetBtn";
			this.TitrantCorrectionResetBtn.Size = new System.Drawing.Size(23, 23);
			this.TitrantCorrectionResetBtn.TabIndex = 15;
			this.TitrantCorrectionResetBtn.TabStop = false;
			this.RawProteinToolTip.SetToolTip(this.TitrantCorrectionResetBtn, "Сбросить в значение по умолчанию.");
			this.TitrantCorrectionResetBtn.UseVisualStyleBackColor = true;
			this.TitrantCorrectionResetBtn.Click += new System.EventHandler(this.TitrantCorrectionResetBtn_Click);
			this.TitrantCorrectionResetBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseDown);
			this.TitrantCorrectionResetBtn.MouseEnter += new System.EventHandler(this.OnDefaulterBtn_MouseEnter);
			this.TitrantCorrectionResetBtn.MouseLeave += new System.EventHandler(this.OnDefaulterBtn_MouseLeave);
			this.TitrantCorrectionResetBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseUp);
			// 
			// LoadDefaultsBtnsImageList
			// 
			this.LoadDefaultsBtnsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LoadDefaultsBtnsImageList.ImageStream")));
			this.LoadDefaultsBtnsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.LoadDefaultsBtnsImageList.Images.SetKeyName(0, "Reset-20x20-Normal.png");
			this.LoadDefaultsBtnsImageList.Images.SetKeyName(1, "Reset-20x20-Over.png");
			this.LoadDefaultsBtnsImageList.Images.SetKeyName(2, "Reset-20x20-Disabled.png");
			// 
			// TitrantCorrectionDeleteBtn
			// 
			this.TitrantCorrectionDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TitrantCorrectionDeleteBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitrantCorrectionDeleteBtn.ImageIndex = 0;
			this.TitrantCorrectionDeleteBtn.ImageList = this.DeleteDefaultsBtnsImageList;
			this.TitrantCorrectionDeleteBtn.Location = new System.Drawing.Point(142, 178);
			this.TitrantCorrectionDeleteBtn.Name = "TitrantCorrectionDeleteBtn";
			this.TitrantCorrectionDeleteBtn.Size = new System.Drawing.Size(23, 23);
			this.TitrantCorrectionDeleteBtn.TabIndex = 14;
			this.TitrantCorrectionDeleteBtn.TabStop = false;
			this.RawProteinToolTip.SetToolTip(this.TitrantCorrectionDeleteBtn, "Удалить значение по умолчанию.");
			this.TitrantCorrectionDeleteBtn.UseVisualStyleBackColor = true;
			this.TitrantCorrectionDeleteBtn.Click += new System.EventHandler(this.TitrantCorrectionDeleteBtn_Click);
			this.TitrantCorrectionDeleteBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseDown);
			this.TitrantCorrectionDeleteBtn.MouseEnter += new System.EventHandler(this.OnDefaulterBtn_MouseEnter);
			this.TitrantCorrectionDeleteBtn.MouseLeave += new System.EventHandler(this.OnDefaulterBtn_MouseLeave);
			this.TitrantCorrectionDeleteBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseUp);
			// 
			// DeleteDefaultsBtnsImageList
			// 
			this.DeleteDefaultsBtnsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DeleteDefaultsBtnsImageList.ImageStream")));
			this.DeleteDefaultsBtnsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.DeleteDefaultsBtnsImageList.Images.SetKeyName(0, "Cross-20x20-Normal.png");
			this.DeleteDefaultsBtnsImageList.Images.SetKeyName(1, "Cross-20x20-Over.png");
			this.DeleteDefaultsBtnsImageList.Images.SetKeyName(2, "Cross-20x20-Disabled.png");
			// 
			// TitrantCorrectionSaveBtn
			// 
			this.TitrantCorrectionSaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TitrantCorrectionSaveBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionSaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.TitrantCorrectionSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitrantCorrectionSaveBtn.ImageIndex = 0;
			this.TitrantCorrectionSaveBtn.ImageList = this.SaveDefaultsBtnsImageList;
			this.TitrantCorrectionSaveBtn.Location = new System.Drawing.Point(117, 178);
			this.TitrantCorrectionSaveBtn.Name = "TitrantCorrectionSaveBtn";
			this.TitrantCorrectionSaveBtn.Size = new System.Drawing.Size(23, 23);
			this.TitrantCorrectionSaveBtn.TabIndex = 13;
			this.TitrantCorrectionSaveBtn.TabStop = false;
			this.RawProteinToolTip.SetToolTip(this.TitrantCorrectionSaveBtn, "Запомнить как значение по умолчанию.");
			this.TitrantCorrectionSaveBtn.UseVisualStyleBackColor = true;
			this.TitrantCorrectionSaveBtn.Click += new System.EventHandler(this.TitrantCorrectionSaveBtn_Click);
			this.TitrantCorrectionSaveBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseDown);
			this.TitrantCorrectionSaveBtn.MouseEnter += new System.EventHandler(this.OnDefaulterBtn_MouseEnter);
			this.TitrantCorrectionSaveBtn.MouseLeave += new System.EventHandler(this.OnDefaulterBtn_MouseLeave);
			this.TitrantCorrectionSaveBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseUp);
			// 
			// SaveDefaultsBtnsImageList
			// 
			this.SaveDefaultsBtnsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SaveDefaultsBtnsImageList.ImageStream")));
			this.SaveDefaultsBtnsImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.SaveDefaultsBtnsImageList.Images.SetKeyName(0, "Diskette-20x20-Normal.png");
			this.SaveDefaultsBtnsImageList.Images.SetKeyName(1, "Diskette-20x20-Over.png");
			this.SaveDefaultsBtnsImageList.Images.SetKeyName(2, "Diskette-20x20-Disabled.png");
			// 
			// TitrantControlVolumeDeleteBtn
			// 
			this.TitrantControlVolumeDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TitrantControlVolumeDeleteBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitrantControlVolumeDeleteBtn.ImageIndex = 0;
			this.TitrantControlVolumeDeleteBtn.ImageList = this.DeleteDefaultsBtnsImageList;
			this.TitrantControlVolumeDeleteBtn.Location = new System.Drawing.Point(142, 230);
			this.TitrantControlVolumeDeleteBtn.Name = "TitrantControlVolumeDeleteBtn";
			this.TitrantControlVolumeDeleteBtn.Size = new System.Drawing.Size(23, 23);
			this.TitrantControlVolumeDeleteBtn.TabIndex = 12;
			this.TitrantControlVolumeDeleteBtn.TabStop = false;
			this.RawProteinToolTip.SetToolTip(this.TitrantControlVolumeDeleteBtn, "Удалить значение по умолчанию.");
			this.TitrantControlVolumeDeleteBtn.UseVisualStyleBackColor = true;
			this.TitrantControlVolumeDeleteBtn.Click += new System.EventHandler(this.TitrantControlVolumeDeleteBtn_Click);
			this.TitrantControlVolumeDeleteBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseDown);
			this.TitrantControlVolumeDeleteBtn.MouseEnter += new System.EventHandler(this.OnDefaulterBtn_MouseEnter);
			this.TitrantControlVolumeDeleteBtn.MouseLeave += new System.EventHandler(this.OnDefaulterBtn_MouseLeave);
			this.TitrantControlVolumeDeleteBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseUp);
			// 
			// TitrantControlVolumeResetBtn
			// 
			this.TitrantControlVolumeResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TitrantControlVolumeResetBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitrantControlVolumeResetBtn.ImageIndex = 0;
			this.TitrantControlVolumeResetBtn.ImageList = this.LoadDefaultsBtnsImageList;
			this.TitrantControlVolumeResetBtn.Location = new System.Drawing.Point(165, 230);
			this.TitrantControlVolumeResetBtn.Name = "TitrantControlVolumeResetBtn";
			this.TitrantControlVolumeResetBtn.Size = new System.Drawing.Size(23, 23);
			this.TitrantControlVolumeResetBtn.TabIndex = 11;
			this.TitrantControlVolumeResetBtn.TabStop = false;
			this.RawProteinToolTip.SetToolTip(this.TitrantControlVolumeResetBtn, "Сбросить в значение по умолчанию.");
			this.TitrantControlVolumeResetBtn.UseVisualStyleBackColor = true;
			this.TitrantControlVolumeResetBtn.EnabledChanged += new System.EventHandler(this.OnDefaulterBtn_EnabledChanged);
			this.TitrantControlVolumeResetBtn.Click += new System.EventHandler(this.TitrantControlVolumeResetBtn_Click);
			this.TitrantControlVolumeResetBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseDown);
			this.TitrantControlVolumeResetBtn.MouseEnter += new System.EventHandler(this.OnDefaulterBtn_MouseEnter);
			this.TitrantControlVolumeResetBtn.MouseLeave += new System.EventHandler(this.OnDefaulterBtn_MouseLeave);
			this.TitrantControlVolumeResetBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseUp);
			// 
			// TitrantControlVolumeSaveBtn
			// 
			this.TitrantControlVolumeSaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.TitrantControlVolumeSaveBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeSaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.TitrantControlVolumeSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitrantControlVolumeSaveBtn.ImageIndex = 0;
			this.TitrantControlVolumeSaveBtn.ImageList = this.SaveDefaultsBtnsImageList;
			this.TitrantControlVolumeSaveBtn.Location = new System.Drawing.Point(117, 230);
			this.TitrantControlVolumeSaveBtn.Name = "TitrantControlVolumeSaveBtn";
			this.TitrantControlVolumeSaveBtn.Size = new System.Drawing.Size(23, 23);
			this.TitrantControlVolumeSaveBtn.TabIndex = 3;
			this.TitrantControlVolumeSaveBtn.TabStop = false;
			this.RawProteinToolTip.SetToolTip(this.TitrantControlVolumeSaveBtn, "Запомнить как значение по умолчанию.");
			this.TitrantControlVolumeSaveBtn.UseVisualStyleBackColor = true;
			this.TitrantControlVolumeSaveBtn.EnabledChanged += new System.EventHandler(this.OnDefaulterBtn_EnabledChanged);
			this.TitrantControlVolumeSaveBtn.Click += new System.EventHandler(this.TitrantControlVolumeSaveBtn_Click);
			this.TitrantControlVolumeSaveBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseDown);
			this.TitrantControlVolumeSaveBtn.MouseEnter += new System.EventHandler(this.OnDefaulterBtn_MouseEnter);
			this.TitrantControlVolumeSaveBtn.MouseLeave += new System.EventHandler(this.OnDefaulterBtn_MouseLeave);
			this.TitrantControlVolumeSaveBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDefaulterBtn_MouseUp);
			// 
			// TitrantControlVolumeTextBox
			// 
			this.TitrantControlVolumeTextBox.Location = new System.Drawing.Point(6, 233);
			this.TitrantControlVolumeTextBox.Name = "TitrantControlVolumeTextBox";
			this.TitrantControlVolumeTextBox.Size = new System.Drawing.Size(105, 20);
			this.TitrantControlVolumeTextBox.TabIndex = 10;
			this.RawProteinToolTip.SetToolTip(this.TitrantControlVolumeTextBox, "(Vк) Объем раствора серной кислоты, пошедший\r\nна титрование в контрольном опыте.");
			this.TitrantControlVolumeTextBox.TextChanged += new System.EventHandler(this.TitrantControlVolumeTextBox_TextChanged);
			this.TitrantControlVolumeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericNonNegativeTextBox_KeyPress);
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
			// TitrantCorrectionTextBox
			// 
			this.TitrantCorrectionTextBox.Location = new System.Drawing.Point(6, 181);
			this.TitrantCorrectionTextBox.Name = "TitrantCorrectionTextBox";
			this.TitrantCorrectionTextBox.Size = new System.Drawing.Size(105, 20);
			this.TitrantCorrectionTextBox.TabIndex = 8;
			this.RawProteinToolTip.SetToolTip(this.TitrantCorrectionTextBox, "(K) Поправочный коэффициент для раствора серной кислоты,\r\nс помощью которого прои" +
        "зводилось титрование.");
			this.TitrantCorrectionTextBox.TextChanged += new System.EventHandler(this.TitrantCorrectionTextBox_TextChanged);
			this.TitrantCorrectionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericNonNegativeTextBox_KeyPress);
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
			// TitrantVolumeTextBox
			// 
			this.TitrantVolumeTextBox.Location = new System.Drawing.Point(6, 142);
			this.TitrantVolumeTextBox.Name = "TitrantVolumeTextBox";
			this.TitrantVolumeTextBox.Size = new System.Drawing.Size(182, 20);
			this.TitrantVolumeTextBox.TabIndex = 6;
			this.RawProteinToolTip.SetToolTip(this.TitrantVolumeTextBox, "(Vт) Объем раствора серной кислоты,\r\nпошедший на титрование.");
			this.TitrantVolumeTextBox.TextChanged += new System.EventHandler(this.TitrantVolumeTextBox_TextChanged);
			this.TitrantVolumeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericNonNegativeTextBox_KeyPress);
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
			// TubeAndRemainsMassTextBox
			// 
			this.TubeAndRemainsMassTextBox.Location = new System.Drawing.Point(6, 103);
			this.TubeAndRemainsMassTextBox.Name = "TubeAndRemainsMassTextBox";
			this.TubeAndRemainsMassTextBox.Size = new System.Drawing.Size(182, 20);
			this.TubeAndRemainsMassTextBox.TabIndex = 4;
			this.RawProteinToolTip.SetToolTip(this.TubeAndRemainsMassTextBox, "(m2) После погружения в колбу Кьельдаля.");
			this.TubeAndRemainsMassTextBox.TextChanged += new System.EventHandler(this.TubeAndRemainsMassTextBox_TextChanged);
			this.TubeAndRemainsMassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericNonNegativeTextBox_KeyPress);
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
			// TubeAndSampleMassTextBox
			// 
			this.TubeAndSampleMassTextBox.Location = new System.Drawing.Point(6, 51);
			this.TubeAndSampleMassTextBox.Name = "TubeAndSampleMassTextBox";
			this.TubeAndSampleMassTextBox.Size = new System.Drawing.Size(182, 20);
			this.TubeAndSampleMassTextBox.TabIndex = 2;
			this.RawProteinToolTip.SetToolTip(this.TubeAndSampleMassTextBox, "(m1) До погружения в колбу Кьельдаля.");
			this.TubeAndSampleMassTextBox.TextChanged += new System.EventHandler(this.TubeAndSampleMassTextBox_TextChanged);
			this.TubeAndSampleMassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnNumericNonNegativeTextBox_KeyPress);
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
			// RawProteinToolTip
			// 
			this.RawProteinToolTip.AutomaticDelay = 5;
			this.RawProteinToolTip.AutoPopDelay = 30000;
			this.RawProteinToolTip.InitialDelay = 5;
			this.RawProteinToolTip.ReshowDelay = 5;
			this.RawProteinToolTip.UseFading = false;
			// 
			// EnableSaveDefaultsCheckBox
			// 
			this.EnableSaveDefaultsCheckBox.AutoSize = true;
			this.EnableSaveDefaultsCheckBox.Location = new System.Drawing.Point(12, 293);
			this.EnableSaveDefaultsCheckBox.Name = "EnableSaveDefaultsCheckBox";
			this.EnableSaveDefaultsCheckBox.Size = new System.Drawing.Size(253, 17);
			this.EnableSaveDefaultsCheckBox.TabIndex = 3;
			this.EnableSaveDefaultsCheckBox.TabStop = false;
			this.EnableSaveDefaultsCheckBox.Text = "Разрешить сохранение дефолтных значений";
			this.RawProteinToolTip.SetToolTip(this.EnableSaveDefaultsCheckBox, "При включении появляется возможность сохранять\r\nзначения по умолчанию для некотор" +
        "ых полей.");
			this.EnableSaveDefaultsCheckBox.UseVisualStyleBackColor = true;
			this.EnableSaveDefaultsCheckBox.CheckedChanged += new System.EventHandler(this.EnableSaveDefaultsCheckBox_CheckedChanged);
			// 
			// EnableLoadDefaultsCheckBox
			// 
			this.EnableLoadDefaultsCheckBox.AutoSize = true;
			this.EnableLoadDefaultsCheckBox.Checked = true;
			this.EnableLoadDefaultsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.EnableLoadDefaultsCheckBox.Location = new System.Drawing.Point(12, 331);
			this.EnableLoadDefaultsCheckBox.Name = "EnableLoadDefaultsCheckBox";
			this.EnableLoadDefaultsCheckBox.Size = new System.Drawing.Size(267, 17);
			this.EnableLoadDefaultsCheckBox.TabIndex = 4;
			this.EnableLoadDefaultsCheckBox.TabStop = false;
			this.EnableLoadDefaultsCheckBox.Text = "Разрешить сброс полей в дефолтные значения";
			this.RawProteinToolTip.SetToolTip(this.EnableLoadDefaultsCheckBox, "При включении появляется возможность сбрасывать\r\nполя в значения по умолчанию.");
			this.EnableLoadDefaultsCheckBox.UseVisualStyleBackColor = true;
			this.EnableLoadDefaultsCheckBox.CheckedChanged += new System.EventHandler(this.EnableLoadDefaultsCheckBox_CheckedChanged);
			// 
			// EnableDeleteDefaultsCheckBox
			// 
			this.EnableDeleteDefaultsCheckBox.AutoSize = true;
			this.EnableDeleteDefaultsCheckBox.Location = new System.Drawing.Point(12, 312);
			this.EnableDeleteDefaultsCheckBox.Name = "EnableDeleteDefaultsCheckBox";
			this.EnableDeleteDefaultsCheckBox.Size = new System.Drawing.Size(241, 17);
			this.EnableDeleteDefaultsCheckBox.TabIndex = 5;
			this.EnableDeleteDefaultsCheckBox.TabStop = false;
			this.EnableDeleteDefaultsCheckBox.Text = "Разрешить удаление дефолтных значений";
			this.RawProteinToolTip.SetToolTip(this.EnableDeleteDefaultsCheckBox, "При включении появляется возможность удалять\r\nзначения по умолчанию для некоторых" +
        " полей.");
			this.EnableDeleteDefaultsCheckBox.UseVisualStyleBackColor = true;
			this.EnableDeleteDefaultsCheckBox.CheckedChanged += new System.EventHandler(this.EnableDeleteDefaultsCheckBox_CheckedChanged);
			// 
			// SampleMassTextBox
			// 
			this.SampleMassTextBox.Location = new System.Drawing.Point(9, 38);
			this.SampleMassTextBox.Name = "SampleMassTextBox";
			this.SampleMassTextBox.ReadOnly = true;
			this.SampleMassTextBox.Size = new System.Drawing.Size(171, 20);
			this.SampleMassTextBox.TabIndex = 3;
			this.RawProteinToolTip.SetToolTip(this.SampleMassTextBox, "(m1 - m2) Разность между грубой навеской пробы\r\nи ее остатком в малой пробирке.");
			// 
			// OutputGroupBox
			// 
			this.OutputGroupBox.Controls.Add(this.RawProteinFractureTextBox);
			this.OutputGroupBox.Controls.Add(this.RawProteinFractureLabel);
			this.OutputGroupBox.Controls.Add(this.NitrogenFractureTextBox);
			this.OutputGroupBox.Controls.Add(this.NitrogenFractionLabel);
			this.OutputGroupBox.Controls.Add(this.SampleMassTextBox);
			this.OutputGroupBox.Controls.Add(this.SampleMassLabel);
			this.OutputGroupBox.Location = new System.Drawing.Point(212, 77);
			this.OutputGroupBox.Name = "OutputGroupBox";
			this.OutputGroupBox.Size = new System.Drawing.Size(191, 154);
			this.OutputGroupBox.TabIndex = 6;
			this.OutputGroupBox.TabStop = false;
			this.OutputGroupBox.Text = "Рассчитанные значения";
			// 
			// RawProteinFractureTextBox
			// 
			this.RawProteinFractureTextBox.Location = new System.Drawing.Point(9, 116);
			this.RawProteinFractureTextBox.Name = "RawProteinFractureTextBox";
			this.RawProteinFractureTextBox.ReadOnly = true;
			this.RawProteinFractureTextBox.Size = new System.Drawing.Size(171, 20);
			this.RawProteinFractureTextBox.TabIndex = 7;
			// 
			// RawProteinFractureLabel
			// 
			this.RawProteinFractureLabel.AutoSize = true;
			this.RawProteinFractureLabel.Location = new System.Drawing.Point(6, 100);
			this.RawProteinFractureLabel.Name = "RawProteinFractureLabel";
			this.RawProteinFractureLabel.Size = new System.Drawing.Size(174, 13);
			this.RawProteinFractureLabel.TabIndex = 6;
			this.RawProteinFractureLabel.Text = "Содержание сырого протеина, %";
			// 
			// NitrogenFractureTextBox
			// 
			this.NitrogenFractureTextBox.Location = new System.Drawing.Point(9, 77);
			this.NitrogenFractureTextBox.Name = "NitrogenFractureTextBox";
			this.NitrogenFractureTextBox.ReadOnly = true;
			this.NitrogenFractureTextBox.Size = new System.Drawing.Size(171, 20);
			this.NitrogenFractureTextBox.TabIndex = 5;
			// 
			// NitrogenFractionLabel
			// 
			this.NitrogenFractionLabel.AutoSize = true;
			this.NitrogenFractionLabel.Location = new System.Drawing.Point(6, 61);
			this.NitrogenFractionLabel.Name = "NitrogenFractionLabel";
			this.NitrogenFractionLabel.Size = new System.Drawing.Size(116, 13);
			this.NitrogenFractionLabel.TabIndex = 4;
			this.NitrogenFractionLabel.Text = "Содержание азота, %";
			// 
			// SampleMassLabel
			// 
			this.SampleMassLabel.AutoSize = true;
			this.SampleMassLabel.Location = new System.Drawing.Point(6, 22);
			this.SampleMassLabel.Name = "SampleMassLabel";
			this.SampleMassLabel.Size = new System.Drawing.Size(134, 13);
			this.SampleMassLabel.TabIndex = 2;
			this.SampleMassLabel.Text = "Точная масса навески, г";
			// 
			// RawProteinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 364);
			this.Controls.Add(this.OutputGroupBox);
			this.Controls.Add(this.EnableDeleteDefaultsCheckBox);
			this.Controls.Add(this.EnableLoadDefaultsCheckBox);
			this.Controls.Add(this.EnableSaveDefaultsCheckBox);
			this.Controls.Add(this.InputGroupBox);
			this.Name = "RawProteinForm";
			this.Text = "Сырой протеин";
			this.Load += new System.EventHandler(this.RawProteinForm_Load);
			this.InputGroupBox.ResumeLayout(false);
			this.InputGroupBox.PerformLayout();
			this.OutputGroupBox.ResumeLayout(false);
			this.OutputGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Button TitrantControlVolumeSaveBtn;
		private System.Windows.Forms.Button TitrantControlVolumeResetBtn;
		private System.Windows.Forms.ImageList SaveDefaultsBtnsImageList;
		private System.Windows.Forms.ImageList LoadDefaultsBtnsImageList;
		private System.Windows.Forms.CheckBox EnableSaveDefaultsCheckBox;
		private System.Windows.Forms.CheckBox EnableLoadDefaultsCheckBox;
		private System.Windows.Forms.ImageList DeleteDefaultsBtnsImageList;
		private System.Windows.Forms.Button TitrantControlVolumeDeleteBtn;
		private System.Windows.Forms.CheckBox EnableDeleteDefaultsCheckBox;
		private System.Windows.Forms.Button TitrantCorrectionSaveBtn;
		private System.Windows.Forms.Button TitrantCorrectionDeleteBtn;
		private System.Windows.Forms.Button TitrantCorrectionResetBtn;
		private System.Windows.Forms.GroupBox OutputGroupBox;
		private System.Windows.Forms.TextBox SampleMassTextBox;
		private System.Windows.Forms.Label SampleMassLabel;
		private System.Windows.Forms.Label NitrogenFractionLabel;
		private System.Windows.Forms.TextBox RawProteinFractureTextBox;
		private System.Windows.Forms.Label RawProteinFractureLabel;
		private System.Windows.Forms.TextBox NitrogenFractureTextBox;
	}
}