using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Cloud
{
    static class CloudTester
    {
        internal static void Test()
        {
            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudSteam())));
        }

        internal static void StoreCreditCard(IStream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
