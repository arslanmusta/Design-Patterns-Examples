using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern.Editor
{
    // CareTaker
    public class History
    {
        private readonly List<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            var lastState = _states.LastOrDefault();

            if (lastState != null)
            {
                _states.Remove(lastState);
            }

            return lastState;
        }
    }
}
