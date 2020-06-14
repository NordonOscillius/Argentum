using System;
using System.Collections.Generic;
using System.Diagnostics;
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


		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_AgNO3Conc. Если false, то Chlorides_AgNO3Conc не будет использоваться.
		/// </summary>
		public bool Chlorides_AgNO3ConcDefined = false;

		/// <summary>
		/// Для расчета хлоридов: точная концентрация 0,1 М раствора AgNO3, используемая по умолчанию. Имеет смысл только при Chlorides_AgNO3ConcDefined = true.
		/// </summary>
		public double Chlorides_AgNO3Conc = .1;

		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_NH4SCNConc. Если false, то Chlorides_NH4SCNConc не будет использоваться.
		/// </summary>
		public bool Chlorides_NH4SCNConcDefined = false;

		/// <summary>
		/// Для расчета хлоридов: точная концентрация 0,1 М раствора NH4SCN, используемая по умолчанию. Имеет смысл только при Chlorides_NH4SCNConcDefined = true.
		/// </summary>
		public double Chlorides_NH4SCNConc = .1;

		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_AliquotVolume. Если false, то Chlorides_AliquotVolume не будет использоваться.
		/// </summary>
		public bool Chlorides_AliquotVolumeDefined = true;

		/// <summary>
		/// Для расчета хлоридов: объем аликвотной части фильтрата, использованный для анализа (V4) (значение по умолчанию). Имеет смысл только при Chlorides_AliquotVolumeDefined = true.
		/// </summary>
		public double Chlorides_AliquotVolume = 50;

		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_CommonVolume. Если false, то Chlorides_CommonVolume не будет использоваться.
		/// </summary>
		public bool Chlorides_CommonVolumeDefined = true;

		/// <summary>
		/// Для расчета хлоридов: общий объем водной вытяжки, используемый в расчетах по умолчанию. Имеет смысл только при Chlorides_CommonVolumeDefined = true.
		/// </summary>
		public double Chlorides_CommonVolume = 250;

		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_AgNO3Volume. Если false, то Chlorides_AgNO3Volume не будет использоваться.
		/// </summary>
		public bool Chlorides_AgNO3VolumeDefined = true;

		/// <summary>
		/// Для расчета хлоридов: объем раствора AgNO3 (0,1 М), добавленный в исследуемую пробу непосредственно перед титрованием (V5); значение по умолчанию. Имеет смысл только при Chlorides_AgNO3VolumeDefined = true.
		/// </summary>
		public double Chlorides_AgNO3Volume = 5;

		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_AgNO3VolumeControl. Если false, то Chlorides_AgNO3VolumeControl не будет использоваться.
		/// </summary>
		public bool Chlorides_AgNO3VolumeControlDefined = true;

		/// <summary>
		/// Для расчета хлоридов: объем раствора AgNO3 (0,1 М), добавленный в контрольном опыте (V5'); значение по умолчанию. Имеет смысл только при Chlorides_AgNO3VolumeControlDefined = true.
		/// </summary>
		public double Chlorides_AgNO3VolumeControl = .5;

		/// <summary>
		/// Для расчета хлоридов: определен ли Chlorides_TitrantVolumeControl. Если false, то Chlorides_TitrantVolumeControl не будет использоваться.
		/// </summary>
		public bool Chlorides_TitrantVolumeControlDefined = true;

		/// <summary>
		/// Для расчета хлоридов: объем раствора NH4SCN (0,1 М), пошедший на титрование в контрольном опыте (V6'); значение по умолчанию. Имеет смысл только при Chlorides_TitrantVolumeControlDefined = true.
		/// </summary>
		public double Chlorides_TitrantVolumeControl = .5;


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

			Chlorides_AgNO3ConcDefined = false;
			Chlorides_AgNO3Conc = .1;
			Chlorides_NH4SCNConcDefined = false;
			Chlorides_NH4SCNConc = .1;
			Chlorides_AliquotVolumeDefined = true;
			Chlorides_AliquotVolume = 50;
			Chlorides_CommonVolumeDefined = true;
			Chlorides_CommonVolume = 250;
			Chlorides_AgNO3VolumeDefined = true;
			Chlorides_AgNO3Volume = 5;
			Chlorides_AgNO3VolumeControlDefined = true;
			Chlorides_AgNO3VolumeControl = .5;
			Chlorides_TitrantVolumeControlDefined = true;
			Chlorides_TitrantVolumeControl = .5;
		}

		/// <summary>
		/// Читает настройки из строки iniText и устанавливает свойства этого объекта в соответствующие значения. Если настройки не удается прочитать (не найдено ожидаемое название свойства или значение свойства не может быть приведено к требуемому значению), то successful устанавливается в false.
		/// </summary>
		/// <param name="iniText">Строка, прочитанная из файла настроек.</param>
		/// <param name="successful">Было ли чтение настроек проведено успешно. Если метод устанавливает этот параметр в false, то следует выполнить сброс настроек с помощью setDefault().</param>
		public void Setup (string iniText, out bool successful)
		{
			int curIndex = 0;

			// Raw Protein.

			RawProtein_TitrantControlVolumeDefined = ReadNextBoolean (iniText, "RawProtein_TitrantControlVolumeDefined = ", ref curIndex, out successful);
			if (!successful) return;
			RawProtein_TitrantControlVolume = ReadNextDouble (iniText, "RawProtein_TitrantControlVolume = ", ref curIndex, out successful);
			if (!successful) return;
			RawProtein_TitrantCorrectionDefined = ReadNextBoolean (iniText, "RawProtein_TitrantCorrectionDefined = ", ref curIndex, out successful);
			if (!successful) return;
			RawProtein_TitrantCorrection = ReadNextDouble (iniText, "RawProtein_TitrantCorrection = ", ref curIndex, out successful);
			if (!successful) return;

			// Chlorides.

			Chlorides_AgNO3ConcDefined = ReadNextBoolean (iniText, "Chlorides_AgNO3ConcDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_AgNO3Conc = ReadNextDouble (iniText, "Chlorides_AgNO3Conc = ", ref curIndex, out successful);
			if (!successful) return;

			Chlorides_NH4SCNConcDefined = ReadNextBoolean (iniText, "Chlorides_NH4SCNConcDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_NH4SCNConc = ReadNextDouble (iniText, "Chlorides_NH4SCNConc = ", ref curIndex, out successful);
			if (!successful) return;

			Chlorides_AliquotVolumeDefined = ReadNextBoolean (iniText, "Chlorides_AliquotVolumeDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_AliquotVolume = ReadNextDouble (iniText, "Chlorides_AliquotVolume = ", ref curIndex, out successful);
			if (!successful) return;

			Chlorides_CommonVolumeDefined = ReadNextBoolean (iniText, "Chlorides_CommonVolumeDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_CommonVolume = ReadNextDouble (iniText, "Chlorides_CommonVolume = ", ref curIndex, out successful);
			if (!successful) return;

			Chlorides_AgNO3VolumeDefined = ReadNextBoolean (iniText, "Chlorides_AgNO3VolumeDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_AgNO3Volume = ReadNextDouble (iniText, "Chlorides_AgNO3Volume = ", ref curIndex, out successful);
			if (!successful) return;

			Chlorides_AgNO3VolumeControlDefined = ReadNextBoolean (iniText, "Chlorides_AgNO3VolumeControlDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_AgNO3VolumeControl = ReadNextDouble (iniText, "Chlorides_AgNO3VolumeControl = ", ref curIndex, out successful);
			if (!successful) return;

			Chlorides_TitrantVolumeControlDefined = ReadNextBoolean (iniText, "Chlorides_TitrantVolumeControlDefined = ", ref curIndex, out successful);
			if (!successful) return;
			Chlorides_TitrantVolumeControl = ReadNextDouble (iniText, "Chlorides_TitrantVolumeControl = ", ref curIndex, out successful);
			if (!successful) return;
		}

		#region Helpers

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

			if (curIndex > iniText.Length - 1 || curIndex + propertyName.Length > iniText.Length -1)
			{
				successful = false;
				return null;
			}

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

		#endregion

		/// <summary>
		/// Возвращает строку, хранящую свойства этого объекта настроек, которую впоследствии можно записать в файл.
		/// </summary>
		/// <returns>Строка с сохраненными настройками.</returns>
		public string GetIniText ()
		{
			string newline = Environment.NewLine;
			StringBuilder sb = new StringBuilder ();

			sb
				/* Raw Protein */

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

				/* Chlorides */

				.Append ("Chlorides_AgNO3ConcDefined = ")
				.Append (Chlorides_AgNO3ConcDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_AgNO3Conc = ")
				.Append (ConvertDoubleToString (Chlorides_AgNO3Conc))
				.AppendLine ()

				.Append ("Chlorides_NH4SCNConcDefined = ")
				.Append (Chlorides_NH4SCNConcDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_NH4SCNConc = ")
				.Append (ConvertDoubleToString (Chlorides_NH4SCNConc))
				.AppendLine ()

				.Append ("Chlorides_AliquotVolumeDefined = ")
				.Append (Chlorides_AliquotVolumeDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_AliquotVolume = ")
				.Append (ConvertDoubleToString (Chlorides_AliquotVolume))
				.AppendLine ()

				.Append ("Chlorides_CommonVolumeDefined = ")
				.Append (Chlorides_CommonVolumeDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_CommonVolume = ")
				.Append (ConvertDoubleToString (Chlorides_CommonVolume))
				.AppendLine ()

				.Append ("Chlorides_AgNO3VolumeDefined = ")
				.Append (Chlorides_AgNO3VolumeDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_AgNO3Volume = ")
				.Append (ConvertDoubleToString (Chlorides_AgNO3Volume))
				.AppendLine ()

				.Append ("Chlorides_AgNO3VolumeControlDefined = ")
				.Append (Chlorides_AgNO3VolumeControlDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_AgNO3VolumeControl = ")
				.Append (ConvertDoubleToString (Chlorides_AgNO3VolumeControl))
				.AppendLine ()

				.Append ("Chlorides_TitrantVolumeControlDefined = ")
				.Append (Chlorides_TitrantVolumeControlDefined.ToString ().ToLower ())
				.AppendLine ()
				.Append ("Chlorides_TitrantVolumeControl = ")
				.Append (ConvertDoubleToString (Chlorides_TitrantVolumeControl))
				.AppendLine ()
			;

			return sb.ToString ();
		}

		// Для инкапсуляции изменений.
		private string ConvertDoubleToString (double number)
		{
			return number.ToString (Utils.CultureInfoUsed.NumberFormat);
		}

	}
}
