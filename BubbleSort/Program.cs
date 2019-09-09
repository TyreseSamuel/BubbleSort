using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static int swaps = 0;
        static int loops = 0;
        static int passes = 0;

        static void Main(string[] args)
        {
            bool Sorted = false;

            //int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            int[] arrayToSort = { 14, 65, 63, 1, 54, 89, 84, 9, 98, 57, 71, 18, 21, 84, 69, 28, 11, 83, 13, 42, 64, 58, 78, 82, 13, 9, 96, 14, 39, 89, 40, 32, 51, 85, 48, 40, 23, 15, 94, 93, 35, 81, 1, 9, 43, 39, 15, 17, 97, 52 };
            int swaps = 0;
            int loops = 0;

            Console.Write(arrayToSort);
            Console.WriteLine(arrayToSort[0]);
            Console.WriteLine(arrayToSort[1]);
            Console.WriteLine(arrayToSort[2]);
            Console.WriteLine(arrayToSort[3]);
            Console.WriteLine(arrayToSort[4]);
            Console.WriteLine(arrayToSort[5]);
            Console.WriteLine(arrayToSort[6]);

            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swaps);

            while (!Sorted)
            {
                Sorted = true;
                int t;

                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        t = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i - 1] = t;
                        Sorted = false;
                        swaps++;
                    }
                    loops++;
                }
                for (int i = arrayToSort.Length - passes - 2; i > passes; i--)
                {
                    if (arrayToSort[i] > arrayToSort[i - 1])
                    {
                        t = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i - 1];
                        arrayToSort[i - 1] = t;
                        Sorted = false;
                        swaps++;
                    }
                    loops++;
                }

                Console.ReadKey();
            
        }

        public static void OptimizedBubbleSort(int[] arrayToSort)
        {
            int swaps = 0;
            int loops = 0;
            int passes = 0;
            bool Sorted = false;

            while (!Sorted)
            {
                Sorted = true;
                int t;

                for (int i = passes; i < arrayToSort.Length - passes - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        t = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i - 1] = t;
                        Sorted = false;
                        swaps++;
                    }
                    loops++;
                }
                for (int i = arrayToSort.Length - passes - 2; i > passes; i--)
                {
                    if (arrayToSort[i] > arrayToSort[i - 1])
                    {
                        t = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i - 1];
                        arrayToSort[i - 1] = t;
                        Sorted = false;
                        swaps++;
                    }
                    loops++;
                }

            }
            Console.WriteLine(arrayToSort[0]);
            Console.WriteLine(arrayToSort[1]);
            Console.WriteLine(arrayToSort[2]);
            Console.WriteLine(arrayToSort[3]);
            Console.WriteLine(arrayToSort[4]);
            Console.WriteLine(arrayToSort[5]);
            Console.WriteLine(arrayToSort[6]);

            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swaps);


            Console.ReadKey();
        }
        /*public static void CocktailShakerSort(int[] arrayToSort)
        {
            int swaps = 0;
            int loops = 0;
            int passes = 0;
            bool Sorted = false;

            while (!Sorted)
            {
                Sorted = true;
                int t;

                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        t = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = t;
                        Sorted = false;
                        swaps++;
                    }
                    loops++;
                }

            }
            Console.WriteLine(arrayToSort[0]);
            Console.WriteLine(arrayToSort[1]);
            Console.WriteLine(arrayToSort[2]);
            Console.WriteLine(arrayToSort[3]);
            Console.WriteLine(arrayToSort[4]);
            Console.WriteLine(arrayToSort[5]);
            Console.WriteLine(arrayToSort[6]);

            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swaps);

            Console.ReadKey();
        }*/
    }
}