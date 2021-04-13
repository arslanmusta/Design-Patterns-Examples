using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.KeyNote
{
    static class KeyNoteTester
    {
        internal static void Test()
        {
            var group1 = new Group();
            group1.Add(new Shape()); // square
            group1.Add(new Shape()); // square

            var group2 = new Group();
            group2.Add(new Shape()); // circle
            group2.Add(new Shape()); // circle

            var group = new Group();
            group.Add(group1);
            group.Add(group2);
            
            group.Render();
        }
    }
}
