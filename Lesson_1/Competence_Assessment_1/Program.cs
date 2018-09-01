using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            discount(23);
            Console.ReadLine();
        }

        private static void discount(int quantity)
        {
            if (quantity < 10)
            {
                Console.WriteLine("Discount 5%");
            }
            else if (quantity < 50)
            {
                Console.WriteLine("Dicount 10%");
                
            }

            else if (quantity < 100)
            {
                Console.WriteLine("Discount 15%");
            }
            else
            {

                Console.WriteLine("Dicount 20%");
            }


        }
    }
}
