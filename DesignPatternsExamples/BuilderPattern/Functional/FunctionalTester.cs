using System;

namespace BuilderPattern.Functional
{
    public static class FunctionalTester
    {
        public static void Test()
        {
            var person = new PersonBuilder()
                .Called("Neo")
                .WorkAs("Chosen One")
                .Build();

            Console.WriteLine(person);
        }
    }
}