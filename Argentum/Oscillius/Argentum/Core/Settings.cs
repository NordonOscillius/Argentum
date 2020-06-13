using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argentum.Oscillius.Argentum.Core
{
	class Settings
	{
		/// <summary>
		/// Для определения сырого протеина: использовать ли дефолтное значение для объема титранта в контрольном опыте RawProtein_TitrantControlVolume.
		/// </summary>
		public bool RawProtein_TitrantControlVolumeDefined = true;

		/// <summary>
		/// Для определения сырого протеина: объем раствора серной кислоты, пошедший на титрование в контрольном опыте (значение по умолчанию). Имеет значение только при RawProtein_TitrantControlVolumeDefined = true.
		/// </summary>
		public double RawProtein_TitrantControlVolume = .1;

		/// <summary>
		/// Для определения сырого протеина: определен ли поправочный коэффициент титранта (серной кислоты). Если false, то RawProtein_TitrantCorrection не будет использоваться.
		/// </summary>
		public bool RawProtein_TitrantCorrectionDefined = false;

		/// <summary>
		/// Для определения сырого протеина: поправочный коэффициент титранта (раствора серной кислоты), используемый по умолчанию. Имеет смысл только при RawProtein_TitrantCorrectionDefined = true.
		/// </summary>
		public double RawProtein_TitrantCorrection = 1.0000;


		public Settings ()
		{ }

		/// <summary>
		/// Устанавливает все свойства объекта настроек в значения по умолчанию.
		/// </summary>
		public void SetDefault ()
		{
			RawProtein_TitrantControlVolumeDefined = true;
			RawProtein_TitrantControlVolume = .1;
			RawProtein_TitrantCorrectionDefined = false;
			RawProtein_TitrantCorrection = 1;
		}

		/// <summary>
		/// Читает настройки из строки iniText и устанавливает свойства этого объекта в соответствующие значения. Если настройки не удается прочитать (не найдено ожидаемое название свойства или значение свойства не может быть приведено к требуемому значению), то successful устанавливается в false.
		/// </summary>
		/// <param name="iniText">Строка, прочитанная из файла настроек.</param>
		/// <param name="successful">Было ли чтение настроек проведено успешно. Если метод устанавливает этот параметр в false, то следует выполнить сброс настроек с помощью setDefault().</param>
		public void Setup (string iniText, out bool successful)
		{
			int curIndex = 0;

			RawProtein_TitrantControlVolumeDefined = ReadNextBoolean (iniText, "RawProtein_TitrantControlVolumeDefined = ", ref curIndex, out successful);
			if (!successful) return;
			RawProtein_TitrantControlVolume = ReadNextDouble (iniText, "RawProtein_TitrantControlVolume = ", ref curIndex, out successful);
			if (!successful) return;
			RawProtein_TitrantCorrectionDefined = ReadNextBoolean (iniText, "RawProtein_TitrantCorrectionDefined = ", ref curIndex, out successful);
			if (!successful) return;
			RawProtein_TitrantCorrection = ReadNextDouble (iniText, "RawProtein_TitrantCorrection = ", ref curIndex, out successful);
			if (!successful) return;
		}

		private bool ReadNextBoolean (string iniText, string propertyName, ref int curIndex, out bool successful)
		{
			string valueString = ReadNextPropertyRaw (iniText, propertyName, ref curIndex, out successful);
			if (!successful)
			{
				return false;
			}
			if (valueString == "true") return true;
			if (valueString == "false") return false;

			// Инишка повреждена.
			successful = false;
			return false;
		}

		private string ReadNextString (string iniText, string propertyName, ref int curIndex, out bool successful)
		{
			string valueString = ReadNextPropertyRaw (iniText, propertyName, ref curIndex, out successful);
			if (!successful)
			{
				return null;
			}
			return valueString;
		}

		private double ReadNextDouble (string iniText, string propertyName, ref int curIndex, out bool successful)
		{
			string valueString = ReadNextPropertyRaw (iniText, propertyName, ref curIndex, out successful);
			if (!successful)
			{
				return 0;
				//return double.NaN;
			}
			double result = Utils.GetNumberFromString (valueString);
			if (double.IsNaN (result))
			{
				successful = false;
				return 0;
			}
			return result;
		}

		/// <summary>
		/// Читает следующее свойство с именем propertyName из строки iniText, начиная с индекса curIndex. Если свойство прочитать не удалось, то successful устанавливается в false. В ходе чтения индекс curIndex увеличивается, перемещаясь к началу следующей строки.
		/// </summary>
		/// <param name="iniText">Строка, из которой необходимо прочитать следующее свойство.</param>
		/// <param name="propertyName">Название свойства, которое необходимо прочитать.</param>
		/// <param name="curIndex">Индекс символа внутри строки iniText, в котором начинается название свойства. ref-параметр.</param>
		/// <param name="successful">Удалось ли прочитать свойство. Если false, файл инишки считается поврежденным.</param>
		/// <returns>Подстрока, представляющая собой строковое представление значения свойства - например, "false" или "0.051".</returns>
		private string ReadNextPropertyRaw (string iniText, string propertyName, ref int curIndex, out bool successful)
		{
			string newline = Environment.NewLine;

			string record = iniText.Substring (curIndex, propertyName.Length);
			successful = record.Equals (propertyName);
			if (!successful)
			{
				return null;
			}

			curIndex += propertyName.Length;

			int newlineIndex = iniText.IndexOf (newline, curIndex);
			string valueString = iniText.Substring (curIndex, newlineIndex - curIndex);
			curIndex = newlineIndex + newline.Length;

			return valueString;
		}

		/// <summary>
		/// Возвращает строку, хранящую свойства этого объекта настроек, которую впоследствии можно записать в файл.
		/// </summary>
		/// <returns>Строка с сохраненными настройками.</returns>
		public string GetIniText ()
		{
			string newline = Environment.NewLine;
			StringBuilder sb = new StringBuilder ();

			sb
				.Append ("RawProtein_TitrantControlVolumeDefined = ")
				.Append (RawProtein_TitrantControlVolumeDefined.ToString ().ToLower ())
				.AppendLine ()

				.Append ("RawProtein_TitrantControlVolume = ")
				.Append (ConvertDoubleToString (RawProtein_TitrantControlVolume))
				.AppendLine ()

				.Append ("RawProtein_TitrantCorrectionDefined = ")
				.Append (RawProtein_TitrantCorrectionDefined.ToString ().ToLower ())
				.AppendLine ()

				.Append ("RawProtein_TitrantCorrection = ")
				.Append (ConvertDoubleToString (RawProtein_TitrantCorrection))
				.AppendLine ()
			;

			return sb.ToString ();
		}

		// Для инкапсуляции изменений.
		private string ConvertDoubleToString (double number)
		{
			return number.ToString ("N", Utils.CultureInfoUsed.NumberFormat);
		}

	}
}
