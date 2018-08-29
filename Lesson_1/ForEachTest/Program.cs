using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program(); //Object created 
            pr.ForEachTest();
            Console.ReadLine();

        }

        void ForEachTest()
        {
            int[] numbers = {1,2,3,4,5};
            foreach(int i in numbers)
            {

                Console.WriteLine("The value of i= {0}", i);
            }

        }
    }
}
