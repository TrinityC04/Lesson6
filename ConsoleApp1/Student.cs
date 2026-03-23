using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name { get; }
        public int Age { get; }
        public double Mark { get; }

        public Student(string name, int age, double mark)
        {
            Name = name;
            Age = age;
            Mark = mark;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"{Name} ({Age}) - {Mark}%");
        }
    }
}
