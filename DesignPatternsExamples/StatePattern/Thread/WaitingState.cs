using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Thread
{
    class WaitingState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.State = new RunningState();
            Console.WriteLine("Thread rescheduled while it was idle.");
        }

        public void Stop(ThreadContext context)
        {
            context.State = new StoppedState();
            Console.WriteLine("Pending thread completely stopped.");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread is already pending.");
        }
    }
}
