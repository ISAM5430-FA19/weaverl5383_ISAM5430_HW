using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    class Motorway
    {
        private string name;
        private string type;
        private string surface;
        private string direction;
        private int lanesNum;
        private string toll;
        private string party;

        public Motorway(string name, string type, string surface, string direction, int lanesNum, string toll, string  party)
        {
            this.name = name;
            this.type = type;
            this.surface = surface;
            this.direction = direction;
            this.lanesNum = lanesNum;
            this.toll = toll;
            this.party = party;
        }

        //public string Name { get; set; }
        //public string Type { get; set; }
        //public string Surface { get; set; }
        //public string Direction { get; set; }
        //public string LanesNum { get; set; }
        //public string Toll { get; set; }
        //public string Party { get; set; }

        public void FullName()
        {
            Console.WriteLine("Motorway: " + name); 
        }

        public void NameToll()
        {
            Console.WriteLine("Motorway: " + name + " and it " + toll);
        }

        public void NameLanes()
        {
            Console.WriteLine("Motorway: " + name + " has " + lanesNum + " lanes"); 
        }

        public override string ToString()
        {
            return "Motorway: " + name + " " + type + " is made of " + surface + " and faces " + direction + ". It has " +  lanesNum + " lanes. It " + toll + ". It is maintained by " + party;
        }
    }
}
