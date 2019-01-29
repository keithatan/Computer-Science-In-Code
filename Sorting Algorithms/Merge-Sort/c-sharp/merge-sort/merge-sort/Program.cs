using System;
using System.Collections.Generic;
using System.Linq;

namespace mergesort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 2000, 8, 1, 4, 14, 7, 16, 10, 9, 3 };
            int[] sortedArray = Mergesort(array); 
            Console.WriteLine("Sorted: " + String.Join(", ", sortedArray));
            Console.ReadLine();
        }

        /// <summary>
        /// Merge the specified left and right arrays.
        /// </summary>
        /// <returns>The merged arrays.</returns>
        /// <param name="left">Left array.</param>
        /// <param name="right">Right array.</param>
        public static int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while(leftIndex < left.Length && rightIndex < right.Length)
            {
                if(left[leftIndex] <= right[rightIndex])
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            if(leftIndex < left.Length)
            {
                int[] half = left.Skip(leftIndex).ToArray();
                result.AddRange(half);
                //result.Add(left[leftIndex]);
            }
            else if(rightIndex < right.Length)
            {
                int[] half = right.Skip(rightIndex).ToArray();
                result.AddRange(half);
                //result.Add(right[rightIndex]);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Mergesort is the main function of the sorting algorithm it deals with the recursion.
        /// </summary>
        /// <returns>Array sorted with the mergesort method.</returns>
        /// <param name="array">Array</param>
        public static int[] Mergesort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            double math = array.Length / 2;
            int middle = Convert.ToInt32(Math.Floor(math));
            int[] leftInital = array.Take(middle).ToArray();
            int[] rightInital = array.Skip(middle).ToArray();

            int[] left = Mergesort(leftInital);
            int[] right = Mergesort(rightInital);
            return Merge(left, right);
        }
    }
}
