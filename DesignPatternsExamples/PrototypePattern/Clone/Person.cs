using System;
using System.Linq;

namespace PrototypePattern.Clone
{
    public class Person : ICloneable
    {
        public string Name { get; set; }

        public int[] Award { get; set; }

        public Address Address { get; set; }
        
        public object Clone()
        {
            return new Person()
            {
                Name = (string) this.Name.Clone(),
                Award = (int[]) this.Award.Clone(),
                Address = (Address) this.Address.Clone()
            };
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Award)}: {Award.Aggregate<int,string>("", (result, value) => result + " " + value.ToString() )}, {nameof(Address)}: {Address}";
        }
    }
}