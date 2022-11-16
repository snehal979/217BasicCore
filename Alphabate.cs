using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class Alphabate
    {
        public static void VowelAndConsonant()
        {
            Console.WriteLine("enter the alphabet A-Z and a-z");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
            // a, e, i, o, u 
            if (ch == 'a' || ch == 'e' ||ch == 'i' ||ch == 'o' ||ch == 'u' || ch == 'A' ||ch == 'E' ||ch == 'I' ||ch == 'O' ||ch == 'U')
            {
                Console.WriteLine("{0} is vowel alphabet", ch);
            }
            else
            {
                Console.WriteLine("{0} alphabet is consonant", ch);
            }
        }
    }
}
