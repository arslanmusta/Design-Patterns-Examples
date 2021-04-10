using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.UserInterface.Fx;

namespace CommandPattern.UserInterface
{
    class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
