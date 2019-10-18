using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"№9 Задать массив 10 чисел. Выяснить, есть ли в массиве одинаковые числа. 
            Сколько их?");
            List<int> arr = new List<int>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            List<int> array1 = checkValues(arr);
            printInfoList(array1);

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
            //размер массива
            int sizeArray = 10;

            for (int i = 0; i < sizeArray; i++)
            {
                while (true) {
                    Console.Write($"Введите {i}-й элемент массива: ");
                    string str = Console.ReadLine();
                    try
                    {
                        arr.Add(int.Parse(str));
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный формат. Введите целое число.");
                    }
                }
            }
        }

        /// <summary>
        /// Печать массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="str">сообщение</param>
        private static void printInfoList(List<int> array, string str)
        {
            Console.WriteLine(str);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Печать массива на экран
        /// </summary>
        /// <param name="array">исходный массив</param>
        private static void printInfoList(List<int> array)
        {
            if (array.Count == 0) Console.WriteLine($"Нет одинаковых чисел в массиве.");
            else {
                for (int i = 0; i < array.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Элемент: {array[i]} встречается в массиве {array[i + 1]} раз");
                    }
                }
            }
        }

        /// <summary>
        /// Выявление одинаковых чисел в массиве
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns></returns>
        private static List<int> checkValues(List<int> array) {
            List<int> temp = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[i] == array[j] && checkAvailability(temp, array[i])) {
                        temp.Add(array[i]);
                        temp.Add(considerValues(array, array[i]));
                        break;
                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// Проверка на присутствие в результативном массиве одинаковых элементов
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static bool checkAvailability(List<int> array, int n) {
            if (array.Count == 0) return true;
            else {
                for (int i = 0; i < array.Count; i++)
                {
                    if (i % 2 == 0 && array[i] == n) return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Посчет одинаковых элементов в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int considerValues(List<int> array, int n)
        {
            int count = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == n)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
