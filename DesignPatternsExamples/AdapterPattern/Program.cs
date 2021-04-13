using System;
using AdapterPattern.ImageProcess;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---ImageProcessTest---");
            ImageProcessTester.Test();
        }
    }
}
