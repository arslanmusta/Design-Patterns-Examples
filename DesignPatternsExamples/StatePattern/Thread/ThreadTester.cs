using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Thread
{
    static class ThreadTester
    {
        public static void Test()
        {
            var context = new ThreadContext();
            context.Start();
            context.Start();
            context.Sleep();
            context.Start();
            context.Abort();
            context.Start();
            context.Abort();
            context.Abort();
        }
    }
}
