using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_recursion
{
    class Program
    {
		///<summary>
		///This function will return the factorial of any givin <num>
		///</summary>
        static int factorial(int num)
        {
            // base case 
            if(num == 0 || num == 1) {
                return 1;
            } else {
            // recursion
				return num * factorial(num - 1);
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(factorial(10));
            Console.ReadKey();
        }
    }
}
