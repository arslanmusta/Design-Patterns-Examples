namespace AbstractFactoryPattern.CLI
{
    public class WindowsCommandFactory : ICommandFactory
    {
        public ICreateFileCommand CreateCreateFileCommand(string name)
        {
            return new WindowsCreateFileCommand(name);
        }

        public IListCommand CreateListCommand(bool showHidden)
        {
            return new WindowsListCommand(showHidden);
        }
    }
}