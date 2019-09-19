using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int lastNum=int.MaxValue;
            int currentNum;

            Console.WriteLine("The program will calculate the sum of the numbers entered. It will terminate when a number is entered twice in a row.");


            for (int count=1; count>0; count++)
            {
                Console.WriteLine("Please enter the number: ");
                currentNum = int.Parse(Console.ReadLine());

                if (currentNum != lastNum)
                {
                    sum = sum + currentNum;
                    lastNum = currentNum;
                }
                else
                {
                    Console.WriteLine("You entered the same number twice. The program will terminate.");
                    break;
                       
                }
            }
            if (sum > 0)
            {
                Console.WriteLine($"The sum of the numbers entered is {sum}");
            }
            Console.ReadKey();
        }
    }
}
