using System;

namespace AbstractFactoryPattern.CLI
{
    public class LinuxCreateFileCommand : ICreateFileCommand
    {
        public void Execute()
        {
            Console.WriteLine($"touch {Name}");
        }

        public string Name { get; set; }

        public LinuxCreateFileCommand(string name)
        {
            Name = name;
        }
    }
}