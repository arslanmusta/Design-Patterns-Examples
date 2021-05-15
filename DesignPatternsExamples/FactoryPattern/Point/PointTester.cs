using System;

namespace FactoryPattern.Point
{
    public static class PointTester
    {
        public static void Test()
        {
            var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            var point2 = Point.NewCartesianPoint(100, 200);
            Console.WriteLine(point);
            Console.WriteLine(point2);
        }
    }
}