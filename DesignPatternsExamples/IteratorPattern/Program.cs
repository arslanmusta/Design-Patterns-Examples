using System;
using IteratorPattern.Department;
using IteratorPattern.Words;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---DepartmentTest---");
            DepartmentTester.Test();

            Console.WriteLine("\n\n---WordsTest---");
            WordsTester.Test();

            Console.ReadKey();
        }
    }
}
