using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Thread
{
    class StoppedState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.State = new RunningState();
            Console.WriteLine("Thread started running.");
        }

        public void Stop(ThreadContext context)
        {
            Console.WriteLine("Thread is already stopped.");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("A stopped thread cannot be suspended.");
        }
    }
}
