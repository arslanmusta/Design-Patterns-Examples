using System;

namespace BuilderPattern.GenericFluent
{
    public static class GenericFluentTester
    {
        public static void Test()
        {
            var person = Person.New
                .Called("John Wick")
                .WorksAsA("Assassin")
                .Born(DateTime.Now)
                .Build();

            Console.WriteLine(person);
        }
    }
}