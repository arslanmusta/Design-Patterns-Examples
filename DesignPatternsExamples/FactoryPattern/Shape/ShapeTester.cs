using System;

namespace FactoryPattern.Shape
{
    public static class ShapeTester
    {
        public static void Test()
        {
            var circle = ShapeFactory.CreateShape("circle", 5);
            var rectangle = ShapeFactory.CreateShape("rectangle", 3, 4);
            Console.WriteLine($"Circle area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
        }
    }
}