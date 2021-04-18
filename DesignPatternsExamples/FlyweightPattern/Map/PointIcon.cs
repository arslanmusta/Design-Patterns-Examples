using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern.Map
{
    class PointIcon
    {
        public PointType Type { get; }
        private readonly byte[] _icon;

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            _icon = icon;
        }
    }
}
