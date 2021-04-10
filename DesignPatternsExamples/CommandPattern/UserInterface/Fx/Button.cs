using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.UserInterface.Fx
{
    public class Button
    {
        public string Label { get; set; }

        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}
