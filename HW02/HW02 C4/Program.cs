using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int num = 1;
            int inNum;
            decimal sum = 0;
            decimal avg;

            //display 'enter the number count'
            Console.WriteLine("Enter how many numbers you would like to input:");
            //user inputs count number of numbers
            count = Int32.Parse(Console.ReadLine());

            //while num<count
            while (num <= count)
            {
                //display 'input number'
                Console.WriteLine("Input the number:");
                //user inputs numbers
                inNum = Int32.Parse(Console.ReadLine());
                //sum numbers
                sum = sum + inNum;
                num = num + 1;
            }

            //calculate average
            avg = sum / count;
            //display sum and average
            Console.WriteLine($"The sum of the {count} numbers is {sum} and the average is {avg}.");

            Console.ReadKey();
        }
    }
}
