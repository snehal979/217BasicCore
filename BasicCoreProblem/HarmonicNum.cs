using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class HarmonicNum
    {
        public static void HarmonicNumber(int Hnum)
        {
            Console.WriteLine("Harmonic Number series for n th number");
            //harmonic number serie = (1/1 + 1/2 + ... + 1/N)

            double har_num = 0.0;
            
            if (Hnum > 0)
            {
                for (double i = 1.0; i <= Hnum; i++)
                {

                    har_num += 1/i;

                    Console.WriteLine("harmanic number 1/{0} and their sum of harmonic number {1}", i, har_num);
                }

            }
            else
            {
                Console.WriteLine("the hamonic number is positive");
            }


        }
    }
}
