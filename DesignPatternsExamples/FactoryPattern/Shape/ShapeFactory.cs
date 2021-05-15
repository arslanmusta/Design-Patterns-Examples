namespace FactoryPattern.Shape
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string name, params double[] values)
        {
            IShape shape = name switch
            {
                "circle" => new Circle(values[0]),
                "rectangle" => new Rectangle(values[0], values[1]),
                _ => new Rectangle(0, 0)
            };

            return shape;
        }
    }
}