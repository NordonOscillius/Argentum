﻿using Argentum.Oscillius.Argentum.Core;
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
		private Kernel _kernel;

		private SodiumForm _sodiumForm;
		private RawProteinForm _rawProteinForm;
		private ChloridesForm _chloridesForm;


		public MainForm ()
		{
			InitializeComponent ();

			_kernel = new Kernel (this);
		}

		// При закрытии формы сохраняем все настройки.
		private void MainForm_FormClosing (object sender, FormClosingEventArgs e)
		{
			_kernel.SaveSettings ();
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

		private void RawProteinButton_Click (object sender, EventArgs e)
		{
			if (_rawProteinForm != null)
				return;

			_rawProteinForm = new RawProteinForm ();
			_rawProteinForm.Show ();
			_rawProteinForm.FormClosed += OnRawProteinFormClosed;
			_rawProteinForm.Location = new Point (Location.X + Width, Location.Y);
		}

		private void OnRawProteinFormClosed (object sender, FormClosedEventArgs e)
		{
			_rawProteinForm.FormClosed -= OnRawProteinFormClosed;
			_rawProteinForm = null;
		}

		private void ChloridesButton_Click (object sender, EventArgs e)
		{
			if (_chloridesForm != null)
				return;

			_chloridesForm = new ChloridesForm ();
			_chloridesForm.Show ();
			_chloridesForm.FormClosed += OnChloridesFormClosed;
			_chloridesForm.Location = new Point (Location.X + Width, Location.Y);
		}

		private void OnChloridesFormClosed (object sender, FormClosedEventArgs e)
		{
			_chloridesForm.FormClosed -= OnChloridesFormClosed;
			_chloridesForm = null;
		}
	}
}
