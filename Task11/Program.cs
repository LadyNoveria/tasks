using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"№11 Задать массив из 6 слов. Удалить слова, начинающиеся на  “ко”.");
            List<string> arr = new List<string>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            deleteItems(ref arr);
            printInfoList(arr, "Полученный массив: ");

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
        private static void filling(ref List<string> arr)
        {
            //размер массива
            int sizeArray = 6;

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                arr.Add(Console.ReadLine());
            }
        }

        /// <summary>
        /// Печать массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="str">сообщение</param>
        private static void printInfoList(List<string> array, string str)
        {
            Console.WriteLine(str);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Удаление из массива слов, начинающихся на "ко"
        /// </summary>
        /// <param name="array"></param>
        private static void deleteItems(ref List<string> array) {
            string subStr = "ко";
            for (int i = 0; i < array.Count; i++) {
                string str = array[i];
                int indexOfSubstring = str.IndexOf(subStr);
                if (indexOfSubstring == 0) {
                    array.Remove(str);
                    i--;
                }

            }
        }
    }
}
