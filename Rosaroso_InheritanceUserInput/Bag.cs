using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosaroso_InheritanceUserInput
{
    public class Bag
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Bag(string color, string size)
        {
            this.Color = color;
            this.Size = size;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Bag Color: {Color}");
            Console.WriteLine($"Bag Size: {Size}");
        }
    }
    public class Backpack : Bag
    {
        public int Capacity { get; set; }
        public string StrapType { get; set; }

        public void DisplayBackpackInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Capacity: {Capacity} liters, Strap Type: {StrapType}");
        }
        public Backpack(string Color, string Size, int Capacity, string StrapType) : base(Color, Size)
        {
            this.Capacity = Capacity;
            this.StrapType = StrapType;
        }
    }

    public class Handbag : Bag
    {
        public string Material { get; set; }
        public string HandType { get; set; }

        public void DisplayHandbagInfo()
        {
            DisplayInfo(); //Call the Base
            Console.WriteLine($"Material : {Material} Hand Type {HandType}");
        }
        public Handbag(string Color, string Size, int Capacity, string StrapType, string Material, string HandType) : base(Color, Size)
        {
            this.Material = Material;
            this.HandType = HandType;
        }
    }

}
