using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileTest();
            Console.ReadLine();
        }
     private static void WhileTest()
        {
            int i = 1;
            while (i <= 5)//till TRUE
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }

        }

    }

}
