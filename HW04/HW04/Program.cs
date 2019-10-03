using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1=0;
            int sum2=0;

            for (int i=1; i<=5; i++)
            {
                for (int j=1; j<=5; j++)
                {
                    if(i!= j )
                    {
                        sum1 = sum1 + (i * j);
                    }
                    for (int k=1; k<=5; k++)
                    {
                        if (i != j && i!=k && j!=k)
                        {
                            sum2 = sum2 + (i * j * k);
                        }
                    }
                }
            }
            Console.WriteLine(sum1 + " " + sum2);
            Console.ReadKey();
        }
    }
}
