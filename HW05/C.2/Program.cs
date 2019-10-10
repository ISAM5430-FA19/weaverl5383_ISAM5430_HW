using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var route66 = new HW05.Motorway("Route 66", "Highway", "Concrete", "E", 10, "Has toll", "US roads service");
            Console.WriteLine(route66.ToString());

            Console.ReadKey();
        }
    }
}
