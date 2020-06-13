using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum.Oscillius.Argentum.Core
{
	public class Utils
	{
		private static CultureInfo _cultureInfoUsed = CultureInfo.GetCultureInfo ("ru-RU");
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


		// Возвращает true, если ввод символа, переданного в событии при нажатии кнопки, разрешен.
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

		public static double GetNumberFromTextBox (TextBox source)
		{
			string validatedText = ValidateDecimalSeparator (source.Text);

			if (Double.TryParse (validatedText, _numberStyleUsed, _cultureInfoUsed, out double result))
				return result;

			return Double.NaN;
		}

		// При необходимости меняет десятичный разделитель (точку, запятую), встретившийся в строке numericString, на разделитель, соответствующий культуре _cultureInfoUsed. Предполагается, что строка numericString представлена в необходимом формате (например, была введена в TextBox с использованием Utils.ProcessNumericInput()), то есть не содержит двух разделителей, точку и запятую одновременно и т.д.
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

		// Округляет число number до precision-го знака после запятой и возвращает полученное значение.
		public static double RoundUpNumber (double number, int precision)
		{
			if (double.IsNaN (number))
				throw new ArgumentException ("The 'number' parameter is NaN.");
			double powerOfTen = Math.Pow (10, precision);
			return Math.Round (number * powerOfTen) / powerOfTen;
		}

		// Возвращает строку, представляющую число number, округленное до precision-го знака после запятой и содержащее precision знаков после запятой. Исходное значение number не изменяется.
		public static string NumberToString (double number, int precision)
		{
			_tempCultureInfo.NumberFormat.NumberDecimalDigits = precision;
			return number.ToString ("N", _tempCultureInfo.NumberFormat);
		}

		// PROPERTIES

		public static CultureInfo CultureInfoUsed { get { return _cultureInfoUsed; } }

	}
}
