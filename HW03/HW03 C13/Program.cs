using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C13
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money=1000;
            decimal interest = .05M;
            string monString;

           for (int i=1; i <= 10; i++)
            {
                for (int j=1; j<=10; j++)
                {
                    money = money+(money * interest);
                }
                monString = string.Format("{0:C}", money);

                Console.WriteLine($"The money at the end of year {i} is {monString}");
            }
            Console.ReadKey();

        }
    }
}
