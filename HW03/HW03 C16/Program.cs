using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;


            Console.WriteLine("Enter a number greater than or equal to zero:");
            num = int.Parse(Console.ReadLine());

            for (int i=1; i<=num; i++)
            {
                for (int j=num; j>i; j--)
                {
                    Console.Write('0');
                }
                for (int j = 1; j <=(num-j); j++)
                {
                    for (int k = i; k >= j; k--)
                    {
                        Console.Write(k);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
