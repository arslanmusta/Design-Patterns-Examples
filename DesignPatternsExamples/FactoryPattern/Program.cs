using System;
using System.Threading.Tasks;
using FactoryPattern.Point;
using FactoryPattern.Shape;

namespace FactoryPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("---Point Test---");
            await PointTester.Test();
            Console.WriteLine("---Shape Test---");
            ShapeTester.Test();
        }
    }
}