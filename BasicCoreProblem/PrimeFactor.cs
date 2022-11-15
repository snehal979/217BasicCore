using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class PrimeFactor
    {
        public static void primefactornumber(int number)
        {
           

            while (number % 2 == 0) // even number
            {
                Console.WriteLine(2);
                number /= 2;


            }


            for (int j = 3; j < number; j+=2) // j = j+2 odd number
            {
                while (number % j == 0)
                {
                    Console.WriteLine(j);
                    number /= j;
                }

            }
            // prime number is always greater than 2
            if (number > 2)
            {
                Console.WriteLine(number);
            }





        }
    }
}
