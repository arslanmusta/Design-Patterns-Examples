using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Generic
{
    public static class GenericTester
    {
        public static void Test()
        {
            var caretaker = new CareTaker();

            var person = new Person
            {
                Name = "Hazel",
                Age = 20,
                Balance = 1000
            };

            caretaker.Push(person.CreateMemento());

            Console.WriteLine(person);

            person.Balance = 900;
            person.Name += "nut";
            person.Balance = decimal.Zero;

            Console.WriteLine(person);

            person.Restore(caretaker.Pop());

            Console.WriteLine(person);
        }
    }
}
