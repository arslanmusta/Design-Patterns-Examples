using System;

namespace AbstractFactoryPattern.CLI
{
    public class WindowsCreateFileCommand : ICreateFileCommand
    {
        public void Execute()
        {
            Console.WriteLine($"copy NUL {Name}");
        }

        public string Name { get; set; }

        public WindowsCreateFileCommand(string name)
        {
            Name = name;
        }
    }
}