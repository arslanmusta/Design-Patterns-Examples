using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.UserInterface.Fx;

namespace CommandPattern.UserInterface
{
    class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public CompositeCommand()
        {
            _commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            _commands.ForEach(command => command.Execute());
        }
    }
}
