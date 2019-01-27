using System;
using System.Collections.Generic;

namespace insertionsortcsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] array = new int[] { 10, 12, 3, 4, 5, 65, 454, 32, 14, 63, 34, 343, 2356, 123, 143, 321, 432, 156 };
            int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Console.WriteLine("program started");
            //Console.WriteLine(insertionSort(array, 0));
            //Console.WriteLine("program ended");
            //Console.ReadLine();
            Console.WriteLine(String.Join(", ", array));
            Console.WriteLine(String.Join(", ", Insert(array, 34)));
            Console.ReadLine();

        }


        /// <summary>
        /// Function will insert a number into a SORTED list.
        /// </summary>
        /// <returns>Array with number insorted in a relevant position.</returns>
        /// <param name="list">Sorted list</param>
        /// <param name="number">Number to be inserted.</param>
        public static List<int> Insert(int[] list, int number)
        {
            // create new list and 
            List<int> newList = new List<int>();
            bool hasBeenInserted = false;

            if (!hasBeenInserted)
            {
                if (number < list[0])
                {
                    newList.Add(number);
                    hasBeenInserted = true;
                } 
            }

            for (int i = 0; i < list.Length - 1; i++)
            {
                // add pointer first
                newList.Add(list[i]);

                // first check if we have already added the number
                if (!hasBeenInserted)
                {
                    // check if the number fits between the current pointer and the ahead number
                    if (list[i] < number && number < list[i+1])
                    {
                        // insert number and note it
                        newList.Add(number);
                        hasBeenInserted = true;
                    }
                }
            }

            // insert last number into list
            newList.Add(list[list.Length - 1]);

            if (!hasBeenInserted)
            {
                // check if number is larger then the last number in the list
                if (list[list.Length - 1] < number)
                {
                    newList.Add(number);
                }
            }

            return newList;
        }

        /// <summary>
        /// Sorts an list using the Insertion Sorting Algorithm.
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="list">Sorted or Unsorted List.</param>
        /// <param name="pointer">Pointer, defaulted to 0.</param>
        public static int[] InsertionSort(int[] list, int pointerIndex = 0)
        {
            // keep track of:
            List<int> sortedList = new List<int>();

            // check number to right
            // if the number to the right is larger then make it the pointer and toss the old pointer into the sortedList
            // if number is larger then toss the right number to the sortedList

        }
    }
}