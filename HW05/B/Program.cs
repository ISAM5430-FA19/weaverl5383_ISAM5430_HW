using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"{account2.Name}'s balance: {account2.Balance:C}");

            Console.WriteLine("\nEnter withdraw amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Removing {withdrawAmount:C} from {account1.Name}'s balance.");
            account1.Withdraw(withdrawAmount);

            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance:C}");

            Console.ReadKey();
        }
    }
}
