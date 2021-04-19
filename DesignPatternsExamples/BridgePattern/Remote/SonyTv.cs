using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Remote
{
    class SonyTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: SetChannel");
        }
    }
}
