using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_fibonacci_recursion
	{
	class Program
		{

		static int SmartFibonacci (int num) {
			int a = 0;
			int b = 1;
			

			for (int i = 0; i < num; i++) {
				a = b;
				b = a + b;
			}
			return b;
		}

		static void Main ( string[] args )
			{

			Console.WriteLine ( SmartFibonacci(1000) );
			Console.ReadKey ( );
			}
		}
	}
