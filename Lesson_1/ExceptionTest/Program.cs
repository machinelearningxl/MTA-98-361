using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {

                sr = File.OpenText(@"c:/data.txt");
                Console.WriteLine(sr.ReadToEnd());
                Console.ReadLine();
            }
           catch(FileNotFoundException fnfe)
           {

                Console.WriteLine(fnfe.Message);
                Console.ReadLine();

            }

            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }





        }
    }
}
