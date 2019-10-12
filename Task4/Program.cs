using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //№4 Сформировать массив N случайных чисел. Подсчитать количество четных чисел
            List<int> arr = new List<int>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            printEven(arr);
            Pause();
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        private static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнение массива элементами
        /// </summary>
        /// <returns></returns>
        private static void filling(ref List<int> arr)
        {
            int minN = 5; //нижняя граница размерности массива
            int maxN = 20; //верхняя граница размерности массива

            int minM = -100; //минимальный элемент массива
            int maxM = 50; //максимальный элемент массива

            int n = 0;
            Random rnd = new Random();
            n = checkInput(minN, maxN, n);

            //проверка введённой размерности
            bool checkN = checkSize(minN, maxN, n);
            while (true) {
                if (checkN)
                {
                    for (int i = 0; i < n; i++)
                    {
                        arr.Add(rnd.Next(minM, maxM));
                    }
                    break;
                }
                else
                {
                    n = checkInput(minN, maxN, n);
                    checkN = checkSize(minN, maxN, n);
                }
            }
        }

        /// <summary>
        /// Проверка ввода
        /// </summary>
        /// <param name="minN">нижняя граница размерности массива</param>
        /// <param name="maxN">верхняя граница размерности массива</param>
        /// <param name="n">размер массива</param>
        /// <returns></returns>
        private static int checkInput(int minN, int maxN, int n)
        {
            Console.WriteLine($"Введите размерность массива от {minN} до {maxN}.");
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine($"Неверный формат. Введите целое число от {minN} до {maxN}.");
                }
            }

            return n;
        }

        /// <summary>
        /// Проверка размерности
        /// </summary>
        /// <param name="minN">нижняя граница размерности массива</param>
        /// <param name="maxN">верхняя граница размерности массива</param>
        /// <param name="n">размер массива</param>
        /// <returns></returns>
        private static bool checkSize(int minN, int maxN, int n) {
            if (n >= minN && n <= maxN) return true;
            else return false;
        }

        /// <summary>
        /// Печать исходного массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="str">сообщение</param>
        private static void printInfoList(List<int> array, string str)
        {
            if (array.Count == 0)
            {
                Console.WriteLine("Вы не ввели ни одного элемента");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine(str);
                for (int i = 0; i < array.Count; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }

        /// <summary>
        /// Вывод чётных элементов массива
        /// </summary>
        /// <param name="array">массив</param>
        private static void printEven(List<int> array) {
            Console.WriteLine("");
            Console.Write("Чётные элементы массива: ");
            int count = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 == 0) {
                    Console.Write($"{array[i]} ");
                    count += 1;
                }
            }
            if (count == 0) Console.Write("нет чётных элементов.");
            else {
                Console.WriteLine("");
                Console.WriteLine($"Количество чётных элементов массива: {count}");
            }
        }
    }
}
