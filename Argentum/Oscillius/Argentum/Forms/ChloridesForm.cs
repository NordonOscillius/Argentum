using Argentum.Oscillius.Argentum.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum.Oscillius.Argentum.Forms
{
	public partial class ChloridesForm : Form
	{
		private Settings _settings;

		private double _sampleMass = double.NaN;
		private double _titrantVolume = double.NaN;
		private double _agNO3Conc = double.NaN;
		private double _nh4SCNConc = double.NaN;
		private double _aliquotVolume = double.NaN;
		private double _commonVolume = double.NaN;
		private double _agNO3Volume = double.NaN;
		private double _agNO3VolumeControl = double.NaN;
		private double _titrantVolumeControl = double.NaN;

		private double _sodiumChlorideFraction = double.NaN;
		private double _chloridesFraction = double.NaN;

		// Кнопки, сохраняющие дефолтные значения для полей.
		private List<Button> _saveDefaultsButtons;
		// Кнопки, удаляющие дефолтные значения для полей.
		private List<Button> _deleteDefaultsButtons;
		// Кнопки, загружающие дефолтные значения для полей.
		private List<Button> _loadDefaultsButtons;


		public ChloridesForm ()
		{
			InitializeComponent ();

			_saveDefaultsButtons = new List<Button> ();
			_saveDefaultsButtons.Add (AgNO3ConcSaveBtn);
			_saveDefaultsButtons.Add (NH4SCNConcSaveBtn);
			_saveDefaultsButtons.Add (AliquotVolumeSaveBtn);
			_saveDefaultsButtons.Add (CommonVolumeSaveBtn);
			_saveDefaultsButtons.Add (AgNO3VolumeSaveBtn);
			_saveDefaultsButtons.Add (AgNO3VolumeControlSaveBtn);
			_saveDefaultsButtons.Add (TitrantVolumeControlSaveBtn);

			_deleteDefaultsButtons = new List<Button> ();
			_deleteDefaultsButtons.Add (AgNO3ConcDeleteBtn);
			_deleteDefaultsButtons.Add (NH4SCNConcDeleteBtn);
			_deleteDefaultsButtons.Add (AliquotVolumeDeleteBtn);
			_deleteDefaultsButtons.Add (CommonVolumeDeleteBtn);
			_deleteDefaultsButtons.Add (AgNO3VolumeDeleteBtn);
			_deleteDefaultsButtons.Add (AgNO3VolumeControlDeleteBtn);
			_deleteDefaultsButtons.Add (TitrantVolumeControlDeleteBtn);

			_loadDefaultsButtons = new List<Button> ();
			_loadDefaultsButtons.Add (AgNO3ConcLoadBtn);
			_loadDefaultsButtons.Add (NH4SCNConcLoadBtn);
			_loadDefaultsButtons.Add (AliquotVolumeLoadBtn);
			_loadDefaultsButtons.Add (CommonVolumeLoadBtn);
			_loadDefaultsButtons.Add (AgNO3VolumeLoadBtn);
			_loadDefaultsButtons.Add (AgNO3VolumeControlLoadBtn);
			_loadDefaultsButtons.Add (TitrantVolumeControlLoadBtn);
		}

		#region Main Init

		private void ChloridesForm_Load (object sender, EventArgs e)
		{
			_settings = Kernel.Instance.Settings;

			// Устанавливаем в текст-боксы значения по умолчанию.
			if (_settings.Chlorides_AgNO3ConcDefined)
				AgNO3ConcTextBox.Text = _settings.Chlorides_AgNO3Conc.ToString (Utils.CultureInfoUsed);
			if (_settings.Chlorides_AgNO3VolumeDefined)
				AgNO3VolumeTextBox.Text = _settings.Chlorides_AgNO3Volume.ToString (Utils.CultureInfoUsed);
			if (_settings.Chlorides_AgNO3VolumeControlDefined)
				AgNO3VolumeControlTextBox.Text = _settings.Chlorides_AgNO3VolumeControl.ToString (Utils.CultureInfoUsed);
			if (_settings.Chlorides_AliquotVolumeDefined)
				AliquotVolumeTextBox.Text = _settings.Chlorides_AliquotVolume.ToString (Utils.CultureInfoUsed);
			if (_settings.Chlorides_CommonVolumeDefined)
				CommonVolumeTextBox.Text = _settings.Chlorides_CommonVolume.ToString (Utils.CultureInfoUsed);
			if (_settings.Chlorides_NH4SCNConcDefined)
				NH4SCNConcTextBox.Text = _settings.Chlorides_NH4SCNConc.ToString (Utils.CultureInfoUsed);
			if (_settings.Chlorides_TitrantVolumeControlDefined)
				TitrantVolumeControlTextBox.Text = _settings.Chlorides_TitrantVolumeControl.ToString (Utils.CultureInfoUsed);

			// Включаем или выключаем кнопки "Save Default", "Delete Default", "Load Default".
			UpdateSaveDefaultsButtons ();
			UpdateDeleteDefaultsButtons ();
			UpdateLoadDefaultsButtons ();

			OnInputTextChanged ();
		}

		#endregion

		#region Numeric Input (Text Boxes)

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

		#endregion

		#region Defaulters (Save, Delete, Load) - Common

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

		#endregion

		#region Defaulters (Save, Delete, Load) - Switching Globally

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

		#endregion

		private void EnableSaveDefaultsCheckBox_CheckedChanged (object sender, EventArgs e)
		{
			UpdateSaveDefaultsButtons ();
		}

		private void EnableDeleteDefaultsCheckBox_CheckedChanged (object sender, EventArgs e)
		{
			UpdateDeleteDefaultsButtons ();
		}

		private void EnableLoadDefaultsCheckBox_CheckedChanged (object sender, EventArgs e)
		{
			UpdateLoadDefaultsButtons ();
		}

		private void OnSaveDefaultsBtn_Click (object sender, EventArgs e)
		{
			Button button = sender as Button;

			TextBox textBox;
			Action<bool> setPropertyDefined;
			Action<double> setProperty;

			if (button == AgNO3ConcSaveBtn)
			{
				textBox = AgNO3ConcTextBox;
				setProperty =
					value => _settings.Chlorides_AgNO3Conc = value;
				setPropertyDefined =
					value => _settings.Chlorides_AgNO3ConcDefined = value;
			}
			else if (button == NH4SCNConcSaveBtn)
			{
				textBox = NH4SCNConcTextBox;
				setProperty =
					value => _settings.Chlorides_NH4SCNConc = value;
				setPropertyDefined =
					value => _settings.Chlorides_NH4SCNConcDefined = value;
			}
			else if (button == AliquotVolumeSaveBtn)
			{
				textBox = AliquotVolumeTextBox;
				setProperty =
					value => _settings.Chlorides_AliquotVolume = value;
				setPropertyDefined =
					value => _settings.Chlorides_AliquotVolumeDefined = value;
			}
			else if (button == CommonVolumeSaveBtn)
			{
				textBox = CommonVolumeTextBox;
				setProperty =
					value => _settings.Chlorides_CommonVolume = value;
				setPropertyDefined =
					value => _settings.Chlorides_CommonVolumeDefined = value;
			}
			else if (button == AgNO3VolumeSaveBtn)
			{
				textBox = AgNO3VolumeTextBox;
				setProperty =
					value => _settings.Chlorides_AgNO3Volume = value;
				setPropertyDefined =
					value => _settings.Chlorides_AgNO3VolumeDefined = value;
			}
			else if (button == AgNO3VolumeControlSaveBtn)
			{
				textBox = AgNO3VolumeControlTextBox;
				setProperty =
					value => _settings.Chlorides_AgNO3VolumeControl = value;
				setPropertyDefined =
					value => _settings.Chlorides_AgNO3VolumeControlDefined = value;
			}
			else if (button == TitrantVolumeControlSaveBtn)
			{
				textBox = TitrantVolumeControlTextBox;
				setProperty =
					value => _settings.Chlorides_TitrantVolumeControl = value;
				setPropertyDefined =
					value => _settings.Chlorides_TitrantVolumeControlDefined = value;
			}
			else
			{
				throw new Exception ("Unknown 'Save Default' button clicked.");
			}

			double newValue = Utils.GetNumberFromTextBox (textBox);
			if (double.IsNaN (newValue))
				return;

			setPropertyDefined (true);
			setProperty (newValue);
		}

		private void OnDeleteDefaultsBtn_Click (object sender, EventArgs e)
		{
			Button button = sender as Button;

			if (button == AgNO3ConcDeleteBtn)
				_settings.Chlorides_AgNO3ConcDefined = false;
			else if (button == NH4SCNConcDeleteBtn)
				_settings.Chlorides_NH4SCNConcDefined = false;
			else if (button == AliquotVolumeDeleteBtn)
				_settings.Chlorides_AliquotVolumeDefined = false;
			else if (button == CommonVolumeDeleteBtn)
				_settings.Chlorides_CommonVolumeDefined = false;
			else if (button == AgNO3VolumeDeleteBtn)
				_settings.Chlorides_AgNO3VolumeDefined = false;
			else if (button == AgNO3VolumeControlDeleteBtn)
				_settings.Chlorides_AgNO3VolumeControlDefined = false;
			else if (button == TitrantVolumeControlDeleteBtn)
				_settings.Chlorides_TitrantVolumeControlDefined = false;
			else
				throw new Exception ("Unknown 'Delete Default' button clicked.");
		}

		private void OnLoadDefaultsBtn_Click (object sender, EventArgs e)
		{
			Button button = sender as Button;

			double property;
			bool propertyDefined;
			TextBox textBox;

			if (button == AgNO3ConcLoadBtn)
			{
				property = _settings.Chlorides_AgNO3Conc;
				propertyDefined = _settings.Chlorides_AgNO3ConcDefined;
				textBox = AgNO3ConcTextBox;
			}
			else if (button == NH4SCNConcLoadBtn)
			{
				property = _settings.Chlorides_NH4SCNConc;
				propertyDefined = _settings.Chlorides_NH4SCNConcDefined;
				textBox = NH4SCNConcTextBox;
			}
			else if (button == AliquotVolumeLoadBtn)
			{
				property = _settings.Chlorides_AliquotVolume;
				propertyDefined = _settings.Chlorides_AliquotVolumeDefined;
				textBox = AliquotVolumeTextBox;
			}
			else if (button == CommonVolumeLoadBtn)
			{
				property = _settings.Chlorides_CommonVolume;
				propertyDefined = _settings.Chlorides_CommonVolumeDefined;
				textBox = CommonVolumeTextBox;
			}
			else if (button == AgNO3VolumeLoadBtn)
			{
				property = _settings.Chlorides_AgNO3Volume;
				propertyDefined = _settings.Chlorides_AgNO3VolumeDefined;
				textBox = AgNO3VolumeTextBox;
			}
			else if (button == AgNO3VolumeControlLoadBtn)
			{
				property = _settings.Chlorides_AgNO3VolumeControl;
				propertyDefined = _settings.Chlorides_AgNO3VolumeControlDefined;
				textBox = AgNO3VolumeControlTextBox;
			}
			else if (button == TitrantVolumeControlLoadBtn)
			{
				property = _settings.Chlorides_TitrantVolumeControl;
				propertyDefined = _settings.Chlorides_TitrantVolumeControlDefined;
				textBox = TitrantVolumeControlTextBox;
			}
			else
			{
				throw new Exception ("Unknown 'Load Default' button clicked.");
			}

			if (propertyDefined)
			{
				textBox.Text = property.ToString (Utils.CultureInfoUsed);
			}
		}

		private void OnInputTextBox_TextChanged (object sender, EventArgs e)
		{
			TextBox textBox = sender as TextBox;
			double newValue = Utils.GetNumberFromTextBox (textBox);

			if (textBox == SampleMassTextBox)
				_sampleMass = newValue;
			else if (textBox == TitrantVolumeTextBox)
				_titrantVolume = newValue;
			else if (textBox == AgNO3ConcTextBox)
				_agNO3Conc = newValue;
			else if (textBox == NH4SCNConcTextBox)
				_nh4SCNConc = newValue;
			else if (textBox == AliquotVolumeTextBox)
				_aliquotVolume = newValue;
			else if (textBox == CommonVolumeTextBox)
				_commonVolume = newValue;
			else if (textBox == AgNO3VolumeTextBox)
				_agNO3Volume = newValue;
			else if (textBox == AgNO3VolumeControlTextBox)
				_agNO3VolumeControl = newValue;
			else if (textBox == TitrantVolumeControlTextBox)
				_titrantVolumeControl = newValue;
			else
			{
				throw new Exception ("Unknown text box.");
			}

			OnInputTextChanged ();
		}

		private void OnInputTextChanged ()
		{
			// Sodium Chloride Fraction.
			if (double.IsNaN (_sampleMass) ||
				double.IsNaN (_titrantVolume) ||
				double.IsNaN (_agNO3Conc) ||
				double.IsNaN (_nh4SCNConc) ||
				double.IsNaN (_aliquotVolume) ||
				double.IsNaN (_commonVolume) ||
				double.IsNaN (_agNO3Volume) ||
				double.IsNaN (_agNO3VolumeControl) ||
				double.IsNaN (_titrantVolumeControl)
			)
			{
				_sodiumChlorideFraction = double.NaN;
				SodiumChlorideFractionTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				double leftPart = (_agNO3Volume - _agNO3VolumeControl) * _agNO3Conc;
				double rightPart = (_titrantVolume - _titrantVolumeControl) * _nh4SCNConc;
				double denominator = _sampleMass * _aliquotVolume;
				if (denominator == 0)
				{
					_sodiumChlorideFraction = double.NaN;
					SodiumChlorideFractionTextBox.Text = Utils.UndefinedString;
				}
				else
				{
					_sodiumChlorideFraction = 5.845 * (leftPart - rightPart) * _commonVolume / (_sampleMass * _aliquotVolume);
					SodiumChlorideFractionTextBox.Text = Utils.NumberToStringPrecise (_sodiumChlorideFraction, 3);
				}
			}

			// Chlorides Fraction.
			if (double.IsNaN (_sodiumChlorideFraction))
			{
				_chloridesFraction = double.NaN;
				ChloridesFractionTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_chloridesFraction = _sodiumChlorideFraction / 1.648;
				ChloridesFractionTextBox.Text = Utils.NumberToStringPrecise (_chloridesFraction, 3);
			}
		}
	}
}
