using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;


            Console.WriteLine("The program will display positive prime numbers for a specified number of times.");

            Console.WriteLine("Enter the target number: ");
            number = int.Parse(Console.ReadLine());

            bool isPrime = true;
            Console.WriteLine("Prime Numbers less than target number: ");
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write(i+","+"\t");
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
