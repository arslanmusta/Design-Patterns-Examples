using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TrafficLight
{
    // ConcreteState
    public class RedTrafficLightColor : ITrafficLightColor
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.Color = new GreenTrafficLightColor();
        }

        public override string ToString()
        {
            return "Red Traffic Light";
        }
    }
}
