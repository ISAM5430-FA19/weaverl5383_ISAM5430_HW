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
            
            int ones = 0;
            int fours = 0;
            int num = 1;
            int inNum;
            int count;
            

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

                //if inNum=1
                if (inNum == 1)
                {
                    //add 1 to the count of ones
                    ones = ones + 1;
                }

                //if inNum=4
                if (inNum == 4)
                {
                    //add 1 to the count of fours
                    fours = fours + 1;
                }
                //add one to num
                num = num + 1;
            }   

            //display findings

            //declare number of ones and fours
            Console.WriteLine($"The number of ones was {ones} and the number of fours was {fours}.");

            //if more fours than ones
            if (fours > ones)
            {
                //display more fours than ones
                Console.WriteLine("There were more fours than ones.");
            }
            //if more ones than fours
            else if (ones > fours)
            {
                //display more ones than fours
                Console.WriteLine("There were more ones than fours");
            }
            //else
            else
            {
                //display fours and ones equal
                Console.WriteLine("The number of fours and ones was equal.");
            }

            

            Console.ReadKey();
        }
    }
}
