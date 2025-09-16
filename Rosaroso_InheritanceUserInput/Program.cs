using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rosaroso_InheritanceUserInput
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SHIELA JANE ROSAROSO
            //IT306

            Console.WriteLine("Enter the Brand of the Bag:");
            string brand =Console.ReadLine();
            Console.WriteLine("Enter the Color of the Bag: ");
            string color = Console.ReadLine();
            Console.WriteLine("Enter the type of Bag (Backpack/ Handbag): ");
            string bagtype = Console.ReadLine();

            Console.WriteLine("\n ------ Bag Details -----");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Type: {bagtype}");

            Console.ReadKey();
        }
    }
}
