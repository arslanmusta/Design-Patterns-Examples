﻿namespace BuilderPattern.Faceted
{
    public class PersonBuilder
    {
        protected Person Person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(Person);
        
        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

        public static implicit operator Person(PersonBuilder pb) => pb.Person;
    }
}