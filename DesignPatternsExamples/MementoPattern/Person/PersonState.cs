using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Person
{
    // Memento
    public class PersonState
    {
        public string Name { get; }
        public int Age { get; }
        public decimal Balance { get; }

        public PersonState(string name, int age, decimal balance)
        {
            Name = name;
            Age = age;
            Balance = balance;
        }
    }
}
