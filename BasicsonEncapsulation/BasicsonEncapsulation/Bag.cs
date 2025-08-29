using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsonEncapsulation
{
    internal class Bag
    {
        //
        private string brand;
        private string color;

        //
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Method to display the Bag's Information
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}\n Color:{Color}");
        }
    }
}
