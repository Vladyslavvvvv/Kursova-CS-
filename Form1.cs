using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova__CS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxCompare1;
            _ = B2 >> textBoxCompare2;

            if (B1 > B2)
            {
                labelCompareRes.Text = "Перше число більше за друге";
            }
            else if (B1 < B2)
            {
                labelCompareRes.Text = "Перше число менше за друге";
            }
            else if (B1 == B2)
            {
                labelCompareRes.Text = "Числа рівні";
            }
        }

        private void buttonEnterSum_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxEnterSum1;
            _ = B2 >> textBoxEnterSum2;

            BigInt B3 = new BigInt(B1 + B2);

            _ = B3 << labelSumRes;
        }

        private void buttonEnterProd_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxEnterProd1;
            _ = B2 >> textBoxEnterProd2;

            BigInt B3 = new BigInt(B1 * B2);

            _ = B3 << labelProdRes;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReadSum_Click(object sender, EventArgs e)
        {
            // Вказати шлях до вхідного файлу з масивом чисел
            string inputFile = textBoxPathSource.Text;

            // Вказати шлях до вихідного файлу, куди буде записана сума
            string outputFile = textBoxPathResult.Text;

            try
            {
                ArrayBigInt arrayBigInt = new ArrayBigInt();
                bool stop = false;

                // Читання масиву чисел з файлу
                try
                {
                    using (StreamReader sr = new StreamReader(inputFile))
                    {
                        string line = sr.ReadLine();

                        int len = line.Length;
                        char[] ch = line.ToCharArray();

                        for (int i = 0; i < len; i++)
                        {
                            if (ch[i] == ' ')
                            {
                                continue;
                            }
                            if (!Char.IsDigit(ch[i]))
                            {
                                stop = true;
                                break;
                            }
                        }

                        if (!stop)
                        {
                            string[] numbers = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); // Розділити рядок на числа
                            foreach (string numStr in numbers)
                            {
                                BigInt parsedBigInt = new BigInt(); // Створення BigInt

                                char[] charArray = numStr.ToCharArray(); // Перетворення числа у char[]

                                // Встановлення значення за допомогою SetString
                                parsedBigInt.SetString(charArray);

                                // Встановлення розміру за допомогою SetLength
                                parsedBigInt.SetLength(charArray.Length);

                                arrayBigInt.AddBigInt(parsedBigInt);
                            }
                        }
                        else
                        {
                            MessageBox.Show("У файлі є символи що не є цифрами! Перевірте файл і повторіть спробу", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка читання з  файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!stop)
                {
                    // Обчислення суми чисел
                    BigInt sum = arrayBigInt.Sum();

                    _ = sum << labelWriteSumRes;

                    arrayBigInt.WriteSumToFile(outputFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPolym_Click(object sender, EventArgs e)
        {
            bool flag1 = false;
            bool flag2 = false;

            CString S1 = new CString();
            CString S2 = new CString();

            char[] str1 = textBoxPolym1.Text.ToCharArray();
            int len1 = str1.Length;
            char[] str2 = textBoxPolym2.Text.ToCharArray();
            int len2 = str2.Length;

            _ = S1 >> textBoxPolym1;
            _ = S2 >> textBoxPolym2;

            for (int i = 0; i < len1; i++)
            {
                if (!char.IsDigit(str1[i]))
                {
                    flag1 = true;
                }
            }
            if (flag1 == false)
            {
                for (int i = 0; i < len2; i++)
                {
                    if (!char.IsDigit(str2[i]))
                    {
                        flag2 = true;
                    }
                }
            }

            if (flag1 == false && flag2 == false)
            {
                BigInt B = new BigInt();
                CString result1 = B.Sum(S1, S2);
                _ = result1 << labelPolymRes;
            }
            else
            {
                CString S = new CString();
                CString result2 = S.Sum(S1, S2);
                _ = result2 << labelPolymRes;
            }
        }

        private void buttonEnterMinus_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxEnterMinus1;
            _ = B2 >> textBoxEnterMinus2;

            if (B1 < B2)
            {
                labelMinusRes.Text = "Перше число менше за друге! Програма не може працювати з від'ємними значеннями.";
            }
            else if (B1 == B2)
            {
                labelMinusRes.Text = "0";
            }
            else
            {
                BigInt B3 = new BigInt(B1 - B2);

                _ = B3 << labelMinusRes;
            }
        }

        private void buttonEnterDivide_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxDivide1;
            _ = B2 >> textBoxDivide2;
            
            if (B1 < B2)
            {
                labelDivideRes.Text = "В результаті вийде дробове число. Програма не може працювати з дробовими числами.";
            }
            else if (B1 == B2)
            {
                labelDivideRes.Text = "1";
            }
            else
            {
                BigInt B3 = new BigInt(B1 / B2);

                _ = B3 << labelDivideRes;
            }
        }
    }
}
