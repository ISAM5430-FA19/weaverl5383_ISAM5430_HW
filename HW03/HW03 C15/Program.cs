using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;


            Console.WriteLine("Enter a number that is greater than 0: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i<=number; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(j + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
