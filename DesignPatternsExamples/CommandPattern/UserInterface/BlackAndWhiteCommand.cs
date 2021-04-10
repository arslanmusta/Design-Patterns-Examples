using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.UserInterface.Fx;

namespace CommandPattern.UserInterface
{
    class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and white");
        }
    }
}
