using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C13_b
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount=0;
            int years;
            decimal principal;
            decimal rate;
            decimal moneyTotal=0;
            string moneyString;

            Console.WriteLine("Enter the principal amount: ");
            principal = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest: ");
            rate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of years: ");
            years = int.Parse(Console.ReadLine());

            for (int i=1; i<=years; i++)
            {
               
                for (int k=1; k<=i; k++)
                    {
                        
                        amount = amount + ((1 + rate) * k);
                    }

                moneyTotal = moneyTotal + principal * amount;
               
                moneyString = string.Format("{0:C}", moneyTotal);

                Console.WriteLine($"The total money in year {i} is {moneyString}");
            }
            Console.ReadKey();
        }
    }
}
