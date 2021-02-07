using System;
using MementoPattern.Editor;
using MementoPattern.Generic;
using MementoPattern.Person;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---PersonTest---");
            PersonTester.Test();
            Console.WriteLine("\n\n---EditorTest---");
            EditorTester.Test();
            Console.WriteLine("\n\n---GenericTest---");
            GenericTester.Test();

            Console.ReadKey();
        }
    }
}
