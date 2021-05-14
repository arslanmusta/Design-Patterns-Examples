using System;

namespace BuilderPattern.GenericFluent
{
    public class PersonBirthDateBuilder<T> : PersonJobBuilder<PersonBirthDateBuilder<T>> where T: PersonBirthDateBuilder<T>
    {
        public T Born(DateTime dateOfBirth)
        {
            Person.BirthOfDate = dateOfBirth;
            return this as T;
        }
    }
}