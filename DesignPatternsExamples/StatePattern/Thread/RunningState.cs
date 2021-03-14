using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Thread
{
    class RunningState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            Console.WriteLine("Thread is already running.");
        }

        public void Stop(ThreadContext context)
        {
            context.State = new StoppedState();
            Console.WriteLine("Thread stopped.");
        }

        public void Wait(ThreadContext context)
        {

            context.State = new WaitingState();
            Console.WriteLine("Thread temporarily out of scheduling.");
        }
    }
}
