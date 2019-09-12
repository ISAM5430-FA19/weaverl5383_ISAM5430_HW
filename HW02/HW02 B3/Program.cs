using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_B3
{
    class Program
    {
        static void Main(string[] args)
        {
            // display 'enter a decimal number between 0 and 4'
            Console.WriteLine("Enter a decimal number between 0 and 4:");
            // user inputs number
            decimal gradeNum = Decimal.Parse(Console.ReadLine());

            //display ' with this gpa, your letter grade is'
            Console.Write($"With a GPA of {gradeNum}, the letter grade is: ");

            //if gpa between 0 and 4
            if (gradeNum>=0 && gradeNum<=4)
            {
                // calculate gpa with calculation
                int GPA = (int)(3*gradeNum + 0.5m);

                // switch cases for gpa
                switch (GPA)
                {
                    // A case
                    case 12:
                    case 11:
                        Console.Write("A");
                        break;
                    //B case
                    case 10:
                    case 9:
                    case 8:
                        Console.Write("B");
                        break;
                    //C case
                    case 7:
                    case 6:
                    case 5:
                        Console.Write("C");
                        break;
                    //d case
                    case 4:
                    case 3:
                        Console.Write("D");
                        break;
                    //f case
                    case 2:
                    case 1:
                    case 0:
                        Console.Write("F");
                        break;
                }

                // if gpa is 10 or 7 or 4
                if (GPA==10 || GPA==7 || GPA == 4)
                {
                    // display '+'
                    Console.Write("+");
                }
                // else if gpa is 8 or 5
                else if (GPA==8 || GPA == 5)
                {
                    // display '-'
                    Console.Write("-");
                }
            }
            //else
            else
            {
                // display 'gpa invalid'
                Console.WriteLine("GPA invalid.");
            }
            Console.ReadKey();

        }
    }
}
