using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosaroso_SimpleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Rosaroso, Shiela Jane B.
            //IT306
            //Simple Inheritance

            //Create an instance of the Student class
            Student student = new Student
            {
                Name = "Keishi Mae Alaan" , 
                Program = "BSIT"
             };

            //call the method of the Student Class
            student.BasicInfo();// Call Method to display

            //Instantiate the object of the Regular Student 
            RegularStudent regularStudent = new RegularStudent
            {
                Name = "Keisha Baril",
                Program = "BSHM",
                Section = "IT306"
            };
            //call the method of the Regular Student 
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();

            IrregularStudent irregularStudent = new IrregularStudent
            {
                Name = "Sheila Mei Rosaroso",
                Program = "BSN",
                UnitsEnrolled = 18
            };
            //call the method of the Irregular Student 
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();
            Console.ReadLine();

        }

    }
}
