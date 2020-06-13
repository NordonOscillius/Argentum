using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argentum.Oscillius.Argentum.Core
{
	public class Utils
	{

		// Возвращает true, если ввод символа, переданного в событии при нажатии кнопки, разрешен. Если ввод разрешен, выходной параметр inputChar будет содержать символ, который нужно передать текст-боксу.
		public static bool ProcessNumericInput (object sender, KeyPressEventArgs e, out char inputChar)
		{
			char keyChar = e.KeyChar;
			inputChar = keyChar;

			// В поле можно вводить только цифры, символ знака "минус", точку и запятую. Кроме того, должна быть возможность пользоваться Backspace.
			if (!char.IsControl (keyChar) && !char.IsDigit (keyChar) && keyChar != '.' && keyChar != ',' && keyChar != '-')
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

	}
}
