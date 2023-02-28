using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Id}, {Name}";
    }
}
