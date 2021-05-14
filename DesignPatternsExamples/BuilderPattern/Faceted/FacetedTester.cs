using System;

namespace BuilderPattern.Faceted
{
    public static class FacetedTester
    {
        public static void Test()
        {
            Person person = new PersonBuilder()
                .Lives
                    .At("Vatan Street")
                    .In("Istanbul")
                    .WithPostcode("34001")
                .Works
                    .At("TC")
                    .AsA("POFTC")
                    .Earning(100000);

            Console.WriteLine(person);
        }
    }
}