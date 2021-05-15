using System;
using System.Threading.Tasks;

namespace FactoryPattern.Point
{
    public static class PointTester
    {
        public static async Task Test()
        {
            var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            var point2 = Point.NewCartesianPoint(100, 200);
            var point3 = await Point.NewCartesianPointAsync(10, 20);
            Console.WriteLine(point);
            Console.WriteLine(point2);
            Console.WriteLine(point3);
        }
    }
}