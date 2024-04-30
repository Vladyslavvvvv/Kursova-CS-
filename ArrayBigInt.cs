using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova__CS_
{
    public class ArrayBigInt : IEnumerable<BigInt>, IEnumerator<BigInt>
    {
        private List<BigInt> bigInts = new List<BigInt>();
        private int position = -1;

        // Додавання елемента в масив
        public void AddBigInt(BigInt bigInt)
        {
            bigInts.Add(bigInt);
        }

        // Знаходження суми всіх елементів масиву
        public BigInt Sum()
        {
            BigInt sum = new BigInt();

            IEnumerator<BigInt> enumerator = GetEnumerator();
            while (enumerator.MoveNext())
            {
                sum += enumerator.Current;
            }
            enumerator.Dispose();

            return sum;
        }

        // Читання масиву чисел з файлу .txt
        public void ReadFromFile(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line = sr.ReadLine();
                    string[] numbers = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); // Розділити рядок на числа
                    foreach (string numStr in numbers)
                    {
                        BigInt parsedBigInt = new BigInt(); // Створення BigInt
                                                            // Перетворення числа у char[]
                        char[] charArray = numStr.ToCharArray();

                        // Встановлення значення за допомогою SetString
                        parsedBigInt.SetString(charArray);

                        // Встановлення розміру за допомогою SetLength
                        parsedBigInt.SetLength(charArray.Length);

                        AddBigInt(parsedBigInt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проблема з читанням файлу: {ex.Message}");
            }
        }

        // Запис суми у файл .txt
        public void WriteSumToFile(string filename)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    // Отримуємо суму
                    BigInt sum = Sum();

                    string SUM = new string (sum.GetString());

                    // Записуємо суму у файл
                    sw.WriteLine("Сума: " + SUM);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка запису у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Реалізація інтерфейсу IEnumerable<BigInt>
        public IEnumerator<BigInt> GetEnumerator()
        {
            return this;
        }

        // Реалізація інтерфейсу IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        // Реалізація інтерфейсу IEnumerator<BigInt>
        public BigInt Current => bigInts[position];

        // Реалізація інтерфейсу IEnumerator
        object IEnumerator.Current => Current;
        
        // Перехід до наступного елемента масиву
        public bool MoveNext()
        {
            position++;
            return (position < bigInts.Count);
        }

        // Скидання позиції перебору на початок
        public void Reset()
        {
            position = -1;
        }

        // Видалення ресурсів
        public void Dispose()
        {
            Reset();
        }
    }
}