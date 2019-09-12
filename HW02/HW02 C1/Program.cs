using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create integers for loops
            int num1 = 20;
            int num2 = 1;
            int num3 = 10;
            int num4 = 1;
            int num5 = 1;
            int num6 = 1;
            char let = 'a';

            //Part1

            //while num1>0
            while (num1 > 0)
            {
                //display the current number
                Console.Write(num1+" ");
                //subtract one from current number
                num1 = num1 - 1;
            }

            // blank line
            Console.WriteLine();

            //Part2

            // while num2>0 and num2<10
            while (num2>0 && num2<=10)
            {
                // if num2 divided by 2 = 0
                if (num2%2 == 0)
                {
                    // display num2
                    Console.Write(num2 + " ");
                }
                // increase num2 by 1
                num2 = num2 + 1;
            }

            //blank line
            Console.WriteLine();

            //Part3

            // while num3>=10 and num3<100
            while (num3>=10 && num3 < 100)
            {
                //display num3
                Console.Write(num3 + " ");
                // add 10 to num3
                num3 = num3 + 10;
            }

            //blank line
            Console.WriteLine();

            //Part4

            //while num4>0 and num4<20
            while (num4>0 && num4 < 20)
            {
                // if num4 is positive and not divisible by 3
                if (num4%2!=0 && num4%3!=0)
                {
                    // display num4
                    Console.Write(num4 + " ");
                }
                //increase num4 by 1
                num4 = num4 + 1;
            }

            //blank line
            Console.WriteLine();

            //Part5

            // while num5>0 and num5<10
            while (num5>0 && num5<10)
            {
                // calculate square of num5
                int sq5 = num5*num5;
                //if length of square is equal to 2
                string str5 = Convert.ToString(sq5);
                if (str5.Length == 2)
                {
                    //display the square of num5
                    Console.Write(str5 + " ");
                }
                //increase num5 by 1
                num5 = num5 + 1;
            }

            //blank line
            Console.WriteLine();

            //Part6

            //while num6>0 and num6<=100
            while (num6>0 && num6 <= 100)
            {
                // if num6 is divisible by 3 and 5
                if (num6%3==0 & num6%5==0)
                {
                    //display num6
                    Console.Write(num6 + " ");
                }
                // else if num6 is not divisible by 3 and 5
                else if (num6%3!=0 & num6%5!=0)
                {
                    //display num6
                    Console.Write(num6 + " ");
                }
                //increase num6 by 1
                num6 = num6 + 1;
            }

            //blank line
            Console.WriteLine();

            //Part7

            //while let>=a and <=z
            while (let >= 'a' && let <='z')
            {
                //display let
                Console.Write(let);
                //increase let by 1
                let++;
            }

            Console.ReadKey();
        }
    }
}
