namespace AbstractFactoryPattern.CLI
{
    public class LinuxCommandFactory : ICommandFactory
    {
        public ICreateFileCommand CreateCreateFileCommand(string name)
        {
            return new LinuxCreateFileCommand(name);
        }

        public IListCommand CreateListCommand(bool showHidden)
        {
            return new LinuxListCommand(showHidden);
        }
    }
}