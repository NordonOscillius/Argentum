using Argentum.Oscillius.Argentum.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum.Oscillius.Argentum.Forms
{
	public partial class RawProteinForm : Form
	{
		private double _tubeAndSampleMass = double.NaN;
		private double _tubeAndRemainsMass = double.NaN;
		private double _titrantVolume = double.NaN;
		private double _titrantCorrection = double.NaN;
		private double _titrantControlVolume = double.NaN;

		private double _sampleMass = double.NaN;
		private double _nitrogenFraction = double.NaN;
		private double _rawProteinFraction = double.NaN;

		// Кнопки, сохраняющие дефолтные значения для полей.
		private List<Button> _saveDefaultsButtons;
		// Кнопки, удаляющие дефолтные значения для полей.
		private List<Button> _deleteDefaultsButtons;
		// Кнопки, загружающие дефолтные значения для полей.
		private List<Button> _loadDefaultsButtons;


		public RawProteinForm ()
		{
			InitializeComponent ();

			_saveDefaultsButtons = new List<Button> ();
			_saveDefaultsButtons.Add (TitrantControlVolumeSaveBtn);
			_saveDefaultsButtons.Add (TitrantCorrectionSaveBtn);

			_deleteDefaultsButtons = new List<Button> ();
			_deleteDefaultsButtons.Add (TitrantControlVolumeDeleteBtn);
			_deleteDefaultsButtons.Add (TitrantCorrectionDeleteBtn);

			_loadDefaultsButtons = new List<Button> ();
			_loadDefaultsButtons.Add (TitrantControlVolumeResetBtn);
			_loadDefaultsButtons.Add (TitrantCorrectionResetBtn);
		}

		// Обеспечивает правильность ввода числовых значений в текст-боксы.
		private void OnNumericTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			if (!Utils.ProcessNumericInput (sender, e, false))
			{
				e.Handled = true;
			}
		}

		// Обеспечивает правильность ввода числовых значений в текст-боксы.
		private void OnNumericNonNegativeTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			if (!Utils.ProcessNumericInput (sender, e, true))
			{
				e.Handled = true;
			}
		}

		// MAIN INITIALIZATION.
		private void RawProteinForm_Load (object sender, EventArgs e)
		{
			// Устанавливаем в текст-боксы значения по умолчанию (если есть).
			Settings settings = Kernel.Instance.Settings;
			if (settings.RawProtein_TitrantControlVolumeDefined)
			{
				TitrantControlVolumeTextBox.Text = settings.RawProtein_TitrantControlVolume.ToString (Utils.CultureInfoUsed);
			}
			if (settings.RawProtein_TitrantCorrectionDefined)
			{
				TitrantCorrectionTextBox.Text = settings.RawProtein_TitrantCorrection.ToString (Utils.CultureInfoUsed);
			}

			// Включаем или выключаем кнопки "Save Default".
			UpdateSaveDefaultsButtons ();
			// Включаем или выключаем кнопки "Delete Default".
			UpdateDeleteDefaultsButtons ();
			// Включаем или выключаем кнопки "Load Default".
			UpdateLoadDefaultsButtons ();

			// Обновляем значения output-полей.
			OnInputTextChanged ();
		}

		// Включает или выключает кнопки "Save Defaults" в зависимости от состояния галочки.
		private void UpdateSaveDefaultsButtons ()
		{
			bool doEnable = EnableSaveDefaultsCheckBox.Checked;
			for (int i = 0; i < _saveDefaultsButtons.Count; i++)
			{
				_saveDefaultsButtons[i].Enabled = doEnable;
			}
		}

		// Включает или выключает кнопки "Delete Defaults" в зависимости от состояния галочки.
		private void UpdateDeleteDefaultsButtons ()
		{
			bool doEnable = EnableDeleteDefaultsCheckBox.Checked;
			for (int i = 0; i < _deleteDefaultsButtons.Count; i++)
			{
				_deleteDefaultsButtons[i].Enabled = doEnable;
			}
		}

		// Включает или выключает кнопки "Load Defaults" в зависимости от состояния галочки.
		private void UpdateLoadDefaultsButtons ()
		{
			bool doEnable = EnableLoadDefaultsCheckBox.Checked;
			for (int i = 0; i < _loadDefaultsButtons.Count; i++)
			{
				_loadDefaultsButtons[i].Enabled = doEnable;
			}
		}

		// Сохранить значение в настройки: объем титранта в контрольном опыте.
		private void TitrantControlVolumeSaveBtn_Click (object sender, EventArgs e)
		{
			double newValue = Utils.GetNumberFromTextBox (TitrantControlVolumeTextBox);
			if (double.IsNaN (newValue))
				return;

			Kernel.Instance.Settings.RawProtein_TitrantControlVolumeDefined = true;
			Kernel.Instance.Settings.RawProtein_TitrantControlVolume = newValue;
		}

		// Удалить значение по умолчанию из настроек: объем титранта в контрольном опыте.
		private void TitrantControlVolumeDeleteBtn_Click (object sender, EventArgs e)
		{
			Kernel.Instance.Settings.RawProtein_TitrantControlVolumeDefined = false;
		}

		// Сбросить значение: объем титранта в контрольном опыте.
		private void TitrantControlVolumeResetBtn_Click (object sender, EventArgs e)
		{
			// Если значение по умолчанию не используется, выходим.
			if (!Kernel.Instance.Settings.RawProtein_TitrantControlVolumeDefined)
				return;

			TitrantControlVolumeTextBox.Text = Kernel.Instance.Settings.RawProtein_TitrantControlVolume.ToString (Utils.CultureInfoUsed);
		}

		// Для кнопок, получающих или устанавливающих дефолтные значения.
		private void OnDefaulterBtn_MouseEnter (object sender, EventArgs e)
		{
			(sender as Button).ImageIndex = 1;
		}

		// Для кнопок, получающих или устанавливающих дефолтные значения.
		private void OnDefaulterBtn_MouseLeave (object sender, EventArgs e)
		{
			(sender as Button).ImageIndex = 0;
		}

		// Для кнопок, получающих или устанавливающих дефолтные значения.
		private void OnDefaulterBtn_MouseDown (object sender, MouseEventArgs e)
		{
			(sender as Button).ImageIndex = 0;
		}

		// Для кнопок, получающих или устанавливающих дефолтные значения.
		private void OnDefaulterBtn_MouseUp (object sender, MouseEventArgs e)
		{
			if (ClientRectangle.Contains (e.Location))
				(sender as Button).ImageIndex = 1;
		}

		// Для кнопок, получающих или устанавливающих дефолтные значения.
		private void OnDefaulterBtn_EnabledChanged (object sender, EventArgs e)
		{
			if (Enabled)
				//(sender as Button).ImageIndex = ClientRectangle.Contains (PointToClient (Control.MousePosition)) ? 1 : 0;
				(sender as Button).ImageIndex = 0;
			else
				(sender as Button).ImageIndex = 2;
		}

		// Галочка "Разрешить установку дефолтных значений": при изменении Checked.
		private void EnableSaveDefaultsCheckBox_CheckedChanged (object sender, EventArgs e)
		{
			UpdateSaveDefaultsButtons ();
		}

		// Галочка "Разрешить удаление дефолтных значений": при изменении Checked.
		private void EnableDeleteDefaultsCheckBox_CheckedChanged (object sender, EventArgs e)
		{
			UpdateDeleteDefaultsButtons ();
		}

		// Галочка "Разрешить загрузку дефолтных значений": при изменении Checked.
		private void EnableLoadDefaultsCheckBox_CheckedChanged (object sender, EventArgs e)
		{
			UpdateLoadDefaultsButtons ();
		}

		private void TitrantCorrectionSaveBtn_Click (object sender, EventArgs e)
		{
			double newValue = Utils.GetNumberFromTextBox (TitrantCorrectionTextBox);
			if (double.IsNaN (newValue))
				return;

			Kernel.Instance.Settings.RawProtein_TitrantCorrectionDefined = true;
			Kernel.Instance.Settings.RawProtein_TitrantCorrection = newValue;
		}

		private void TitrantCorrectionDeleteBtn_Click (object sender, EventArgs e)
		{
			Kernel.Instance.Settings.RawProtein_TitrantCorrectionDefined = false;
		}

		private void TitrantCorrectionResetBtn_Click (object sender, EventArgs e)
		{
			// Если значение по умолчанию не используется, выходим.
			if (!Kernel.Instance.Settings.RawProtein_TitrantCorrectionDefined)
				return;

			TitrantCorrectionTextBox.Text = Kernel.Instance.Settings.RawProtein_TitrantCorrection.ToString (Utils.CultureInfoUsed);
		}

		private void TubeAndSampleMassTextBox_TextChanged (object sender, EventArgs e)
		{
			_tubeAndSampleMass = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void TubeAndRemainsMassTextBox_TextChanged (object sender, EventArgs e)
		{
			_tubeAndRemainsMass = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void TitrantVolumeTextBox_TextChanged (object sender, EventArgs e)
		{
			_titrantVolume = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void TitrantCorrectionTextBox_TextChanged (object sender, EventArgs e)
		{
			_titrantCorrection = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void TitrantControlVolumeTextBox_TextChanged (object sender, EventArgs e)
		{
			_titrantControlVolume = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void OnInputTextChanged ()
		{
			// Sample Mass.
			if (double.IsNaN (_tubeAndSampleMass) || double.IsNaN (_tubeAndRemainsMass))
			{
				_sampleMass = double.NaN;
				SampleMassTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_sampleMass = _tubeAndSampleMass - _tubeAndRemainsMass;
				SampleMassTextBox.Text = Utils.NumberToStringPrecise (_sampleMass, 4);
			}

			// Nitrogen Fraction.
			if (double.IsNaN (_titrantVolume) || double.IsNaN (_titrantControlVolume) || double.IsNaN (_titrantCorrection) || double.IsNaN (_sampleMass))
			{
				_nitrogenFraction = double.NaN;
				NitrogenFractureTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_nitrogenFraction = (_titrantVolume - _titrantControlVolume) * _titrantCorrection * 0.0014 * 100 / _sampleMass;
				NitrogenFractureTextBox.Text = Utils.NumberToStringPrecise (_nitrogenFraction, 3);
			}

			// Raw Protein Fraction.
			if (double.IsNaN (_nitrogenFraction))
			{
				_rawProteinFraction = double.NaN;
				RawProteinFractureTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_rawProteinFraction = _nitrogenFraction * 6.25;
				RawProteinFractureTextBox.Text = Utils.NumberToStringPrecise (_rawProteinFraction, 3);
			}
		}
	}
}
