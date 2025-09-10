using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosaroso_InheritanceWithConstructor
{
        public class Student //Base class
        {
            string name;
            string program;

            public Student (string Name, string Program) //Properties of the student class
            {
                name = Name;
                program = Program;
            }

            public void BasicInfo()
            {
                Console.WriteLine(" Name: " + name);
                Console.WriteLine(" Program: " + program);
            }
        }

       public class RegularStudent : Student //Derived Class
    {
        public string section;

        public RegularStudent(string Name, string Program , string Section) : base(Name, Program)
        {
            section = Section;
        }
        public void SectionEnrolled() //Method for the Regular Student
        {
            Console.WriteLine("Section:  " + section);
        }

    }

    public class IrregularStudent : Student //Another Derived Class
    {
        int unitsEnrolled;
        public IrregularStudent(string Name, string Program, string Section, int UnitsEnrolled) : base(Name, Program)
        {
            unitsEnrolled = UnitsEnrolled;
        }

        public void EnrolledSemUnits() //Method to display Irregular Student
        {
            Console.WriteLine("Units Enrolled:   " + unitsEnrolled);
        }
    }

}
