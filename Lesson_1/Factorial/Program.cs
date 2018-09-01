using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
            Console.ReadLine();
        }
    public static int Factorial (int n)
        {
            if (n == 0) //if TRUE
            {
                return 1; //base case 

            }
            else
            {

                return n * Factorial(n - 1);
            }

        }
    }
}
