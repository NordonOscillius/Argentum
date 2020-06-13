using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argentum.Oscillius.Argentum.Core
{
	class Kernel
	{
		private MainForm _mainForm;
		private Settings _settings;

		private const string SETTINGS_FILE_PATH = "settings.ini";


		public Kernel (MainForm mainForm)
		{
			_mainForm = mainForm;

			// Читаем настройки или создаем новые.
			_settings = new Settings ();
			if (File.Exists (SETTINGS_FILE_PATH))
			{
				_settings.Setup (File.ReadAllText (SETTINGS_FILE_PATH), out bool settingsSuccessful);
				if (!settingsSuccessful)
				{
					Debug.Print (".INI-файл поврежден, будут использованы настройки по умолчанию.");
					_settings.SetDefault ();
				}
			}
			else
			{
				_settings.SetDefault ();
				File.WriteAllText (SETTINGS_FILE_PATH, _settings.GetIniText (), Encoding.UTF8);
			}
		}

	}
}
