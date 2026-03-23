using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string Name { get; }
        public Employee(string name)
        {
            Name = name;
        }
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }
}
