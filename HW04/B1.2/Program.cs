using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;

            for (int i=1; i<=5; i++)
            {
                for (int j=2; j<5; j++)
                {
                    if (i!=j)
                    {
                        //Console.Write(i + "; " + j + "; ");
                        sum1 = sum1 + (i * j);
                    }
                    for (int k=3; k<5; k++)
                    {
                        if (i!=j &&i!=k && j!=k)
                        {
                            //Console.Write(i + "; " + j + "; "+ k + "; ");
                            sum2 = sum2 + (i * j*k);
                        }

                        for (int l=4; l<5; l++)
                        {
                            if (i != j && i != k && j != k&& i!=l  && j!=l && k!=l)
                            {
                                //Console.Write(i + "; " + j + "; " + k + "; "+l+"; ");
                                sum3 = sum3 + (i * j*k*l);
                            }
                            for(int m = 5; m <= 5; m++)
                                {
                                if (i != j && i != k && j != k && i != l && j != l && k != l && i!=m&&j!=m&&k!=m&&l!=m)
                                {
                                    //Console.Write(i + "; " + j + "; " + k + "; " + l + "; "+m+"; ");
                                    sum4 = sum4 + (i * j*k*l*m);
                                }
            }
        }
                        
                    }
                }
            }
            Console.Write(sum1 + "; " + sum2 + "; "+sum3 + "; "+sum4);
            Console.ReadKey();
        }
    }
}
