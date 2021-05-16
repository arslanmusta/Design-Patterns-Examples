using System;

namespace AbstractFactoryPattern.CLI
{
    public class LinuxListCommand : IListCommand
    {
        public void Execute()
        {
            var parameters = ShowHidden ? " -a" : string.Empty;
            Console.WriteLine($"ls{parameters}");
        }

        public bool ShowHidden { get; set; }

        public LinuxListCommand(bool showHidden)
        {
            ShowHidden = showHidden;
        }
    }
}