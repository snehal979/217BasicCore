using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class SwapNumber
    {
        public static void SwapTwoNumber(int a,int b)
        {
            
            Console.WriteLine("befor the swap a={0} and b= {1}", a, b);

            a=b; //a=5
            b=a*b; // b=5*5
            a=b; //a=25
            Console.WriteLine("after the swap a={0} and b={1}", a, b);
        }
    }
}
