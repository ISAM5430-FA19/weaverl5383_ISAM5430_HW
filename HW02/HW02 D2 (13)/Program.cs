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

            int prevInNum = int.MaxValue; // set as something no one will ever use
            int prevprevInNum = int.MaxValue; //set as something no one will ever use
            int num = 1;
            int inNum;
            int count;
            int hills = 0;


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

                //if the previous number was greater than the previous previous number and previous number greater than current number
                if (prevprevInNum<prevInNum && prevInNum>inNum)
                {
                    //add one to hill count
                    hills = hills + 1;
                }

                //ignore plateaus
                //if previous number is equal to current number
                if (prevInNum != inNum)
                {
                    
                }

                //set new previous previous number
                prevprevInNum = prevInNum;

                //set new previous number
                prevInNum = inNum;

                Console.WriteLine(prevInNum);
                Console.WriteLine(prevprevInNum);
                //add one to num
                num = num + 1;
            }

            //display number of hills
            Console.WriteLine($"There were {hills} hills.");
                
            Console.ReadKey();
            
        }
    }
}
