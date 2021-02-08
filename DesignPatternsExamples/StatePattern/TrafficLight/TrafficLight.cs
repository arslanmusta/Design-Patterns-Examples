using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TrafficLight
{
    // Context
    public class TrafficLight
    {
        public ITrafficLightColor Color { get; set; }

        public void Change()
        {
            Color.Change(this);
        }
    }
}
