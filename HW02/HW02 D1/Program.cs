using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int num = 1;
            int inNum;
            int zeroes = 0;
            int evens = 0;
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            int sum1=0;
            int sum2=0;

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
                //if number is zero
                if (inNum == 0)
                {
                    //add to zero count
                    zeroes = zeroes + 1;
                }
                    
                //if number is even
                if (inNum % 2 == 0)
                {
                    //add to even count
                    evens = evens + 1;
                }
                    
                //if number is larger than largest
                if (inNum > largest)
                {
                    //largest = number
                    largest = inNum;
                }
                    
                //if number is smaller than smallest
                if (inNum < smallest)
                {
                    //smallest = number
                    smallest = inNum;
                }
                
               // if count is less than half
               if (count < (count / 2))
                {
                    //add to sum of first half
                    sum1 = sum1 + inNum;
                }

               if (count> (count / 2))
                {
                    sum2 = sum2 + inNum;
                }

                num = num + 1;

            }

            //Display all results

            Console.WriteLine($"Within the {count} numbers entered, there were {zeroes} zeroes, {evens} even numbers, the largest value was {largest}, the smallest value was {smallest}.");

            //see if sum of first and second half were euqal
            if (sum1 == sum2)
            {
                Console.WriteLine("YES. The sum of the first and second half were equal.");
            }
            else
            {
                Console.WriteLine("NO. The sum of the first and second half were not equal.");
            }

            Console.ReadKey();
        }
    }
}
