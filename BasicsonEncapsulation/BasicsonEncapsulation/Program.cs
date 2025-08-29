using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsonEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SHIELA JANE ROSAROSO
            //IT306
            //Basics on Encapsulation

            //Instantiate Object
            Bag bag1 = new Bag();

            //Set the properties
            Console.WriteLine("Bag's Information:");
            bag1.Brand = "Gucci";
            bag1.Color = "Pink";

            //Method to display the object details
            bag1.DisplayInfo();

            Console.ReadKey();
        }
    }
}
