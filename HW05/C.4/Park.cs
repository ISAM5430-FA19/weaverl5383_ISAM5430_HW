using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    class Park
    {
        //private string name;
        //private string location;
        //private string type;
        //private float fee;
        //private int numEmp;
        //private int numVis;
        //private float budget;
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public float Fee { get; set; }
        public int NumEmp { get; set; }
        public int NumVis { get; set; }
        public float Budget { get; set; }

        public string Facilities { get; set; }

        public void FindNameLocType()
        {
            Console.WriteLine("The name is " +Name+", the type is " + Type+ " and the location is "+Location);
        }

        public void FindNameLocFac()
        {
            Console.WriteLine("The name is " + Name + ", the facilities are " + Facilities + " and the location is " + Location);
        }

        public void CostPerVisitor()
        {
            float cost = Budget / NumVis;
            Console.WriteLine("{0:C}", cost);
        }

        public void RevenueFromFees()
        {
            float revenue = NumVis * Fee;
            Console.WriteLine("{0:C}", revenue);
        }

        public void ConvToString()
        {
            Console.WriteLine(Name.ToString());
            Console.WriteLine(Location.ToString());
            Console.WriteLine(Type.ToString());
            Console.WriteLine(Fee.ToString());
            Console.WriteLine(NumEmp.ToString());
            Console.WriteLine(NumVis.ToString());
            Console.WriteLine(Budget.ToString());
            Console.WriteLine(Facilities.ToString());
        }

    }
}
