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
		static int binarySearch(int[] source, int search) {
			//split the array by the middle number
			int middle = Math.Floor ( source.Length / 2 );

			if (source[middle] == search) {
				// 
				return true;
			}
		}

		static void Main ( string[] args )
			{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			Console.WriteLine ( "Hello World!" );
			Console.ReadKey ( );

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
			}
		}
	}
