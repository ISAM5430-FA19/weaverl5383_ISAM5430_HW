using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C13_c
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 1000;
            decimal rate= .05M;
            decimal amount = 0;
            decimal moneyTotal=0;
            string moneyString;
            int years = 10;

            for (int h=1; h<=6; h++)
            {
                for (int i = 1; i <= years; i++)
                {

                    for (int k = 1; k <= i; k++)
                    {

                        amount = amount + ((1 + rate) * k);
                    }

                    moneyTotal = moneyTotal + principal * amount;

                    moneyString = string.Format("{0:C}", moneyTotal);

                    Console.WriteLine($"The total money in year {i} with interest rate {rate} is {moneyString}");
                }
                Console.WriteLine();
                rate = rate + .01M;
            }
           
            Console.ReadKey();
        }

    }
}
