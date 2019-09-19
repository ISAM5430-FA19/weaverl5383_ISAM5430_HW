using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B4
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1;
            int side2;
            int side3;
            int sideCount=0;
            int sideSum1;
            int sideSum2;
            int sideSum3;

            Console.WriteLine("The program will determine if the sides entered for a triangle are valid. It will end when 0 or a negative number is entered.");

            for (int count=1; count>0; count++)
            {
                if (sideCount == 0)
                {
                    Console.WriteLine("Enter the first side: ");
                    side1 = int.Parse(Console.ReadLine());
                    if (side1 > 0)
                    {
                        Console.WriteLine("Enter the second side: ");
                        side2 = int.Parse(Console.ReadLine());
                        if (side2 > 0)
                        {
                            Console.WriteLine("Enter the third side: ");
                            side3 = int.Parse(Console.ReadLine());

                            sideSum1 = side1 + side2;
                            sideSum2 = side1 + side3;
                            sideSum3 = side2 + side3;

                            if (sideSum1 > side3 && sideSum2 > side2 && sideSum3 > side1)
                            {
                                Console.WriteLine("The triangle is valid!");
                            }
                            else
                            {
                                Console.WriteLine("The triangle is invalid.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The side was invalid. The program will terminate.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The side was invalid. The program will terminate.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The side was invalid. The program will terminate.");
                    break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
