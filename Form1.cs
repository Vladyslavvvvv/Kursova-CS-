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
                labelCompare.Text = "Перше число більше за друге";
            }
            else if (B1 < B2)
            {
                labelCompare.Text = "Перше число менше за друге";
            }
            else if (B1 == B2)
            {
                labelCompare.Text = "Числа рівні";
            }
        }

        private void buttonEnterSum_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxEnterSum1;
            _ = B2 >> textBoxEnterSum2;

            BigInt SUM = new BigInt(B1 + B2);

            _ = SUM << labelEnterSum;
        }

        private void buttonEnterProd_Click(object sender, EventArgs e)
        {
            BigInt B1 = new BigInt();
            BigInt B2 = new BigInt();

            _ = B1 >> textBoxEnterProd1;
            _ = B2 >> textBoxEnterProd2;

            BigInt SUM = new BigInt(B1 * B2);

            _ = SUM << labelEnterProd;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReadSum_Click(object sender, EventArgs e)
        {
            // Вказати шлях до вхідного файлу з масивом чисел
            string inputFile = "C:\\Users\\acer\\OneDrive\\Робочий стіл\\2 курс\\Курсова\\Source.txt";

            // Вказати шлях до вихідного файлу, куди буде записана сума
            string outputFile = "C:\\Users\\acer\\OneDrive\\Робочий стіл\\2 курс\\Курсова\\Result.txt";

            try
            {
                ArrayBigInt arrayBigInt = new ArrayBigInt();

                // Читання масиву чисел з файлу
                arrayBigInt.ReadFromFile(inputFile);

                // Обчислення суми чисел
                BigInt sum = arrayBigInt.Sum();

                _ = sum << labelReadSum;

                arrayBigInt.WriteSumToFile(outputFile);

                labelReadSumRes.Text = "Результат записано у файл: ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPolym_Click(object sender, EventArgs e)
        {
            CString S1 = new CString();
            CString S2 = new CString();

            _ = S1 >> textBoxPolym1;
            _ = S2 >> textBoxPolym2;

            // Створення екземпляра похідного класу
            BigInt B = new BigInt();

            // Виклик віртуального методу
            CString result = B.Sum(S1, S2);

            _ = result << labelPolym;
        }
    }
}
