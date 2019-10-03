using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._3
{
    class Program
    {
        static void Main(string[] args)
        {
      

            for (char a='A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';

                for (char b = 'A'; b<='H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';

                    //int vowels = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    //if (vowels == 1)
                    if (vowelA==false && vowelB==true)
                    {
                        Console.Write($"{a}{b}; ");
                    }

                }

            }

            Console.ReadKey();
        }
    }
}
