using System;

namespace AbstractFactoryPattern.CLI
{
    public class WindowsListCommand : IListCommand
    {
        public void Execute()
        {
            var parameters = ShowHidden ? " /a:h" : string.Empty;
            Console.WriteLine($"ls{parameters}");
        }

        public bool ShowHidden { get; set; }

        public WindowsListCommand(bool showHidden)
        {
            ShowHidden = showHidden;
        }
    }
}