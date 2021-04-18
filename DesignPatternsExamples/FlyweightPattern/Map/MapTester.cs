using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern.Map
{
    static class MapTester
    {
        public static void Test()
        {
            var service = new PointService(new PointIconFactory());

            service.GetPoints().ForEach(p => p.Draw());
        }
    }
}
