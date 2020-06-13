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
		public SodiumForm ()
		{
			InitializeComponent ();
		}

		private void OnNumericTextBox_KeyPress (object sender, KeyPressEventArgs e)
		{
			if (!Utils.ProcessNumericInput (sender, e, out char inputChar))
			{
				e.Handled = true;
			}
		}
	}
}
