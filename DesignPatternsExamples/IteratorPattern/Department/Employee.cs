using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Department
{
    public class Employee
    {
        public string Name { get; }

        public string Title { get; }

        public Employee(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Title: {Title}";
        }
    }
}
