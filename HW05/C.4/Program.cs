using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var park = new Park();
            park.Name = "Yellowstone";
            park.Location = "Wyoming";
            park.Type = "National";
            park.Facilities = "restroom";
            park.Fee = 12;
            park.NumEmp = 100;
            park.NumVis = 500;
            park.Budget = 2000;

            park.FindNameLocFac();

            Console.ReadKey();

        }
    }
}
