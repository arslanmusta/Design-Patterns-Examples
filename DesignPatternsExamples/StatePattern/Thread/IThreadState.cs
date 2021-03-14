using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Thread
{
    interface IThreadState
    {
        void Run(ThreadContext context);
        
        void Stop(ThreadContext context);
        
        void Wait(ThreadContext context);
    }
}
