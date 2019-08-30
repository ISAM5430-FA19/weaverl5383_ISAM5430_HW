using System;

/* multiline comment
 */

namespace isam5430._01
{
    class Program
    {
        // entry point in console app- code inside method
        static void Main(string[] args)
        {
            // namespace.class
            // semicolon at end
            System.Console.WriteLine("Welcome to C# Programming");
            Console.WriteLine("Welcome to C# Programming"); // Works because 'using system'

            //declaring variable as string
            string person = "Michael"; // initializing a variable

            //string interpolation
            Console.WriteLine($"Welcome to C# programming, {person}.");

            // other ways
            Console.WriteLine("Welcome to C# programming, {0}.", person);

            Console.WriteLine("Welcome to C# programming," + person + ".");

            Console.Write("Welcome to"); // same thing, prints on one line
            Console.Write(" C# programming, ");
            Console.Write(person);
            Console.WriteLine(".");

            /*
             * Variables:
             * Data types:
             * simple types
             *  int
             *  bool (true/false)
             *  char(single quote in C# - 'a', '0' != 0)
             *  double/float (IEEE 754)
             *  decimal software-implementation of double/float
             *  byte (binary contents)
             *  
             * complex types
             *  string
             *  array (int[])
             *  classes
             *  struct
             * 
             * Operators
             *  +,-,/,*,%
             * boolean operators:           
             *  ==, !=, >, <, >=, <=, &&, ||, !
             */

            Console.WriteLine("Enter number 1");
            string input = Console.ReadLine(); //retursn string
            int num1 = int.Parse(input);
            Console.WriteLine("Enter number 2");
            input = Console.ReadLine(); //reads line from keyboard and assigns to input variable
            int num2 = Convert.ToInt32(input);
            Console.WriteLine("Enter the operator: (+, -, /, *)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                //print sum of num1, num2

            // delcare variable, assign sum of num1+num2 to sum variable, print sum
                // etc for -, /, *
            }

        }
    }
}
