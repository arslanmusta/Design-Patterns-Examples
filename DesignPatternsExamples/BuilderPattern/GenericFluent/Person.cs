using System;

namespace BuilderPattern.GenericFluent
{
    public class Person
    {
        public string Name;

        public string Position;

        public DateTime BirthOfDate;

        public class Builder : PersonBirthDateBuilder<Builder>
        {
            internal Builder() {}
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"Name: {Name}, Position: {Position}, Birth: {BirthOfDate.ToShortDateString()}";
        }
    }
}