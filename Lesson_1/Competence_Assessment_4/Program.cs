using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Scenario 1-4: Creating a Recursive Algoritm
//You are developing a library of utility functions for your application.You need to write a method that
//takes an integer and counts the number of significant digits in it.You need to create a recursive
//program to solve the problem.How would you write such a program?

namespace Competence_Assessment_4
{
    class Program
    {

        private static int Significant_Dig(int x)//with Recursion
        {

            if (x < 10)
            {
                return 1;
            }
            else
            {
                return 1 + Significant_Dig(x / 10);
            }
        }

        //private static int Significant_NoRec(int x) //without Recursion
        //{

        //    int temp = 1;

        //    while (x > 9)
        //    {
        //        x = x / 10;
        //        temp = temp + 1;
        //    }

        //    return temp;
        //}

        static void Main(string[] args)
        {

            Console.WriteLine("The significant numer is: {0} ",Significant_Dig(5653));
            //Console.WriteLine("The significant numer is: {0}", Significant_NoRec(-120));
            Console.ReadLine();

            
        }
    }
}
