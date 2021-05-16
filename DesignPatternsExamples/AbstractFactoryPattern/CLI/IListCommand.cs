namespace AbstractFactoryPattern.CLI
{
    public interface IListCommand : ICommand
    {
        bool ShowHidden { get; set; }
    }
}