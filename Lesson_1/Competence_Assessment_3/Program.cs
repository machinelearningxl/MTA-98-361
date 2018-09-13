using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Scenario 1-3: Handeling Exceptions
//You are writing cide for a simple arithmetic library. You decided to create to create a method named
//Divide that takes two arguments, x and ym and returns the value of x/y, You need to catch
//any arithmetic expetion that might to be thrown for error in arithmetic, casting or data type conversion. 
//You also need to catch any other exception that may throwen from the code.

namespace Competence_Assessment_3
{
    class Program
    {

        private static double Divide(int x , int y)
        {
            return x / y;
                
        }

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine(Divide(5,0));
                
            }

            //only one exception will be executed, most specific one first

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
            Console.ReadLine();
        }

    }
}
