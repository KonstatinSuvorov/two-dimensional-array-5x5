using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Дан двумерный массив размерностью 5×5, заполнен-
ный случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных
между минимальным и максимальным элементами.
*/

namespace ConsoleApplication1
{
    class Program
    {
        private static int n, m;

        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] MyArray = new int[5, 5];

          

            Console.WriteLine("This is our start array: ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MyArray[i, j] = rand.Next(-100, 101);
                    Console.Write(MyArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            IEnumerable<int> ConvertedArray = MyArray.Cast<int>();

            int MinValue = ConvertedArray.Min();

            int MaxValue = ConvertedArray.Max();

            Console.WriteLine("Минимальное значение массива: " + MinValue);

            Console.WriteLine("Максимальное значение массива: " + MaxValue);

            int IndexRMin = 0, IndexCMin = 0, IndexRMax = 0, IndexCMax = 0, Sum = 0;
            //ищем  максимум и минимум
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (MyArray[i, j] == MinValue)
                    {
                        IndexRMin = i;
                        IndexCMin = j;
                    }
                    if (MyArray[i, j] == MaxValue)
                    {
                        IndexRMax = i;
                        IndexCMax = j;
                    }
                }
            }

            Console.WriteLine("Позиция минимального значения: " + IndexRMin + IndexCMin);

            Console.WriteLine("Позиция максимального значения: " + IndexRMax + IndexCMax);

            
            for (int i = IndexRMin; i < IndexRMax; i++)
            {
                for (int j = IndexCMin; j < IndexCMax; j++)
                {
                    if (MyArray[i, j] == MyArray[IndexRMin, IndexCMin])
                    {
                        j++;
                    }
                    Sum += MyArray[i, j];
                }
            }
            int k = 0, s = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == IndexRMin && j == IndexRMin) { ++k; continue; }
                    if (i == IndexRMax && j == IndexRMax) { ++k; continue; }

                    if (k == 1)
                    {
                        Console.WriteLine(MyArray[i, j] << ' ');
                        s += MyArray[i, j];
                    }
                }
            }
            Console.WriteLine("Summa = : " + Sum);
            Console.ReadKey(); 
        }
    }
}