using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_C10
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;

            Console.WriteLine("The program will display a box of the entered size.");

            Console.WriteLine("Enter the height: ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            width = int.Parse(Console.ReadLine());

            for (int count=0; count<height; count++)
            {

                for (int count2=0; count2<width; count2++)
                {
                    Console.Write('X');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
