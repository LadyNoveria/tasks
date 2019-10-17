using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"№8 массиве из 12 чисел найти сумму тех чисел массива, 
            которые расположены между минимальным и максимальным.");
            List<int> arr = new List<int>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            int min = findMin(arr);
            int max = findMax(arr);
            Console.WriteLine($"min: {min} max: {max}");
            int sum = findSum(min, max, arr);
            Console.WriteLine($"Сумма чисел между минимальным и максимальным: {sum}");

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
            //минимальное и максимальное значения элементов массива
            int minA = -100;
            int maxA = 100;

            //размер массива
            int sizeArray = 12;
            Random rnd = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
                arr.Add(rnd.Next(minA, maxA));
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

        private static int findMin(List<int> array) {
            int min = array[0];
            for (int i = 1; i < array.Count; i++) {
                if (min > array[i]) min = array[i];
            }
            return min;
        }

        private static int findMax(List<int> array)
        {
            int max = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                if (max < array[i]) max = array[i];
            }
            return max;
        }

        private static int findSum(int min, int max, List<int> array) {
            int sum = 0;
            Console.WriteLine("Подходящие значения массива: ");
            for (int i = 0; i < array.Count; i++) {
                if (array[i] > min && array[i] < max) {
                    sum += array[i];
                    Console.Write($"{array[i]} ");
                }
            }
            Console.WriteLine("");
            return sum;
        }
    }
}
