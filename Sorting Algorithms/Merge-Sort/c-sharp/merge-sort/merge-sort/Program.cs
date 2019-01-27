using System;
using System.Collections.Generic;
using System.Linq;


//NOTE: SPLITTING WORKS ON LINE +72
//NOTE: THE RETURN ARRAY IS NOT CORRECT NEEDS REFRACTORING

namespace mergesort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 2000, 8, 1, 4, 14, 7, 16, 10, 9, 3 };
            int[] sortedArray = Mergesort(array); 
            Console.WriteLine(String.Join(", ", sortedArray));
            Console.ReadLine();
        }

        /// <summary>
        /// Merge the specified left and right.
        /// </summary>
        /// <returns>The merge.</returns>
        /// <param name="left">Left.</param>
        /// <param name="right">Right.</param>
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
                result.Add(left[leftIndex]);
            }
            else if(rightIndex < right.Length)
            {
                result.Add(right[rightIndex]);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Mergesort the specified array.
        /// </summary>
        /// <returns>The mergesort.</returns>
        /// <param name="array">Array.</param>
        public static int[] Mergesort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            double math = array.Length / 2;
            int middle = Convert.ToInt32(Math.Floor(math));
            int[] left = array.Take(middle).ToArray();
            int[] right = array.Skip(middle).ToArray();
            Console.WriteLine(String.Join(", ", left));
            Console.WriteLine(String.Join(", ", right));


            return Merge(left, right);
        }
    }
}
