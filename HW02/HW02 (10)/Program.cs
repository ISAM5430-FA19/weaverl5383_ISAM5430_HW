using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables
            
            int num = 1;
            int inNum;
            int count;
            int sum = 0;
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            int centAvg;


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

                //if inNum>largest
                if (inNum > largest)
                {
                    largest = inNum;
                    //largest=inNum
                }

                //if inNum<smallest
                if (inNum < smallest)
                {
                    smallest = inNum;
                    //smallest=inNum
                }
                //add one to num
                num = num + 1;
                //add inNum to sum
                sum = sum + inNum;
            }
               
            //calculate centered average
            centAvg = ((sum - largest - smallest) / count);

            Console.WriteLine($"The centered average = ({sum}-{largest}-{smallest})/{count}");
            Console.WriteLine($"The centered average is {centAvg}.");

            Console.ReadKey();
        }
    }
}
