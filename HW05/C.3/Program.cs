using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money(8, 30);
            money.IncrementMoney();
            money.DecrementMoney();
            money.ToString();

            Console.ReadKey();
        }
    }
}
