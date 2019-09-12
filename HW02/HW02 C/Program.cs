using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // display 'enter the first integer'
            Console.WriteLine("Enter the first integer: ");
            // user enters first integer
            int value1 = Int32.Parse(Console.ReadLine());
            //display 'enter the second integer'
            Console.WriteLine("Enter the second integer:");
            //user enters the second integer
            int value2 = Int32.Parse(Console.ReadLine());
            //display 'enter the third integer'
            Console.WriteLine("Enter the third integer:");
            //user enters the  third integer
            int value3 = Int32.Parse(Console.ReadLine());

            // if first < second integer and second integer < third integer or third < second integer and second integer < first integer
            if (value1 < value2 && value2 < value3 || value3 < value2 && value2 < value1)
            {
                // display 'second integer is in the middle'
                Console.WriteLine($"The second integer, {value2} is in the middle.");
            }

            // else if second integer < first integer and first < third integer or third < first integer and first < second integer
            else if (value2 < value1 && value1 < value3 || value3 < value1 && value1 < value2)
            {
                // display 'first integer is in the middle'
                Console.WriteLine($"The first integer, {value1}, is in the middle.");
            }

            // else
            else
            {
                // display 'third integer is in the middle'
                Console.WriteLine($"The third integer, {value3}, is in the middle.");
            }
            Console.ReadKey();
        }
    }
}
