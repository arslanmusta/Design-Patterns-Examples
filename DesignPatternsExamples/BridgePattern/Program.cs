using System;
using BridgePattern.Remote;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---RemoteTest---");
            RemoteTester.Test();
        }
    }
}
