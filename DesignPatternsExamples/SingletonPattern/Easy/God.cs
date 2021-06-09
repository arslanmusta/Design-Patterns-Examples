namespace SingletonPattern.Easy
{
    public class God
    {
        private static volatile God _instance = new ();

        public static God Instance => _instance;

        public int Value { get; set; }
        
        private God()
        {
            // init
        }
    }
}