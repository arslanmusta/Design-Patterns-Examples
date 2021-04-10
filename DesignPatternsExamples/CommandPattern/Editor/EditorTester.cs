using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Editor
{
    static class EditorTester
    {
        internal static void Test()
        {
            var history = new History();
            var document = new HtmlDocument();
            document.Content = "Hello, World!";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();
            Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
        }
    }
}
