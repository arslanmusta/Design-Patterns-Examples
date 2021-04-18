using System.Collections.Generic;

namespace FlyweightPattern.Map
{
    class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            return new List<Point>
            {
                new Point(1, 2, _iconFactory.GetPointIcon(PointType.CAFE))
            };
        }
    }
}
