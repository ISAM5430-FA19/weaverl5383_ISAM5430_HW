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
            int clumpLen=0;
            int longestClump = 0;

            //display 'enter the number count'
            Console.WriteLine("Enter how many numbers you would like to input:");

            //user inputs count number of numbers
            count = Int32.Parse(Console.ReadLine());


            //while num<=count
            while (num <= count)
            {

                //display 'input number'
                Console.WriteLine("Input the number:");
                //user inputs numbers
                inNum = Int32.Parse(Console.ReadLine());



                //if inNum is equal to prevInNum
                if (inNum == prevInNum && inNum != prevprevInNum)
                {

                    //reset clumpLen
                    clumpLen = 2;

                }

                //if number equals previous and equals previous previous
                if (inNum==prevInNum && inNum == prevprevInNum)
                {
                    //add one to clump length
                    clumpLen = clumpLen + 1;
                }

                //if clumpLen>longestClump
                if (clumpLen > longestClump)
                {
                    //set clumpLen as longest
                    longestClump = clumpLen;
                }

                //set new previous previous number
                prevprevInNum = prevInNum;
                //set new previous number
                prevInNum = inNum;


                //add one to num
                num = num + 1;
            }


            //display number of clumps
            Console.WriteLine($"The longest clump is {longestClump}.");

            Console.ReadKey();
        }
    }
}
