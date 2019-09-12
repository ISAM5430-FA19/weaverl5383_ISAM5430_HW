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
            int seqLen = 0;
            int longestSeq = 0;

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



                //if previous and previous previous and current number are not equidistant
                if ((inNum - prevInNum) != (prevInNum - prevprevInNum))
                {

                    //reset seqLen
                    seqLen = 2;

                }

                //if number equals previous and equals previous previous
                if ((inNum - prevInNum) == (prevInNum- prevprevInNum))
                {
                    //add one to clump length
                    seqLen = seqLen + 1;
                }

                //if seqLen>longestSeq
                if (seqLen > longestSeq)
                {
                    //set seqLen as longest

                    longestSeq = seqLen;
                }

                //set new previous previous number
                prevprevInNum = prevInNum;
                //set new previous number
                prevInNum = inNum;


                //add one to num
                num = num + 1;
            }


            //display longest sequence
            Console.WriteLine($"The longest sequence is {longestSeq}.");

            Console.ReadKey();
        }
    }
}
