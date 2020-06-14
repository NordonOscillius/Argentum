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
		public RawProteinForm ()
		{
			InitializeComponent ();
		}

		private void OnNumericTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			if (!Utils.ProcessNumericInput (sender, e, false))
			{
				e.Handled = true;
			}
		}

		private void OnNumericNonNegativeTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			if (!Utils.ProcessNumericInput (sender, e, true))
			{
				e.Handled = true;
			}
		}

		// При загрузке формы устанавливаем в текст-боксы значения по умолчанию (если есть).
		private void RawProteinForm_Load (object sender, EventArgs e)
		{
			Settings settings = Kernel.Instance.Settings;
			if (settings.RawProtein_TitrantControlVolumeDefined)
			{
				TitrantControlVolumeTextBox.Text = settings.RawProtein_TitrantControlVolume.ToString (Utils.CultureInfoUsed);
			}
			if (settings.RawProtein_TitrantCorrectionDefined)
			{
				TitrantCorrectionTextBox.Text = settings.RawProtein_TitrantCorrection.ToString (Utils.CultureInfoUsed);
			}
		}

		private void TitrantControlVolumeSaveBtn_Click (object sender, EventArgs e)
		{
			double newValue = Utils.GetNumberFromTextBox (TitrantControlVolumeTextBox);
			if (double.IsNaN (newValue))
				return;

			Kernel.Instance.Settings.RawProtein_TitrantControlVolumeDefined = true;
			Kernel.Instance.Settings.RawProtein_TitrantControlVolume = newValue;
		}

		private void TitrantControlVolumeResetBtn_Click (object sender, EventArgs e)
		{
			// Если значение по умолчанию не используется, выходим.
			if (!Kernel.Instance.Settings.RawProtein_TitrantControlVolumeDefined)
				return;

			TitrantControlVolumeTextBox.Text = Kernel.Instance.Settings.RawProtein_TitrantControlVolume.ToString (Utils.CultureInfoUsed);
		}
	}
}
