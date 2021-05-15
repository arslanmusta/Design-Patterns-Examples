namespace FactoryPattern.Shape
{
    public class Rectangle : IShape
    {
        private readonly double _x, _y;

        public Rectangle(double x, double y)
        {
            _x = x;
            _y = y;
        }
        
        public double CalculateArea()
        {
            return _x * _y;
        }
    }
}