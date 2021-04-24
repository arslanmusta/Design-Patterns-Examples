namespace ProxyPattern.BookLibrary
{
    internal interface IEbook
    {
        string FileName { get; }
        void Show();
    }
}