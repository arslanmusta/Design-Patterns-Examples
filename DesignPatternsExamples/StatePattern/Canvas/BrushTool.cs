using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Canvas
{
    // ConcreteState
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
