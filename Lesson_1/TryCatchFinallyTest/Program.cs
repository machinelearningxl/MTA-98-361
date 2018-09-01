using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchFinallyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinalyTest();
            Console.ReadLine();
        }

        private static void TryCatchFinalyTest()
        {
            StreamReader sr = null;
            try
            {    
                sr = File.OpenText("data.txt"); //TryCatchFinallyTest\bin\Debug folder
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
                                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

            }


        }
    }
}
