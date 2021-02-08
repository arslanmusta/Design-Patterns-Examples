using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Canvas
{
    public static class CanvasTester
    {
        public static void Test()
        {
            var canvas = new Canvas {CurrentTool = new SelectionTool()};
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
