using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Person
{
    // Originator
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Balance { get; set; }

        public PersonState CreatePersonState()
        {
            return new PersonState(Name, Age, Balance);
        }

        public void Restore(PersonState state)
        {
            Name = state.Name;
            Age = state.Age;
            Balance = state.Balance;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Balance}";
        }
    }
}
