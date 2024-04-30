using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Kursova__CS_
{
    public class CString
    {
        protected char[] str;
        protected int maxLength;

        // Дефолтний конструктор
        public CString()
        {
            maxLength = 1;
            str = new char[maxLength];
            str[0] = '0';
        }

        // Конструктор з параметрами
        public CString(char[] newStr, int newLength)
        {
            maxLength = newLength;
            str = newStr;
        }

        // Конструктор копіювання
        public CString(CString other, bool copy)
        {
            maxLength = other.maxLength;
            str = other.str;
        }

        // Конструктор переміщення
        public CString(CString other)
        {
            maxLength = other.maxLength;
            str = other.str;
            other.str = null;
            other.maxLength = 0;
        }

        // Деструктор
        ~CString()
        {
            str = null;
        }

        // Метод для встановлення максимального розміру
        public void SetLength(int newLength)
        {
            maxLength = newLength;
        }

        // Метод для встановлення значення рядка
        public void SetString(char[] newStr)
        {
            str = newStr;
        }

        // Метод для отримання максимального розміру
        public int GetLength()
        {
            return maxLength;
        }

        // Метод для отримання значення рядка
        public char[] GetString()
        {
            return str;
        }

        // Метод для отримання фактичного розміру рядка
        public int GetTrueSize()
        {
            return str.Length;
        }

        // В C# неможливо перевантажити оператор =
        // тому неможливо створити перевантажені оператори копіювання і переміщення

        // Перевантажений оператор додавання (Статичний метод неможливо зробити віртуальним)
        public static CString operator+(CString S1, CString S2)
        {
            CString result = new CString();

            string s1 = new string(S1.GetString());
            string s2 = new string(S2.GetString());

            string s3 = s1 + s2;

            char[] s = s3.ToCharArray();
            int len = s3.Length;

            result.SetString(s);
            result.SetLength(len);

            return result;
        }

        // Віртуальний метод для знаходження суми щоб продемонструвати поліморфізм
        public virtual CString Sum(CString S1, CString S2)
        {
            CString result = new CString();

            string s1 = new string(S1.GetString());
            string s2 = new string(S2.GetString());

            string s3 = s1 + s2;

            char[] s = s3.ToCharArray();
            int len = s3.Length;

            result.SetString(s);
            result.SetLength(len);

            return result;
        }

        // Перевантажений оператор віднімання
        public static CString operator-(CString S1, CString S2)
        {
            CString result = new CString();

            string s1 = new string(S1.GetString());
            string s2 = new string(S2.GetString());

            int index = s1.IndexOf(s2);
            if (index >= 0)
            {
                string s3 = s1.Remove(index, s2.Length);
                char[] s = s3.ToCharArray();
                int len = s3.Length;

                result.SetString(s);
                result.SetLength(len);
            }
            else
            {
                result.SetString(S1.str);
                result.SetLength(S1.maxLength);
            }

            return result;
        }

        // Перевантажений оператор перевірки входження рядка
        public static bool operator*(CString S1, CString S2)
        {
            string s1 = new string(S1.GetString());
            string s2 = new string(S2.GetString());

            int index = s1.IndexOf(s2);
            if (index >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Перевантажений оператор введення
        public static CString operator>>(CString S, TextBox textBox)
        {
            char[] STR = textBox.Text.ToCharArray();
            int LEN = STR.Length;

            S.maxLength = LEN;
            S.str = STR;
            return S;
        }

        // Перевантажений оператор виведення
        public static string operator<<(CString S, Label label)
        {
            string STR = new string(S.GetString());
            label.Text = STR;
            return label.Text;
        }
    }
}