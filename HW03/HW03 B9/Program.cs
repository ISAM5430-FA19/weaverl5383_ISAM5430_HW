using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the integer: ");

            int num = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (num > 0)
            {
                remainder = num % 2;
                num = num/2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);
            Console.ReadKey();
        }

    }
    
}
