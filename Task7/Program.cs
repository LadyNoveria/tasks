using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"№7 Даны 2 упорядоченных массива, каждый из 4-х слов. Слить их в один.");
            List<string> arr1 = new List<string>();
            List<string> arr2 = new List<string>();
            List<string> resultArray = new List<string>();
            filling(ref arr1, 1);
            filling(ref arr2, 2);
            sortArr(ref arr1);
            sortArr(ref arr2);
            printInfoList(arr1, "Массив 1: ");
            printInfoList(arr2, "Массив 2: ");
            union(arr1, arr2, ref resultArray);
            sortArr(ref resultArray);
            printInfoList(resultArray, "Объединенный массив: ");
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
        private static void filling(ref List<string> arr, int n)
        {
            int sizeArray = 4;
            for (int i = 0; i < sizeArray; i++) {
                Console.WriteLine($"Введите {i + 1}-е слово для массива {n}");
                arr.Add(Console.ReadLine());
            }
        }

        /// <summary>
        /// Печать исходного массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="str">сообщение</param>
        private static void printInfoList(List<string> array, string str)
        {
            Console.WriteLine("");
            Console.WriteLine(str);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        /// <summary>
        /// Упорядочение массива по возрастанию
        /// </summary>
        /// <param name="arr">исходный массив</param>
        private static void sortArr(ref List<string> arr)
        {
            for (int i = arr.Count - 1; i > 0; i--) {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j].Length > arr[i].Length) {
                        string temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Объединение массивов
        /// </summary>
        /// <param name="arr1">массив 1</param>
        /// <param name="arr2">массив 2</param>
        /// <param name="resultArray">результирующий массив</param>
        private static void union(List<string>  arr1, List<string> arr2, ref List<string> resultArray) {
            for (int i = 0; i < arr1.Count; i++) {
                resultArray.Add(arr1[i]);
            }

            for (int i = 0; i < arr2.Count; i++)
            {
                resultArray.Add(arr2[i]);
            }
        }
    }
}
