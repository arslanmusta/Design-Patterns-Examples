using System;

namespace PrototypePattern.Clone
{
    public static class CloneTester
    {
        public static void Test()
        {
            var person1 = new Person()
            {
                Name = "Adam",
                Award = new[] {1, 2, 3},
                Address = new Address()
                {
                    Number = 100,
                    Street = "SStreet"
                }
            };

            var person2 = (Person)person1.Clone();

            person2.Award[2] = 5;
            person2.Name = "Will";
            person2.Address.Street = "High Street";

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}