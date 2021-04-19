using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Remote
{
    class SamsungTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung: TurnOn");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: TurnOff");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung: SetChannel");
        }
    }
}
