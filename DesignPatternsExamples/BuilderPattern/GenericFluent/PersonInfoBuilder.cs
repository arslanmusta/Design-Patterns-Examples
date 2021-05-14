namespace BuilderPattern.GenericFluent
{
    public class PersonInfoBuilder<T> : PersonBuilder where T: PersonInfoBuilder<T>
    {
        public T Called(string name)
        {
            Person.Name = name;
            return this as T;
        }
    }
}