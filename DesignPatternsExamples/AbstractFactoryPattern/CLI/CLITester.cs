using System;

namespace AbstractFactoryPattern.CLI
{
    public static class CLITester
    {
        public static void Test()
        {
            ICommandFactory factory = null;
            
            if (OperatingSystem.IsLinux())
            {
                factory = new LinuxCommandFactory();
            }
            else if(OperatingSystem.IsWindows())
            {
                factory = new WindowsCommandFactory();
            }

            if (factory != null)
            {
                var createFileCommand = factory.CreateCreateFileCommand("newFile");
                var listCommand = factory.CreateListCommand(true);
                
                createFileCommand.Execute();
                listCommand.Execute();
            }
        }
    }
}