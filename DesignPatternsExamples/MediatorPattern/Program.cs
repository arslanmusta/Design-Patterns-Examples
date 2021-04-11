using System;
using MediatorPattern.MediatorWithObserver;
using MediatorPattern.UserInterface;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---UserInterfaceTest---");
            UserInterfaceTester.Test();
            
            Console.WriteLine("\n\n---MediatorWithObserverTest---");
            MediatorWithObserverTester.Test();
        }
    }
}
