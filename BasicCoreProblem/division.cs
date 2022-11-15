using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class division
    {
        public static void QuoteientRemainder()
        {
            int Quotient, Remainder;
            Console.WriteLine("enter a number divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number dividor");
            int dividor = Convert.ToInt32(Console.ReadLine());

            Quotient = divident/ dividor;
            Remainder = divident% dividor;
            Console.WriteLine("quotitent {0} and remainder {1} ", Quotient, Remainder);
        }
    }
}
