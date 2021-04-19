using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Remote
{
    static class RemoteTester
    {
        public static void Test()
        {
            var remoteControl = new RemoteControl(new SonyTv());
            remoteControl.TurnOn();

            var remoteControl2 = new AdvancedRemoteControl(new SamsungTv());
            remoteControl2.SetChannel(5);
        }
    }
}
