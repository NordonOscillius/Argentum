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
	public partial class SodiumForm : Form
	{
		private double _sampleMass = double.NaN;
		private double _e1 = double.NaN;
		private double _e2 = double.NaN;
		private double _e3 = double.NaN;

		private double _deltaE = double.NaN;
		private double _steepness = double.NaN;
		private double _exponent = double.NaN;
		private double _sodiumFractionPercent = double.NaN;


		public SodiumForm ()
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

		private void SodiumForm_Load (object sender, EventArgs e)
		{
			//E1Label.Text = "E" + "\u2081";
			//E2Label.Text = "E" + "\u2082";
			//E3Label.Text = "E" + "\u2083";

			OnInputTextChanged ();
		}

		private void MassTextBox_TextChanged (object sender, EventArgs e)
		{
			_sampleMass = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void E1TextBox_TextChanged (object sender, EventArgs e)
		{
			_e1 = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void E2TextBox_TextChanged (object sender, EventArgs e)
		{
			_e2 = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void E3TextBox_TextChanged (object sender, EventArgs e)
		{
			_e3 = Utils.GetNumberFromTextBox (sender as TextBox);
			OnInputTextChanged ();
		}

		private void OnInputTextChanged ()
		{
			// Delta E.
			if (double.IsNaN (_e3) || double.IsNaN (_e2))
			{
				_deltaE = double.NaN;
				DeltaETextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_deltaE = _e3 - _e2;
				DeltaETextBox.Text = Utils.NumberToStringPrecise (_deltaE, 2);
			}

			// Steepness.
			if (double.IsNaN (_e3) || double.IsNaN (_e1))
			{
				_steepness = double.NaN;
				SteepnessTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_steepness = _e3 - _e1;
				SteepnessTextBox.Text = Utils.NumberToStringPrecise (_steepness, 2);
			}

			// Exponent.
			if (double.IsNaN (_deltaE) || double.IsNaN (_steepness) || _steepness == 0)
			{
				_exponent = double.NaN;
				ExponentTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				_exponent = _deltaE / _steepness;
				ExponentTextBox.Text = Utils.NumberToStringPrecise (_exponent, 2);
			}

			// Sodium Fraction Percent.
			if (double.IsNaN (_exponent))
			{
				_sodiumFractionPercent = double.NaN;
				SodiumFractionTextBox.Text = Utils.UndefinedString;
			}
			else
			{
				// При содержании натрия более 0,1% результат округляется до второго знака после запятой.
				// При содержании натрия менее 0,1% результат округляется до третьего знака после запятой.
				double denominator = (Math.Pow (10, _exponent) - 1) * _sampleMass;
				if (denominator == 0)
				{
					_sodiumFractionPercent = double.NaN;
					SodiumFractionTextBox.Text = Utils.UndefinedString;
				}
				else
				{
					_sodiumFractionPercent = 2.2990 / denominator;
					SodiumFractionTextBox.Text = Utils.NumberToStringPrecise (_sodiumFractionPercent, _sodiumFractionPercent < .1 ? 3 : 2);
				}
			}
		}

	}
}
