using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Events
{
    public  class Refree
    {
        public string Name { get; set; }

        public override string ToString() => $"Refree: {Name}";

        public void Look(Location location) => Console.WriteLine($"{this} is Looking to {location}");
    }
}
