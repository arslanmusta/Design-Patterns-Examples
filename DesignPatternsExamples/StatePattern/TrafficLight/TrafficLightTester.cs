using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.TrafficLight
{
    public static class TrafficLightTester
    {
        public static void Test()
        {
            var trafficLight = new TrafficLight();
            trafficLight.Color = new YellowTrafficLightColor();


            for (var _ = 0; _ < 10; _++)
            {
                trafficLight.Change();
                Console.WriteLine(trafficLight.Color);
            }

            Console.ReadKey();
        }
    }
}
