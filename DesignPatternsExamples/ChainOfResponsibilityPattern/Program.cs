using System;
using ChainOfResponsibilityPattern.Http;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---HttpTest---");
            HttpTester.Test();
        }
    }
}
