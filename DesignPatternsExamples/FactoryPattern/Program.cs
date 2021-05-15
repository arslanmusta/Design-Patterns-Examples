using System;
using System.Threading.Tasks;
using FactoryPattern.Point;

namespace FactoryPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("---Point Test---");
            await PointTester.Test();
        }
    }
}