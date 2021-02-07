using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Editor
{
    // Memento
    public class EditorState
    {
        public string Content { get; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}
