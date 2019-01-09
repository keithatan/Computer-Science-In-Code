using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_recursion
	{
	class Program
		{

		/// <summary>
		/// This function will return the Fibonacci numbers for givin num.
		/// </summary>
		/// <param name="num"></param>
		/// <returns>Fibonacci numbers</returns>
		static int Fibonacci(int num) {
			if(num == 1 || num == 2) {
				return 1;
			} else {
				return Fibonacci ( num - 1 ) + Fibonacci ( num - 2 );
			}

		}

		static void Main ( string[] args )
			{
			Console.WriteLine (Fibonacci(10));
			Console.ReadKey ( );
			}
		}
	}
