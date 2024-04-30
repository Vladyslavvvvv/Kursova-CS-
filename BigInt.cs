using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova__CS_
{
    public class BigInt : CString
    {
        // Дефолтний конструктор
        public BigInt() : base()
        {
        }

        // Конструктор з параметрами
        public BigInt(char[] newStr, int newLength) : base(newStr, newLength)
        {
        }

        // Конструктор копіювання
        public BigInt(BigInt other, bool copy) : base(other, copy)
        {
        }

        // Конструктор переміщення
        public BigInt(BigInt other) : base(other)
        {
        }

        // Оператор додавання
        public static BigInt operator+(BigInt B1, BigInt B2)
        {
            int len1 = B1.GetLength();
            int len2 = B2.GetLength();
            int maxLength = Math.Max(len1, len2);

            int[] result = new int[maxLength + 1];

            int carry = 0;
            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = (i < len1) ? B1.str[len1 - 1 - i] - '0' : 0;
                int digit2 = (i < len2) ? B2.str[len2 - 1 - i] - '0' : 0;

                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result[maxLength - i] = sum % 10;
            }

            result[0] = carry;

            string sumStr = string.Join("", result.SkipWhile(x => x == 0));
            char[] sumChars = sumStr.ToCharArray();

            return new BigInt(sumChars, sumChars.Length);
        }

        // Віртуальний метод для знаходження суми щоб продемонструвати поліморфізм
        public override CString Sum(CString B1, CString B2)
        {
            int len1 = B1.GetLength();
            int len2 = B2.GetLength();
            int maxLength = Math.Max(len1, len2);

            int[] result = new int[maxLength + 1];

            int carry = 0;
            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = (i < len1) ? B1.GetString()[len1 - 1 - i] - '0' : 0;
                int digit2 = (i < len2) ? B2.GetString()[len2 - 1 - i] - '0' : 0;

                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result[maxLength - i] = sum % 10;
            }

            result[0] = carry;

            string sumStr = string.Join("", result.SkipWhile(x => x == 0));
            char[] sumChars = sumStr.ToCharArray();

            return new BigInt(sumChars, sumChars.Length);
        }

        // Оператор множення
        public static BigInt operator*(BigInt B1, BigInt B2)
        {
            int len1 = B1.GetLength();
            int len2 = B2.GetLength();
            int[] result = new int[len1 + len2];

            for (int i = 0; i < len1 + len2; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < len1; i++)
            {
                int carry = 0;
                int digit1 = B1.str[len1 - 1 - i] - '0';

                for (int j = 0; j < len2; j++)
                {
                    int digit2 = B2.str[len2 - 1 - j] - '0';
                    int multiply = digit1 * digit2 + result[i + j] + carry;

                    carry = multiply / 10;
                    result[i + j] = multiply % 10;
                }

                if (carry > 0)
                {
                    result[i + len2] += carry;
                }
            }

            string multiplyStr = string.Join("", result.Reverse().SkipWhile(x => x == 0));

            char[] multiplyChars = multiplyStr.ToCharArray();
            return new BigInt(multiplyChars, multiplyChars.Length);
        }

        // Оператор більше
        public static bool operator>(BigInt B1, BigInt B2)
        {
            int len1 = B1.GetLength();
            int len2 = B2.GetLength();
            if (len1 > len2)
            {
                return true;
            }
            else if (len1 < len2)
            {
                return false;
            }
            
            for (int i = 0; i < len1; ++i)
            {
                if (B1.str[i] > B2.str[i])
                {
                    return true;
                }
                else if (B1.str[i] < B2.str[i])
                {
                    return false;
                }
            }
            
            return false;
        }

        // Оператор менше
        public static bool operator<(BigInt B1, BigInt B2)
        {
            int len1 = B1.GetLength();
            int len2 = B2.GetLength();
            if (len1 < len2)
            {
                return true;
            }
            else if (len1 > len2)
            {
                return false;
            }

            for (int i = 0; i < len1; ++i)
            {
                if (B1.str[i] < B2.str[i])
                {
                    return true;
                }
                else if (B1.str[i] > B2.str[i])
                {
                    return false;
                }
            }

            return false;
        }

        // Оператор рівне
        public static bool operator==(BigInt B1, BigInt B2)
        {
            // Перевірка довжин рядків
            if (B1.str.Length != B2.str.Length)
            {
                return false;
            }

            // Порівняння символів кожного рядка
            for (int i = 0; i < B1.str.Length; i++)
            {
                if (B1.str[i] != B2.str[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Оператор не рівне
        public static bool operator!=(BigInt B1, BigInt B2)
        {
            return !(B1 == B2);
        }

        // Оператор більше-рівне
        public static bool operator>=(BigInt B1, BigInt B2)
        {
            return ((B1 > B2) || (B1 == B2));
        }

        // Оператор менше-рівне
        public static bool operator<=(BigInt B1, BigInt B2)
        {
            return ((B1 < B2) || (B1 == B2));
        }

        // Перевантажений оператор введення
        public static BigInt operator>>(BigInt B, TextBox textBox)
        {
            char[] STR = textBox.Text.ToCharArray();
            int LEN = STR.Length;

            for (int i = 0; i < LEN; i++)
            {
                if (!char.IsDigit(STR[i]))
                {
                    MessageBox.Show("Потрібно ввести цілі невід'ємні числа!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            B.maxLength = LEN;
            B.str = STR;
            return B;
        }

        // Перевантажений оператор виведення
        public static string operator<<(BigInt B, Label label)
        {
            string STR = new string(B.GetString());
            label.Text = STR;
            return label.Text;
        }
    }
}
