using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_operation_counter
	{
	class Program
		{

		/// <summary>
		/// This function will count how many operations are ran when using the fibonacci solving recusive method
		/// </summary>
		/// <param name="num"></param>
		/// <returns>the number of operations to calculate the fib number</returns>
		static int FibonacciOperationsCounter(int num){
			if(num == 1 || num == 2) {
				return 0;
			} else {
				return 1 + FibonacciOperationsCounter ( num - 1 ) + FibonacciOperationsCounter ( num - 2 );
			}
		}

		static void Main ( string[] args )
			{
			Console.WriteLine ("Counting operations........");
			Console.WriteLine (FibonacciOperationsCounter(40));
			// returns 102334154  for the 40th fib number
			Console.ReadKey ( ); 
			}
		}
	}
