using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosaroso_SimpleInheritance
{
    internal class Student //Base Class
    {
        //Properties for the Student Class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display Student Information
        public void BasicInfo()
        {
            Console.WriteLine("*** Student Information ***");
            Console.WriteLine($"Name: {Name} , \n Program: {Program}");
        }
    }
    class RegularStudent : Student //Derived class
    {
        //Additional property for the Student Class
        public string Section { get; set; }

        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student //Derived class
    {
        public int UnitsEnrolled { get; set; }

        public void EnrolledSemUnits() 
        {
            Console.WriteLine($"UnitsEnrolled: {UnitsEnrolled}");
        }
    }
}
