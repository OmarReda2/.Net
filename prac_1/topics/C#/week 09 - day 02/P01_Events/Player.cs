using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Events
{
    public class Player
    {
        public string Name { get; set; }
        
        public string Team { get; set; }

        public override string ToString() => $"Player: {Name}, Team: {Team}";

        public void Run(Location location) => Console.WriteLine($"{this} is Running to {location}");
    }
}
