using System;

namespace PrototypePattern.Clone
{
    public class Address : ICloneable
    {
        public string Street { get; set; }

        public int Number { get; set; }
        
        public object Clone()
        {
            return new Address()
            {
                Street = (string)this.Street.Clone(),
                Number = this.Number
            };
        }

        public override string ToString()
        {
            return $"{nameof(Street)}: {Street}, {nameof(Number)}: {Number}";
        }
    }
}