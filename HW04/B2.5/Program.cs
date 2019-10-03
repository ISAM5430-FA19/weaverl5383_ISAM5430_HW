using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';

                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';

                    int vowels1 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);

                    //if (vowels1>0)
                    if (vowelA == false && vowelB == true)
                    {
                        if (a != b)
                        {
                            Console.Write($"{a}{b}; ");
                        }
                    }

                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';

                        //int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1:0);
                        //if (vowels > 1 && vowels <3)
                        if (vowelA==false  && vowelC == true)
                        {
                            if (a != b && b != c && c != a)
                            {
                                Console.Write($"{a}{b}{c}; ");
                            }
                        }

                    }
                }

            }

            Console.ReadKey();
        }
    }
}
