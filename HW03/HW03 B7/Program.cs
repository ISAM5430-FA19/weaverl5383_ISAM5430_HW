using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int remainder;
            int reduction;
           
            Console.WriteLine("This program will display entered numbers in reversed order. Enter 0 to end.");

            Console.WriteLine("Enter the first number: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0 &&num>int.MinValue&&num<int.MaxValue)
            {
                remainder = num % 10;
                reduction = num / 10;

                Console.WriteLine($"{remainder}" + $"{reduction}");
                
                Console.WriteLine("Enter the next number:");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The program will end now.");
            Console.ReadKey();
        }
    }
}
