using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = int.MinValue;
            int lastNum=int.MinValue;
            int currentNum;

            Console.WriteLine("The program will find the highest number from a list of numbers entered in increasing order. If a smaller number than the current number is enterd, the program will terminate.");

            for (int count = 1; count > 0; count++)
            {
                Console.WriteLine("Enter the number: ");
                currentNum = int.Parse(Console.ReadLine());

                if (currentNum > lastNum)
                {
                    lastNum = currentNum;
                    if (currentNum > largest)
                    {
                        largest = currentNum;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered a smaller number. The program will terminate.");
                    break;
                }
            }
            if (largest > int.MinValue)
            {
                Console.WriteLine($"The largest number entered is {largest}");
            }
            Console.ReadKey();
        }
    }
}
