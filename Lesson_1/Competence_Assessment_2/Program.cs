using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence_Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(3));
            Console.ReadLine();

        }

        public static int Factorial(int n)
        {
            Console.WriteLine(n); //prints out what value is holding in the Stack
            int fact = 1;
            if (n == 1)
            {
                return fact;
            }
            else
            {
              fact = Factorial(n-1) * n;
              return fact;
                
            }



        }
    }
}
