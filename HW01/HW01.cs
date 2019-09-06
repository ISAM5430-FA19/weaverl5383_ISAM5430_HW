using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1_LeahWeaver
{
    class Program 
    {
        static void Main(string[] args)
        {
            // get input from user (two numbers)
            Console.WriteLine("Welcome to Calculator. This program allows basic operations to be performed on two numbers.");
            Console.Write("Please enter a number: ");
            string num1 = Console.ReadLine();
            Console.Write("Please enter another number: ");
            string num2 = Console.ReadLine();
            Console.Write("Please enter the basic operation to perform on the numbers (+, -, *, /): ");
            string oper = Console.ReadLine();


            try
            {
                // try to convert input from strings to integers
                int IntNum11 = Int32.Parse(num1);
                int IntNum22 = Int32.Parse(num2);
            }

            catch (System.FormatException)
            {
                // if user did not input numbers
                Console.WriteLine("Error. You did not enter a number. Please restart the program and try again.");
            }

            // convert input from strings to integers
            int IntNum1 = Int32.Parse(num1);
            int IntNum2 = Int32.Parse(num2);

            if (oper == "/" & IntNum2 == 0) // if the user tries to divide by zero
            {
                Console.WriteLine("You have entered an invalid operation (divide by zero). Please restart the program and try again.");

            }
            // perform selected operation on the two numbers and display solution
            if (oper == "+")
            {
                int solution = IntNum1 + IntNum2;
                Console.WriteLine($"Answer: {IntNum1}+{IntNum2}={solution}");
            }
            else if (oper == "-")
            {
                int solution = IntNum1 - IntNum2;
                Console.WriteLine($"Answer: {IntNum1}-{IntNum2}={solution}");
            }
            else if (oper == "*")
            {
                int solution = IntNum1 * IntNum2;
                Console.WriteLine($"Answer: {IntNum1}*{IntNum2}={solution}");
            }
            else if (oper == "/")
            {
                int solution = IntNum1 / IntNum2;
                Console.WriteLine($"Answer: {IntNum1}/{IntNum2}={solution}");
            }
            else if (oper != "+" & oper != "-" & oper != "*" & oper != "/") // if the user did not enter a valid operation
            {
                Console.WriteLine("Error. You did not enter a valid operation. Please restart the program and try again.");
            }

            Console.Read(); //keep console open

        }
    }
}