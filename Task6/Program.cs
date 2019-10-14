using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"№6 Задать массив 12 чисел, содержащий несколько нулей. 
                Воспользовавшись вспомогательным массивом, все нулевые элементы перенести в начало, 
                а остальные - в конец.");
            List<int> arr = new List<int>();
            List<int> newArr = new List<int>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            sortArr(arr, ref newArr);
            printInfoList(newArr, "Сдвинутый массив: ");
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
            int minA = 0;
            int maxA = 10;

            //размер массива
            int sizeArray = 12;
            Random rnd = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
                arr.Add(rnd.Next(minA, maxA));
            }

            int amountNull = rnd.Next(minA, maxA);
            //заполнение массива рандомным количеством нулей
            for (int i = 0; i < amountNull; i++)
            {
                arr[rnd.Next(minA, maxA)] = 0;
            }
        }

        /// <summary>
        /// Печать исходного массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="str">сообщение</param>
        private static void printInfoList(List<int> array, string str)
        {
            Console.WriteLine("");
            Console.WriteLine(str);
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        /// <summary>
        /// Перемещение всех нулевых элементов в начало массива
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="newArr">результирующий массив</param>
        private static void sortArr(List<int> arr, ref List<int> newArr)
        {
            for (int i = 0; i < arr.Count; i++) {
                if (arr[i] == 0)
                {
                    newArr.Add(0);
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != 0)
                {
                    newArr.Add(arr[i]);
                }
            }
        }
    }
}
