using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B5
{
    class Program
    {
        static void Main(string[] args)
        {
            int item;
            int number;
            int difference;
            int distance;
            int smallestDistance = int.MaxValue;
            int smallestDistanceNum=0;

            Console.WriteLine("The program will determine the closest number to the first value entered. If the value matchest the first number, the program will end.");

            Console.WriteLine("Enter the first value: ");
            item = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());


            while (item != number)
            {
                difference = item - number;
                distance = Math.Abs(difference);

                if (smallestDistance > distance)
                {
                    smallestDistance = distance;
                    smallestDistanceNum = number;
                }

                Console.WriteLine($"The closest number is {smallestDistanceNum} with a distance of {smallestDistance}");

                Console.WriteLine("Enter the number: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number and the first value are equal. The program will end.");
            Console.ReadKey();
        }
    }
}
