using Argentum.Oscillius.Argentum.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum
{
	public partial class MainForm : Form
	{
		private SodiumForm _sodiumForm;


		public MainForm ()
		{
			InitializeComponent ();
		}

		private void NaButton_Click (object sender, EventArgs e)
		{
			if (_sodiumForm != null)
				return;

			_sodiumForm = new SodiumForm ();
			_sodiumForm.Show ();
			_sodiumForm.FormClosed += OnSodiumFormClosed;
			_sodiumForm.Location = new Point (Location.X + Width, Location.Y);
		}

		private void OnSodiumFormClosed (object sender, FormClosedEventArgs e)
		{
			_sodiumForm.FormClosed -= OnSodiumFormClosed;
			_sodiumForm = null;
		}
	}
}
