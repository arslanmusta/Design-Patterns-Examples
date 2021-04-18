using System;

namespace FlyweightPattern.Map
{
    class Point
    {
        private readonly int _x;
        private readonly int _y;
        private readonly PointIcon _icon;


        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine("{0:G} at ({1:D}, {2:D})", _icon.Type, _x, _y);
        }
    }
}
