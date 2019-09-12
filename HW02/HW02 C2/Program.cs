using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables
            int num8 = 1;
            int num9 = 100;
            decimal num10 = 100;

            //Part8

            //while num8>0 and num8<100
            while (num8>0 && num8<100)
            {
                //display num8
                Console.Write(num8 + " ");
                //divide num8 by 2
                num8 = num8 * 2;
            }

            Console.WriteLine();

            //Part9

            //while num9<=100 and num9>0
            while (num9<=100 && num9>0)
            {
                //display num9
                Console.Write(num9 + " ");
                //divide num9 by 2
                num9 = num9 / 2;
            }

            Console.WriteLine();

            //Part10

            //while num10<=100 and num10>1
            while (num10<=100 && num10 > 1)
            {
                //display num10
                Console.Write(num10 + " ");
                //divide num10 by 2
                num10 = num10 / 2;
                
            }


            Console.ReadKey();
        }
    }
}
