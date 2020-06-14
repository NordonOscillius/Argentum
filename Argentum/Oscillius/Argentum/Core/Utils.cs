using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum.Oscillius.Argentum.Core
{
	public class Utils
	{
		/// <summary>
		/// Объект CultureInfo, используемый для приведения "числовых строк" к единому формату. По умолчанию используется русский языковой стандарт: отсутствуют разделители между классами, в качестве разделителя дробной части используется запятая (1052,076 - тысяча пятьдесят две целых семьдесят шесть тысячных).
		/// </summary>
		private static CultureInfo _cultureInfoUsed = CreateUsedCultureInfo ();

		private static NumberStyles _numberStyleUsed =
				NumberStyles.AllowDecimalPoint |
				NumberStyles.AllowExponent |
				NumberStyles.AllowLeadingSign |
				NumberStyles.AllowLeadingWhite |
				NumberStyles.AllowTrailingWhite;

		public static string UndefinedString = "Не определено";

		/// <summary>
		/// CultureInfo, используемая для округления чисел. Является копией _cultureInfoUsed.
		/// </summary>
		private static CultureInfo _tempCultureInfo = (CultureInfo) _cultureInfoUsed.Clone ();

		private static CultureInfo CreateUsedCultureInfo ()
		{
			CultureInfo cultureInfo = (CultureInfo) CultureInfo.GetCultureInfo ("ru-RU").Clone ();
			cultureInfo.NumberFormat.NumberDecimalDigits = 20;
			return cultureInfo;
		}


		#region Numeric Stuff

		/// <summary>
		/// Возвращает true, если в текст-бокс (в его текущем состоянии) разрешено добавить символ, введенный с клавиатуры. Этот метод следует вызывать из обработчиков событий KeyPress тех текст-боксов, которые предназначены для ввода чисел в формате "знак - целая часть числа - точка или запятая - дробная часть числа". Экспоненциальная форма записи не поддерживается.
		/// </summary>
		/// <param name="sender">TextBox, на котором произошло событие KeyPress.</param>
		/// <param name="e">Экземпляр события KeyPress.</param>
		/// <param name="nonNegative">Должен ли текст-бокс принимать только неотрицательные значения. Если true, то ввод символа '-' запрещается.</param>
		/// <returns>true, если введенный символ следует добавить в текущую позицию текст-бокса; false, если ввод символа следует предотвратить, установив e.Handled в значение true.</returns>
		public static bool ProcessNumericInput (object sender, KeyPressEventArgs e, bool nonNegative = false)
		{
			char keyChar = e.KeyChar;

			// В поле можно вводить только цифры, символ знака "минус", точку и запятую. Кроме того, должна быть возможность пользоваться Backspace.
			if (!char.IsControl (keyChar) && !char.IsDigit (keyChar) && keyChar != '.' && keyChar != ',' && keyChar != '-')
			{
				return false;
			}
			if (nonNegative && keyChar == '-')
			{
				return false;
			}

			TextBox textBox = sender as TextBox;
			string text = textBox.Text;

			// Минус может стоять только перед числом (в нулевой позиции). Если пользователь пытается поставить минус в начале строки или заменить начальную выделенную часть числа на минус, мы должны позволить ему сделать это (при условии, что минуса еще нет в строке или он находится в выделенной части).
			if (keyChar == '-')
			{
				bool minusAllowed = true;
				if (text.Length > 0)
				{
					// Если в тексте есть минус и он находится в невыделенной части текста, запрещаем ввод.
					if (text.IndexOf ('-') > -1)
					{
						if (textBox.SelectionLength > 0)
						{
							if (textBox.SelectionStart > 0 || text.IndexOf ('-', textBox.SelectionStart, textBox.SelectionLength) < 0)
							{
								minusAllowed = false;
							}
						}
						else
						{
							minusAllowed = false;
						}
					}
					// Если минуса в строке нет, то его можно поставить только в самом начале.
					else
					{
						// Неважно, выбрана часть текста или нет - в любом случае каретка должна стоять в самом начале строки.
						if (textBox.SelectionStart > 0)
							minusAllowed = false;
					}
				}
				return minusAllowed;
			}

			// Цифра не может стоять перед знаком, но она может заменить выделенную часть текста, если в этой части содержится минус.
			if (char.IsDigit (keyChar))
			{
				bool digitAllowed = true;
				if (text.Length > 0)
				{
					// Если в тексте содержится знак минуса.
					if (text.IndexOf ('-') > -1)
					{
						if (textBox.SelectionLength == 0 && textBox.SelectionStart == 0)
							digitAllowed = false;
						// Какая бы часть строки ни была выделена, цифра в этом случае будет разрешена (чтобы стереть минус или стереть другие цифры).
					}
				}

				return digitAllowed;
			}

			// В числе может быть только одна точка или запятая. Точка или запятая не может стоять перед знаком. Если текст содержит запятую или точку, а пользователь пытается заменить выделенную часть текста запятой (точкой), то эта выделенная часть должна содержать запятую или точку.
			if (keyChar == '.' || keyChar == ',')
			{
				if (text.Length > 0)
				{
					// Если мы не имеем дело с (частично или полностью) выделенным текстом.
					if (textBox.SelectionLength == 0)
					{
						// Если в тексте уже есть точка или запятая, запрещаем ввод.
						if (text.IndexOf ('.') > -1 || text.IndexOf (',') > -1)
							return false;

						// Если каретка стоит перед знаком минуса, запрещаем ввод.
						if (textBox.SelectionStart == 0 && text.IndexOf ('-') > -1)
							return false;
					}
					// Если часть текста выделена.
					else
					{
						// Если в тексте есть точка или запятая, но при этом она не попадает в выделенный фрагмент, запрещаем ввод.
						if (text.IndexOf ('.') > -1 || text.IndexOf (',') > -1)
						{
							if (text.IndexOf ('.', textBox.SelectionStart, textBox.SelectionLength) < 0 && text.IndexOf (',', textBox.SelectionStart, textBox.SelectionLength) < 0)
								return false;
						}

					}
				}
			}

			return true;
		}

		/// <summary>
		/// Преобразует строку, введенную в текст-бокс source, в число Double. Если преобразование удалось, метод возвращает полученное Double-значение; если преобразование невозможно, метод возвращает Double.NaN. Для преобразования используются языковой стандарт Utils.CultureInfoUsed и Utils.NumberStyleUsed.
		/// </summary>
		/// <param name="source">TextBox, свойство Text которого должно быть преобразовано в Double.</param>
		/// <returns>Значение source.Text, преобразованное в Double, или Double.NaN, если преобразование невозможно.</returns>
		public static double GetNumberFromTextBox (TextBox source)
		{
			return GetNumberFromString (source.Text);
		}

		/// <summary>
		/// Преобразует строку source в число Double. Если преобразование удалось, метод возвращает полученное Double-значение; если преобразование невозможно, метод возвращает Double.NaN. Для преобразования используются языковой стандарт Utils.CultureInfoUsed и Utils.NumberStyleUsed.
		/// </summary>
		/// <param name="source">Строка, которая должна быть преобразована в Double.</param>
		/// <returns>Строка source, преобразованная в Double, или Double.NaN, если преобразование невозможно.</returns>
		public static double GetNumberFromString (string source)
		{
			string validatedText = ValidateDecimalSeparator (source);

			if (Double.TryParse (validatedText, _numberStyleUsed, _cultureInfoUsed, out double result))
				return result;

			return Double.NaN;
		}

		/// <summary>
		/// При необходимости меняет десятичный разделитель (точку, запятую), встретившийся в строке numericString, на разделитель, соответствующий культуре _cultureInfoUsed. Предполагается, что строка numericString представлена в необходимом формате (например, была введена в TextBox с использованием Utils.ProcessNumericInput()), то есть не содержит двух разделителей, точку и запятую одновременно и т.д.
		/// </summary>
		/// <param name="numericString">Строка, в которой (при необходимости) необходимо заменить разделитель дробной части на соответствующий языковому стандарту _cultureInfoUsed.</param>
		/// <returns>Новая строка, являющаяся копией исходной строки numericString с замененным разделителем дробной части, либо точной копией исходной строки, если замена не потребовалась.</returns>
		private static string ValidateDecimalSeparator (string numericString)
		{
			string separator = _cultureInfoUsed.NumberFormat.NumberDecimalSeparator;
			if (separator == ",")
			{
				return numericString.Replace (".", separator);
			}
			else if (separator == ".")
			{
				return numericString.Replace (",", separator);
			}
			else
			{
				throw new Exception ("Unknown decimal separator (\"" + separator + "\").");
			}
		}

		/// <summary>
		/// Возвращает строку, представляющую число number, округленное до precision-го знака после запятой и содержащее precision знаков после запятой.
		/// </summary>
		/// <param name="number">Число, которое необходимо преобразовать в строку. Исходное значение остается неизменным.</param>
		/// <param name="precision">Количество знаков после запятой, которое необходимо оставить в строковом представлении числа и до которого его необходимо округлить.</param>
		/// <returns>Новая строка, представляющая число, содержащее precision знаков после запятой и округленное соответствующим образом.</returns>
		public static string NumberToString (double number, int precision)
		{
			_tempCultureInfo.NumberFormat.NumberDecimalDigits = precision;
			return number.ToString ("N", _tempCultureInfo.NumberFormat);
		}

		#endregion

		#region Paths

		/// <summary>
		/// Создает относительный путь от одного файла или директории к другому файлу или директории. Нужно помнить, что Uri рассматривает путь к папке, не оканчивающийся разделителем, как путь к файлу; т.е. если 'bar' - директория, то нужно использовать "C:\foo\bar\", а не "C:\foo\bar".
		/// Взято отсюда: https://stackoverflow.com/questions/275689/how-to-get-relative-path-from-absolute-path
		/// </summary>
		/// <param name="fromPath"></param>
		/// <param name="toPath"></param>
		/// <returns></returns>
		public static string GetRelativePath (string fromPath, string toPath)
		{
			if (String.IsNullOrEmpty (fromPath)) throw new ArgumentNullException ("fromPath");
			if (String.IsNullOrEmpty (toPath)) throw new ArgumentNullException ("toPath");

			Uri fromUri = new Uri (fromPath);
			Uri toUri = new Uri (toPath);

			// Если путь невозможно преобразовать в относительный, возвращаем полный путь.
			if (fromUri.Scheme != toUri.Scheme)
			{
				return toPath;
			}

			Uri relativeUri = fromUri.MakeRelativeUri (toUri);
			string relativePath = Uri.UnescapeDataString (relativeUri.ToString ());

			// Для файлов: заменяем альтернативные разделители на обычные (Unix-системы поддерживают только прямые слеши).
			if (toUri.Scheme.Equals ("file", StringComparison.InvariantCultureIgnoreCase))
			{
				relativePath = relativePath.Replace (Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
			}

			return relativePath;
		}

		public static string GetAbsolutePath (string relativePath)
		{
			Uri baseUri = new Uri (Directory.GetCurrentDirectory ());
			Uri targetUri = new Uri (baseUri, relativePath);
			return targetUri.LocalPath;
		}

		// Отсюда:
		// https://stackoverflow.com/questions/48380031/detect-the-encoding-of-a-text-file-using-c-sharp
		// That's it.
		public static string ReadText (string fileName)
		{
			Byte[] bytes = File.ReadAllBytes (fileName);
			Encoding encoding = null;
			String text = null;
			// Test UTF8 with BOM. This check can easily be copied and adapted
			// to detect many other encodings that use BOMs.
			UTF8Encoding encUtf8Bom = new UTF8Encoding (true, true);
			Boolean couldBeUtf8 = true;
			Byte[] preamble = encUtf8Bom.GetPreamble ();
			Int32 prLen = preamble.Length;
			if (bytes.Length >= prLen && preamble.SequenceEqual (bytes.Take (prLen)))
			{
				// UTF8 BOM found; use encUtf8Bom to decode.
				try
				{
					// Seems that despite being an encoding with preamble,
					// it doesn't actually skip said preamble when decoding...
					text = encUtf8Bom.GetString (bytes, prLen, bytes.Length - prLen);
					encoding = encUtf8Bom;
				}
				catch (ArgumentException)
				{
					// Confirmed as not UTF-8!
					couldBeUtf8 = false;
				}
			}
			// use boolean to skip this if it's already confirmed as incorrect UTF-8 decoding.
			if (couldBeUtf8 && encoding == null)
			{
				// test UTF-8 on strict encoding rules. Note that on pure ASCII this will
				// succeed as well, since valid ASCII is automatically valid UTF-8.
				UTF8Encoding encUtf8NoBom = new UTF8Encoding (false, true);
				try
				{
					text = encUtf8NoBom.GetString (bytes);
					encoding = encUtf8NoBom;
				}
				catch (ArgumentException)
				{
					// Confirmed as not UTF-8!
				}
			}
			// fall back to default ANSI encoding.
			if (encoding == null)
			{
				//encoding = Encoding.GetEncoding (1252);
				encoding = Encoding.Default;
				text = encoding.GetString (bytes);
			}

			return text;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Объект CultureInfo, используемый для приведения "числовых строк" к единому формату. По умолчанию используется русский языковой стандарт: отсутствуют разделители между классами, в качестве разделителя дробной части используется запятая (1052,076 - тысяча пятьдесят две целых семьдесят шесть тысячных).
		/// </summary>
		public static CultureInfo CultureInfoUsed { get { return _cultureInfoUsed; } }

		public static NumberStyles NumberStyleUsed { get { return _numberStyleUsed; } }

		#endregion

	}
}
