using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int sum;
            
            

            Console.WriteLine("The program will find the sum of two numbers entered and reverse it. Enter 0  to end.");

            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            sum = a + b;

            while (a != 0 && b != 0)
            {
                while (sum > 0)
                {
                    Console.Write(sum % 10);
                    sum = sum / 10;
                }

                Console.WriteLine("Enter the first number: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                b = int.Parse(Console.ReadLine());

                sum = a + b;
            }

            Console.WriteLine("The program will terminate.");

            Console.ReadKey();
        }
    }
}
