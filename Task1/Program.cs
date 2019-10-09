using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //№ 1 Элементы заданного 8 числами массива расположить в обратном порядке.
            int[] array = filling();
            printArray(array, "Исходный массив: ");
            int[] newArray = sortArray(array);
            printArray(newArray, "Полученный массив: ");
            Pause();
        }
        /// <summary>
        /// Заполнение массива элементами
        /// </summary>
        /// <returns></returns>
        private static int[] filling()
        {

            int n = 8;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                arr[i] = checkInt();
            }
            return arr;
        }
        /// <summary>
        /// Проверка на целое число
        /// </summary>
        /// <returns></returns>
        private static int checkInt()
        {
            int temp = 0;
            bool flag;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out temp);
                if (!flag) Console.Write("Неверный формат. Введите целое число: ");
            } while (!flag);

            return temp;
        }
        /// <summary>
        /// Задержка экрана
        /// </summary>
        private static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="str">текст</param>
        private static void printArray(int[] array, string str)
        {
            Console.WriteLine("");
            Console.WriteLine(str);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        /// <summary>
        /// Сортировка массива - задом наперед
        /// </summary>
        /// <param name="array">исходный массив</param>
        /// <returns></returns>
        private static int[] sortArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[j] = array[i];
                j++;
            }
            return newArray;
        }
    }
}
