using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.KeyNote
{
    class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Render Shape");
        }

        public void Move()
        {
            Console.WriteLine("Move Shape");
        }
    }
}
