using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Editor
{
    class History
    {
        private readonly Queue<IUndoableCommand> _command;

        public int Size => _command.Count;

        public History()
        {
            _command = new Queue<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command)
        {
            _command.Enqueue(command);
        }

        public IUndoableCommand Pop()
        {
            return _command.Dequeue();
        }

    }
}
