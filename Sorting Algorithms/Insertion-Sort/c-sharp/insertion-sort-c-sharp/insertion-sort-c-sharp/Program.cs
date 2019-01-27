using System;
using System.Collections.Generic;

namespace insertionsortcsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 10, 12, 3, 4, 5, 65, 454, 32, 14, 63, 34, 343, 2356, 123, 143, 321, 432, 156 };
            //Console.WriteLine("program started");
            //Console.WriteLine(insertionSort(array, 0));
            //Console.WriteLine("program ended");
            //Console.ReadLine();

            Console.WriteLine(insert(array, 24));
            Console.ReadLine();

        }

        public static List<int> insert(int[] array, int number)
        {
            List<int> newArray = new List<int>();
            bool hasBeenInserted = false;

            if (!hasBeenInserted)
            {
                if (array[0] > number)
                {
                    newArray.Add(number);
                    hasBeenInserted = true;
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (!hasBeenInserted)
                {
                    if (array[0] > number)
                    {
                        newArray.Add(number);
                        hasBeenInserted = true;
                    }
                }
                else
                {
                    newArray.Add(array[i]);
                }
            }

            return newArray;
        }

        //public static int[] insertionSort(int[] array, int pointer)
        //{

        //}
    }
}