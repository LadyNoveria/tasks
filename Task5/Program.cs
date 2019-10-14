using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*№5 Задать массив 10 чисел. Воспользовавшись вспомогательным массивом, 
            элементы исходного массива циклически сдвинуть на 6 позиций вправо.*/
            Console.WriteLine("Задать массив 10 чисел. Воспользовавшись вспомогательным массивом, \n элементы исходного массива циклически сдвинуть на 6 позиций вправо.");
            List<int> arr = new List<int>();
            List<int> newArr = new List<int>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            shift(arr, ref newArr);
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
            int sizeArray = 10;
            Random rnd = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
                arr.Add(rnd.Next(minA, maxA));
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
        /// Сдвиг массива на заданное количество позиций вправо
        /// </summary>
        /// <param name="arr">исходный массив</param>
        /// <param name="newArr">результирующий массив</param>
        private static void shift(List<int> arr, ref List<int> newArr) {
            //количество позиций для сдвига
            int position = 6;
            for (int i = position; i < arr.Count; i++) {
                newArr.Add(arr[i]);
            }
            for (int i = 0; i < position; i++)
            {
                newArr.Add(arr[i]);
            }
        }
    }
}
