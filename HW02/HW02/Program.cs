using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02 //B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            // Display 'enter first integer'
            Console.WriteLine("Enter the first integer: ");
            // record user input
            firstNum = Convert.ToInt32(Console.ReadLine());
            // display 'enter second integer'
            Console.WriteLine("Enter the second integer: ");
            //record user input
            secondNum = Convert.ToInt32(Console.ReadLine());
            //if first number > second number
            if (firstNum > secondNum)
            {
                // display 'first number is larger'
                Console.WriteLine("The first integer is larger.");
            }
            // else if second number is > first number
            else if (secondNum > firstNum)
            {
                // display 'second number is larger'
                Console.WriteLine("The second integer is larger");
            }
            //else
            else
            {
                // display both numbers are the same
                Console.WriteLine("Both integers are the same.");
            }
            Console.Read();
        }
    }
}
