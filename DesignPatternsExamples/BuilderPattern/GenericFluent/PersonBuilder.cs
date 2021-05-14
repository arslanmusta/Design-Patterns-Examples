namespace BuilderPattern.GenericFluent
{
    public abstract class PersonBuilder
    {
        protected readonly Person Person = new();

        public Person Build()
        {
            return Person;
        }
    }
}