﻿using System;
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
            Console.WriteLine(Factorial(3));
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
                int result= Factorial(n - 1);
                return n * result;
            }

        }
    }
}
