namespace AbstractFactoryPattern.CLI
{
    public interface ICreateFileCommand : ICommand
    {
        string Name { get; set; }
    }
}