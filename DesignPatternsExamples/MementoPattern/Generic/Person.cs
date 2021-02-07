using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Generic
{
    [Serializable]
    public class Person : Originator
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Balance { get; set; }
        
        public override void Restore(Memento memento)
        {
            if (memento.GetObject() is Person obj)
            {
                Name = obj.Name;
                Age = obj.Age;
                Balance = obj.Balance;
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Balance}";
        }
    }
}
