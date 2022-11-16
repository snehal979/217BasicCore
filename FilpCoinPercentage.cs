using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class FilpCoinPercentage
    {
        public static void flipcountpercentage()
        {
            //variable
            int total_count = 0;
            int headcount = 0;
            int tailcount = 0;
            int percentage_head, percentage_tail;

            Console.WriteLine("enter a flipcount number"); // input
            int flipcount = Convert.ToInt32(Console.ReadLine());

            if (flipcount > 0)
            {
                for (int i = 0; i < flipcount; i++)
                {
                    Random random = new Random();
                    int flipcoin = random.Next(2);
                    Console.WriteLine("random number of flipcoin : " +flipcoin);
                    switch (flipcoin)
                    {
                        case 1:
                            headcount++;
                            break;

                        default:
                            tailcount++;
                            break;

                    }
                    total_count = total_count + 1;
                    Console.WriteLine("totalcount is" +total_count);
                }
                Console.WriteLine("total count of head is " +headcount);
                Console.WriteLine("total count of head is " +tailcount);

                percentage_head = headcount*100/total_count;
                percentage_tail = tailcount*100/total_count;

                Console.WriteLine("percentage of head is" +percentage_head);
                Console.WriteLine("percentage of head is" +percentage_tail);

            }
            else
            {
                Console.WriteLine("enter positve number");
            }

        }
    }
}

    

