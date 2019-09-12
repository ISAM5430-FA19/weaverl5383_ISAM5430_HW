using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_C3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part11

            int num = 1;
            int fact = 1;

            //while num is between 1 and 7
            while (num>=1 & num<7)
            {

                //multiply num by fact
                fact = fact * num;
                //add one to num
                num = num + 1;

                //display factorial
                Console.Write(fact + " ");

            }

            Console.WriteLine();

            //Part12

            //create variables
            int num1=0;
            int num2=1;
            int num3;
            int count=2;

            Console.Write(num1+" ");
            Console.Write(num2+" ");

            while (count >= 0 && count<25)
            {

                num3 = num1 + num2;
                Console.Write(num3+" ");
                num1 = num2;
                num2 = num3;
               
                count = count + 1;
            }



            Console.ReadKey(); 
        }
    }
}
