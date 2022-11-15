using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class PowerOfNumber
    {
        public static void PowerOfTwo()
        {

            // FOR N TH NUMBER OF POWER OF 2 

            int base_num = 2;
            Console.WriteLine("enter a power number");
            int power_num = Convert.ToInt32(Console.ReadLine());
            // Only works if 0 <= N < 31 

            if (power_num > 0 && power_num < 31)
            {
                for (int i = 1; i <= power_num; i++)
                {
                    Console.WriteLine("base {0} and power of is {1}", base_num, i);
                    Console.WriteLine(Math.Pow(base_num, i));
                }
            }
            else
            {
                Console.WriteLine("invalid power no ");
            }


        }
    }
}
