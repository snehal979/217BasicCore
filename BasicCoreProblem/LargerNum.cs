using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class LargerNum
    {
        public static void LargenNumber(int num1,int num2,int num3)
        {
            

            if (num1>num2)
            {
                if (num1>num3)
                {
                    Console.WriteLine("{0} is greater number than another two number", num1);
                }
                else
                {
                    Console.WriteLine("{0} is greater number than another two number", num3);
                }

            }
            else if (num2>num3)
            {
                Console.WriteLine("{0} is greater number than another two number", num2);
            }

        }
    }
}
