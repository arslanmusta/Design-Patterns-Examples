using System;
using BuilderPattern.Code;
using BuilderPattern.Faceted;
using BuilderPattern.Functional;
using BuilderPattern.GenericFluent;
using BuilderPattern.Html;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Html Test---");
            HtmlTester.Test();
            Console.WriteLine("---Generic Fluent Test---");
            GenericFluentTester.Test();
            Console.WriteLine("---Functional Test---");
            FunctionalTester.Test();
            Console.WriteLine("---Faceted Test---");
            FacetedTester.Test();
            Console.WriteLine("---Code Test---");
            CodeTester.Test();
        }
    }
}