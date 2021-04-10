using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Editor
{
    class BoldCommand : IUndoableCommand
    {
        private readonly HtmlDocument _document;
        private string _prevContent;
        private readonly History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeBold();
            _history.Push(this);
        }

        public void UnExecute()
        {
            _document.Content = _prevContent;
        }
    }
}
