using System;
using System.Collections.Generic;

namespace insertionsortcsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 10, 12, 3, 4, 5, 65, 454, 32, 14, 63, 34, 343, 2356, 123, 143, 321, 432, 156 };

            InsertionSort(array, array.Length);

            Console.WriteLine(String.Join(", ", array));
            Console.ReadLine();

        }

        /// <summary>
        /// Sorts an list using the Insertion Sorting Algorithm.
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="array">Sorted or Unsorted List.</param>
        /// <param name="num">Pointer, defaulted to 0.</param>
        static void InsertionSort(int[] array, int num = 0)
        {
            // Check if input array is empty (this is called the basecase) 
            if (num <= 1)
            {
                return;
            }

            InsertionSort(array, num - 1);

            int lastNum = array[num - 1];
            int index = num - 2;
              
            while (index >= 0 && array[index] > lastNum)
            {
                array[index + 1] = array[index];
                index--;
            }
            array[index + 1] = lastNum;
        }

    }
}