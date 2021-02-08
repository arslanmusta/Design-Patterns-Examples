using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TrafficLight
{
    // ConcreteState
    public class GreenTrafficLightColor : ITrafficLightColor
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.Color = new YellowTrafficLightColor();
        }

        public override string ToString()
        {
            return "Green Traffic Light";
        }
    }
}
