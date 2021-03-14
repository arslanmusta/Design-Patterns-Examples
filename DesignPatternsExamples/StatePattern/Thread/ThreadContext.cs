using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Thread
{
    class ThreadContext
    {
        public IThreadState State { get; set; }

        public ThreadContext()
        {
            Console.WriteLine("The thread has been created and is not yet running.");
            State = new StoppedState();
        }

        public void Start()
        {
            State.Run(this);
        }

        public void Abort()
        {
            State.Stop(this);
        }

        public void Sleep()
        {
            State.Wait(this);
        }
    }
}
