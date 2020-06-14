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
		private static Kernel _instance;

		private MainForm _mainForm;
		private Settings _settings;

		private const string SETTINGS_FILE_PATH = "settings.ini";


		public Kernel (MainForm mainForm)
		{
			if (_instance != null)
				throw new Exception ("Kernel already exists.");
			_instance = this;

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

		/// <summary>
		/// Сохраняет все настройки в файл.
		/// </summary>
		public void SaveSettings ()
		{
			File.WriteAllText (SETTINGS_FILE_PATH, _settings.GetIniText ());
		}


		#region Properties

		public static Kernel Instance { get { return _instance; } }

		public Settings Settings { get { return _settings; } }

		#endregion

	}
}
