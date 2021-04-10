using System;
using CommandPattern.Editor;
using CommandPattern.UserInterface;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---DepartmentTest---");
            UserInterfaceTester.Test();

            Console.WriteLine("\n\n---EditorTest---");
            EditorTester.Test();
        }
    }
}
