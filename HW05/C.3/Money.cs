using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._3
{
    class Money
    {
        private float dollars;
        private float cents;

        public void IncrementMoney()
        {
            float newMon = dollars + cents / 100 + 1;
            Console.WriteLine($"{newMon:C}");
        }

        public void DecrementMoney()
        {
            float newMon = dollars + cents / 100 - 1;
            Console.WriteLine($"{newMon:C}"); 
        }

        public void Change()
        {
            float quarters = (cents / 25) - (cents % 25);
            float dimes = (cents - quarters) / 10 - ((cents - quarters) % 10);
            float nickles = (quarters - dimes) / 5 - (quarters % 5);
            float pennies = (dimes - nickles) - (nickles % 1);

            Console.WriteLine("There are "+dollars+"dollars, "+quarters+"quarters, "+dimes+"dimes, "+nickles+"nickles, and "+pennies+"pennies.");
        }

        public Money(float cash)
        {
            dollars = cash;
            cents = cash;
        }
        public Money(float cashD, float cashC)
        {
            dollars = cashD;
            cents = cashC;
        }

        public override string ToString()
        {
            return dollars + " " + cents; 
        }

    }
}
