using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Editor
{
    public static class EditorTester
    {
        public static void Test()
        {
            var history = new History();
            var editor = new Editor {Content = "Apple"};

            history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "Banana";
            history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "Cherry";
            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);
        }
    }
}
