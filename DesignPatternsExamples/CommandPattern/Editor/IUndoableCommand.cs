using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Editor
{
    interface IUndoableCommand : ICommand
    {
        void UnExecute();
    }
}
