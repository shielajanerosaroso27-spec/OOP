using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosaroso_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shiela Jane Rosaroso
            //IT306
            //Simple Inheritance with Constructor

            //Instantiate Student Object
            Student student = new Student ("Shiela Jane Rosaroso", "IT306");

            //Student Display
            Console.WriteLine("\n********** STUDENT INFORMATION **********");
            student.BasicInfo();
            Console.WriteLine("*********************************************");

            //Instantiate Regular Student Class
            RegularStudent regularStudent = new RegularStudent ("Keisha", "BSHM", "IT306");

            //Regular Student Display
            Console.WriteLine("\n ********** REGULAR STUDENT INFORMATION ********** ");
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();
            Console.WriteLine("*********************************************");


            //Instantiate Irregular Student 
            IrregularStudent irregularStudent = new IrregularStudent("Xania", "BSTM", "IT306", 23);

            //Irregular Student Display
            Console.WriteLine("\n ********** IRREGULAR STUDENT INFORMATION ********** ");
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();
            Console.WriteLine("*********************************************");
             
            Console.ReadKey();
        }
    }
}
