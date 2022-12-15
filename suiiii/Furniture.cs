using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suiiii
{
    public class Furniture
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public class Chair : Furniture
    {
        public string Upholstery { get; set; }
    }

    public class Computer : Furniture
    {
        public string OperatingSystem { get; set; }
    }

}
