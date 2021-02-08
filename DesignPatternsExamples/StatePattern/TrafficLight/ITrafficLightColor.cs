using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TrafficLight
{
    // State
    public interface ITrafficLightColor
    {
        void Change(TrafficLight trafficLight);
    }
}
