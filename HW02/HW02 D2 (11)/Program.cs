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
            int twos = 0;
            int twoCount = 0;

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

                //if inNum is two
                if (inNum == 2)
                {
                    //add 1 to twoCount
                    twoCount = twoCount + 1;
                }



                //if prevprevInNum is 2 and inNum is 2 but prevInNum is not two
                if (prevprevInNum == 2 && inNum == 2 && prevInNum != 2)
                {
                    //set twos to 1
                    twos = 1;
                }

                //set new previous previous number
                prevprevInNum = prevInNum;
                //set new previous number
                prevInNum = inNum;

                //add one to num
                num = num + 1;

            }

            if (twos == 0 && twoCount > 1)
            {
                Console.WriteLine("All the twos ARE next to another two.");
            }
            else if (twos == 1)
            {
                Console.WriteLine("All the twos ARE NOT next to another two.");
            }
            else
            {
                Console.WriteLine("There were not enough twos to determine if they were next to one another.");
            }
            Console.ReadKey();

        }
    }
}
