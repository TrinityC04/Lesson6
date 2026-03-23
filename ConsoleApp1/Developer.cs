using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Developer : Employee
    {
        public Developer(string name) : base(name) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }
}
