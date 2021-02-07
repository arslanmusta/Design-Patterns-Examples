using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Person
{
    public static class PersonTester
    {
        public static void Test()
        {
            var memory = new PersonMemory();
            
            var person = new Person
            {
                Name = "Hazel",
                Age = 20,
                Balance = 1000
            };

            memory.State = person.CreatePersonState();

            Console.WriteLine(person);

            person.Balance = 900;
            person.Name += "nut";
            person.Balance = decimal.Zero;

            Console.WriteLine(person);
            
            person.Restore(memory.State);

            Console.WriteLine(person);

        }
    }
}
