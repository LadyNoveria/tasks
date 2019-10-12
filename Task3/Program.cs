using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //№3 В массиве из N чисел найти первый нулевой элемент (его номер)
            List<int> arr = new List<int>();
            filling(ref arr);
            printInfoList(arr, "Исходный массив: ");
            Pause();
        }

        /// <summary>
        /// Заполнение массива элементами
        /// </summary>
        /// <returns></returns>
        private static void filling(ref List<int> arr)
        {
            //завершить ввод при вводе пользователем q
            Console.WriteLine("Чтобы закончить ввод, введите q");
            int i = 1;
            while (true)
            {
                Console.Write($"Введите {i}-й элемент массива: ");
                string str = Console.ReadLine();
                if (str != "q")
                {
                    try
                    {
                        arr.Add(int.Parse(str));
                        i++;
                    }
                    catch
                    {
                        Console.WriteLine("Неверный формат. Введите целое число.");
                    }
                }
                else break;
            }
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
        private static void printInfoList(List<int> array, string str)
        {
            if (array.Count == 0)
            {
                Console.WriteLine("Вы не ввели ни одного элемента");
            }
            else
            {
                int position = 0;
                int value = 1;
                Console.WriteLine("");
                Console.WriteLine(str);
                for (int i = 0; i < array.Count; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] == 0) {
                        position = i;
                        value = 0;
                        break;
                    }
                }

                Console.WriteLine("");
                if (value == 1) Console.WriteLine("Массив не содержит нулевых элементов");
                else Console.WriteLine($"Позиция первого нулевого элемента массива: {position}");
            }

        }
    }
}
