namespace BasicCoreProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hint 1.leapyear\n 2.swapnumber \n 3.even odd \n 4.largenumber \n 5. harmonic number\n " +
                "6.primefactor\n 7.filpcoin\n 8.alphabate\n 9.divison\n10.powerofnumber");


            int choice = Convert.ToInt32(Console.ReadLine());
           
           
            if(choice == 1)
            {
                Console.WriteLine("the year is leap or not leap year");
                Console.WriteLine("enter a year");
                int year = Convert.ToInt32(Console.ReadLine());
                LeapYear.CheckLeapYear(year);
            }
            else if (choice== 2)
            {
                int a, b;
                Console.WriteLine("enter the value of a and b");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                SwapNumber.SwapTwoNumber(a,b);
            } else if (choice == 3)
            {
                Console.WriteLine("The enter number is even or odd");
                int num = Convert.ToInt32(Console.ReadLine());
                EvenOddNum.EvenOrOdd(num);

            } else if (choice ==4)
            {
                int num1, num2, num3;
                Console.WriteLine("Enter the three number");
                num1=Convert.ToInt32(Console.ReadLine());
                num2=Convert.ToInt32(Console.ReadLine());
                num3=Convert.ToInt32(Console.ReadLine());
                LargerNum.LargenNumber(num1,num2,num3);

            } else if (choice == 5)
            {
                Console.WriteLine("enter the harmonic nth number");
                int Hnum = Convert.ToInt32(Console.ReadLine());
                HarmonicNum.HarmonicNumber(Hnum);

            } else if (choice==6)
            {
                Console.WriteLine("Enter the number for prime factor");
                int number = Convert.ToInt32(Console.ReadLine());
                PrimeFactor.primefactornumber(number);
            } else if (choice ==7)
            {
                FilpCoinPercentage.flipcountpercentage();
            } else if (choice ==8)
            {
                Alphabate.VowelAndConsonant();
            }
            else if (choice ==9)
            {
                division.QuoteientRemainder();
            }
            else if (choice ==10)
            {
                PowerOfNumber.PowerOfTwo();
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
            
    }
}
