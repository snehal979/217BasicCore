using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class LeapYear
    {
        public static void CheckLeapYear(int year)
        {
            
            if (year.ToString().Length == 4)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0} is the leap year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not leap year", year);
                }
            }
            else
            {
                Console.WriteLine("Enter 4 digit leap year");
            }
        }
    }
}
