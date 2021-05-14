namespace BuilderPattern.GenericFluent
{
    public class PersonJobBuilder<T> : PersonInfoBuilder<T> where T: PersonJobBuilder<T>
    {
        public T WorksAsA(string position)
        {
            Person.Position = position;
            return this as T;
        }
    }
}