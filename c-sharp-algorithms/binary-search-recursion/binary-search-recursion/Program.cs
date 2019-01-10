using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace binary_search_recursion
	{
	class Program
		{
		/// <summary>
		/// Takes in a source array and a number to search for using the binary search method.
		/// </summary>
		/// <param name="source">An array of integers.</param>
		/// <param name="search">The number to find in the array.</param>
		/// <returns>True if found, False if not found.</returns>
		static bool BinarySearchAlgorithm ( int[] source, int search ) {
			//split the array by the middle number
			int middle = Convert.ToInt16(Math.Floor(Convert.ToDouble( source.Length / 2 )));

			if( source[middle] == search )
				{
				// 
				return true;
				}
			else if( source.Length <= 1 )
				{
				// if array is empty or 1, we have tried all choices number does not exist
				return false;
				}
			else
				{
				if( source[middle] < search )
					{
					// if middle is smaller then we go right
					int[] right = source.Skip(middle).ToArray();
					// call the function again with the right array
					return BinarySearchAlgorithm(right, search);

					}
				else if( search < source[middle] )
					{
					// if middle is smaller then we go left 
					int[] left = source.Take(middle).ToArray();
					// call the function again with the left array
					return BinarySearchAlgorithm(left, search);

					}
				}
			return false;
		}

		/// <summary>
		///  Function will generate a list for testing
		/// </summary>
		/// <param name="cout"></param>
		/// <returns></returns>
		static int[] listMaker(int cout) {
				List<int> list = new List<int>();
				for( int i = 0; i < cout; i++ )
					list.Add(i);
				return list.ToArray();
			}

		static void Main ( string[] args )
			{  
			Console.WriteLine (BinarySearchAlgorithm(listMaker(100), 230 )); // false 
			Console.ReadKey ( );
			}
		}
	}
