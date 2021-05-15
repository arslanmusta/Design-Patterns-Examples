using System;
using System.Threading.Tasks;

namespace FactoryPattern.Point
{
    public class Point
    {
        private double _x, _y;

        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        
        // factory method
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        // factory method
        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        private async Task<Point> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
        
        // async factory method
        public static Task<Point> NewCartesianPointAsync(double x, double y)
        {
            var result = new Point(x, y);
            return result.InitAsync();
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
        }
    }
}
