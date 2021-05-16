namespace AbstractFactoryPattern.CLI
{
    public interface ICommandFactory
    {
        ICreateFileCommand CreateCreateFileCommand(string name);

        IListCommand CreateListCommand(bool showHidden);
    }
}