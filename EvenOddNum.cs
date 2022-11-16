using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class EvenOddNum
    {
        public static void EvenOrOdd(int num)
        {

            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} the given number is even", num);
                }
                else
                {
                    Console.WriteLine("{0} the given number is odd", num);
                }
            }
            else
            {
                Console.WriteLine("Enter positive number");
            }

        }
    }
}
