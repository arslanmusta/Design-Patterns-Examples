namespace BuilderPattern.Functional
{
    public class Person
    {
        public string Name, Position;

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}";
        }
    }
}