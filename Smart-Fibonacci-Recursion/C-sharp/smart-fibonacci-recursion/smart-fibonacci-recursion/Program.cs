using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_fibonacci_recursion
	{
	class Program
		{
		//Question: How many additions are necessary to calculate the  with smart_fibonacci(1000)?

		static int SmartFibonacci (int num) {
			int a = 0;
			int b = 1;
			
			if(num == 0) {
				return a + 0;
			}

			int additions = 0;

			for (int i = 0; i < num; i++) {
				a = b;
				b = a + b;
				additions++;
			}

			return b + additions - 1;
		}

		static void Main ( string[] args )
			{

			Console.WriteLine ( SmartFibonacci(40) );
			Console.ReadKey ( );
			}
		}
	}