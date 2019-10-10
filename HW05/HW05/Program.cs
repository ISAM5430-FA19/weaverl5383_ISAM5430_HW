using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW05
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Leah", "Weaver"); 

            student.ID = 1570030;
            student.GPA = 4.0;
            student.Major = "MIS";
            student.Classification = "Full time grad student";

            Console.WriteLine(student.NameF);
            Console.WriteLine(student.NameL);
            Console.WriteLine(student.ID);
            Console.WriteLine(student.GPA);
            Console.WriteLine(student.Major);
            Console.WriteLine(student.Classification);

            Console.ReadLine();
        }
    }
}
