using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwitchFallThrough
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program prg = new Program();
            
            TestSwitchFallThrough();
            Console.ReadLine();
        }

        public static void TestSwitchFallThrough()
        {
            DateTime dt = DateTime.Today; //without break statement it "Falls Throught till first break"
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                Console.WriteLine("Today is a weekday");
                break;
                default:
                Console.WriteLine("Today is a weekend day");
                break;


            }


        }
    }
}
