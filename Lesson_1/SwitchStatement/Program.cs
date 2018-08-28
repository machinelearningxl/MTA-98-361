using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TestSwith(3, 4, '+');
            TestSwith(3, 4, '*');
            TestSwith(3, 4, '5');
            Console.ReadLine();
        }

        public static void TestSwith(int op1, int op2, char opr)
        {
            int result=0;
            switch (opr)
            {
                case '+': //if true
                    result = op1 + op2;
                    break;
                case '-': // if true
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown operator");
                    return;
            }

            Console.WriteLine("Result:{0}", result);
            return;

        }

    }
}
