using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=10; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
