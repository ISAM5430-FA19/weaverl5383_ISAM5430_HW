using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW05
{
    class Student
    {


        public Student(int ident)
        {
            ID = ident;
        }
        public Student(string firstName, string lastName)
        {
            NameF = firstName;
            NameL = lastName;
        }

        public double GPA { get; set; }

        public int ID { get;  set; }

        public string NameF { get; set; }

        public string NameL { get; set; }

        public string Major { get; set; }

        public string Classification { get; set; }
 
    }
}
