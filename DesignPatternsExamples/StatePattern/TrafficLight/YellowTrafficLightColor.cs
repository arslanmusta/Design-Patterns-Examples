using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TrafficLight
{
    // ConcreteState
    public class YellowTrafficLightColor : ITrafficLightColor
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.Color = new RedTrafficLightColor();
        }

        public override string ToString()
        {
            return "Yellow Traffic Light";
        }
    }
}
